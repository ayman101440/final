namespace WindowsFormsApplication10.pl
{
    partial class FRM_BAY_LIST
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
            this.btnnew = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtamoumt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtnameproduct = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtidproduct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsuntotals = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsalesman = new System.Windows.Forms.TextBox();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.txtdesorder = new System.Windows.Forms.TextBox();
            this.dtorder = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(633, 543);
            this.btnnew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(114, 50);
            this.btnnew.TabIndex = 23;
            this.btnnew.Text = "فاتورة جديده";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(483, 543);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 50);
            this.btnadd.TabIndex = 22;
            this.btnadd.Text = "حفظ الفاتورة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(325, 543);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(114, 50);
            this.btnprint.TabIndex = 21;
            this.btnprint.Text = "طباعه الفاتورة";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(157, 543);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 50);
            this.button6.TabIndex = 20;
            this.button6.Text = "خروج ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txttotalamount);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtdiscount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtamoumt);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtqty);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtprice);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtnameproduct);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtidproduct);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtsuntotals);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dgvproducts);
            this.groupBox3.Controls.Add(this.btnbrowse);
            this.groupBox3.Location = new System.Drawing.Point(8, 234);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(870, 304);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تفاصيل الفاتورة";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(768, 23);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.label18.Size = new System.Drawing.Size(95, 21);
            this.label18.TabIndex = 27;
            this.label18.Text = "اختيار";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttotalamount
            // 
            this.txttotalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalamount.Location = new System.Drawing.Point(7, 47);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.ReadOnly = true;
            this.txttotalamount.Size = new System.Drawing.Size(120, 20);
            this.txttotalamount.TabIndex = 26;
            this.txttotalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(7, 23);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.label17.Size = new System.Drawing.Size(120, 21);
            this.label17.TabIndex = 25;
            this.label17.Text = "الاجمالي";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdiscount
            // 
            this.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiscount.Location = new System.Drawing.Point(126, 47);
            this.txtdiscount.MaxLength = 3;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(99, 20);
            this.txtdiscount.TabIndex = 22;
            this.txtdiscount.Text = "0";
            this.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyDown);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            this.txtdiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyUp);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(126, 23);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.label16.Size = new System.Drawing.Size(99, 21);
            this.label16.TabIndex = 23;
            this.label16.Text = "الخصم -%";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtamoumt
            // 
            this.txtamoumt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtamoumt.Location = new System.Drawing.Point(218, 47);
            this.txtamoumt.Name = "txtamoumt";
            this.txtamoumt.ReadOnly = true;
            this.txtamoumt.Size = new System.Drawing.Size(99, 20);
            this.txtamoumt.TabIndex = 24;
            this.txtamoumt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(218, 23);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.label15.Size = new System.Drawing.Size(99, 21);
            this.label15.TabIndex = 21;
            this.label15.Text = "المبلغ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Location = new System.Drawing.Point(308, 47);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(99, 20);
            this.txtqty.TabIndex = 20;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            this.txtqty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyUp);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(308, 23);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.label14.Size = new System.Drawing.Size(99, 21);
            this.label14.TabIndex = 19;
            this.label14.Text = "الكمية";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Location = new System.Drawing.Point(402, 47);
            this.txtprice.MaxLength = 8;
            this.txtprice.Name = "txtprice";
            this.txtprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtprice.Size = new System.Drawing.Size(99, 20);
            this.txtprice.TabIndex = 18;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            this.txtprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyDown);
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            this.txtprice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyUp);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(402, 23);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.label13.Size = new System.Drawing.Size(99, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "السعر";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnameproduct
            // 
            this.txtnameproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnameproduct.Location = new System.Drawing.Point(496, 47);
            this.txtnameproduct.Name = "txtnameproduct";
            this.txtnameproduct.ReadOnly = true;
            this.txtnameproduct.Size = new System.Drawing.Size(177, 20);
            this.txtnameproduct.TabIndex = 16;
            this.txtnameproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(496, 23);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.label12.Size = new System.Drawing.Size(177, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "اسم المنتج";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtidproduct
            // 
            this.txtidproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidproduct.Location = new System.Drawing.Point(663, 47);
            this.txtidproduct.Name = "txtidproduct";
            this.txtidproduct.ReadOnly = true;
            this.txtidproduct.Size = new System.Drawing.Size(99, 20);
            this.txtidproduct.TabIndex = 14;
            this.txtidproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(663, 23);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.label11.Size = new System.Drawing.Size(99, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "رقم المنتج ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsuntotals
            // 
            this.txtsuntotals.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtsuntotals.ForeColor = System.Drawing.Color.White;
            this.txtsuntotals.Location = new System.Drawing.Point(7, 271);
            this.txtsuntotals.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsuntotals.Name = "txtsuntotals";
            this.txtsuntotals.ReadOnly = true;
            this.txtsuntotals.Size = new System.Drawing.Size(165, 20);
            this.txtsuntotals.TabIndex = 12;
            this.txtsuntotals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "الاجمالي";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(638, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "حذف المنتج المحدد ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvproducts
            // 
            this.dgvproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.ColumnHeadersVisible = false;
            this.dgvproducts.Location = new System.Drawing.Point(7, 76);
            this.dgvproducts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvproducts.MultiSelect = false;
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.ReadOnly = true;
            this.dgvproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducts.Size = new System.Drawing.Size(856, 181);
            this.dgvproducts.TabIndex = 2;
            this.dgvproducts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvproducts_RowsRemoved);
            this.dgvproducts.DoubleClick += new System.EventHandler(this.dgvproducts_DoubleClick);
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnbrowse.Location = new System.Drawing.Point(768, 47);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(95, 23);
            this.btnbrowse.TabIndex = 28;
            this.btnbrowse.Text = ".....";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtlastname);
            this.groupBox2.Controls.Add(this.txtfirstname);
            this.groupBox2.Controls.Add(this.txttel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtcustomerid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(8, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(485, 198);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbox.Location = new System.Drawing.Point(7, 29);
            this.pbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(139, 161);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 14;
            this.pbox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = ".......";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtlastname
            // 
            this.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlastname.Location = new System.Drawing.Point(149, 91);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.ReadOnly = true;
            this.txtlastname.Size = new System.Drawing.Size(233, 20);
            this.txtlastname.TabIndex = 12;
            // 
            // txtfirstname
            // 
            this.txtfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfirstname.Location = new System.Drawing.Point(149, 59);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.ReadOnly = true;
            this.txtfirstname.Size = new System.Drawing.Size(233, 20);
            this.txtfirstname.TabIndex = 11;
            // 
            // txttel
            // 
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttel.Location = new System.Drawing.Point(149, 125);
            this.txttel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttel.Name = "txttel";
            this.txttel.ReadOnly = true;
            this.txttel.Size = new System.Drawing.Size(233, 20);
            this.txttel.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "الايميل ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "الهاتف ";
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Location = new System.Drawing.Point(149, 165);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(233, 20);
            this.txtemail.TabIndex = 7;
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcustomerid.Location = new System.Drawing.Point(210, 29);
            this.txtcustomerid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.ReadOnly = true;
            this.txtcustomerid.Size = new System.Drawing.Size(172, 20);
            this.txtcustomerid.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "الاسم الاخير ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "الاسم الاول";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "معرف العميل";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsalesman);
            this.groupBox1.Controls.Add(this.txtorderid);
            this.groupBox1.Controls.Add(this.txtdesorder);
            this.groupBox1.Controls.Add(this.dtorder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(500, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(373, 198);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانا ت الفاتورة";
            // 
            // txtsalesman
            // 
            this.txtsalesman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsalesman.Location = new System.Drawing.Point(30, 165);
            this.txtsalesman.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsalesman.Name = "txtsalesman";
            this.txtsalesman.ReadOnly = true;
            this.txtsalesman.Size = new System.Drawing.Size(233, 20);
            this.txtsalesman.TabIndex = 7;
            // 
            // txtorderid
            // 
            this.txtorderid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtorderid.Location = new System.Drawing.Point(30, 29);
            this.txtorderid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.ReadOnly = true;
            this.txtorderid.Size = new System.Drawing.Size(233, 20);
            this.txtorderid.TabIndex = 6;
            // 
            // txtdesorder
            // 
            this.txtdesorder.Location = new System.Drawing.Point(30, 60);
            this.txtdesorder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtdesorder.Multiline = true;
            this.txtdesorder.Name = "txtdesorder";
            this.txtdesorder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdesorder.Size = new System.Drawing.Size(233, 60);
            this.txtdesorder.TabIndex = 0;
            // 
            // dtorder
            // 
            this.dtorder.Location = new System.Drawing.Point(30, 125);
            this.dtorder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtorder.Name = "dtorder";
            this.dtorder.Size = new System.Drawing.Size(233, 20);
            this.dtorder.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "اسم البائم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ البيع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "وصف الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة";
            // 
            // FRM_BAY_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 619);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BAY_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة شراء";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtamoumt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtnameproduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtidproduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsuntotals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvproducts;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsalesman;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.TextBox txtdesorder;
        private System.Windows.Forms.DateTimePicker dtorder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}