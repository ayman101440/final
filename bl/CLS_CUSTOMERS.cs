using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace WindowsFormsApplication10.bl
{
    class CLS_CUSTOMERS
    {
        public void ADD_CUSTOMER(string first_name, string last_name, string tel,
                                    string email, byte[] picture, string criterion)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar,25);
            param[0].Value = first_name;

            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;

            param[2] = new SqlParameter("@tel", SqlDbType.VarChar, 15);
            param[2].Value = tel;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar,25);
            param[3].Value = email;

            param[4] = new SqlParameter("@picture", SqlDbType.Image);
            param[4].Value = picture;


            param[5] = new SqlParameter("@criterion", SqlDbType.VarChar,50);
            param[5].Value = criterion;

            dal.ExecuteCommand("ADD_CUSTOMER", param);



            dal.close();
        }

        public void EDIT_CUSTOMER(string first_name, string last_name, string tel,
                                 string email, byte[] picture, string criterion,int id)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar, 25);
            param[0].Value = first_name;

            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;

            param[2] = new SqlParameter("@tel", SqlDbType.VarChar, 15);
            param[2].Value = tel;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[3].Value = email;

            param[4] = new SqlParameter("@picture", SqlDbType.Image);
            param[4].Value = picture;


            param[5] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[5].Value = criterion;

            param[6] = new SqlParameter("@id", SqlDbType.Int);
            param[6].Value = id;


            dal.ExecuteCommand("EDIT_CUSTOMER", param);



            dal.close();
        }

        public void DELETE_CUSTOMER( int id)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;



            dal.ExecuteCommand("DELETE_CUSTOMER", param);



            dal.close();
        }

        public DataTable GET_ALL_CUSTOMERS()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_ALL_CUSTOMERS", null);
            dal.close();
            return Dt;


        }

        public DataTable search_CUSTOMER(string criterion)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param=new SqlParameter[1];
            param[0]=new SqlParameter("@criterion",SqlDbType.VarChar,50);
            param[0].Value = criterion;
            Dt = dal.SelectData("search_CUSTOMER",param);
            dal.close();
            return Dt;


        }
    }
}
