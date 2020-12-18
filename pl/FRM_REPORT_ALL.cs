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
    public partial class FRM_REPORT_ALL : Form
    {
        bl.CLS_ALL_REPORTS print_orders = new bl.CLS_ALL_REPORTS();
        DataTable dt = new DataTable();
        public FRM_REPORT_ALL()
        {
            InitializeComponent();
         /*
          
                comboBox2.DataSource = print_orders.rpt_cost_for_comp();

                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id_costmer";

          


                comboBox1.DataSource = print_orders.rpt_sub_for_comp();

                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id_sub";
            */
            

            
           
        }

        private void FRM_REPORT_ALL_Load(object sender, EventArgs e)
        {
           // radioButton2.Checked = true;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {


/*
            this.dataGridView1.DataSource = print_orders.report_seles(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            int sumdayly = 0;

*/

            this.Cursor = Cursors.WaitCursor;
            rpt.rpt_seles_report rpt = new rpt.rpt_seles_report();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));
            //rpt.SetDataSource(print_orders.report_seles);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
             
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            rpt.rpt_viow_orders rpt = new rpt.rpt_viow_orders();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));
            //rpt.SetDataSource(print_orders.report_seles);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button14_Click(object sender, EventArgs e)
        {
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rpt.rpt_costmer rpt = new rpt.rpt_costmer();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            //rpt.SetDataSource(print_orders.report_seles);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            rpt.rpt_orders_for_one_cost rpt = new rpt.rpt_orders_for_one_cost();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@id", comboBox1.SelectedValue);
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));
           
           // rpt.SetDataSource(print_orders.);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            rpt.report_viwo_payment_for_cost rpt = new rpt.report_viwo_payment_for_cost();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@id", comboBox1.SelectedValue);
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));

            // rpt.SetDataSource(print_orders.);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rpt.viow_sub rpt = new rpt.viow_sub();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            //rpt.SetDataSource(print_orders.report_seles);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            rpt.report_viwo_bays_for_sub rpt = new rpt.report_viwo_bays_for_sub();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@id", comboBox1.SelectedValue);
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));

            // rpt.SetDataSource(print_orders.);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            rpt.report_bay rpt = new rpt.report_bay();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));
            //rpt.SetDataSource(print_orders.report_seles);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            rpt.report__bay rpt = new rpt.report__bay();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));
            //rpt.SetDataSource(print_orders.report_seles);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_MINES_PRODUCT frm = new FRM_MINES_PRODUCT();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            rpt.report_viwo_product_from_order_for_cutegory rpt = new rpt.report_viwo_product_from_order_for_cutegory();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@id", comboBox1.SelectedValue);
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));

            // rpt.SetDataSource(print_orders.);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.DataSource = print_orders.rpt_sub_for_comp();

                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id_sub";




            }

            

           




        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
              if (radioButton3.Checked == true)
            {
                comboBox1.DataSource = print_orders.GET_ALL_CATEGORIES_fOR_COMP();

                comboBox1.DisplayMember = "description_cat";
                comboBox1.ValueMember = "id_cat";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             if (radioButton2.Checked == true)
            {
                comboBox1.DataSource = print_orders.rpt_cost_for_comp();

                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id_costmer";
                

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                comboBox1.DataSource = print_orders.GET_ALL_PRODUCTS_FRO_COM_RPT();

                comboBox1.DisplayMember = "label_product";
                comboBox1.ValueMember = "id_product";


            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            rpt.report_viwo_product_from_order_for_product rpt = new rpt.report_viwo_product_from_order_for_product();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@id", comboBox1.SelectedValue);
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));

            // rpt.SetDataSource(print_orders.);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            rpt.report_QTE_in_stok rpt = new rpt.report_QTE_in_stok();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));

            // rpt.SetDataSource(print_orders.);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            rpt.report_msrofat rpt = new rpt.report_msrofat();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            rpt.SetParameterValue("@frist_day", (dateTimePicker1.Value.Date));
            rpt.SetParameterValue("@last_day", (dateTimePicker2.Value.Date));

            // rpt.SetDataSource(print_orders.);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
