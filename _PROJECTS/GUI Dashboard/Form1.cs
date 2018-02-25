using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Dashboard
{
    public partial class Form : System.Windows.Forms.Form
    {
        int mm = 0;
        int mov, movX, movY;

        public Form()
        {
            InitializeComponent();
        }

        // Onloaded Form
        private void Form_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            Menu.ForeColor = Color.Black;
        }

        // Manage window movements
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
      
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);

            }
        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        // Creating image drawing for buttons
        private void ExitMenu_Paint(object sender, PaintEventArgs e)
        {
            //Creating exit "button"
            Graphics z = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            z.DrawLine(pen, 7, 7, 19, 19);
            z.DrawLine(pen, 7, 19, 19, 7);
            z.DrawLine(pen, 8, 7, 20, 19);
            z.DrawLine(pen, 8, 19, 20, 7);
        }
        
        private void MinMaxMenu_Paint(object sender, PaintEventArgs e)
        {
            //Creating maxmin button
            Graphics z = e.Graphics;
            Color myColor = Color.FromArgb(230, 179, 70);
            SolidBrush myBrush = new SolidBrush(myColor);
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            z.DrawRectangle(pen, 7, 7, 12, 12);
            z.FillRectangle(myBrush, 7, 7, 12, 12);
            z.DrawRectangle(pen, 9, 7, 7, 10);
            z.DrawRectangle(pen, 12, 12, 10, 10);
        }

        private void MinMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color myColor = Color.FromArgb(230, 179, 70);
            SolidBrush myBrush = new SolidBrush(myColor);
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            z.DrawRectangle(pen, 7, 16, 12, 4);
            z.FillRectangle(myBrush, 7, 16, 12, 4);
        }

        // Window Controls - Max/Min/Close
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinMaxMenu_Click(object sender, EventArgs e)
        {
            if (mm == 0)
            {
                WindowState = FormWindowState.Maximized;
                //MinimumSize = Size;
                //MaximumSize = Size;
                mm = 1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                mm = 0;
            }
        }

        private void MinMenu_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Menu Item Functions
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
