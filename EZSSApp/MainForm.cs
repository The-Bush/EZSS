using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;

namespace EZSS
{
    public partial class MainForm : Form
    {
        private HiddenHotkeyForm hiddenForm;
        public MainForm()
        {
            CheckForUpgrade();
            InitializeComponent();
            hiddenForm = new HiddenHotkeyForm(this);

            // Instantiate the Directory Label
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SaveDirectory))
            {
                lblTargetDirectory.Text = Properties.Settings.Default.SaveDirectory;
            }
            else
            {
                lblTargetDirectory.Text = "NO DIRECTORY SELECTED";
            }

            // Set all the settings to their saved values
            chkbxTogglePreview.Checked = Properties.Settings.Default.ViewPreview;
            chkbxCaptureUnderMouse.Checked = Properties.Settings.Default.CaptureUnderMouse;
            chkbxAutoDelete.Checked = Properties.Settings.Default.AutoDelete;
            nupdwnAllowedQty.Value = Properties.Settings.Default.AllowedQuantity;
            cmbboxHotkey.Text = Properties.Settings.Default.Hotkey;

            ToastNotificationManagerCompat.OnActivated += HandlePreviewSelection;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CheckForUpgrade()
        {
            if (Properties.Settings.Default.UpgradeSettings)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeSettings = false;
                Properties.Settings.Default.Save();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // When program is closed, reset the NotificationWarningGiven flag
            Properties.Settings.Default.NotificationWarningGiven = false;
            Properties.Settings.Default.Save();
        }

        // Update the Target Directory for saved screenshots
        private void btnChangeDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblTargetDirectory.Text = dialog.SelectedPath;
                Properties.Settings.Default.SaveDirectory = dialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                Hide();
            }
        }

        #region WINAPI
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point point);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr GetAncestor(IntPtr hwnd, uint flags);

        // Define the flags for GetAncestor
        private const uint GA_PARENT = 1;
        private const uint GA_ROOT = 2;
        private const uint GA_ROOTOWNER = 3;

        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        #endregion

        public void CaptureScreenshot()
        {

            IntPtr hwnd;
            IntPtr previousForegroundHwnd = GetForegroundWindow();
            if (Properties.Settings.Default.CaptureUnderMouse)
            {
                Point cursorPos;
                GetCursorPos(out cursorPos);
                hwnd = WindowFromPoint(cursorPos);
                hwnd = GetAncestor(hwnd, GA_ROOT);
                if (hwnd != previousForegroundHwnd)
                {
                    SetForegroundWindow(hwnd);
                    SetFocus(hwnd);
                }
            }

            else
            {
                hwnd = GetForegroundWindow();
            }

            if (hwnd != IntPtr.Zero)
            {
                RECT windowRect;
                if (GetWindowRect(hwnd, out windowRect))
                {
                    int width = windowRect.right - windowRect.left;
                    int height = windowRect.bottom - windowRect.top;

                    // Introduce a delay to allow UI changes to take effect
                    int delayMilliseconds = 500;
                    Thread.Sleep(delayMilliseconds);

                    Bitmap screenshot = new Bitmap(width, height);

                    // Create a graphics object from the bitmap
                    using (Graphics graphics = Graphics.FromImage(screenshot))
                    {
                        // Capture the screen contents into the bitmap
                        graphics.CopyFromScreen(new Point(windowRect.left, windowRect.top), Point.Empty, screenshot.Size);
                    }

                    //Reset the focused/foreground window
                    SetForegroundWindow(previousForegroundHwnd);
                    SetFocus(previousForegroundHwnd);

                    if (Properties.Settings.Default.ViewPreview)
                    {
                        ScreenshotPreviewNotification(screenshot);
                    }

                    else
                    {
                        if (SaveScreenshot(screenshot))
                        {
                            // Allocate correct string length first
                            int length = GetWindowTextLength(hwnd);
                            StringBuilder sb = new StringBuilder(length + 1);
                            GetWindowText(hwnd, sb, sb.Capacity);
                            string windowTitle = sb.ToString();

                            ScreenshotNotification(windowTitle);
                        }
                    }
                    SetForegroundWindow(previousForegroundHwnd);
                    SetFocus(previousForegroundHwnd);
                }
            }
        }

        private void ScreenshotNotification(string windowTitle)
        {

            CheckNotificationsEnabled();

            //Clear existing notifications
            ToastNotificationManagerCompat.History.Clear();

            new ToastContentBuilder()
                .AddText($"Screenshot Saved")
                .AddText(windowTitle)
                .AddAudio(new ToastAudio() { Silent = true })
                .Show(toast =>
                {
                    toast.ExpirationTime = DateTime.Now.AddSeconds(5);
                });

        }

        private void ScreenshotPreviewNotification(Bitmap Image)
        {
            //Check if notifications are enabled, bypass notification and go straight to save if not
            if (CheckNotificationsEnabled() == false)
            {
                SaveScreenshot(Image);
                return;
            }

            //Generate a temporary saved file from the given Image bitmap
            string ImagePath = Path.GetTempFileName();
            Image.Save(ImagePath);

            var previewNotification = new ToastContentBuilder()
                .AddInlineImage(new Uri(ImagePath))
                .AddArgument("tempImagePath", ImagePath)
                .AddText("Select to save or discard screenshot")
                .AddText("Will automtically save if no option selected")
                .AddButton(new ToastButton()
                    .SetContent("Save")
                    .AddArgument("action", "save")
                    .SetBackgroundActivation())
                .AddButton(new ToastButton()
                    .SetContent("Discard")
                    .AddArgument("action", "discard")
                    .SetBackgroundActivation())
                .AddAudio(new ToastAudio() { Silent = true });

            previewNotification.Show(toast =>
            {
                toast.Tag = "Preview";
                toast.Group = "EZSS";
            });

            //Check if any toast notifications from this program are open
            if (ToastNotificationManagerCompat.History.GetHistory().Any(x => x.Group == "EZSS"))
            {
                //Check if the preview notification is still open
                if (ToastNotificationManagerCompat.History.GetHistory().Any(x => x.Tag == "Preview"))
                {
                    //Sub to dismissed event for the preview notification
                    ToastNotificationManagerCompat.History.GetHistory().First(x => x.Tag == "Preview").Dismissed += (sender, e) =>
                    {
                        switch (e.Reason)
                        {

                            case ToastDismissalReason.UserCanceled:
                                File.Delete(ImagePath);
                                break;

                            case ToastDismissalReason.TimedOut:
                                SaveTempImage(ImagePath);
                                break;

                            case ToastDismissalReason.ApplicationHidden:
                                SaveTempImage(ImagePath);
                                break;
                        }
                        // Clear notifications from action center
                        ToastNotificationManagerCompat.History.Clear();
                    };
                }
            }
        }

        public bool CheckNotificationsEnabled()
        {
            var toastNotifier = ToastNotificationManagerCompat.CreateToastNotifier();

            bool notificationsEnabled = toastNotifier.Setting == NotificationSetting.Enabled;

            if (!notificationsEnabled)
            {
                if (Properties.Settings.Default.NotificationWarningGiven)
                {
                    return false;
                }

                MessageBox.Show("Notifications are disabled for EZSS/this device. It is recommended to enable them to get confirmation your screenshot was taken, and it is required to use the preview feature. Your screenshot has still been saved.", "Notifications Disabled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Properties.Settings.Default.NotificationWarningGiven = true;
                Properties.Settings.Default.Save();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void HandlePreviewSelection(ToastNotificationActivatedEventArgsCompat e)
        {
            ToastArguments args = ToastArguments.Parse(e.Argument);
            ValueSet userInput = e.UserInput;

            if (args["action"] == "save")
            {
                String tempImagePath = args["tempImagePath"];
                SaveTempImage(tempImagePath);
            }

            if (args["action"] == "discard")
            {
                //Delete the temp file at the given path
                File.Delete(args["tempImagePath"]);
            }
        }

        private void SaveTempImage(string tempImagePath)
        {
            //Create a new bitmap from the given image path, save it, then delete the temp file at the path
            Bitmap Image = new Bitmap(tempImagePath);
            try
            {
                SaveScreenshot(Image);
            }

            finally
            {
                Image.Dispose();
            }

            File.Delete(tempImagePath);
        }

        public bool SaveScreenshot(Bitmap screenshot)
        {
            string directory = Properties.Settings.Default.SaveDirectory;

            if (!string.IsNullOrEmpty(directory))
            {
                //Combine the directory and filename to create a full path
                string fileName = Path.Combine(directory, GenerateFileName());
                screenshot.Save(fileName, ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("Please select a target directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Properties.Settings.Default.AutoDelete)
            {
                DeleteOldScreenshots(directory);
            }

            return true;

        }

        private string GenerateFileName()
        {
            //TODO: Add option to customize file names
            return $"{DateTime.Now:yyyy-MM-dd--HH-mm-ss}--" + $"EZSS.png";
        }

        private void DeleteOldScreenshots(string directory)
        {
            // Dispose of any screenshots in target directory that exceed the maximum number of screenshots
            string[] files = Directory.GetFiles(directory, "*EZSS.png");
            int allowedQuantity = Properties.Settings.Default.AllowedQuantity;
            if (files.Length > allowedQuantity)
            {
                Array.Sort(files);
                for (int i = 0; i < files.Length - allowedQuantity; i++)
                {
                    File.Delete(files[i]);
                }
            }
        }

        private void nupdwnAllowedQty_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AllowedQuantity = (int)nupdwnAllowedQty.Value;
            Properties.Settings.Default.Save();
        }

        private void cmbboxHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected hotkey and save it to settings
            Properties.Settings.Default.Hotkey = cmbboxHotkey.Text;
            Properties.Settings.Default.Save();
            //Conver the string to a Keys enum
            KeysConverter converter = new KeysConverter();
            if (Enum.TryParse(cmbboxHotkey.Text, out Keys key))
            {
                hiddenForm.UpdateHotKey(key);
            }
            else
            {
                //Display error box
                MessageBox.Show("Invalid hotkey selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkbxAutoDelete_CheckedChanged(object sender)
        {
            Properties.Settings.Default.AutoDelete = chkbxAutoDelete.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkbxCaptureUnderMouse_CheckedChanged(object sender)
        {
            Properties.Settings.Default.CaptureUnderMouse = chkbxCaptureUnderMouse.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkbxTogglePreview_CheckedChanged(object sender)
        {
            Properties.Settings.Default.ViewPreview = chkbxTogglePreview.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        // Click and drag window functionality
        private bool mouseDown;
        private Point lastLocation;
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}