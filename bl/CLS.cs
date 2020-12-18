using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication10.bl
{
    class CLS
    {
        public DataTable login(string id, string pwo)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value= id;

            param[1] = new SqlParameter("@pwo", SqlDbType.VarChar, 50);
            param[1].Value = pwo;

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("SP_LOGIN", param);
            dal.close();
            return Dt;

        
        }
        public void ADD_USER(string id, string fullname, string pwo,
                                 string usertype)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[1].Value = fullname;

            param[2] = new SqlParameter("@pwo", SqlDbType.VarChar, 50);
            param[2].Value = pwo;

            param[3] = new SqlParameter("@usertype", SqlDbType.VarChar, 50);
            param[3].Value = usertype;

           
            dal.ExecuteCommand("ADD_USER", param);



            dal.close();
        }

        public void EDIT_USER(string id, string fullname, string pwo,
                                string usertype)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[1].Value = fullname;

            param[2] = new SqlParameter("@pwo", SqlDbType.VarChar, 50);
            param[2].Value = pwo;

            param[3] = new SqlParameter("@usertype", SqlDbType.VarChar, 50);
            param[3].Value = usertype;


            dal.ExecuteCommand("EDIT_USER", param);



            dal.close();
        }


        public void DELETE_USER(string id)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;


            dal.ExecuteCommand("DELETE_USER", param);



            dal.close();
        }


        public DataTable searchusres(string criterion)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;
            Dt = dal.SelectData("searchusres", param);
            dal.close();
            return Dt;

        }

    }
}
