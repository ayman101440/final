namespace WindowsFormsApplication10.pl
{
    partial class FRM_CONFIG
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbwindows = new System.Windows.Forms.RadioButton();
            this.rbsql = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btneixt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اعدادات السيرفر";
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(105, 70);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(127, 20);
            this.txtserver.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم السيرفر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "قاعدة البيانات ";
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(105, 92);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(127, 20);
            this.txtdatabase.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "طريقة الدخول للسيرفر";
            // 
            // rbwindows
            // 
            this.rbwindows.AutoSize = true;
            this.rbwindows.Location = new System.Drawing.Point(132, 138);
            this.rbwindows.Name = "rbwindows";
            this.rbwindows.Size = new System.Drawing.Size(91, 17);
            this.rbwindows.TabIndex = 7;
            this.rbwindows.Text = "windows auth";
            this.rbwindows.UseVisualStyleBackColor = true;
            this.rbwindows.CheckedChanged += new System.EventHandler(this.rbwindows_CheckedChanged);
            // 
            // rbsql
            // 
            this.rbsql.AutoSize = true;
            this.rbsql.Checked = true;
            this.rbsql.Location = new System.Drawing.Point(132, 161);
            this.rbsql.Name = "rbsql";
            this.rbsql.Size = new System.Drawing.Size(97, 17);
            this.rbsql.TabIndex = 8;
            this.rbsql.TabStop = true;
            this.rbsql.Text = "sql server auth";
            this.rbsql.UseVisualStyleBackColor = true;
            this.rbsql.CheckedChanged += new System.EventHandler(this.rbsql_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "كلمة المرور";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(132, 212);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.ReadOnly = true;
            this.txtpwd.Size = new System.Drawing.Size(100, 20);
            this.txtpwd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "اسم المستخدم ";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(132, 186);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(15, 250);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 23);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "حفظ ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btneixt
            // 
            this.btneixt.Location = new System.Drawing.Point(132, 250);
            this.btneixt.Name = "btneixt";
            this.btneixt.Size = new System.Drawing.Size(100, 23);
            this.btneixt.TabIndex = 14;
            this.btneixt.Text = "خروج ";
            this.btneixt.UseVisualStyleBackColor = true;
            this.btneixt.Click += new System.EventHandler(this.btneixt_Click);
            // 
            // FRM_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 292);
            this.Controls.Add(this.btneixt);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.rbsql);
            this.Controls.Add(this.rbwindows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CONFIG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الاتصال بالسيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbwindows;
        private System.Windows.Forms.RadioButton rbsql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btneixt;
    }
}