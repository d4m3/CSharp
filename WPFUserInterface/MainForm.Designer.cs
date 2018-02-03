namespace WPFUserInterface
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
            this.executeAsync = new System.Windows.Forms.Button();
            this.executeParallelAsync = new System.Windows.Forms.Button();
            this.cancelOperation = new System.Windows.Forms.Button();
            this.executeSync = new System.Windows.Forms.Button();
            this.resultsWindow = new System.Windows.Forms.TextBox();
            this.dashboardProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // executeAsync
            // 
            this.executeAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeAsync.Location = new System.Drawing.Point(24, 78);
            this.executeAsync.Name = "executeAsync";
            this.executeAsync.Size = new System.Drawing.Size(574, 29);
            this.executeAsync.TabIndex = 0;
            this.executeAsync.Text = "Async Execution";
            this.executeAsync.UseVisualStyleBackColor = true;
            this.executeAsync.Click += new System.EventHandler(this.executeAsync_Click);
            // 
            // executeParallelAsync
            // 
            this.executeParallelAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeParallelAsync.Location = new System.Drawing.Point(24, 124);
            this.executeParallelAsync.Name = "executeParallelAsync";
            this.executeParallelAsync.Size = new System.Drawing.Size(574, 29);
            this.executeParallelAsync.TabIndex = 0;
            this.executeParallelAsync.Text = "Parallel Async Execution";
            this.executeParallelAsync.UseVisualStyleBackColor = true;
            this.executeParallelAsync.Click += new System.EventHandler(this.executeParallelAsync_Click);
            // 
            // cancelOperation
            // 
            this.cancelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOperation.Location = new System.Drawing.Point(24, 171);
            this.cancelOperation.Name = "cancelOperation";
            this.cancelOperation.Size = new System.Drawing.Size(574, 29);
            this.cancelOperation.TabIndex = 0;
            this.cancelOperation.Text = "Cancel Operation";
            this.cancelOperation.UseVisualStyleBackColor = true;
            this.cancelOperation.Click += new System.EventHandler(this.cancelOperation_Click);
            // 
            // executeSync
            // 
            this.executeSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeSync.Location = new System.Drawing.Point(24, 32);
            this.executeSync.Name = "executeSync";
            this.executeSync.Size = new System.Drawing.Size(574, 29);
            this.executeSync.TabIndex = 0;
            this.executeSync.Text = "Normal Execution";
            this.executeSync.UseVisualStyleBackColor = true;
            this.executeSync.Click += new System.EventHandler(this.executeSync_Click);
            // 
            // resultsWindow
            // 
            this.resultsWindow.Location = new System.Drawing.Point(24, 259);
            this.resultsWindow.Multiline = true;
            this.resultsWindow.Name = "resultsWindow";
            this.resultsWindow.Size = new System.Drawing.Size(574, 184);
            this.resultsWindow.TabIndex = 1;
            // 
            // dashboardProgress
            // 
            this.dashboardProgress.Location = new System.Drawing.Point(24, 224);
            this.dashboardProgress.Name = "dashboardProgress";
            this.dashboardProgress.Size = new System.Drawing.Size(574, 14);
            this.dashboardProgress.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 468);
            this.Controls.Add(this.dashboardProgress);
            this.Controls.Add(this.resultsWindow);
            this.Controls.Add(this.cancelOperation);
            this.Controls.Add(this.executeParallelAsync);
            this.Controls.Add(this.executeSync);
            this.Controls.Add(this.executeAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button executeAsync;
        private System.Windows.Forms.Button executeParallelAsync;
        private System.Windows.Forms.Button cancelOperation;
        private System.Windows.Forms.Button executeSync;
        private System.Windows.Forms.TextBox resultsWindow;
        private System.Windows.Forms.ProgressBar dashboardProgress;
    }
}

