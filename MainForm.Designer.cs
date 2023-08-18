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
            notifyIcon = new NotifyIcon(components);
            ttpCaptureUnderMouse = new ToolTip(components);
            ttpAutoDelete = new ToolTip(components);
            lblShortcutKeyTitle = new Label();
            nupdwnAllowedQty = new ReaLTaiizor.Controls.ForeverNumeric();
            chkbxAutoDelete = new ReaLTaiizor.Controls.ForeverCheckBox();
            chkbxCaptureUnderMouse = new ReaLTaiizor.Controls.ForeverCheckBox();
            chkbxTogglePreview = new ReaLTaiizor.Controls.ForeverCheckBox();
            cmbboxHotkey = new ReaLTaiizor.Controls.ForeverComboBox();
            label1 = new Label();
            lblTargetDirectory = new ReaLTaiizor.Controls.ForeverTextBox();
            extendedPanel1 = new ReaLTaiizor.Controls.ExtendedPanel();
            lblAppName = new ReaLTaiizor.Controls.ForeverLabel();
            btnMinimize = new ReaLTaiizor.Controls.ForeverMinimize();
            btnClose = new ReaLTaiizor.Controls.ForeverClose();
            btnChangeDirectory = new ReaLTaiizor.Controls.ForeverButton();
            extendedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTargetDirectoryTitle
            // 
            lblTargetDirectoryTitle.AutoSize = true;
            lblTargetDirectoryTitle.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetDirectoryTitle.ForeColor = Color.FromArgb(243, 243, 243);
            lblTargetDirectoryTitle.Location = new Point(12, 48);
            lblTargetDirectoryTitle.Name = "lblTargetDirectoryTitle";
            lblTargetDirectoryTitle.Size = new Size(117, 19);
            lblTargetDirectoryTitle.TabIndex = 0;
            lblTargetDirectoryTitle.Text = "Save Directory:";
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "EZSS";
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // lblShortcutKeyTitle
            // 
            lblShortcutKeyTitle.AutoSize = true;
            lblShortcutKeyTitle.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShortcutKeyTitle.ForeColor = Color.FromArgb(243, 243, 243);
            lblShortcutKeyTitle.Location = new Point(13, 115);
            lblShortcutKeyTitle.Name = "lblShortcutKeyTitle";
            lblShortcutKeyTitle.Size = new Size(103, 19);
            lblShortcutKeyTitle.TabIndex = 7;
            lblShortcutKeyTitle.Text = "Shortcut key:";
            // 
            // nupdwnAllowedQty
            // 
            nupdwnAllowedQty.BaseColor = Color.FromArgb(45, 47, 49);
            nupdwnAllowedQty.ButtonColorA = Color.DodgerBlue;
            nupdwnAllowedQty.ButtonColorB = Color.White;
            nupdwnAllowedQty.ButtonColorC = Color.White;
            nupdwnAllowedQty.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nupdwnAllowedQty.ForeColor = Color.Silver;
            nupdwnAllowedQty.Location = new Point(140, 243);
            nupdwnAllowedQty.Maximum = 100L;
            nupdwnAllowedQty.Minimum = 0L;
            nupdwnAllowedQty.Name = "nupdwnAllowedQty";
            nupdwnAllowedQty.Size = new Size(75, 30);
            nupdwnAllowedQty.TabIndex = 9;
            nupdwnAllowedQty.Text = "foreverNumeric1";
            nupdwnAllowedQty.Value = 0L;
            nupdwnAllowedQty.Click += nupdwnAllowedQty_ValueChanged;
            // 
            // chkbxAutoDelete
            // 
            chkbxAutoDelete.BackColor = Color.FromArgb(60, 70, 73);
            chkbxAutoDelete.BaseColor = Color.FromArgb(45, 47, 49);
            chkbxAutoDelete.BorderColor = Color.DodgerBlue;
            chkbxAutoDelete.Checked = false;
            chkbxAutoDelete.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxAutoDelete.ForeColor = Color.FromArgb(243, 243, 243);
            chkbxAutoDelete.Location = new Point(13, 245);
            chkbxAutoDelete.Name = "chkbxAutoDelete";
            chkbxAutoDelete.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            chkbxAutoDelete.Size = new Size(130, 22);
            chkbxAutoDelete.TabIndex = 10;
            chkbxAutoDelete.Text = "Auto Delete";
            chkbxAutoDelete.CheckedChanged += chkbxAutoDelete_CheckedChanged;
            // 
            // chkbxCaptureUnderMouse
            // 
            chkbxCaptureUnderMouse.BackColor = Color.FromArgb(60, 70, 73);
            chkbxCaptureUnderMouse.BaseColor = Color.FromArgb(45, 47, 49);
            chkbxCaptureUnderMouse.BorderColor = Color.DodgerBlue;
            chkbxCaptureUnderMouse.Checked = false;
            chkbxCaptureUnderMouse.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxCaptureUnderMouse.ForeColor = Color.FromArgb(243, 243, 243);
            chkbxCaptureUnderMouse.Location = new Point(13, 199);
            chkbxCaptureUnderMouse.Name = "chkbxCaptureUnderMouse";
            chkbxCaptureUnderMouse.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            chkbxCaptureUnderMouse.Size = new Size(226, 22);
            chkbxCaptureUnderMouse.TabIndex = 11;
            chkbxCaptureUnderMouse.Text = "Capture hovered window";
            chkbxCaptureUnderMouse.CheckedChanged += chkbxCaptureUnderMouse_CheckedChanged;
            // 
            // chkbxTogglePreview
            // 
            chkbxTogglePreview.BackColor = Color.FromArgb(60, 70, 73);
            chkbxTogglePreview.BaseColor = Color.FromArgb(45, 47, 49);
            chkbxTogglePreview.BorderColor = Color.DodgerBlue;
            chkbxTogglePreview.Checked = false;
            chkbxTogglePreview.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxTogglePreview.ForeColor = Color.FromArgb(243, 243, 243);
            chkbxTogglePreview.Location = new Point(13, 153);
            chkbxTogglePreview.Name = "chkbxTogglePreview";
            chkbxTogglePreview.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            chkbxTogglePreview.Size = new Size(226, 22);
            chkbxTogglePreview.TabIndex = 12;
            chkbxTogglePreview.Text = "Enable Preview";
            chkbxTogglePreview.CheckedChanged += chkbxTogglePreview_CheckedChanged;
            // 
            // cmbboxHotkey
            // 
            cmbboxHotkey.BaseColor = Color.FromArgb(25, 27, 29);
            cmbboxHotkey.BGColor = Color.FromArgb(45, 47, 49);
            cmbboxHotkey.DrawMode = DrawMode.OwnerDrawFixed;
            cmbboxHotkey.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxHotkey.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbboxHotkey.ForeColor = Color.White;
            cmbboxHotkey.FormattingEnabled = true;
            cmbboxHotkey.HoverColor = Color.FromArgb(35, 168, 109);
            cmbboxHotkey.HoverFontColor = Color.White;
            cmbboxHotkey.ItemHeight = 18;
            cmbboxHotkey.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11" });
            cmbboxHotkey.Location = new Point(140, 112);
            cmbboxHotkey.Name = "cmbboxHotkey";
            cmbboxHotkey.Size = new Size(121, 24);
            cmbboxHotkey.TabIndex = 13;
            cmbboxHotkey.SelectedIndexChanged += cmbboxHotkey_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(243, 243, 243);
            label1.Location = new Point(123, 276);
            label1.Name = "label1";
            label1.Size = new Size(116, 26);
            label1.TabIndex = 14;
            label1.Text = "Maximum Screenshots \r\nin Folder";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTargetDirectory
            // 
            lblTargetDirectory.BackColor = Color.Transparent;
            lblTargetDirectory.BaseColor = Color.FromArgb(45, 47, 49);
            lblTargetDirectory.BorderColor = Color.DodgerBlue;
            lblTargetDirectory.Enabled = false;
            lblTargetDirectory.FocusOnHover = false;
            lblTargetDirectory.ForeColor = Color.FromArgb(192, 192, 192);
            lblTargetDirectory.ImeMode = ImeMode.NoControl;
            lblTargetDirectory.Location = new Point(12, 77);
            lblTargetDirectory.MaxLength = 32767;
            lblTargetDirectory.Multiline = false;
            lblTargetDirectory.Name = "lblTargetDirectory";
            lblTargetDirectory.ReadOnly = false;
            lblTargetDirectory.Size = new Size(269, 29);
            lblTargetDirectory.TabIndex = 15;
            lblTargetDirectory.Text = "NULL";
            lblTargetDirectory.TextAlign = HorizontalAlignment.Left;
            lblTargetDirectory.UseSystemPasswordChar = false;
            // 
            // extendedPanel1
            // 
            extendedPanel1.BackColor = Color.FromArgb(45, 47, 49);
            extendedPanel1.BorderStyle = BorderStyle.FixedSingle;
            extendedPanel1.Controls.Add(lblAppName);
            extendedPanel1.Controls.Add(btnMinimize);
            extendedPanel1.Controls.Add(btnClose);
            extendedPanel1.DrawMode = ReaLTaiizor.Controls.ExtendedPanel.Drawer.Default;
            extendedPanel1.Location = new Point(0, 0);
            extendedPanel1.MostInterval = 100;
            extendedPanel1.Name = "extendedPanel1";
            extendedPanel1.Opacity = 50;
            extendedPanel1.Size = new Size(295, 31);
            extendedPanel1.TabIndex = 16;
            extendedPanel1.TopMost = true;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.FromArgb(45, 47, 49);
            lblAppName.Dock = DockStyle.Left;
            lblAppName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.LightGray;
            lblAppName.Location = new Point(0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(111, 19);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "EZ ScreenShot";
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.White;
            btnMinimize.BaseColor = Color.FromArgb(45, 47, 49);
            btnMinimize.DefaultLocation = true;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.DownColor = Color.FromArgb(30, 0, 0, 0);
            btnMinimize.Font = new Font("Marlett", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.Location = new Point(257, 0);
            btnMinimize.Margin = new Padding(6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.OverColor = Color.FromArgb(30, 255, 255, 255);
            btnMinimize.Size = new Size(18, 18);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "foreverMinimize1";
            btnMinimize.TextColor = Color.FromArgb(243, 243, 243);
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.BaseColor = Color.FromArgb(45, 47, 49);
            btnClose.DefaultLocation = true;
            btnClose.Dock = DockStyle.Right;
            btnClose.DownColor = Color.FromArgb(30, 0, 0, 0);
            btnClose.Font = new Font("Marlett", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(275, 0);
            btnClose.Margin = new Padding(6);
            btnClose.Name = "btnClose";
            btnClose.OverColor = Color.FromArgb(30, 255, 255, 255);
            btnClose.Size = new Size(18, 18);
            btnClose.TabIndex = 1;
            btnClose.Text = "foreverClose1";
            btnClose.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // btnChangeDirectory
            // 
            btnChangeDirectory.BackColor = Color.Transparent;
            btnChangeDirectory.BaseColor = Color.DodgerBlue;
            btnChangeDirectory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeDirectory.Location = new Point(126, 46);
            btnChangeDirectory.Name = "btnChangeDirectory";
            btnChangeDirectory.Rounded = false;
            btnChangeDirectory.Size = new Size(77, 25);
            btnChangeDirectory.TabIndex = 17;
            btnChangeDirectory.Text = "Change";
            btnChangeDirectory.TextColor = Color.FromArgb(243, 243, 243);
            btnChangeDirectory.Click += btnChangeDirectory_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 70, 73);
            ClientSize = new Size(292, 310);
            Controls.Add(extendedPanel1);
            Controls.Add(btnChangeDirectory);
            Controls.Add(lblTargetDirectory);
            Controls.Add(label1);
            Controls.Add(cmbboxHotkey);
            Controls.Add(chkbxTogglePreview);
            Controls.Add(chkbxCaptureUnderMouse);
            Controls.Add(chkbxAutoDelete);
            Controls.Add(nupdwnAllowedQty);
            Controls.Add(lblShortcutKeyTitle);
            Controls.Add(lblTargetDirectoryTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            SizeChanged += MainForm_SizeChanged;
            extendedPanel1.ResumeLayout(false);
            extendedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTargetDirectoryTitle;
        private FolderBrowserDialog dlgTargetDirectory;
        private Button btnChangeDirectory1;
        private NotifyIcon notifyIcon;
        private ToolTip ttpCaptureUnderMouse;
        private ToolTip ttpAutoDelete;
        private Label lblShortcutKeyTitle;
        private ReaLTaiizor.Controls.ForeverNumeric nupdwnAllowedQty;
        private ReaLTaiizor.Controls.ForeverCheckBox chkbxAutoDelete;
        private ReaLTaiizor.Controls.ForeverCheckBox chkbxCaptureUnderMouse;
        private ReaLTaiizor.Controls.ForeverCheckBox chkbxTogglePreview;
        private ReaLTaiizor.Controls.ForeverComboBox cmbboxHotkey;
        private Label label1;
        private ReaLTaiizor.Controls.ForeverTextBox lblTargetDirectory;
        private ReaLTaiizor.Controls.ExtendedPanel extendedPanel1;
        private ReaLTaiizor.Controls.ForeverButton btnChangeDirectory;
        private ReaLTaiizor.Controls.ForeverClose btnClose;
        private ReaLTaiizor.Controls.ForeverMinimize btnMinimize;
        private ReaLTaiizor.Controls.ForeverLabel lblAppName;
    }
}