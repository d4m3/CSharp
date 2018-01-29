using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UserMgmt
{
    class Connection
    {
        OleDbConnection connection;
        OleDbCommand command;

        public Connection()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Forbes\source\repos\CSharp\UserMgmt\User.accdb;Persist Security Info=False");
            //connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Forbes\source\repos\User.accdb";
            command = connection.CreateCommand();
        }

        // ADD Btn Function
        public void Insert(Person p)
        {
            try
            {
                command.CommandText = "INSERT INTO users(username) VALUES('"+p.Name+"')";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
                //MessageBox.Show("Data added.");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }            
        }

        // LOAD Btn Functionality
        public List<Person> Load()
        {
            List<Person> persons = new List<Person>();
            try
            {
                command.CommandText = "SELECT * FROM users";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Person person = new Person();
                    person.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    person.Name = reader["username"].ToString();
                    persons.Add(person);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return persons;
        }

        //EDIT Btn
        public void Update(Person p)
        {
            try
            {
                //command.CommandText = "UPDATE users SET username = '" +p.Name+ "' "'WHERE id='"+p.ID1'"";
                command.CommandText = "UPDATE users SET username = '"+p.Name+"' WHERE id = '" +p.ID1+ "'";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
