using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication10.bl
{
    class CLS_ORDERS
    {


        public DataTable GET_LAST_ORDER_ID()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_LAST_ORDER_ID", null);
            dal.close();
            return Dt;


        }
        public DataTable GET_LAST_ORDER_ROF_PRINT()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_LAST_ORDER_ROF_PRINT", null);
            dal.close();
            return Dt;


        }

        public void ADD_ORDER(int id_order, DateTime date_order, DateTime time_order, int id_costomer,
                                string description_order, string salesman, string total_priceo, string total_paid, string rest_price)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;

            param[1] = new SqlParameter("@date_order", SqlDbType.DateTime);
            param[1].Value = date_order;

            param[2] = new SqlParameter("@time_order", SqlDbType.DateTime);
            param[2].Value = time_order;

            param[3] = new SqlParameter("@id_costomer", SqlDbType.Int);
            param[3].Value = id_costomer;

            param[4] = new SqlParameter("@description_order", SqlDbType.VarChar, 250);
            param[4].Value = description_order;

           
            param[5] = new SqlParameter("@salesman", SqlDbType.VarChar, 75);
            param[5].Value = salesman;

            param[6] = new SqlParameter("@total_priceo", SqlDbType.VarChar, 50);
            param[6].Value = total_priceo;

            param[7] = new SqlParameter("@total_paid", SqlDbType.VarChar, 50);
            param[7].Value = total_paid;

            param[8] = new SqlParameter("@rest_price", SqlDbType.VarChar, 50);
            param[8].Value = rest_price;
            dal.ExecuteCommand("ADD_ORDER", param);



            dal.close();
        }

        public void ADD_ORDER_DETAILS(string id_product, int id_order, int qte,
                            string price, double discuont, string amount, string total_amount)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar,30);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@id_order", SqlDbType.Int);
            param[1].Value = id_order;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@discuont", SqlDbType.Float);
            param[4].Value = discuont;

            param[5] = new SqlParameter("@amount", SqlDbType.VarChar, 50);
            param[5].Value = amount;

            param[6] = new SqlParameter("@total_amount", SqlDbType.VarChar, 50);
            param[6].Value = total_amount;

            dal.ExecuteCommand("ADD_ORDER_DETAILS", param);



            dal.close();
        }

        public DataTable verfqty(string id_product, int qty_entered)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@qty_entered", SqlDbType.Int);
            param[1].Value = qty_entered;
            Dt = dal.SelectData("verfqty", param);
            dal.close();
            return Dt;


        }

        public DataTable GETORDERDETAILS(int id_order)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;

            Dt = dal.SelectData("GETORDERDETAILS", param);
            dal.close();
            return Dt;


        }

        public DataTable searchorders(string criterion)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;
            Dt = dal.SelectData("searchorders", param);
            dal.close();
            return Dt;

        }
    }
}
