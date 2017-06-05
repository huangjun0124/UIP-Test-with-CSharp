using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;
using Infragistics.Win.UltraWinTabbedMdi;
using Microsoft.ApplicationBlocks.UIProcess;

namespace Client1
{
    public partial class FormMain : WindowsFormView
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region UIPManager Plumbing
        private BaseController MainController
        {
            get { return (BaseController)this.Controller; }
        }
        #endregion

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.ExitThread();
            Application.Exit();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.ShowForm("Form1");
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.ShowForm("Form2");
        }

        private void mdmMain_TabDisplayed(object sender, MdiTabEventArgs e)
        {
            try
            {
                if (this.ultraTabbedMdiManager1.TabGroups.Count > 0)
                    this.ultraTabbedMdiManager1.TabGroups[0].Settings.CloseButtonLocation = Infragistics.Win.UltraWinTabs.TabCloseButtonLocation.Tab;
            }
            catch { }
        }
    }
}
