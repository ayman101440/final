using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication10.bl
{
    class CLS_MANY
    {

        public DataTable LASTPROC(string criterion)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;
            Dt = dal.SelectData("LASTPROC", param);
            dal.close();
            return Dt;

        }
        public DataTable LASTPROC2(string criterion)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;
            Dt = dal.SelectData("LASTPROC2", param);
            dal.close();
            return Dt;

        }
        public DataTable dateoredr(DateTime frist_day, DateTime last_day)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@frist_day", SqlDbType.DateTime);
            param[0].Value = @frist_day;
            param[1] = new SqlParameter("@last_day", SqlDbType.DateTime);
            param[1].Value = @last_day;
            Dt = dal.SelectData("dateoredr", param);
            dal.close();
            return Dt;

        }
        public DataTable dateoredr2(DateTime frist_day, DateTime last_day)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@frist_day", SqlDbType.DateTime);
            param[0].Value = @frist_day;
            param[1] = new SqlParameter("@last_day", SqlDbType.DateTime);
            param[1].Value = @last_day;
            Dt = dal.SelectData("dateoredr2", param);
            dal.close();
            return Dt;

        }
        public DataTable mosro(DateTime frist_day, DateTime last_day)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@frist_day", SqlDbType.DateTime);
            param[0].Value = @frist_day;
            param[1] = new SqlParameter("@last_day", SqlDbType.DateTime);
            param[1].Value = @last_day;
            Dt = dal.SelectData("mosro", param);
            dal.close();
            return Dt;

        }
        public DataTable paym2(DateTime frist_day, DateTime last_day)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@frist_day", SqlDbType.DateTime);
            param[0].Value = @frist_day;
            param[1] = new SqlParameter("@last_day", SqlDbType.DateTime);
            param[1].Value = @last_day;
            Dt = dal.SelectData("paym2", param);
            dal.close();
            return Dt;

        }
        public void ADD_PAYMENT(int id_costmer, string mony, DateTime date_pay,string notes)
        {

            dal.DataAccessLayar dal = new dal.DataAccessLayar();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id_costmer", SqlDbType.Int);
            param[0].Value = id_costmer;

            param[1] = new SqlParameter("@mony", SqlDbType.VarChar, 50);
            param[1].Value = mony;

            param[2] = new SqlParameter("@date_pay", SqlDbType.Date);
            param[2].Value = date_pay;

            param[3] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[3].Value = notes;


            dal.ExecuteCommand("ADD_PAYMENT", param);



            dal.close();
        }
        public DataTable all_payments(string criterion)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;
            Dt = dal.SelectData("all_payments", param);
            dal.close();
            return Dt;

        }

    }
}
