using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthenticationDemo
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        AuthEntities db;

        private void frmUser_Load(object sender, EventArgs e)
        {
            db = new AuthEntities();
            roleBindingSource.DataSource = db.Roles.ToList();
            userBindingSource.DataSource = db.Users.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            userBindingSource.Add(user);
            userBindingSource.MoveLast();
            db.Users.Add(user);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Users.Remove(userBindingSource.Current as User);
                userBindingSource.RemoveCurrent();
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                userBindingSource.EndEdit();
                await db.SaveChangesAsync();
                dataGridView.Refresh();
                MessageBox.Show("Yout data has been successfully saved.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
