namespace EZSS
{
    partial class ScreenshotPreviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxScreenshot = new PictureBox();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScreenshot).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxScreenshot
            // 
            pictureBoxScreenshot.Location = new Point(-1, 0);
            pictureBoxScreenshot.Name = "pictureBoxScreenshot";
            pictureBoxScreenshot.Size = new Size(423, 341);
            pictureBoxScreenshot.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxScreenshot.TabIndex = 0;
            pictureBoxScreenshot.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(223, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(72, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(328, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(72, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ScreenshotPreviewForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            CancelButton = btnCancel;
            ClientSize = new Size(421, 339);
            ControlBox = false;
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(pictureBoxScreenshot);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScreenshotPreviewForm";
            Text = "Screenshot Preview";
            Load += ScreenshotPreviewForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxScreenshot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxScreenshot;
        private Button btnCancel;
        private Button btnSave;
    }
}