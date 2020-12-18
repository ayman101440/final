using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication10.bl
{
    class CLS_ALL_REPORTS
    {
        public DataTable report_seles(DateTime frist_day, DateTime last_day)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@frist_day", SqlDbType.DateTime);
            param[0].Value = @frist_day;
            param[1] = new SqlParameter("@last_day", SqlDbType.DateTime);
            param[1].Value = @last_day;
            Dt = dal.SelectData("report_seles", param);
            dal.close();
            return Dt;

        }

        public DataTable report_viwo_orders(DateTime frist_day, DateTime last_day)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@frist_day", SqlDbType.DateTime);
            param[0].Value = @frist_day;
            param[1] = new SqlParameter("@last_day", SqlDbType.DateTime);
            param[1].Value = @last_day;
            Dt = dal.SelectData("report_viwo_orders", param);
            dal.close();
            return Dt;

        }
        public DataTable rpt_cost_for_comp()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("rpt_cost_for_comp", null);
            dal.close();
            return Dt;


        }
        public DataTable rpt_sub_for_comp()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("rpt_sub_for_comp", null);
            dal.close();
            return Dt;


        }
        public DataTable GET_ALL_CATEGORIES_fOR_COMP()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_ALL_CATEGORIES", null);
            dal.close();
            return Dt;


        }


        public DataTable GET_ALL_PRODUCTS_FRO_COM_RPT()
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectData("GET_ALL_PRODUCTS_FRO_COM_RPT", null);
            dal.close();
            return Dt;


        }

    }
}
