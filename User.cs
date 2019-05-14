using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Managment_Tool
{
    class User
    {
        private int Id;
        private string Name;
        private string Surname;
        private string Permission;
        private string Mail;
        

        public User(int userId)
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source = LAPEKS218-025\SQLEXPRESS;Initial Catalog = StatusKonstrukcjiDB;Integrated Security = True;"))
            {
                var query = "SELECT Name, Surname, Mail, Permission FROM EmployeeTab WHERE id ='" + userId + "'";
                DataTable table = new DataTable();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                connection.Close();
                adapter.Fill(table);
                if(table.Rows.Count==1)
                {
                    DataRow row = table.Rows[0];
                    this.Id = userId;
                    this.Name = row[0].ToString();
                    this.Surname = row[1].ToString();
                    this.Mail = row[2].ToString();
                    this.Permission = row[3].ToString();
                }
            }
        }

        public string GetMail
        {
            get { return Mail; }
            set { Mail = value; }
        }

        #region Properties

        public string GetPermission
        {
            get { return Permission; }
            set { Permission = value; }
        }


        public string GetSurname
        {
            get { return Surname; }
            set { Surname = value; }
        }


        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }

        #endregion
    }
}
