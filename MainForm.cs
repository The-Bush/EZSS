using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

        #region
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("gdi32.dll")]
        private static extern int BitBlt(IntPtr hdcDest, int xDest, int yDest, int width, int height, IntPtr hdcSrc, int xSrc, int ySrc, int dwRop);

        private const int SRCCOPY = 0x00CC0020;

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

            IntPtr hwnd = GetForegroundWindow(); // Get the active window handle

            if (hwnd != IntPtr.Zero)
            {
                RECT windowRect;
                if (GetWindowRect(hwnd, out windowRect))
                {
                    int width = windowRect.right - windowRect.left;
                    int height = windowRect.bottom - windowRect.top;

                    Bitmap screenshot = new Bitmap(width, height);

                    // Create a graphics object from the bitmap
                    using (Graphics graphics = Graphics.FromImage(screenshot))
                    {
                        // Capture the screen contents into the bitmap
                        graphics.CopyFromScreen(new Point(windowRect.left, windowRect.top), Point.Empty, screenshot.Size);
                    }

                    // Display the captured screenshot in a new window
                    using (ScreenshotPreviewForm previewForm = new ScreenshotPreviewForm(screenshot, this))
                    {
                        if (Properties.Settings.Default.ViewPreview)
                        {
                            previewForm.ShowDialog();
                        }

                        else
                        {
                            SaveScreenshot(screenshot);
                        }

                    }
                }
            }
        }

        private void chkbxTogglePreview_CheckedChange(object sender, EventArgs e)
        {
            Properties.Settings.Default.ViewPreview = chkbxTogglePreview.Checked;
            Properties.Settings.Default.Save();
        }

        public void SaveScreenshot(Bitmap screenshot)
        {
            string directory = Properties.Settings.Default.SaveDirectory;

            if (!string.IsNullOrEmpty(directory))
            {
                string fileName = Path.Combine(directory, "screenshot.png");
                screenshot.Save(fileName, ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("Please select a target directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}