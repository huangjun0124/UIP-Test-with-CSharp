using System;
using System.Collections;
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
    public partial class Form2 : WindowsFormView
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region UIPManager Plumbing
        private BaseController MainController
        {
            get { return (BaseController)this.Controller; }
        }
        #endregion

        private void btnGetRegionDS_Click(object sender, EventArgs e)
        {
            DataSet ds = MainController.GetRegionDS();
            panel.Controls.Clear();                                                                                                                                                                                                                                           
            RegionDS ctrl = new RegionDS()
            {
                Province = ds.Tables["Province"],
                Country = ds.Tables["Country"],
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(ctrl);
        }

        private void btnGetRegionCountry_Click(object sender, EventArgs e)
        {
            List<string> ls = MainController.GetRegionCountry();
            DataTable dtTable  = new DataTable();
            dtTable.Columns.Add("CountryName");
            dtTable.Columns.Add("RegionID");
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
            panel.Controls.Clear();
            panel.Controls.Add(grd);
        }

        private void btnGetRegionProvince_Click(object sender, EventArgs e)
        {
            List<string> ls = MainController.GetRegionProvince();

            DataTable dtTable = new DataTable();
            dtTable.Columns.Add("Province");
            dtTable.Columns.Add("RegionID");
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
            panel.Controls.Clear();
            panel.Controls.Add(grd);
        }

        private void btnGetSupportedCityDS_Click(object sender, EventArgs e)
        {
            FormSupportedCity frm = new FormSupportedCity();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MainController = this.MainController;
            frm.Show();
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            FormSelectCity frm = new FormSelectCity();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string city = frm.city;
                string pm = MainController.GetPM25(city);
                List<Dictionary<string, string>> pm25 = fastJSON.JSON.Instance.Parse(pm) as List<Dictionary<string, string>>;

                List<string> ls = MainController.GetWeatherRev1(city);
                WeatherCtl ctl = new WeatherCtl()
                {
                    ls = ls,
                    pm25 = pm25
                };
                panel.Controls.Clear();
                panel.Controls.Add(ctl);
            }
        }
    }
}
