using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TstSI" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TstSI.svc or TstSI.svc.cs at the Solution Explorer and start debugging.
    public class TstSI : ITstSI
    {
        SqlConnection con = new SqlConnection(@"Data Source=VISHAL;Initial Catalog=vishal;Integrated Security=True");
        public int CalculateSI(int p, int r, int t)
        {
            int SI;
            SI = (p * r * t) / 100;
            return SI;
        }
        public DataTable GetRecordList()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select * from student9", con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

    }
    }

