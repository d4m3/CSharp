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
    public partial class frmRole : Form
    {
        public frmRole()
        {
            InitializeComponent();
        }
       
        AuthEntities db;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            roleBindingSource.Add(role);
            roleBindingSource.MoveLast();
            db.Roles.Add(role);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                db.Roles.Remove(roleBindingSource.Current as Role);
                roleBindingSource.RemoveCurrent();
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                roleBindingSource.EndEdit();
                await db.SaveChangesAsync();
                dataGridView.Refresh();
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            db = new AuthEntities();
            roleBindingSource.DataSource = db.Roles.ToList();
        }
    }
}
