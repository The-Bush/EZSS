using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZSS
{
    public partial class HiddenHotkeyForm : Form
    {
        // Import the necessary Windows API functions
        private const int WM_HOTKEY = 0x0312;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 1; // Unique ID for the hotkey

        private MainForm mainForm;
        public HiddenHotkeyForm(MainForm mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
            if (!RegisterHotKey(this.Handle, HOTKEY_ID, 0, (uint)Keys.F5))
            {
                MessageBox.Show("Failed to register hotkey.");
            }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                // Handle the hotkey event here
                // For example: Show the main form
                mainForm?.CaptureScreenshot();
            }
        }

        private void OnFormClosed(object sender, FormClosingEventArgs e)
        {
            // Unregister the hotkey when the form is closing
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }

    }
}
