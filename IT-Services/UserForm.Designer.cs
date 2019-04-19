namespace IT_Services
{
    partial class UserForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.xBox_services = new System.Windows.Forms.ComboBox();
            this.txbx_description = new System.Windows.Forms.TextBox();
            this.btn_service = new System.Windows.Forms.Button();
            this.lbl_balans = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(43, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Balans Artir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(43, 117);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(30, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Arxiv";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // xBox_services
            // 
            this.xBox_services.FormattingEnabled = true;
            this.xBox_services.Location = new System.Drawing.Point(183, 51);
            this.xBox_services.Name = "xBox_services";
            this.xBox_services.Size = new System.Drawing.Size(195, 21);
            this.xBox_services.TabIndex = 2;
            // 
            // txbx_description
            // 
            this.txbx_description.Location = new System.Drawing.Point(183, 117);
            this.txbx_description.Multiline = true;
            this.txbx_description.Name = "txbx_description";
            this.txbx_description.Size = new System.Drawing.Size(195, 108);
            this.txbx_description.TabIndex = 3;
            // 
            // btn_service
            // 
            this.btn_service.Location = new System.Drawing.Point(239, 260);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(75, 23);
            this.btn_service.TabIndex = 4;
            this.btn_service.Text = "Xidmet Al";
            this.btn_service.UseVisualStyleBackColor = true;
            this.btn_service.Click += new System.EventHandler(this.btn_service_Click);
            // 
            // lbl_balans
            // 
            this.lbl_balans.AutoSize = true;
            this.lbl_balans.Location = new System.Drawing.Point(477, 13);
            this.lbl_balans.Name = "lbl_balans";
            this.lbl_balans.Size = new System.Drawing.Size(0, 13);
            this.lbl_balans.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Balans :";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_balans);
            this.Controls.Add(this.btn_service);
            this.Controls.Add(this.txbx_description);
            this.Controls.Add(this.xBox_services);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox xBox_services;
        private System.Windows.Forms.TextBox txbx_description;
        private System.Windows.Forms.Button btn_service;
        private System.Windows.Forms.Label lbl_balans;
        private System.Windows.Forms.Label label1;
    }
}