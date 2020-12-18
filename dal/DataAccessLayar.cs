using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace WindowsFormsApplication10.dal
{
    class DataAccessLayar
    {
        SqlConnection sqlconnection;
        public DataAccessLayar()
        {

            string mode = Properties.Settings.Default.mode;
            if (mode == "SQL")
            {
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.server + "; Database=" + 
                    Properties.Settings.Default.database + "; Integrated Security =false; User ID=" + 
                    Properties.Settings.Default.id + "; Password"+Properties.Settings.Default.password+" ");
            
            }
            else
            {

                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.server + "; Database=" + Properties.Settings.Default.database + "; Integrated Security =true ");
            }
        }

        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();

            }
        
        }
        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();

            }

        }

        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }

            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        public void ExecuteCommand (string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
               
                    sqlcmd.Parameters.AddRange(param);
                

            }
            sqlcmd.ExecuteNonQuery();

        }
    }
}
