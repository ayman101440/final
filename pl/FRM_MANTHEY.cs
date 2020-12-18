using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10.pl
{
    public partial class FRM_MANTHEY : Form
    {
        bl.CLS_MANY pay = new bl.CLS_MANY();
        public FRM_MANTHEY()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
            // dateTimePicker1.Value = DateTime.MinValue;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/yyyy";

        }

        private void FRM_MANTHEY_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = pay.dateoredr(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            int sumdayly = 0;


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sumdayly += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

            }
            txtsum.Text = sumdayly.ToString();

           
            ////

            this.dataGridView2.DataSource = pay.paym2(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            int pa = 0;


            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {

                pa += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);

            }
            paymte.Text = pa.ToString();

            ////

            this.dataGridView3.DataSource = pay.dateoredr2(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            int pa2 = 0;


            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                pa2 += Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value);

            }
            paymte2.Text = pa2.ToString();


            ////

            this.dataGridView4.DataSource = pay.mosro(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            int mos = 0;


            for (int i = 0; i < dataGridView4.Rows.Count; ++i)
            {
                mos += Convert.ToInt32(dataGridView4.Rows[i].Cells[1].Value);

            }
            mostxt.Text = mos.ToString();


            int one = Convert.ToInt32(paymte.Text);
            int tow = Convert.ToInt32(paymte2.Text);
            int sumpa = one + tow;
            textBox1.Text = Convert.ToString(sumpa);


            textBox2.Text = mos.ToString();


            int one1 = Convert.ToInt32(textBox1.Text);
            int tow2 = Convert.ToInt32(textBox2.Text);
            int sum2 = one - tow;
            textBox3.Text = Convert.ToString(sum2);

        
                 
           
                 
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
