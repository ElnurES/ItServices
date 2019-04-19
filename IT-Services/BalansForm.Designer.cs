namespace IT_Services
{
    partial class BalansForm
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
            this.txbx_cart_number = new System.Windows.Forms.TextBox();
            this.txbx_cart_date = new System.Windows.Forms.TextBox();
            this.txbx_cvc = new System.Windows.Forms.TextBox();
            this.txbx_amunt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_cart_number
            // 
            this.txbx_cart_number.Location = new System.Drawing.Point(117, 32);
            this.txbx_cart_number.Name = "txbx_cart_number";
            this.txbx_cart_number.Size = new System.Drawing.Size(170, 20);
            this.txbx_cart_number.TabIndex = 0;
            // 
            // txbx_cart_date
            // 
            this.txbx_cart_date.Location = new System.Drawing.Point(117, 83);
            this.txbx_cart_date.Name = "txbx_cart_date";
            this.txbx_cart_date.Size = new System.Drawing.Size(63, 20);
            this.txbx_cart_date.TabIndex = 1;
            // 
            // txbx_cvc
            // 
            this.txbx_cvc.Location = new System.Drawing.Point(224, 83);
            this.txbx_cvc.Name = "txbx_cvc";
            this.txbx_cvc.Size = new System.Drawing.Size(63, 20);
            this.txbx_cvc.TabIndex = 2;
            // 
            // txbx_amunt
            // 
            this.txbx_amunt.Location = new System.Drawing.Point(117, 136);
            this.txbx_amunt.Name = "txbx_amunt";
            this.txbx_amunt.Size = new System.Drawing.Size(63, 20);
            this.txbx_amunt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BalansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbx_amunt);
            this.Controls.Add(this.txbx_cvc);
            this.Controls.Add(this.txbx_cart_date);
            this.Controls.Add(this.txbx_cart_number);
            this.Name = "BalansForm";
            this.Text = "BalansForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_cart_number;
        private System.Windows.Forms.TextBox txbx_cart_date;
        private System.Windows.Forms.TextBox txbx_cvc;
        private System.Windows.Forms.TextBox txbx_amunt;
        private System.Windows.Forms.Button button1;
    }
}