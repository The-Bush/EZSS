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
            chkbxCaptureUnderMouse = new CheckBox();
            ttpCaptureUnderMouse = new ToolTip(components);
            chkbxAutoDelete = new CheckBox();
            ttpAutoDelete = new ToolTip(components);
            nupdwnAllowedQty = new NumericUpDown();
            lblShortcutKeyTitle = new Label();
            cmbboxHotkey = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nupdwnAllowedQty).BeginInit();
            SuspendLayout();
            // 
            // lblTargetDirectoryTitle
            // 
            lblTargetDirectoryTitle.AutoSize = true;
            lblTargetDirectoryTitle.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetDirectoryTitle.Location = new Point(47, 71);
            lblTargetDirectoryTitle.Name = "lblTargetDirectoryTitle";
            lblTargetDirectoryTitle.Size = new Size(281, 42);
            lblTargetDirectoryTitle.TabIndex = 0;
            lblTargetDirectoryTitle.Text = "Target Directory:";
            // 
            // btnChangeDirectory
            // 
            btnChangeDirectory.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblTargetDirectory.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetDirectory.Location = new Point(205, 120);
            lblTargetDirectory.Name = "lblTargetDirectory";
            lblTargetDirectory.Size = new Size(69, 29);
            lblTargetDirectory.TabIndex = 2;
            lblTargetDirectory.Text = "NULL";
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
            chkbxTogglePreview.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxTogglePreview.Location = new Point(417, 277);
            chkbxTogglePreview.Name = "chkbxTogglePreview";
            chkbxTogglePreview.Size = new Size(240, 33);
            chkbxTogglePreview.TabIndex = 3;
            chkbxTogglePreview.Text = "Preview Screenshot";
            ttpCaptureUnderMouse.SetToolTip(chkbxTogglePreview, "Enable to preview screenshots before saving or cancelling them.");
            chkbxTogglePreview.UseVisualStyleBackColor = true;
            chkbxTogglePreview.CheckedChanged += chkbxTogglePreview_CheckedChange;
            // 
            // chkbxCaptureUnderMouse
            // 
            chkbxCaptureUnderMouse.AutoSize = true;
            chkbxCaptureUnderMouse.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxCaptureUnderMouse.Location = new Point(417, 326);
            chkbxCaptureUnderMouse.Name = "chkbxCaptureUnderMouse";
            chkbxCaptureUnderMouse.Size = new Size(262, 33);
            chkbxCaptureUnderMouse.TabIndex = 4;
            chkbxCaptureUnderMouse.Text = "Capture under mouse";
            ttpCaptureUnderMouse.SetToolTip(chkbxCaptureUnderMouse, "Enable to capture the window the mouse is currently over. If disabled, captures focused/selected window.");
            chkbxCaptureUnderMouse.UseVisualStyleBackColor = true;
            chkbxCaptureUnderMouse.CheckedChanged += chkbxCaptureUnderMouse_CheckedChanged;
            // 
            // chkbxAutoDelete
            // 
            chkbxAutoDelete.AutoSize = true;
            chkbxAutoDelete.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxAutoDelete.Location = new Point(417, 375);
            chkbxAutoDelete.Name = "chkbxAutoDelete";
            chkbxAutoDelete.Size = new Size(156, 33);
            chkbxAutoDelete.TabIndex = 5;
            chkbxAutoDelete.Text = "Auto Delete";
            ttpAutoDelete.SetToolTip(chkbxAutoDelete, "Enable to automatically delete screenshots that exceed the selected quantity, oldest first. Only screenshots named *EZSS.png will be deleted. ");
            chkbxAutoDelete.UseVisualStyleBackColor = true;
            chkbxAutoDelete.CheckedChanged += chkbxAutoDelete_CheckedChanged;
            // 
            // nupdwnAllowedQty
            // 
            nupdwnAllowedQty.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nupdwnAllowedQty.Location = new Point(595, 375);
            nupdwnAllowedQty.Name = "nupdwnAllowedQty";
            nupdwnAllowedQty.Size = new Size(120, 22);
            nupdwnAllowedQty.TabIndex = 6;
            nupdwnAllowedQty.ValueChanged += nupdwnAllowedQty_ValueChanged;
            // 
            // lblShortcutKeyTitle
            // 
            lblShortcutKeyTitle.AutoSize = true;
            lblShortcutKeyTitle.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblShortcutKeyTitle.Location = new Point(47, 186);
            lblShortcutKeyTitle.Name = "lblShortcutKeyTitle";
            lblShortcutKeyTitle.Size = new Size(162, 42);
            lblShortcutKeyTitle.TabIndex = 7;
            lblShortcutKeyTitle.Text = "Shortcut:";
            // 
            // cmbboxHotkey
            // 
            cmbboxHotkey.FormattingEnabled = true;
            cmbboxHotkey.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11" });
            cmbboxHotkey.Location = new Point(209, 200);
            cmbboxHotkey.Name = "cmbboxHotkey";
            cmbboxHotkey.Size = new Size(121, 23);
            cmbboxHotkey.TabIndex = 8;
            cmbboxHotkey.Tag = "";
            cmbboxHotkey.SelectedIndexChanged += cmbboxHotkey_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbboxHotkey);
            Controls.Add(lblShortcutKeyTitle);
            Controls.Add(nupdwnAllowedQty);
            Controls.Add(chkbxAutoDelete);
            Controls.Add(chkbxCaptureUnderMouse);
            Controls.Add(chkbxTogglePreview);
            Controls.Add(lblTargetDirectory);
            Controls.Add(btnChangeDirectory);
            Controls.Add(lblTargetDirectoryTitle);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += MainForm_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)nupdwnAllowedQty).EndInit();
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
        private CheckBox chkbxCaptureUnderMouse;
        private ToolTip ttpCaptureUnderMouse;
        private CheckBox chkbxAutoDelete;
        private ToolTip ttpAutoDelete;
        private NumericUpDown nupdwnAllowedQty;
        private Label lblShortcutKeyTitle;
        private ComboBox cmbboxHotkey;
    }
}