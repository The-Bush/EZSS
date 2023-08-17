using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZSS
{
    public partial class ScreenshotPreviewForm : Form
    {
        private Bitmap screenshot;
        private MainForm mainForm;
        private static ScreenshotPreviewForm? instance;

        public static ScreenshotPreviewForm GetInstance(Bitmap screenshot, MainForm mainForm)
        {
            // Dispose the previous instance if it exists
            if (instance != null && !instance.IsDisposed)
            {
                instance.Dispose();
            }

            instance = new ScreenshotPreviewForm(screenshot, mainForm);
            return instance;
        }

        public ScreenshotPreviewForm(Bitmap screenshot, MainForm mainForm)
        {
            InitializeComponent();
            this.screenshot = screenshot;
            pictureBoxScreenshot.Image = this.screenshot;
            this.mainForm = mainForm;
        }

        private void ScreenshotPreviewForm_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new Point(x, y);

            this.Activate();

            AutoSaveAfterSeconds(10000);
        }

        private async void AutoSaveAfterSeconds(Int32 milliseconds)
        {
            await Task.Delay(milliseconds);
            mainForm.SaveScreenshot(screenshot);
            Close();
        }

        private void ScreenshotPreviewForm_Paint(object sender, PaintEventArgs e)
        {
            if (screenshot != null)
            {
                e.Graphics.DrawImage(screenshot, Point.Empty);
            }
            else
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mainForm.SaveScreenshot(screenshot);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
