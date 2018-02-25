using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrysDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Load table with test data
        private void crvDataTable_Load(object sender, EventArgs e)
        {
            // Declare datatable
            DataTable Product = new DataTable();
            Product.Columns.Add("SlNo",typeof(int));
            Product.Columns.Add("Name", typeof(int));
            Product.Columns.Add("Price", typeof(int));
            Product.Columns.Add("Count", typeof(int));

            // Insert test rows
            Product.Rows.Add(1,"Pen", 20, 250);
            Product.Rows.Add(2, "Pencil", 10, 150);
            Product.Rows.Add(3, "Notebook", 60, 550);
            Product.Rows.Add(4, "Bag", 700, 750);
            Product.Rows.Add(5, "Umbrella", 50, 500);
        }
    }
}
