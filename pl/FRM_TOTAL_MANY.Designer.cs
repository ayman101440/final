namespace WindowsFormsApplication10.pl
{
    partial class FRM_TOTAL_MANY
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
            this.dgvtotal = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtschrch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtotal
            // 
            this.dgvtotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtotal.Location = new System.Drawing.Point(28, 75);
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.Size = new System.Drawing.Size(662, 254);
            this.dgvtotal.TabIndex = 0;
            this.dgvtotal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtotal_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtschrch
            // 
            this.txtschrch.Location = new System.Drawing.Point(222, 49);
            this.txtschrch.Name = "txtschrch";
            this.txtschrch.Size = new System.Drawing.Size(142, 20);
            this.txtschrch.TabIndex = 4;
            this.txtschrch.TextChanged += new System.EventHandler(this.txtschrch_TextChanged);
            // 
            // FRM_TOTAL_MANY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 394);
            this.Controls.Add(this.txtschrch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvtotal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_TOTAL_MANY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "المبلغ المالية";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtschrch;
    }
}