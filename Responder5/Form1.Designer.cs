namespace Responder5
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnLoadR5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(849, 566);
            this.webBrowser.TabIndex = 0;
            // 
            // btnLoadR5
            // 
            this.btnLoadR5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLoadR5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadR5.Location = new System.Drawing.Point(138, 612);
            this.btnLoadR5.Name = "btnLoadR5";
            this.btnLoadR5.Size = new System.Drawing.Size(586, 57);
            this.btnLoadR5.TabIndex = 1;
            this.btnLoadR5.Text = "Load R5";
            this.btnLoadR5.UseVisualStyleBackColor = false;
            this.btnLoadR5.Click += new System.EventHandler(this.btnLoadR5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 698);
            this.Controls.Add(this.btnLoadR5);
            this.Controls.Add(this.webBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnLoadR5;
    }
}

