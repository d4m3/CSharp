using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPanel
{
    public partial class Form1 : Form
    {
        int panelWidth;
        bool Hidden;

        public Form1()
        {
            InitializeComponent();
            //btnHhost1.Visible = false;
            //btnHost2.Visible = false;
            //panelHostButtons.Visible = false;            
            panelSliderBar.Height = btnHideShow.Height;            
            panelWidth = panelSlide.Width;
            Hidden = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panelSliderBar.Height = btnHideShow.Height;
            panelSliderBar.Top = btnHideShow.Top;
        }

        private void btnHosts_Click(object sender, EventArgs e)
        {
            panelSliderBar.Height = btnHosts.Height;
            panelSliderBar.Top = btnHosts.Top;
            //if (panelSliderBar.Top == btnHosts.Top)
            //{
            //    panelHostButtons.Visible = true;
            //    btnHhost1.Visible = true;
            //    btnHost2.Visible = true;
            //}
            //else
            //{
            //    panelHostButtons.Visible = false;
            //    btnHhost1.Visible = false;
            //    btnHost2.Visible = false;
            //}
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            panelSliderBar.Height = btnReports.Height;
            panelSliderBar.Top = btnReports.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelSlide.Width = panelSlide.Width + 10;
                if (panelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 10;
                if (panelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }
    }
}
