namespace WindowsFormsApplication10.pl
{
    partial class FRM_CATEGORIES
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblposition = new System.Windows.Forms.Label();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprevitus = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exporttobdfcarrent = new System.Windows.Forms.Button();
            this.exporttobdfall = new System.Windows.Forms.Button();
            this.btnprintsingle = new System.Windows.Forms.Button();
            this.btnprintall = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dglist = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.lblposition);
            this.groupBox1.Controls.Add(this.btnlast);
            this.groupBox1.Controls.Add(this.btnnext);
            this.groupBox1.Controls.Add(this.btnprevitus);
            this.groupBox1.Controls.Add(this.btnfirst);
            this.groupBox1.Controls.Add(this.txtdes);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(16, 19);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 140);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "خروج";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Location = new System.Drawing.Point(333, 83);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(0, 13);
            this.lblposition.TabIndex = 8;
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(204, 136);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(75, 23);
            this.btnlast.TabIndex = 7;
            this.btnlast.Text = ">>||";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(285, 136);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 6;
            this.btnnext.Text = ">>>";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprevitus
            // 
            this.btnprevitus.Location = new System.Drawing.Point(415, 136);
            this.btnprevitus.Name = "btnprevitus";
            this.btnprevitus.Size = new System.Drawing.Size(75, 23);
            this.btnprevitus.TabIndex = 5;
            this.btnprevitus.Text = "<<<";
            this.btnprevitus.UseVisualStyleBackColor = true;
            this.btnprevitus.Click += new System.EventHandler(this.btnprevitus_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(496, 136);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(75, 23);
            this.btnfirst.TabIndex = 4;
            this.btnfirst.Text = "||<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(374, 70);
            this.txtdes.MaxLength = 10;
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdes.Size = new System.Drawing.Size(147, 50);
            this.txtdes.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(421, 29);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الصنف";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exporttobdfcarrent);
            this.groupBox2.Controls.Add(this.exporttobdfall);
            this.groupBox2.Controls.Add(this.btnprintsingle);
            this.groupBox2.Controls.Add(this.btnprintall);
            this.groupBox2.Controls.Add(this.btnedit);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.btnnew);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // exporttobdfcarrent
            // 
            this.exporttobdfcarrent.Location = new System.Drawing.Point(204, 19);
            this.exporttobdfcarrent.Name = "exporttobdfcarrent";
            this.exporttobdfcarrent.Size = new System.Drawing.Size(57, 37);
            this.exporttobdfcarrent.TabIndex = 7;
            this.exporttobdfcarrent.Text = "حفظ الصنف + النجات";
            this.exporttobdfcarrent.UseVisualStyleBackColor = true;
            this.exporttobdfcarrent.Click += new System.EventHandler(this.exporttobdfcarrent_Click);
            // 
            // exporttobdfall
            // 
            this.exporttobdfall.Location = new System.Drawing.Point(17, 19);
            this.exporttobdfall.Name = "exporttobdfall";
            this.exporttobdfall.Size = new System.Drawing.Size(57, 37);
            this.exporttobdfall.TabIndex = 6;
            this.exporttobdfall.Text = "حفظ الاصناف";
            this.exporttobdfall.UseVisualStyleBackColor = true;
            this.exporttobdfall.Click += new System.EventHandler(this.exporttobdfall_Click);
            // 
            // btnprintsingle
            // 
            this.btnprintsingle.Location = new System.Drawing.Point(80, 19);
            this.btnprintsingle.Name = "btnprintsingle";
            this.btnprintsingle.Size = new System.Drawing.Size(57, 37);
            this.btnprintsingle.TabIndex = 5;
            this.btnprintsingle.Text = "طباعة المحددة";
            this.btnprintsingle.UseVisualStyleBackColor = true;
            this.btnprintsingle.Click += new System.EventHandler(this.btnprintsingle_Click);
            // 
            // btnprintall
            // 
            this.btnprintall.Location = new System.Drawing.Point(143, 19);
            this.btnprintall.Name = "btnprintall";
            this.btnprintall.Size = new System.Drawing.Size(57, 37);
            this.btnprintall.TabIndex = 4;
            this.btnprintall.Text = "طباعة الاصناف";
            this.btnprintall.UseVisualStyleBackColor = true;
            this.btnprintall.Click += new System.EventHandler(this.btnprintall_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(421, 13);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(65, 23);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "تعديل";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(421, 36);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(65, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(506, 36);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(65, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(506, 13);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(65, 23);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "جديد";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dglist);
            this.groupBox3.Location = new System.Drawing.Point(12, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 128);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عرض الاصناف";
            // 
            // dglist
            // 
            this.dglist.AllowUserToAddRows = false;
            this.dglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglist.Location = new System.Drawing.Point(6, 11);
            this.dglist.Name = "dglist";
            this.dglist.Size = new System.Drawing.Size(574, 111);
            this.dglist.TabIndex = 0;
            // 
            // FRM_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CATEGORIES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الاصناف";
            this.Load += new System.EventHandler(this.FRM_CATEGORIES_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dglist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprevitus;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dglist;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button exporttobdfcarrent;
        private System.Windows.Forms.Button exporttobdfall;
        private System.Windows.Forms.Button btnprintsingle;
        private System.Windows.Forms.Button btnprintall;
    }
}