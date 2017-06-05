using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;
using Microsoft.ApplicationBlocks.UIProcess;

namespace Client1
{
    public partial class Form1 : WindowsFormView
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UIPManager Plumbing
        private BaseController MainController
        {
            get { return (BaseController)this.Controller; }
        }
        #endregion

        private void btnGetRegion_Click(object sender, EventArgs e)
        {
            grdTable.DataSource = MainController.GetExampleSvc();
        }
    }
}
