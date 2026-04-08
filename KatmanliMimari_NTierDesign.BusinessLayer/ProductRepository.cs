using KatmanliMimari_NTierDesign.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KatmanliMimari_NTierDesign.BusinessLayer
{
    public class ProductRepository
    {
        public int ProductID { get; set; }
        private string _ProductName { get; set; }

        public string ProductName {
            get { return _ProductName; }
            set { _ProductName = value.ToUpper(); }
                }

        private int _UnitsInStock { get; set; }
        public int UnitsInStock {
            get { return _UnitsInStock; }
            set {
                if (value > 0)
                {
                    _UnitsInStock = value;
                }
                else
                {
                    _UnitsInStock = Math.Abs(value); 
                }
            }
        }

        public decimal UnitPrice { get; set; }
        public decimal CategoryID { get; set; }
        public decimal SupplierID { get; set; }

        public bool Save()
        {
            try
            {
                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("insert into Products (ProductName,UnitsInStock,UnitPrice,CategoryID,SupplierID) values (@ProductName,@UnitsInStock,@UnitPrice,@CategoryID,@SupplierID)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ProductName", _ProductName);
                sqlCommand.Parameters.AddWithValue("@UnitsInStock", _UnitsInStock);
                sqlCommand.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                sqlCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
                sqlCommand.Parameters.AddWithValue("@SupplierID", SupplierID);

                sqlConnection.Open();  
                int affectedRows = sqlCommand.ExecuteNonQuery(); 
                sqlConnection.Close(); 

                return affectedRows > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public SqlDataReader Select()
        {
            SqlConnection sqlConnection = Connection.Connect;

            SqlCommand sqlCommand = new SqlCommand("select * from VW_ProductList ", sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public SqlDataReader Select(string Text)
        {
            SqlConnection sqlConnection = Connection.Connect;

            SqlCommand sqlCommand = new SqlCommand("select * from VW_ProductList where ProductName like '%" + Text + "%'", sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public SqlDataReader Sort(string Text)
        {
            SqlConnection sqlConnection = Connection.Connect;

            SqlCommand sqlCommand = new SqlCommand($"select * from VW_ProductList order by {Text}", sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public bool Update()
        {
            try
            {
                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("update Products set ProductName = @ProductName ,UnitsInStock = @UnitsInStock ,UnitPrice = @UnitPrice ,CategoryID = @CategoryID , SupplierID = @SupplierID where ProductID = @ProductID", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@ProductName", _ProductName);
                sqlCommand.Parameters.AddWithValue("@UnitsInStock", _UnitsInStock);
                sqlCommand.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                sqlCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
                sqlCommand.Parameters.AddWithValue("@SupplierID", SupplierID);
                sqlCommand.Parameters.AddWithValue("@ProductID", ProductID);

                sqlConnection.Open();
                int affectedRows = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return affectedRows > 0;
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

                SqlCommand sqlCommand = new SqlCommand("delete from Products where ProductID = @ProductID", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@ProductID", ProductID);

                sqlConnection.Open();
                int affectedRows = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return affectedRows > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static SqlDataReader ProductDetails(int ProductID)
        {
            SqlConnection sqlConnection = Connection.Connect;

            SqlCommand sqlCommand = new SqlCommand("select * from Products where ProductID = @ProductID ", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ProductID", ProductID);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public int FindID(string ProductName)      
        {

            var sqlConnection = Connection.Connect;
            var sqlCommand = new SqlCommand("select ProductID from Products where ProductName=@ProductName", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@ProductName", ProductName);

            sqlConnection.Open();

            var sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            var productID = Convert.ToInt32(sqlDataReader[0]);

            sqlConnection.Close();
            return productID;

        }
    }
}
