using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// https://www.youtube.com/watch?v=KzRxQ07RhMQ&list=PL-EU0JUF-XD1Za70NnKeDBfNZVI43bCUj&index=52

namespace ChartDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database.AgeStatistics' table. You can move, or remove it, as needed.
            this.ageStatisticsTableAdapter.Fill(this.database.AgeStatistics);

        }

        // Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ageStatisticsBindingSource.EndEdit();
                ageStatisticsTableAdapter.Update(database.AgeStatistics);
                MessageBox.Show("Your data has been successfully saved.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load
        private void btnLoad_Click(object sender, EventArgs e)
        {
            chart1.Series["Age"].XValueMember = "Age";
            chart1.Series["Age"].YValueMembers = "Total";
            chart1.DataSource = database.AgeStatistics;
            chart1.DataBind();

        }
    }
}
