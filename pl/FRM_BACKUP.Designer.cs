namespace WindowsFormsApplication10.pl
{
    partial class FRM_BACKUP
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
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(423, 44);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(56, 23);
            this.btnbrowse.TabIndex = 0;
            this.btnbrowse.Text = ".....";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(64, 24);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(53, 50);
            this.btncreate.TabIndex = 1;
            this.btncreate.Text = "انشاء";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "الرجاء تحديد  مسار قاعدة البيانات ";
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(129, 47);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.Size = new System.Drawing.Size(282, 20);
            this.txtfilename.TabIndex = 4;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(5, 24);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(53, 50);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "خروج";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // FRM_BACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 97);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btnbrowse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BACKUP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انشاء نسخة احتياطية";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}