namespace Client1
{
    partial class RegionDS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdCountry = new System.Windows.Forms.DataGridView();
            this.grdProvince = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProvince)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grdCountry, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grdProvince, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 590);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grdCountry
            // 
            this.grdCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCountry.Location = new System.Drawing.Point(295, 3);
            this.grdCountry.Name = "grdCountry";
            this.grdCountry.Size = new System.Drawing.Size(287, 584);
            this.grdCountry.TabIndex = 0;
            // 
            // grdProvince
            // 
            this.grdProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProvince.Location = new System.Drawing.Point(3, 3);
            this.grdProvince.Name = "grdProvince";
            this.grdProvince.Size = new System.Drawing.Size(286, 584);
            this.grdProvince.TabIndex = 0;
            // 
            // RegionDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegionDS";
            this.Size = new System.Drawing.Size(585, 590);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProvince)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdCountry;
        private System.Windows.Forms.DataGridView grdProvince;
    }
}
