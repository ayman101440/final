using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication10.bl
{
    class CLS_SUB
    {

        public void ADD_sub(string first_name, string last_name, string tel,
                                   string email)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar, 25);
            param[0].Value = first_name;

            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;

            param[2] = new SqlParameter("@tel", SqlDbType.VarChar, 15);
            param[2].Value = tel;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[3].Value = email;



            dal.ExecuteCommand("ADD_sub", param);



            dal.close();
        }
        public DataTable GET_ALL_sub()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_ALL_sub", null);
            dal.close();
            return Dt;


        }
        public void DELETE_SUB(int id)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;



            dal.ExecuteCommand("DELETE_SUB", param);



            dal.close();
        }
        public void EDIT_SUB(string first_name, string last_name, string tel,
                                string email, int id)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar, 25);
            param[0].Value = first_name;

            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;

            param[2] = new SqlParameter("@tel", SqlDbType.VarChar, 15);
            param[2].Value = tel;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[3].Value = email;

           
            param[4] = new SqlParameter("@id", SqlDbType.Int);
            param[4].Value = id;


            dal.ExecuteCommand("EDIT_SUB", param);



            dal.close();
        }
        public DataTable search_sub(string criterion)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;
            Dt = dal.SelectData("search_sub", param);
            dal.close();
            return Dt;


        }
    }
}
