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
            UpdateCountdownLabel(milliseconds);
            await Task.Delay(milliseconds);
            if (IsDisposed) { return; }
            mainForm.SaveScreenshot(screenshot);
            Dispose();
        }

        private async void UpdateCountdownLabel(Int32 milliseconds)
        {
            //Timer that updates the countdown label every second
            for (int i = 0; i < milliseconds / 1000; i++)
            {
                lblCountdown.Text = $"Auto saving in... {(milliseconds / 1000 - i).ToString()}s";
                await Task.Delay(1000);
            }
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
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pictureBoxScreenshot_Click(object sender, EventArgs e)
        {

        }

        private void ScreenshotPreviewForm_KeyDown(object sender, KeyEventArgs e)
        {
            // if key is ENTER, save and set dialog result to OK, if ESC, set dialog result to Cancel and close
            if (e.KeyCode == Keys.Enter)
            {
                mainForm.SaveScreenshot(screenshot);
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
