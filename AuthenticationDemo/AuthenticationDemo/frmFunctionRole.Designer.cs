namespace AuthenticationDemo
{
    partial class frmFunctionRole
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
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.dataGridViewFunctionRole = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctionRole)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(46, 12);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(235, 21);
            this.cboRole.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role:";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.AllowUserToAddRows = false;
            this.dataGridViewFunction.AllowUserToDeleteRows = false;
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Location = new System.Drawing.Point(8, 52);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.Size = new System.Drawing.Size(273, 354);
            this.dataGridViewFunction.TabIndex = 2;
            // 
            // dataGridViewFunctionRole
            // 
            this.dataGridViewFunctionRole.AllowUserToAddRows = false;
            this.dataGridViewFunctionRole.AllowUserToDeleteRows = false;
            this.dataGridViewFunctionRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunctionRole.Location = new System.Drawing.Point(359, 52);
            this.dataGridViewFunctionRole.Name = "dataGridViewFunctionRole";
            this.dataGridViewFunctionRole.Size = new System.Drawing.Size(275, 354);
            this.dataGridViewFunctionRole.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(287, 192);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(31, 50);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmFunctionRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 423);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridViewFunctionRole);
            this.Controls.Add(this.dataGridViewFunction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRole);
            this.Name = "frmFunctionRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctionRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridView dataGridViewFunctionRole;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}