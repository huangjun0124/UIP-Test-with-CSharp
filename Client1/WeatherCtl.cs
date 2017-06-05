using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Client1
{
    public partial class WeatherCtl : UserControl
    {
        public List<string> ls;
        public List<Dictionary<string, string>> pm25;

        public WeatherCtl()
        {
            InitializeComponent();
        }

        private void WeatherCtl_Load(object sender, EventArgs e)
        {
            txt0.Text = ls[0];
            txt3.Text = ls[3];
            txt4.Text = ls[4];
            txt5.Text = ls[5];
            txt6.Text = ls[6].Replace("。",Environment.NewLine);
            txt7.Text = ls[7];
            txt8.Text = ls[8];
            txt9.Text = ls[9];
            //pictureBox1.Image = global::Client1.Properties.Resources.
            pictureBox1.Image = (Image)Client1.Properties.Resources.ResourceManager.GetObject("b_" + ls[10].Split('.')[0]);
            pictureBox2.Image = (Image)Client1.Properties.Resources.ResourceManager.GetObject("a_" + ls[11].Split('.')[0]);
        }

        private void btnPM25_Click(object sender, EventArgs e)
        {
            FormPM25 frm = new FormPM25()
            {
                pm25 = pm25
            };
            frm.ShowDialog();
        }


    }
}
