using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace EZSS
{
    public partial class MainForm : Form
    {
        private HiddenHotkeyForm hiddenForm;
        public MainForm()
        {
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

            chkbxTogglePreview.Checked = Properties.Settings.Default.ViewPreview;
            chkbxCaptureUnderMouse.Checked = Properties.Settings.Default.CaptureUnderMouse;
            chkbxAutoDelete.Checked = Properties.Settings.Default.AutoDelete;
            nupdwnAllowedQty.Value = Properties.Settings.Default.AllowedQuantity;
            cmbboxHotkey.Text = Properties.Settings.Default.Hotkey;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Update the Target Directory for saved screenshots
        private void btnChangeDirectory_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblTargetDirectory.Text = dialog.SelectedPath;
                Properties.Settings.Default.SaveDirectory = dialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
            else
            {
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
        public static extern int GetWindowText(IntPtr hWnd, out string lpString, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr SetFocus(IntPtr hWnd);

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

                    // Display the captured screenshot in a new window
                    using (ScreenshotPreviewForm previewForm = ScreenshotPreviewForm.GetInstance(screenshot, this))
                    {
                        SetForegroundWindow(previousForegroundHwnd);
                        SetFocus(previousForegroundHwnd);

                        if (Properties.Settings.Default.ViewPreview)
                        {
                            previewForm.ShowDialog();

                        }

                        else
                        {
                            SaveScreenshot(screenshot);
                        }


                        SetForegroundWindow(previousForegroundHwnd);
                        SetFocus(previousForegroundHwnd);
                    }


                }
            }
        }
        public void SaveScreenshot(Bitmap screenshot)
        {
            string directory = Properties.Settings.Default.SaveDirectory;

            if (!string.IsNullOrEmpty(directory))
            {
                string fileName = Path.Combine(directory, DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "EZSS.png");
                screenshot.Save(fileName, ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("Please select a target directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Properties.Settings.Default.AutoDelete)
            {
                DeleteOldScreenshots(directory);
            }

        }

        private static void DeleteOldScreenshots(string directory)
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

        private void chkbxTogglePreview_CheckedChange(object sender, EventArgs e)
        {
            Properties.Settings.Default.ViewPreview = chkbxTogglePreview.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkbxCaptureUnderMouse_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CaptureUnderMouse = chkbxCaptureUnderMouse.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkbxAutoDelete_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoDelete = chkbxAutoDelete.Checked;
            Properties.Settings.Default.Save();
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
            Keys key = (Keys)converter.ConvertFromString(cmbboxHotkey.Text);
            hiddenForm.UpdateHotKey(key);
        }
    }
}