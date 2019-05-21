using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProcessesBrowser;

namespace HideWindows
{
    public partial class MainForm : Form
    {
        #region Varables

        private const int appsNum = 10;
        private IntPtr[] hWnd = new IntPtr[appsNum];
        private int current = 0;
        private bool hidden = false;

        #endregion Varables

        #region Import

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        #endregion Import

        #region Functions

        public MainForm()
        {
            InitializeComponent();
            ClearArray();
            currentAppLabel.Text = "Current : " + (current + 1).ToString();
        }

        private void ClearArray()
        {
            hWnd[0] = IntPtr.Zero;
            hWnd[1] = IntPtr.Zero;
            hWnd[2] = IntPtr.Zero;
            hWnd[3] = IntPtr.Zero;
            hWnd[4] = IntPtr.Zero;
            hWnd[5] = IntPtr.Zero;
            hWnd[6] = IntPtr.Zero;
            hWnd[7] = IntPtr.Zero;
            hWnd[8] = IntPtr.Zero;
            hWnd[9] = IntPtr.Zero;
        }

        private void ShowHideButton_Click(object sender, EventArgs e)
        {
            if (hWnd[current] == IntPtr.Zero)
            {
                if (AppNameTextBox.Text != "")
                {
                    //Find Window
                    hWnd[current] = FindWindow(null, AppNameTextBox.Text);
                }
            }

            if (hWnd[current] != IntPtr.Zero)
            {
                if (hidden)
                {
                    //Show
                    ShowWindow(hWnd[current], 1);
                    hidden = false;
                }
                else
                {
                    //Hide
                    ShowWindow(hWnd[current], 0);
                    hidden = true;
                }
            }

        }

        private void previousApp_Click(object sender, EventArgs e)
        {
            if (current > 0)
                current--;
            currentAppLabel.Text = "Current : " + (current + 1).ToString();
        }

        private void nextApp_Click(object sender, EventArgs e)
        {
            if (current < appsNum - 1)
                current++;
            currentAppLabel.Text = "Current : " + (current + 1).ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearCurrentButton_Click(object sender, EventArgs e)
        {
            hWnd[current] = IntPtr.Zero;
        }

        private void browseProcessButton_Click(object sender, EventArgs e)
        {
            ProcessBrowser pb1 = new ProcessBrowser();

            if (pb1.ShowDialog() == DialogResult.OK)
            {
                hWnd[current] = pb1.GetSelectedProcess().MainWindowHandle;
                AppNameTextBox.Text = pb1.GetSelectedProcess().ProcessName;
            }
        }

        #endregion Functions

    }
}