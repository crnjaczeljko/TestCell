namespace TestCell
{
    partial class frmMain
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
            this.gbConn = new System.Windows.Forms.GroupBox();
            this.lbComName = new System.Windows.Forms.Label();
            this.cbComList = new System.Windows.Forms.ComboBox();
            this.gbConn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConn
            // 
            this.gbConn.Controls.Add(this.cbComList);
            this.gbConn.Controls.Add(this.lbComName);
            this.gbConn.Location = new System.Drawing.Point(12, 12);
            this.gbConn.Name = "gbConn";
            this.gbConn.Size = new System.Drawing.Size(200, 426);
            this.gbConn.TabIndex = 0;
            this.gbConn.TabStop = false;
            this.gbConn.Text = "Com Port Connection";
            // 
            // lbComName
            // 
            this.lbComName.AutoSize = true;
            this.lbComName.Location = new System.Drawing.Point(16, 32);
            this.lbComName.Name = "lbComName";
            this.lbComName.Size = new System.Drawing.Size(81, 13);
            this.lbComName.TabIndex = 1;
            this.lbComName.Text = "Com Port Name";
            // 
            // cbComList
            // 
            this.cbComList.FormattingEnabled = true;
            this.cbComList.Location = new System.Drawing.Point(19, 48);
            this.cbComList.Name = "cbComList";
            this.cbComList.Size = new System.Drawing.Size(121, 21);
            this.cbComList.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.gbConn);
            this.Name = "frmMain";
            this.Text = "Test Cell";
            this.gbConn.ResumeLayout(false);
            this.gbConn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConn;
        private System.Windows.Forms.ComboBox cbComList;
        private System.Windows.Forms.Label lbComName;
    }
}

