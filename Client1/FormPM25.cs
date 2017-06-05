using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client1
{
    public partial class FormPM25 : Form
    {
        public List<Dictionary<string, string>> pm25;
        List<PMItem> PMItems = new List<PMItem>();
        private int CurShowIndex = 0;

        public FormPM25()
        {
            InitializeComponent();
        }

        private void FormPM25_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            foreach (Dictionary<string, string> dic in pm25)
            {
                PMItem item = new PMItem()
                {
                    source = dic,
                    Dock = DockStyle.Fill
                };
                PMItems.Add(item);
            }
            if (PMItems.Count > 0)
            {
                CurShowIndex = 0;
                ShowItem();
            }
            else
            {
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurShowIndex--;
            ShowItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurShowIndex++;
            ShowItem();
        }

        private void ShowItem()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(PMItems[CurShowIndex]);

            button1.Enabled = true;
            button2.Enabled = true;
            if (CurShowIndex <= 0)
            {
                button1.Enabled = false;
            }
            else if (CurShowIndex >= PMItems.Count)
            {
                button2.Enabled = false;
            }
        }
    }
}
