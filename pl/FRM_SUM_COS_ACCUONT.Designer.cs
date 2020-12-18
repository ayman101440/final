namespace WindowsFormsApplication10.pl
{
    partial class FRM_SUM_COS_ACCUONT
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
            this.dgvmony = new System.Windows.Forms.DataGridView();
            this.dgvpayment = new System.Windows.Forms.DataGridView();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.resalt = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmony
            // 
            this.dgvmony.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmony.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmony.Location = new System.Drawing.Point(13, 75);
            this.dgvmony.Name = "dgvmony";
            this.dgvmony.ReadOnly = true;
            this.dgvmony.Size = new System.Drawing.Size(485, 67);
            this.dgvmony.TabIndex = 0;
            // 
            // dgvpayment
            // 
            this.dgvpayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayment.Location = new System.Drawing.Point(13, 148);
            this.dgvpayment.Name = "dgvpayment";
            this.dgvpayment.ReadOnly = true;
            this.dgvpayment.Size = new System.Drawing.Size(485, 68);
            this.dgvpayment.TabIndex = 1;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(344, 238);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(154, 20);
            this.txttotal.TabIndex = 2;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "اختيار";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(177, 12);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(156, 20);
            this.txtname.TabIndex = 4;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(239, 35);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(13, 13);
            this.id.TabIndex = 5;
            this.id.Text = "0";
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // resalt
            // 
            this.resalt.AutoSize = true;
            this.resalt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resalt.Location = new System.Drawing.Point(248, 235);
            this.resalt.Name = "resalt";
            this.resalt.Size = new System.Drawing.Size(0, 23);
            this.resalt.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "طباعه ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_SUM_COS_ACCUONT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resalt);
            this.Controls.Add(this.id);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dgvpayment);
            this.Controls.Add(this.dgvmony);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SUM_COS_ACCUONT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبالغ المتبيقة ";
            this.Load += new System.EventHandler(this.FRM_SUM_COS_ACCUONT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmony;
        private System.Windows.Forms.DataGridView dgvpayment;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label resalt;
        private System.Windows.Forms.Button button2;
    }
}