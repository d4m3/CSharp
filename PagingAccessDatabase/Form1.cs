using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagingAccessDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int pageNumber = 1;
        int pageSize = 40;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCustomer.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dbCustomer.Customers);
            var query = from c in dbCustomer.Customers
                        select new
                        {
                            CustomerID = c.CustomerID,
                            CompamyName = c.CompamyName,
                            ContactName = c.ContactName,
                            ContactTitle = c.ContactTitle,
                            Address = c.Address,
                            City = c.City,
                            Region = c.Region,
                            PostalCode = c.PostalCode,
                            Country = c.Country,
                            Phone = c.Phone,
                            Fax=c.Fax
                        };
            customersBindingSource.DataSource = query.Skip(pageSize * pageNumber).Take(pageSize).ToList();
            btnFirst.Enabled = false;
            lblPage.Text = string.Format("Page {0}/{1}", pageNumber, query.Count() / pageSize);
        }

        // <<
        private void btnFirst_Click(object sender, EventArgs e)
        {
            var query = from c in dbCustomer.Customers
                        select new
                        {
                            CustomerID = c.CustomerID,
                            CompamyName = c.CompamyName,
                            ContactName = c.ContactName,
                            ContactTitle = c.ContactTitle,
                            Address = c.Address,
                            City = c.City,
                            Region = c.Region,
                            PostalCode = c.PostalCode,
                            Country = c.Country,
                            Phone = c.Phone,
                            Fax = c.Fax
                        };
            pageNumber--;
            customersBindingSource.DataSource = query.Skip(pageSize * pageNumber).Take(pageSize).ToList();
            if (query.Skip(pageSize * (pageNumber - 1)).Take(pageSize).Count() > 0)
            {
                btnFirst.Enabled = true;
            }
            else
            {
                btnFirst.Enabled = false;
            }
            btnNext.Enabled = true;
            btnFirst.Enabled = !(pageNumber == 1);
            lblPage.Text = string.Format("Page {0}/{1}", pageNumber, query.Count() / pageSize);
        }

        // >>
        private void btnNext_Click(object sender, EventArgs e)
        {
            var query = from c in dbCustomer.Customers
                        select new
                        {
                            CustomerID = c.CustomerID,
                            CompamyName = c.CompamyName,
                            ContactName = c.ContactName,
                            ContactTitle = c.ContactTitle,
                            Address = c.Address,
                            City = c.City,
                            Region = c.Region,
                            PostalCode = c.PostalCode,
                            Country = c.Country,
                            Phone = c.Phone,
                            Fax = c.Fax
                        };
            pageNumber++;
            customersBindingSource.DataSource = query.Skip(pageSize * pageNumber).Take(pageSize).ToList();
            if (query.Skip(pageSize * (pageNumber + 1)).Take(pageSize).Count() > 0)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
            btnFirst.Enabled = true;
            btnNext.Enabled = !(pageNumber == 1);
            lblPage.Text = string.Format("Page {0}/{1}", pageNumber, query.Count() / pageSize);

        }


        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dataGridView.Height;
            dataGridView.Height = dataGridView.RowCount * dataGridView.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bmp, new Rectangle(0,0,dataGridView.Width, dataGridView.Height));
            dataGridView.Height = height;
            printPreviewDialog.ShowDialog();

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
