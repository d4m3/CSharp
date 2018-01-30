namespace RocketAnimation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ball = new System.Windows.Forms.PictureBox();
            this.linerocket = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(391, 262);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(6, 6);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // linerocket
            // 
            this.linerocket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(172)))), ((int)(((byte)(221)))));
            this.linerocket.Location = new System.Drawing.Point(340, 320);
            this.linerocket.Name = "linerocket";
            this.linerocket.Size = new System.Drawing.Size(104, 4);
            this.linerocket.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(341, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 89);
            this.panel1.TabIndex = 1;
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.Color.Transparent;
            this.rocket.Location = new System.Drawing.Point(362, 323);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(64, 64);
            this.rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket.TabIndex = 2;
            this.rocket.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please wait..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.linerocket);
            this.Controls.Add(this.ball);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Panel linerocket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rocket;
    }
}

