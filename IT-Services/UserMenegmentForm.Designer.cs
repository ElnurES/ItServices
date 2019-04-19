namespace IT_Services
{
    partial class UserMenegmentForm
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
            this.dGW_userMenegment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_userMenegment)).BeginInit();
            this.SuspendLayout();
            // 
            // dGW_userMenegment
            // 
            this.dGW_userMenegment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW_userMenegment.Location = new System.Drawing.Point(12, 12);
            this.dGW_userMenegment.Name = "dGW_userMenegment";
            this.dGW_userMenegment.Size = new System.Drawing.Size(510, 396);
            this.dGW_userMenegment.TabIndex = 0;
            // 
            // UserMenegmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 451);
            this.Controls.Add(this.dGW_userMenegment);
            this.Name = "UserMenegmentForm";
            this.Text = "UserMenegmentForm";
            this.Load += new System.EventHandler(this.UserMenegmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGW_userMenegment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGW_userMenegment;
    }
}