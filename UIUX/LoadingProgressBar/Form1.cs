using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingProgressBar
{
    public partial class Form : System.Windows.Forms.Form
    {
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        public Form()
        {
            InitializeComponent();
            LoadingFunction();
        }

        // Load
        void LoadingFunction()
        {
            this.labelLoading.Top = 229;
            this.labelBy.Top = 220;
            this.labelPercent.Left = 184;
            this.labelBy.Visible = false;
            this.labelLoading.BringToFront();
            this.progressBar.Value = 0;
        }

        int plus = 1;
        int lblplus = 4;
        void Move(object sender, EventArgs e)
        {
            if (labelPercent.Left < 587 && progressBar.Value < 100) 
            {
                progressBar.Value += plus;
                labelPercent.Left += lblplus;
                labelPercent.Text = progressBar.Value.ToString() + "%";
            }
            if (labelPercent.Text == "100%")
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(Move);
            timer2.Tick += new EventHandler(Move);

            timer1.Interval = 20;
            timer2.Interval = 10;

            timer1.Start();
        }
    }
}
