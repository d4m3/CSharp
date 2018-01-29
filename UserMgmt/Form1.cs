using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UserMgmt
{
    public partial class Form1 : Form
    {
        Connection connection; // The class
        public Form1()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtUsername.Text;
            
            // Pass person to the Insert Method from Connection.cs
            connection.Insert(person);

            // Used to clear Textbox 
            txtUsername.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Ensure same data isn't loaded when clicked again
            listData.Items.Clear();

            List<Person> persons = connection.Load();
            foreach (var person in persons)
            {
                ListViewItem item = new ListViewItem(person.Name);
                item.SubItems.Add(person.Name.ToString());

                // Display data on the list view screen
                listData.Items.Add(item);
                
            }
        }

        // Used for updating/Edit
        private void listData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listData.SelectedItems.Count != 0)
            {
                btnEdit.Enabled = true;
                //txtUsername.Text;
                //Person person = new Person();
                //person.Name = txtUsername.Text;
                //connection.Insert(person);
                txtUsername.Clear();
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();
            newPerson.Name = txtUsername.Text;
            int index = listData.SelectedItems[0].Index;
            List<Person> persons= connection.Load();
            newPerson.ID1 = persons[index].ID1;
            connection.Update(newPerson);
        }
    }
}
