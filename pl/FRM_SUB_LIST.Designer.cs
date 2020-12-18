namespace WindowsFormsApplication10.pl
{
    partial class FRM_SUB_LIST
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
            this.dgvcustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcustomers
            // 
            this.dgvcustomers.AllowUserToAddRows = false;
            this.dgvcustomers.AllowUserToDeleteRows = false;
            this.dgvcustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvcustomers.Name = "dgvcustomers";
            this.dgvcustomers.ReadOnly = true;
            this.dgvcustomers.Size = new System.Drawing.Size(574, 372);
            this.dgvcustomers.TabIndex = 1;
            this.dgvcustomers.DoubleClick += new System.EventHandler(this.dgvcustomers_DoubleClick);
            // 
            // FRM_SUB_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 372);
            this.Controls.Add(this.dgvcustomers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SUB_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الموردين";
            this.Load += new System.EventHandler(this.FRM_SUB_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvcustomers;
    }
}