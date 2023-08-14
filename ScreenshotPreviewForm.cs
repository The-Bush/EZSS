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
        public ScreenshotPreviewForm(Bitmap screenshot, MainForm mainForm)
        {
            InitializeComponent();
            this.screenshot = screenshot;
            pictureBoxScreenshot.Image = this.screenshot;
            this.mainForm = mainForm;
        }

        private void ScreenshotPreviewForm_Load(object sender, EventArgs e)
        {

        }

        private void ScreenshotPreviewForm_Paint(object sender, PaintEventArgs e)
        {
            if (screenshot != null)
            {
                e.Graphics.DrawImage(screenshot, Point.Empty);
                TopMost = true;
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
