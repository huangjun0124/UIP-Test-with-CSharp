namespace Client1
{
    partial class Form1
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
            this.btnGetRegion = new System.Windows.Forms.Button();
            this.grdTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetRegion
            // 
            this.btnGetRegion.AutoSize = true;
            this.btnGetRegion.Location = new System.Drawing.Point(219, 30);
            this.btnGetRegion.Name = "btnGetRegion";
            this.btnGetRegion.Size = new System.Drawing.Size(107, 23);
            this.btnGetRegion.TabIndex = 1;
            this.btnGetRegion.Text = "GetRegionDataSet";
            this.btnGetRegion.UseVisualStyleBackColor = true;
            this.btnGetRegion.Click += new System.EventHandler(this.btnGetRegion_Click);
            // 
            // grdTable
            // 
            this.grdTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTable.Location = new System.Drawing.Point(12, 59);
            this.grdTable.Name = "grdTable";
            this.grdTable.Size = new System.Drawing.Size(729, 377);
            this.grdTable.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 492);
            this.Controls.Add(this.grdTable);
            this.Controls.Add(this.btnGetRegion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetRegion;
        private System.Windows.Forms.DataGridView grdTable;

    }
}