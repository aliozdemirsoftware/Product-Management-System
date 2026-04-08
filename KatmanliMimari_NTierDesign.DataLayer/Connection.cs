using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari_NTierDesign.DataLayer
{
    public class Connection
    {
        public static SqlConnection Connect
        {
            get
            {
                //SqlConnection sqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;User ID=sa;Password=as;Database=NORTHWND;TrustServerCertificate=True;");

                SqlConnection sqlConnection = new SqlConnection("Server = DESKTOP-N7OIBIA\\SQLEXPRESS;Trusted_Connection=True;Database=NORTHWND;TrustServerCertificate=True;");
                return sqlConnection;
            }
        }
    }
}
