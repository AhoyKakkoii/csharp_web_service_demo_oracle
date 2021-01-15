using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace Webservice_CRUD_demo
{
    public class DBInfo
    {

        public String GetApprDivSummary(String appr, String start_date, String end_date, String bfy)
        {
            String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            Console.WriteLine(connectionString);
            OracleConnection con = new OracleConnection(connectionString);
            con.Open();

            ApprDivSummary ds = new ApprDivSummary();
            OracleCommand cmd = new OracleCommand("FMSCR_REPORTS.GET_APPR_DIV_SUMMARY", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new OracleParameter("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output));
            cmd.Parameters.Add(new OracleParameter("v_appr", OracleDbType.Varchar2, appr, ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("v_start_date", OracleDbType.Varchar2, start_date, ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("v_end_date", OracleDbType.Varchar2, end_date, ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("v_bfy", OracleDbType.Int16, bfy, ParameterDirection.Input));
            

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.TableMappings.Add("Table", "ApprDivSummary");
            da.Fill(ds);
            da.Dispose();

            if (cmd.Connection.State != ConnectionState.Closed)
                cmd.Connection.Close();
            string str = ds.GetXml();
            return str;
        }
            
    }
}