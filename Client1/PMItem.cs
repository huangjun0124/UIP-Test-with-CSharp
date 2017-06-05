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
    public partial class PMItem : UserControl
    {
        public Dictionary<string, string> source;

        public PMItem()
        {
            InitializeComponent();
        }

        private Dictionary<string, Label> dicFuck;
        private void PMItem_Load(object sender, EventArgs e)
        {
            dicFuck = new Dictionary<string, Label>();
            dicFuck.Add("aqi",label2);
            dicFuck.Add("area", label4);
            dicFuck.Add("pm2_5", label6);
            dicFuck.Add("pm2_5_24h", label8);
            dicFuck.Add("position_name", label10);
            dicFuck.Add("primary_pollutant", label12);
            dicFuck.Add("quality", label14);
            dicFuck.Add("station_code", label16);
            dicFuck.Add("time_point", label18);

            foreach (string key in source.Keys)
            {
                dicFuck[key].Text = source[key];
            }
        }
    }
}
