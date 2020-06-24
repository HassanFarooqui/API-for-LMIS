using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DBLayer
{
    public class Class1
    {
        private SqlConnection con;

        public DataSet FillData(string procedureName, Hashtable Parameters, string orderBy)
        {

            //SqlConnection conObj = new SqlConnection(new Connection().getstrConnection());
            string constr = ConfigurationManager.ConnectionStrings["Clc_App_CHKEntities"].ToString();
            con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            //int loopCounter=0;
            ICollection ParamKeys = Parameters.Keys;
            foreach (object key in ParamKeys)
            {
                cmd.Parameters.Add(new SqlParameter(key.ToString(), Parameters[key.ToString()]));
            }

            ad.SelectCommand = cmd;
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
    }
}
