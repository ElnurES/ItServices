namespace IT_Services
{
    partial class CartMenegerForm
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
            this.dGW_cartMeneger = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_cartMeneger)).BeginInit();
            this.SuspendLayout();
            // 
            // dGW_cartMeneger
            // 
            this.dGW_cartMeneger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW_cartMeneger.Location = new System.Drawing.Point(30, 35);
            this.dGW_cartMeneger.Name = "dGW_cartMeneger";
            this.dGW_cartMeneger.Size = new System.Drawing.Size(508, 343);
            this.dGW_cartMeneger.TabIndex = 0;
            // 
            // CartMenegerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 472);
            this.Controls.Add(this.dGW_cartMeneger);
            this.Name = "CartMenegerForm";
            this.Text = "CartMenegerForm";
            this.Load += new System.EventHandler(this.CartMenegerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGW_cartMeneger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGW_cartMeneger;
    }
}