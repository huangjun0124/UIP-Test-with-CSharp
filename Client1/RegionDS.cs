using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client1
{
    public partial class RegionDS : UserControl
    {
        public RegionDS()
        {
            InitializeComponent();
        }

        public DataTable Province
        {
            get {return grdProvince.DataSource as DataTable;}
            set { grdProvince.DataSource = value; }
        }

        public DataTable Country
        {
            get { return grdCountry.DataSource as DataTable; }
            set { grdCountry.DataSource = value; }
        }
    }
}
