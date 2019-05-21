using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ProcessesBrowser
{
    public partial class ProcessBrowser : Form
    {
        #region Import

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        #endregion Import

        #region Variables

        Process[] prc;
        int index = 0;

        #endregion Variables

        #region Functions

        public ProcessBrowser()
        {
            InitializeComponent();
        }

        private void RefreshProcesses()
        {
            try
            {
                processesListBox.Items.Clear();

                prc = Process.GetProcesses();

                for (int i = 0; i < prc.Length; i++)
                    processesListBox.Items.Add(prc[i].ProcessName);

                processesListBox.SelectedIndex = index;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void processesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                index = processesListBox.SelectedIndex;

                prcNameTextBox.Text = prc[index].ProcessName;
                prcTitleTextBox.Text = prc[index].MainWindowTitle;
                machineNameTextBox.Text = prc[index].MachineName;
                idTextBox.Text = prc[index].Id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshProcesses();
        }

        private void processBrowser_Load(object sender, EventArgs e)
        {
            RefreshProcesses();
        }

        public Process GetSelectedProcess()
        {
            return prc[index];
        }

        #endregion Functions
    }
}
