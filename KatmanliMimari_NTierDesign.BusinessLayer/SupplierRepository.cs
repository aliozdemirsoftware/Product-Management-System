using KatmanliMimari_NTierDesign.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari_NTierDesign.BusinessLayer
{
    public class SupplierRepository
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }

        public bool Save()
        {
            try
            {
                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("insert into Suppliers (CompanyName) values (@CompanyName)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@CompanyName", CompanyName);

                sqlConnection.Open();  
                sqlCommand.ExecuteNonQuery(); 
                sqlConnection.Close();  

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public SqlDataReader Select()
        {
            SqlConnection sqlConnection = Connection.Connect;

            SqlCommand sqlCommand = new SqlCommand("select * from Suppliers order by CompanyName", sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public bool Update()
        {
            try
            {
                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("update Suppliers set CompanyName = @CompanyName where SupplierID = @SupplierID", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@SupplierID", SupplierID);
                sqlCommand.Parameters.AddWithValue("@CompanyName", CompanyName);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("delete from Suppliers where SupplierID = @SupplierID", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@SupplierID", SupplierID);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int FindID(string CompanyName)
        {
            var sqlConnection = Connection.Connect;
            var sqlCommand = new SqlCommand($"SELECT SupplierID FROM Suppliers WHERE CompanyName = @CompanyName", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@CompanyName", CompanyName);
            sqlConnection.Open();

            var sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            var supplierID = Convert.ToInt32(sqlDataReader[0]);
            sqlConnection.Close();
            return supplierID;
        }
    }
}
