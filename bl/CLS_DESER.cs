using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication10.bl
{
    class CLS_DESER
    {

        public void ADD_DESER_TYPE(int deser_id, string deser_name)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@deser_id", SqlDbType.Int);
            param[0].Value = deser_id;

            param[1] = new SqlParameter("@deser_name", SqlDbType.VarChar, 50);
            param[1].Value = deser_name;





            dal.ExecuteCommand("ADD_DESER_TYPE", param);



            dal.close();
        }
        public DataTable GET_LAST_DESER_ID()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_LAST_DESER_ID", null);
            dal.close();
            return Dt;


        }
        public void DELETE_DERSRE(string id)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            dal.ExecuteCommand("DELETE_DERSRE", param);



            dal.close();
        }

        public DataTable searchdeser(string criterion)
        {
             dal.DataAccessLayar dal = new dal.DataAccessLayar();

             dal.Open();
             DataTable Dt = new DataTable();
             SqlParameter[] param = new SqlParameter[1];
             param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
             param[0].Value = criterion;
             Dt = dal.SelectData("searchdeser", param);
             dal.close();
             return Dt;

         }
        public DataTable GET_ALL_DESER()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_ALL_DESER", null);
            dal.close();
            return Dt;


        }
        public void ADD_DESER(int des_id, string price, DateTime dete,
                                    string notes, int deser_id)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@des_id", SqlDbType.Int);
            param[0].Value = des_id;

            param[1] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[1].Value = price;

            param[2] = new SqlParameter("@dete", SqlDbType.Date);
            param[2].Value = dete;

            param[3] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[3].Value = notes;


            param[4] = new SqlParameter("@deser_id", SqlDbType.Int);
            param[4].Value = deser_id;


            dal.ExecuteCommand("ADD_DESER", param);



            dal.close();
        }
    }
}
