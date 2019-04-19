namespace IT_Services
{
    partial class GenerateCart
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
            this.txbx_cartNumber = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.txbx_cart_price = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_cartNumber
            // 
            this.txbx_cartNumber.Location = new System.Drawing.Point(36, 43);
            this.txbx_cartNumber.Name = "txbx_cartNumber";
            this.txbx_cartNumber.Size = new System.Drawing.Size(141, 20);
            this.txbx_cartNumber.TabIndex = 0;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(204, 43);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(103, 23);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Cart Nomersi Yarat";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txbx_cart_price
            // 
            this.txbx_cart_price.Location = new System.Drawing.Point(36, 85);
            this.txbx_cart_price.Name = "txbx_cart_price";
            this.txbx_cart_price.Size = new System.Drawing.Size(24, 20);
            this.txbx_cart_price.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(89, 85);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Elave Et";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // GenerateCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 152);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txbx_cart_price);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.txbx_cartNumber);
            this.Name = "GenerateCart";
            this.Text = "GenerateCart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_cartNumber;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txbx_cart_price;
        private System.Windows.Forms.Button btn_add;
    }
}