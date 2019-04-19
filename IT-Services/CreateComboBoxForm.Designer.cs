namespace IT_Services
{
    partial class CreateComboBoxForm
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
            this.txbx_cbx_name = new System.Windows.Forms.TextBox();
            this.txbx_cbc_price = new System.Windows.Forms.TextBox();
            this.btn_add_comboBoxModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_cbx_name
            // 
            this.txbx_cbx_name.Location = new System.Drawing.Point(57, 26);
            this.txbx_cbx_name.Name = "txbx_cbx_name";
            this.txbx_cbx_name.Size = new System.Drawing.Size(139, 20);
            this.txbx_cbx_name.TabIndex = 0;
            // 
            // txbx_cbc_price
            // 
            this.txbx_cbc_price.Location = new System.Drawing.Point(57, 72);
            this.txbx_cbc_price.Name = "txbx_cbc_price";
            this.txbx_cbc_price.Size = new System.Drawing.Size(44, 20);
            this.txbx_cbc_price.TabIndex = 1;
            // 
            // btn_add_comboBoxModel
            // 
            this.btn_add_comboBoxModel.Location = new System.Drawing.Point(121, 72);
            this.btn_add_comboBoxModel.Name = "btn_add_comboBoxModel";
            this.btn_add_comboBoxModel.Size = new System.Drawing.Size(75, 23);
            this.btn_add_comboBoxModel.TabIndex = 2;
            this.btn_add_comboBoxModel.Text = "Elave Et";
            this.btn_add_comboBoxModel.UseVisualStyleBackColor = true;
            this.btn_add_comboBoxModel.Click += new System.EventHandler(this.btn_add_comboBoxModel_Click);
            // 
            // CreateComboBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 182);
            this.Controls.Add(this.btn_add_comboBoxModel);
            this.Controls.Add(this.txbx_cbc_price);
            this.Controls.Add(this.txbx_cbx_name);
            this.Name = "CreateComboBoxForm";
            this.Text = "CreateComboBoxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_cbx_name;
        private System.Windows.Forms.TextBox txbx_cbc_price;
        private System.Windows.Forms.Button btn_add_comboBoxModel;
    }
}