using KatmanliMimari_NTierDesign.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari_NTierDesign.BusinessLayer
{
    public class EmployeeRepository
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public bool Save()
        {
            try
            {
                string[] Firstname_Lastname = EmployeeName.Split(' ');

                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("insert into Employees (Firstname,Lastname) values (@Firstname,@Lastname)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Firstname", Firstname_Lastname[0]);
                sqlCommand.Parameters.AddWithValue("@Lastname", Firstname_Lastname[1]);

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

            SqlCommand sqlCommand = new SqlCommand("select * from Employees", sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public bool Update()
        {
            try
            {
                string[] Firstname_Lastname = EmployeeName.Split(' ');

                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("update Employees set FirstName = @FirstName, LastName = @LastName where EmployeeID = @EmployeeID", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                sqlCommand.Parameters.AddWithValue("@FirstName", Firstname_Lastname[0]);
                sqlCommand.Parameters.AddWithValue("@LastName", Firstname_Lastname[1]);

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

                SqlCommand sqlCommand = new SqlCommand("delete from Employees where EmployeeID = @EmployeeID", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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

        public int FindID(string FirstNameLastName)      //Kullanıcı adı alıp ID döndürüyorum.
        {
            string[] FirstName_LastName = FirstNameLastName.Split(' ');


            var sqlConnection = Connection.Connect;
            var sqlCommand = new SqlCommand("SELECT EmployeeID FROM Employees where FirstName=@FirstName and  Lastname=@Lastname", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@FirstName", FirstName_LastName[0]);
            sqlCommand.Parameters.AddWithValue("@Lastname", FirstName_LastName[1]);

            sqlConnection.Open();

            var sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            var employeeID = Convert.ToInt32(sqlDataReader[0]);

            sqlConnection.Close();
            return employeeID;
        }
    }
}
