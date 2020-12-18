using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication10.bl
{
    class CLS_ALL_RPT_
    {
        public DataTable verfqtymains( int qty_entered)
        {
            dal.DataAccessLayar dal = new dal.DataAccessLayar();

            dal.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@qty_entered", SqlDbType.Int);
            param[0].Value = qty_entered;


            Dt = dal.SelectData("verfqtymains", param);
            dal.close();
            return Dt;


        }
    }
}
