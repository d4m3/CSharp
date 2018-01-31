namespace LoadingProgressBar
{
    partial class Form
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
            this.labelLoading = new System.Windows.Forms.Label();
            this.labelBy = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLoading
            // 
            this.labelLoading.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelLoading.ForeColor = System.Drawing.Color.White;
            this.labelLoading.Location = new System.Drawing.Point(219, 197);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(346, 31);
            this.labelLoading.TabIndex = 0;
            this.labelLoading.Text = "LOADING";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBy
            // 
            this.labelBy.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelBy.ForeColor = System.Drawing.Color.White;
            this.labelBy.Location = new System.Drawing.Point(219, 239);
            this.labelBy.Name = "labelBy";
            this.labelBy.Size = new System.Drawing.Size(346, 31);
            this.labelBy.TabIndex = 0;
            this.labelBy.Text = "By Damian Forbes";
            this.labelBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Gainsboro;
            this.progressBar.Location = new System.Drawing.Point(186, 273);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(412, 5);
            this.progressBar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(310, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelPercent.ForeColor = System.Drawing.Color.White;
            this.labelPercent.Location = new System.Drawing.Point(183, 281);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(15, 17);
            this.labelPercent.TabIndex = 0;
            this.labelPercent.Text = "0";
            this.labelPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(116)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.labelBy);
            this.Controls.Add(this.labelLoading);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Screen";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label labelBy;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPercent;
    }
}

