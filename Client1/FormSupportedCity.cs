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
    public partial class FormSupportedCity : WindowsFormView
    {
        public BaseController MainController;

        public FormSupportedCity()
        {
            InitializeComponent();
        }

        private void FormSupportedCity_Load(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            List<string> ls = MainController.GetSuppotedCityString(code);

            DataTable dtTable = new DataTable();
            dtTable.Columns.Add("City");
            dtTable.Columns.Add("CityCode");
            foreach (string s in ls)
            {
                string[] value = s.Split(',');
                DataRow row = dtTable.NewRow();
                row[0] = value[0];
                row[1] = value[1];
                dtTable.Rows.Add(row);
            }

            DataGridView grd = new DataGridView()
            {
                Dock = DockStyle.Fill,
                DataSource = dtTable
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(grd);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGet.PerformClick();
            }
        }

        private void btnGetDS_Click(object sender, EventArgs e)
        {
            DataSet ds = MainController.GetSuppotedCityDS(txtCode.Text.Trim());

            DataGridView grd = new DataGridView()
            {
                Dock = DockStyle.Fill,
                DataSource = ds.Tables["City"]
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(grd);
        }

    }
}
