namespace Client1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetRegionDS = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetRegionCountry = new System.Windows.Forms.Button();
            this.btnGetRegionProvince = new System.Windows.Forms.Button();
            this.btnGetSupportedCityDS = new System.Windows.Forms.Button();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetRegionDS
            // 
            this.btnGetRegionDS.AutoSize = true;
            this.btnGetRegionDS.Location = new System.Drawing.Point(3, 3);
            this.btnGetRegionDS.Name = "btnGetRegionDS";
            this.btnGetRegionDS.Size = new System.Drawing.Size(83, 23);
            this.btnGetRegionDS.TabIndex = 0;
            this.btnGetRegionDS.Text = "GetRegionDS";
            this.btnGetRegionDS.UseVisualStyleBackColor = true;
            this.btnGetRegionDS.Click += new System.EventHandler(this.btnGetRegionDS_Click);
            // 
            // panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel, 6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 32);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(695, 431);
            this.panel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGetRegionDS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGetRegionCountry, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGetRegionProvince, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGetSupportedCityDS, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGetWeather, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 466);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnGetRegionCountry
            // 
            this.btnGetRegionCountry.AutoSize = true;
            this.btnGetRegionCountry.Location = new System.Drawing.Point(92, 3);
            this.btnGetRegionCountry.Name = "btnGetRegionCountry";
            this.btnGetRegionCountry.Size = new System.Drawing.Size(104, 23);
            this.btnGetRegionCountry.TabIndex = 0;
            this.btnGetRegionCountry.Text = "GetRegionCountry";
            this.btnGetRegionCountry.UseVisualStyleBackColor = true;
            this.btnGetRegionCountry.Click += new System.EventHandler(this.btnGetRegionCountry_Click);
            // 
            // btnGetRegionProvince
            // 
            this.btnGetRegionProvince.AutoSize = true;
            this.btnGetRegionProvince.Location = new System.Drawing.Point(202, 3);
            this.btnGetRegionProvince.Name = "btnGetRegionProvince";
            this.btnGetRegionProvince.Size = new System.Drawing.Size(110, 23);
            this.btnGetRegionProvince.TabIndex = 0;
            this.btnGetRegionProvince.Text = "GetRegionProvince";
            this.btnGetRegionProvince.UseVisualStyleBackColor = true;
            this.btnGetRegionProvince.Click += new System.EventHandler(this.btnGetRegionProvince_Click);
            // 
            // btnGetSupportedCityDS
            // 
            this.btnGetSupportedCityDS.AutoSize = true;
            this.btnGetSupportedCityDS.Location = new System.Drawing.Point(318, 3);
            this.btnGetSupportedCityDS.Name = "btnGetSupportedCityDS";
            this.btnGetSupportedCityDS.Size = new System.Drawing.Size(115, 23);
            this.btnGetSupportedCityDS.TabIndex = 0;
            this.btnGetSupportedCityDS.Text = "GetSupportedCityDS";
            this.btnGetSupportedCityDS.UseVisualStyleBackColor = true;
            this.btnGetSupportedCityDS.Click += new System.EventHandler(this.btnGetSupportedCityDS_Click);
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.AutoSize = true;
            this.btnGetWeather.Location = new System.Drawing.Point(439, 3);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(115, 23);
            this.btnGetWeather.TabIndex = 0;
            this.btnGetWeather.Text = "GetWeather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetRegionDS;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGetRegionCountry;
        private System.Windows.Forms.Button btnGetRegionProvince;
        private System.Windows.Forms.Button btnGetSupportedCityDS;
        private System.Windows.Forms.Button btnGetWeather;

    }
}