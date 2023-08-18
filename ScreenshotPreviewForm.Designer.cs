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
            btnSave = new ReaLTaiizor.Controls.ForeverButton();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            btnHiddenSave = new Button();
            btnHiddenCancel = new Button();
            lblCountdown = new ReaLTaiizor.Controls.ForeverLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScreenshot).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxScreenshot
            // 
            pictureBoxScreenshot.Location = new Point(1, -3);
            pictureBoxScreenshot.Name = "pictureBoxScreenshot";
            pictureBoxScreenshot.Size = new Size(420, 311);
            pictureBoxScreenshot.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxScreenshot.TabIndex = 0;
            pictureBoxScreenshot.TabStop = false;
            pictureBoxScreenshot.Click += pictureBoxScreenshot_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BaseColor = Color.DodgerBlue;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(319, 296);
            btnSave.Name = "btnSave";
            btnSave.Rounded = true;
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.FromArgb(243, 243, 243);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BaseColor = Color.FromArgb(45, 47, 49);
            btnCancel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(216, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Rounded = true;
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Discard";
            btnCancel.TextColor = Color.FromArgb(243, 243, 243);
            btnCancel.Click += btnCancel_Click;
            // 
            // foreverLabel2
            // 
            foreverLabel2.AutoSize = true;
            foreverLabel2.BackColor = Color.Transparent;
            foreverLabel2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            foreverLabel2.ForeColor = Color.LightGray;
            foreverLabel2.Location = new Point(182, 9);
            foreverLabel2.Name = "foreverLabel2";
            foreverLabel2.Size = new Size(46, 13);
            foreverLabel2.TabIndex = 4;
            foreverLabel2.Text = "Preview";
            // 
            // btnHiddenSave
            // 
            btnHiddenSave.Location = new Point(221, 303);
            btnHiddenSave.Name = "btnHiddenSave";
            btnHiddenSave.Size = new Size(0, 0);
            btnHiddenSave.TabIndex = 5;
            btnHiddenSave.Text = "btnHiddenSave";
            btnHiddenSave.UseVisualStyleBackColor = true;
            btnHiddenSave.Click += btnSave_Click;
            // 
            // btnHiddenCancel
            // 
            btnHiddenCancel.Location = new Point(319, 303);
            btnHiddenCancel.Name = "btnHiddenCancel";
            btnHiddenCancel.Size = new Size(0, 0);
            btnHiddenCancel.TabIndex = 6;
            btnHiddenCancel.Text = "btnHiddenCancel";
            btnHiddenCancel.UseVisualStyleBackColor = true;
            btnHiddenCancel.Click += btnCancel_Click;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.BackColor = Color.Transparent;
            lblCountdown.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountdown.ForeColor = Color.LightGray;
            lblCountdown.Location = new Point(12, 319);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(76, 13);
            lblCountdown.TabIndex = 7;
            lblCountdown.Text = "foreverLabel3";
            // 
            // ScreenshotPreviewForm
            // 
            AcceptButton = btnHiddenSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(60, 70, 73);
            CancelButton = btnHiddenCancel;
            ClientSize = new Size(420, 341);
            ControlBox = false;
            Controls.Add(lblCountdown);
            Controls.Add(btnHiddenCancel);
            Controls.Add(btnHiddenSave);
            Controls.Add(foreverLabel2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pictureBoxScreenshot);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScreenshotPreviewForm";
            Text = "Screenshot Preview";
            Load += ScreenshotPreviewForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxScreenshot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxScreenshot;
        private ReaLTaiizor.Controls.ForeverButton btnSave;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ExtendedPanel extendedPanel1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private Button btnHiddenSave;
        private Button btnHiddenCancel;
        private ReaLTaiizor.Controls.ForeverLabel lblCountdown;
    }
}