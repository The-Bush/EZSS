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
            lblShortcutKeyTitle = new Label();
            chkbxAutoDelete = new ReaLTaiizor.Controls.ForeverCheckBox();
            chkbxCaptureUnderMouse = new ReaLTaiizor.Controls.ForeverCheckBox();
            chkbxTogglePreview = new ReaLTaiizor.Controls.ForeverCheckBox();
            label1 = new Label();
            lblTargetDirectory = new ReaLTaiizor.Controls.ForeverTextBox();
            nupdwnAllowedQty = new ReaLTaiizor.Controls.ForeverNumeric();
            ttpAutoDelete = new ToolTip(components);
            cmbboxHotkey = new ReaLTaiizor.Controls.ForeverComboBox();
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
            lblTargetDirectoryTitle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetDirectoryTitle.ForeColor = Color.FromArgb(243, 243, 243);
            lblTargetDirectoryTitle.Location = new Point(11, 31);
            lblTargetDirectoryTitle.Name = "lblTargetDirectoryTitle";
            lblTargetDirectoryTitle.Size = new Size(80, 13);
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
            lblShortcutKeyTitle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblShortcutKeyTitle.ForeColor = Color.FromArgb(243, 243, 243);
            lblShortcutKeyTitle.Location = new Point(12, 98);
            lblShortcutKeyTitle.Name = "lblShortcutKeyTitle";
            lblShortcutKeyTitle.Size = new Size(99, 13);
            lblShortcutKeyTitle.TabIndex = 7;
            lblShortcutKeyTitle.Text = "Screenshot hotkey:";
            ttpCaptureUnderMouse.SetToolTip(lblShortcutKeyTitle, "Set the shortcut that will trigger the screenshot to be taken");
            // 
            // chkbxAutoDelete
            // 
            chkbxAutoDelete.BackColor = Color.FromArgb(60, 70, 73);
            chkbxAutoDelete.BaseColor = Color.FromArgb(45, 47, 49);
            chkbxAutoDelete.BorderColor = Color.DodgerBlue;
            chkbxAutoDelete.Checked = false;
            chkbxAutoDelete.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxAutoDelete.ForeColor = Color.FromArgb(243, 243, 243);
            chkbxAutoDelete.Location = new Point(12, 186);
            chkbxAutoDelete.Name = "chkbxAutoDelete";
            chkbxAutoDelete.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            chkbxAutoDelete.Size = new Size(130, 22);
            chkbxAutoDelete.TabIndex = 10;
            chkbxAutoDelete.Text = "Auto Delete";
            ttpCaptureUnderMouse.SetToolTip(chkbxAutoDelete, "Enable to automatically clean old screenshots from the save directory.");
            chkbxAutoDelete.CheckedChanged += chkbxAutoDelete_CheckedChanged;
            // 
            // chkbxCaptureUnderMouse
            // 
            chkbxCaptureUnderMouse.BackColor = Color.FromArgb(60, 70, 73);
            chkbxCaptureUnderMouse.BaseColor = Color.FromArgb(45, 47, 49);
            chkbxCaptureUnderMouse.BorderColor = Color.DodgerBlue;
            chkbxCaptureUnderMouse.Checked = false;
            chkbxCaptureUnderMouse.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxCaptureUnderMouse.ForeColor = Color.FromArgb(243, 243, 243);
            chkbxCaptureUnderMouse.Location = new Point(12, 158);
            chkbxCaptureUnderMouse.Name = "chkbxCaptureUnderMouse";
            chkbxCaptureUnderMouse.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            chkbxCaptureUnderMouse.Size = new Size(226, 22);
            chkbxCaptureUnderMouse.TabIndex = 11;
            chkbxCaptureUnderMouse.Text = "Capture hovered window";
            ttpCaptureUnderMouse.SetToolTip(chkbxCaptureUnderMouse, "Enable to have the window underneath the mouse be captured, rather than the selected/focused window.");
            chkbxCaptureUnderMouse.CheckedChanged += chkbxCaptureUnderMouse_CheckedChanged;
            // 
            // chkbxTogglePreview
            // 
            chkbxTogglePreview.BackColor = Color.FromArgb(60, 70, 73);
            chkbxTogglePreview.BaseColor = Color.FromArgb(45, 47, 49);
            chkbxTogglePreview.BorderColor = Color.DodgerBlue;
            chkbxTogglePreview.Checked = false;
            chkbxTogglePreview.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkbxTogglePreview.ForeColor = Color.FromArgb(243, 243, 243);
            chkbxTogglePreview.Location = new Point(12, 130);
            chkbxTogglePreview.Name = "chkbxTogglePreview";
            chkbxTogglePreview.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            chkbxTogglePreview.Size = new Size(202, 22);
            chkbxTogglePreview.TabIndex = 12;
            chkbxTogglePreview.Text = "Enable Preview";
            ttpCaptureUnderMouse.SetToolTip(chkbxTogglePreview, "Enable to be prompted before saving the screenshot.");
            chkbxTogglePreview.CheckedChanged += chkbxTogglePreview_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(243, 243, 243);
            label1.Location = new Point(58, 225);
            label1.Name = "label1";
            label1.Size = new Size(126, 13);
            label1.TabIndex = 14;
            label1.Text = "Maximum # Screenshots ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            ttpCaptureUnderMouse.SetToolTip(label1, "If auto delete is enabled, only allow this many EZSS screenshots in the folder.");
            // 
            // lblTargetDirectory
            // 
            lblTargetDirectory.BackColor = Color.Transparent;
            lblTargetDirectory.BaseColor = Color.FromArgb(45, 47, 49);
            lblTargetDirectory.BorderColor = Color.DodgerBlue;
            lblTargetDirectory.Enabled = false;
            lblTargetDirectory.FocusOnHover = false;
            lblTargetDirectory.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetDirectory.ForeColor = Color.FromArgb(192, 192, 192);
            lblTargetDirectory.ImeMode = ImeMode.NoControl;
            lblTargetDirectory.Location = new Point(11, 60);
            lblTargetDirectory.MaxLength = 32767;
            lblTargetDirectory.Multiline = false;
            lblTargetDirectory.Name = "lblTargetDirectory";
            lblTargetDirectory.ReadOnly = false;
            lblTargetDirectory.Size = new Size(269, 24);
            lblTargetDirectory.TabIndex = 15;
            lblTargetDirectory.Text = "NULL";
            lblTargetDirectory.TextAlign = HorizontalAlignment.Left;
            ttpCaptureUnderMouse.SetToolTip(lblTargetDirectory, "The directory screenshots will be saved in.");
            lblTargetDirectory.UseSystemPasswordChar = false;
            // 
            // nupdwnAllowedQty
            // 
            nupdwnAllowedQty.BaseColor = Color.FromArgb(45, 47, 49);
            nupdwnAllowedQty.ButtonColorA = Color.DodgerBlue;
            nupdwnAllowedQty.ButtonColorB = Color.White;
            nupdwnAllowedQty.ButtonColorC = Color.White;
            nupdwnAllowedQty.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            nupdwnAllowedQty.ForeColor = Color.Silver;
            nupdwnAllowedQty.Location = new Point(200, 216);
            nupdwnAllowedQty.Maximum = 100L;
            nupdwnAllowedQty.Minimum = 0L;
            nupdwnAllowedQty.Name = "nupdwnAllowedQty";
            nupdwnAllowedQty.Size = new Size(75, 30);
            nupdwnAllowedQty.TabIndex = 9;
            nupdwnAllowedQty.Text = "foreverNumeric1";
            nupdwnAllowedQty.Value = 0L;
            nupdwnAllowedQty.Click += nupdwnAllowedQty_ValueChanged;
            // 
            // cmbboxHotkey
            // 
            cmbboxHotkey.BaseColor = Color.FromArgb(25, 27, 29);
            cmbboxHotkey.BGColor = Color.FromArgb(45, 47, 49);
            cmbboxHotkey.DrawMode = DrawMode.OwnerDrawFixed;
            cmbboxHotkey.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbboxHotkey.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbboxHotkey.ForeColor = Color.White;
            cmbboxHotkey.FormattingEnabled = true;
            cmbboxHotkey.HoverColor = Color.FromArgb(35, 168, 109);
            cmbboxHotkey.HoverFontColor = Color.White;
            cmbboxHotkey.ItemHeight = 18;
            cmbboxHotkey.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11" });
            cmbboxHotkey.Location = new Point(159, 95);
            cmbboxHotkey.Name = "cmbboxHotkey";
            cmbboxHotkey.Size = new Size(121, 24);
            cmbboxHotkey.TabIndex = 13;
            cmbboxHotkey.SelectedIndexChanged += cmbboxHotkey_SelectedIndexChanged;
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
            extendedPanel1.Size = new Size(295, 21);
            extendedPanel1.TabIndex = 16;
            extendedPanel1.TopMost = true;
            extendedPanel1.MouseDown += MainForm_MouseDown;
            extendedPanel1.MouseMove += MainForm_MouseMove;
            extendedPanel1.MouseUp += MainForm_MouseUp;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.FromArgb(45, 47, 49);
            lblAppName.Dock = DockStyle.Left;
            lblAppName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.LightGray;
            lblAppName.Location = new Point(0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(80, 13);
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
            btnChangeDirectory.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeDirectory.Location = new Point(97, 27);
            btnChangeDirectory.Name = "btnChangeDirectory";
            btnChangeDirectory.Rounded = false;
            btnChangeDirectory.Size = new Size(50, 20);
            btnChangeDirectory.TabIndex = 17;
            btnChangeDirectory.Text = "Change";
            btnChangeDirectory.TextColor = Color.FromArgb(243, 243, 243);
            btnChangeDirectory.Click += btnChangeDirectory_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 70, 73);
            ClientSize = new Size(292, 256);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            SizeChanged += MainForm_SizeChanged;
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            MouseUp += MainForm_MouseUp;
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