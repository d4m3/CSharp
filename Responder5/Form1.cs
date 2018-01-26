using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Responder5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadR5_Click(object sender, EventArgs e)
        {
            LoadR5();                      
        }

        private void LoadR5()
        {
            webBrowser.Navigate("google.com");                        
            var timer = new System.Threading.Timer(state => webBrowser.Refresh(), null,0,30000);
        }
    }
}
