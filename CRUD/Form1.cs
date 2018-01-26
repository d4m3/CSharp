using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;


namespace CRUD
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(ofd.FileName);
                    Student obj = studentBindingSource.Current as Student;
                    if (obj != null)
                        obj.ImageUrl = ofd.FileName;                                       
                }
            }
        }

        void ClearInput()
        {
            txtFullName.Text = null;
            txtEmail.Text = null;
            txtAddress.Text = null;
            chkGender.Checked = false;
            txtBirthday.Text = null;
            pic.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State==ConnectionState.Closed)                    
                        db.Open();
                    studentBindingSource.DataSource = db.Query<Student>("SELECT *FROM Students", commandType: CommandType.Text);
                    pContainer.Enabled = false;
                    Student obj = studentBindingSource.Current as Student;
                    if (obj != null)
                    {
                        if (!string.IsNullOrEmpty(obj.ImageUrl))
                            pic.Image = Image.FromFile(obj.ImageUrl);
                    }
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pic.Image = null;
            pContainer.Enabled = true;
            studentBindingSource.Add(new Student());
            studentBindingSource.MoveLast();
            txtFullName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            studentBindingSource.ResetBindings(false);
            //ClearInput();
            this.Form1_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pContainer.Enabled = true;
            txtFullName.Focus();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Student obj = studentBindingSource.Current as Student;
                if (obj != null)
                {
                    if (!string.IsNullOrEmpty(obj.ImageUrl))
                        pic.Image = Image.FromFile(obj.ImageUrl);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to DELETE this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    Student obj = studentBindingSource.Current as Student;
                    if (obj != null)
                    {
                        using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            int result = db.Execute("DELETE FROM Students WHERE StudentID = @StudentID", new { StudentID = obj.StudentID}, commandType: CommandType.Text );
                            if (result != 0)
                            {
                                studentBindingSource.RemoveCurrent();
                                pContainer.Enabled = false;
                                pic.Image = null;
                                objState = EntityState.Unchanged;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                studentBindingSource.EndEdit();
                Student obj = studentBindingSource.Current as Student;
                if (obj != null)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        if (objState == EntityState.Added)
                        {
                            DynamicParameters p = new DynamicParameters();
                            p.Add("@StudentID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                            p.AddDynamicParams(new { FullName = obj.FullName, Email = obj.Email, Address = obj.Address, Gender = obj.Gender, Birthday = obj.Birthday, ImageUrl = obj.ImageUrl });
                            db.Execute("sp_Students_Insert", p, commandType: CommandType.StoredProcedure);
                            obj.StudentID = p.Get<int>("@StudentID");
                        }
                        else if (objState == EntityState.Changed)
                        {
                            db.Execute("sp+Student_Update", new{ StudentID = obj.StudentID, FullName = obj.FullName, Email = obj.Email, Address = obj.Address, Gender = obj.Gender, Birthday = obj.Birthday, ImageUrl = obj.ImageUrl}, commandType:CommandType.StoredProcedure);
                        }
                        metroGrid.Refresh();
                        pContainer.Enabled = false;
                        objState = EntityState.Unchanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkGender.CheckState == CheckState.Checked)
                chkGender.Text = "Female";
            else if (chkGender.CheckState == CheckState.Unchecked)
                chkGender.Text = "Male";
            else
                chkGender.Text = "?";
        }
    }
}
