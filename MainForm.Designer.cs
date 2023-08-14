namespace EZSS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblTargetDirectoryTitle = new Label();
            dlgTargetDirectory = new FolderBrowserDialog();
            btnChangeDirectory = new Button();
            lblTargetDirectory = new Label();
            notifyIcon1 = new NotifyIcon(components);
            chkbxTogglePreview = new CheckBox();
            SuspendLayout();
            // 
            // lblTargetDirectoryTitle
            // 
            lblTargetDirectoryTitle.AutoSize = true;
            lblTargetDirectoryTitle.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetDirectoryTitle.Location = new Point(91, 73);
            lblTargetDirectoryTitle.Name = "lblTargetDirectoryTitle";
            lblTargetDirectoryTitle.Size = new Size(233, 42);
            lblTargetDirectoryTitle.TabIndex = 0;
            lblTargetDirectoryTitle.Text = "Target Directory:";
            // 
            // btnChangeDirectory
            // 
            btnChangeDirectory.Location = new Point(692, 90);
            btnChangeDirectory.Name = "btnChangeDirectory";
            btnChangeDirectory.Size = new Size(75, 23);
            btnChangeDirectory.TabIndex = 1;
            btnChangeDirectory.Text = "Change";
            btnChangeDirectory.UseVisualStyleBackColor = true;
            btnChangeDirectory.Click += btnChangeDirectory_Click_1;
            // 
            // lblTargetDirectory
            // 
            lblTargetDirectory.AutoSize = true;
            lblTargetDirectory.Location = new Point(330, 94);
            lblTargetDirectory.Name = "lblTargetDirectory";
            lblTargetDirectory.Size = new Size(0, 15);
            lblTargetDirectory.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // chkbxTogglePreview
            // 
            chkbxTogglePreview.AutoSize = true;
            chkbxTogglePreview.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxTogglePreview.Location = new Point(453, 164);
            chkbxTogglePreview.Name = "chkbxTogglePreview";
            chkbxTogglePreview.Size = new Size(314, 49);
            chkbxTogglePreview.TabIndex = 3;
            chkbxTogglePreview.Text = "Preview Screenshot";
            chkbxTogglePreview.UseVisualStyleBackColor = true;
            chkbxTogglePreview.CheckedChanged += chkbxTogglePreview_CheckedChange;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(chkbxTogglePreview);
            Controls.Add(lblTargetDirectory);
            Controls.Add(btnChangeDirectory);
            Controls.Add(lblTargetDirectoryTitle);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += MainForm_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTargetDirectoryTitle;
        private FolderBrowserDialog dlgTargetDirectory;
        private Button btnChangeDirectory;
        private Label lblTargetDirectory;
        private NotifyIcon notifyIcon1;
        private CheckBox chkbxTogglePreview;
    }
}