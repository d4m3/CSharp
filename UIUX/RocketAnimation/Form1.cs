using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketAnimation
{
    public partial class Form1 : Form
    {
        Timer timeback = new Timer();
        Timer timerrocket = new Timer();
        Timer timerball = new Timer();

        public Form1()
        {
            InitializeComponent();

            timeback.Tick += new EventHandler(Resource);
            timerrocket.Tick += new EventHandler(Ball);
            timerball.Tick += new EventHandler(RocketUp);

            RocketFunction();
        }

        //
        void RocketFunction()
        {
            linerocket.Height = 1; linerocket.Width = 0; linerocket.Left = 341;
            ball.Top = 262; ball.Visible = false; ball.BringToFront();
            rocket.Height = 64; rocket.Top = 320; rocket.Visible = false;

            // Image Locations
            ball.ImageLocation = "ball2.png";
            rocket.ImageLocation = "whiterocket.png";
            ImageAnimator.UpdateFrames();


            // Time Intervals
            timeback.Interval = 30;
            timeback.Interval = 40;
            timerrocket.Interval = 10;

            timeback.Start();
        }

        // Initial
        int wd = 0; int down = 1, lt = 5;
        void Resource(object sender, EventArgs e)
        {
            linerocket.Width += wd;
            if (linerocket.Width < 1)
            {
                wd = 8;
            }
            if (linerocket.Width > 104)
            {
                timeback.Stop();
                timerrocket.Start();
            }
            
            //anim.ShowSync(label1);
        }

        // Ball        
        void Ball(object sender, EventArgs e)
        {
            ball.Top += down;
            if (ball.Top < 265)
            {
                ball.Visible = true;
                down = 1;
            }
            if (ball.Top > 305)
            {
                timerball.Interval = 10; // increase speed
                rocket.ImageLocation = "rocket.png";

                ball.Visible = false;
                down = 5;
                rocket.Top -= down;
                if (rocket.Top < -60)
                {
                    linerocket.Width -= lt;
                    linerocket.Left += lt;
                    if (linerocket.Left > 470)
                    {
                        down = 1;
                        timerball.Stop();
                        RocketFunction();
                    }
                }
            }
        }

        // Rocket
        int rockettop = -1;
        void RocketUp(object sender, EventArgs e)
        {
            rocket.Top += rockettop;
            if (rocket.Top > 318)
            {
                rocket.Visible = true;
                rockettop = -5;
            }
            if (rocket.Top < 250)
            {
                rockettop = -1;
                timerrocket.Stop();
                timerball.Start();
            }
        }
    }
}
