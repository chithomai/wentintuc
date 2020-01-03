using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WebsiteTinTuc
{
    public class XLDL
    {
        public static string strCon = ConfigurationManager.ConnectionStrings["coon"].ConnectionString.ToString();

        public static DataTable GetData(string lenhSQL)
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(lenhSQL, sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        internal static void Execute(string s)
        {
            throw new NotImplementedException();
        }
    }
}