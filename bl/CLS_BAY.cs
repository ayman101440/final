using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication10.bl
{
    class CLS_BAY
    {


        public DataTable GET_LAST_BAY_ID()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_LAST_BAY_ID", null);
            dal.close();
            return Dt;


        }
        public void ADD_BAY(int id_bay, DateTime date, int id_sub,
                                string bayname, string total_price)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_bay", SqlDbType.Int);
            param[0].Value = id_bay;

            param[1] = new SqlParameter("@date", SqlDbType.DateTime);
            param[1].Value = date;

            param[2] = new SqlParameter("@id_sub", SqlDbType.Int);
            param[2].Value = id_sub;


            param[3] = new SqlParameter("@bayname", SqlDbType.VarChar, 75);
            param[3].Value = bayname;

            param[4] = new SqlParameter("@total_price", SqlDbType.VarChar, 50);
            param[4].Value = total_price;

            dal.ExecuteCommand("ADD_BAY", param);



            dal.close();
        }
        public void ADD_BAY_DETAILS(string id_product, int id_bay, int qte,
                            string price,  string total_amount)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@id_bay", SqlDbType.Int);
            param[1].Value = id_bay;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@total_amount", SqlDbType.VarChar, 50);
            param[4].Value = total_amount;

            dal.ExecuteCommand("ADD_BAY_DETAILS", param);



            dal.close();
        }
        public DataTable searchbay(string criterion)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;
            Dt = dal.SelectData("searchbay", param);
            dal.close();
            return Dt;

        }
        public DataTable GET_LAST_BAY_ROF_PRINT()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_LAST_BAY_ROF_PRINT", null);
            dal.close();
            return Dt;


        }
        public DataTable GETBAYDETAILS(int id_bay)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_bay", SqlDbType.Int);
            param[0].Value = id_bay;

            Dt = dal.SelectData("GETBAYDETAILS", param);
            dal.close();
            return Dt;


        }
    }
}
