namespace Client1
{
    partial class FormSupportedCity
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(88, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(240, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "GetString";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 479);
            this.panel1.TabIndex = 2;
            // 
            // btnGetDS
            // 
            this.btnGetDS.Location = new System.Drawing.Point(332, 12);
            this.btnGetDS.Name = "btnGetDS";
            this.btnGetDS.Size = new System.Drawing.Size(75, 23);
            this.btnGetDS.TabIndex = 1;
            this.btnGetDS.Text = "GetDS";
            this.btnGetDS.UseVisualStyleBackColor = true;
            this.btnGetDS.Click += new System.EventHandler(this.btnGetDS_Click);
            // 
            // FormSupportedCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetDS);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtCode);
            this.Name = "FormSupportedCity";
            this.Text = "FormSupportedCity";
            this.Load += new System.EventHandler(this.FormSupportedCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetDS;
    }
}