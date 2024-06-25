namespace RouterWarrantyManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.btnAddRouter = new System.Windows.Forms.Button();
            this.btnSearchRouter = new System.Windows.Forms.Button();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBoxOutOfWarranty = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutOfWarranty)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSN.Location = new System.Drawing.Point(150, 30);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(200, 25);
            this.txtSN.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerName.Location = new System.Drawing.Point(150, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 25);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerEmail.Location = new System.Drawing.Point(150, 90);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(200, 25);
            this.txtCustomerEmail.TabIndex = 2;
            // 
            // btnAddRouter
            // 
            this.btnAddRouter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddRouter.FlatAppearance.BorderSize = 0;
            this.btnAddRouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddRouter.ForeColor = System.Drawing.Color.White;
            this.btnAddRouter.Location = new System.Drawing.Point(150, 130);
            this.btnAddRouter.Name = "btnAddRouter";
            this.btnAddRouter.Size = new System.Drawing.Size(100, 30);
            this.btnAddRouter.TabIndex = 3;
            this.btnAddRouter.Text = "Add Router";
            this.btnAddRouter.UseVisualStyleBackColor = false;
            this.btnAddRouter.Click += new System.EventHandler(this.btnAddRouter_Click);
            // 
            // btnSearchRouter
            // 
            this.btnSearchRouter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchRouter.FlatAppearance.BorderSize = 0;
            this.btnSearchRouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchRouter.ForeColor = System.Drawing.Color.White;
            this.btnSearchRouter.Location = new System.Drawing.Point(260, 130);
            this.btnSearchRouter.Name = "btnSearchRouter";
            this.btnSearchRouter.Size = new System.Drawing.Size(100, 30);
            this.btnSearchRouter.TabIndex = 4;
            this.btnSearchRouter.Text = "Search Router";
            this.btnSearchRouter.UseVisualStyleBackColor = false;
            this.btnSearchRouter.Click += new System.EventHandler(this.btnSearchRouter_Click);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSN.Location = new System.Drawing.Point(30, 33);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(103, 19);
            this.lblSN.TabIndex = 5;
            this.lblSN.Text = "Serial Number:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.Location = new System.Drawing.Point(30, 63);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(117, 19);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerEmail.Location = new System.Drawing.Point(30, 93);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(112, 19);
            this.lblCustomerEmail.TabIndex = 7;
            this.lblCustomerEmail.Text = "Customer Email:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(30, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 19);
            this.lblStatus.TabIndex = 8;
            // 
            // pictureBoxOutOfWarranty
            // 
            this.pictureBoxOutOfWarranty.Location = new System.Drawing.Point(260, 170);
            this.pictureBoxOutOfWarranty.Name = "pictureBoxOutOfWarranty";
            this.pictureBoxOutOfWarranty.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxOutOfWarranty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOutOfWarranty.TabIndex = 9;
            this.pictureBoxOutOfWarranty.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.pictureBoxOutOfWarranty);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.btnSearchRouter);
            this.Controls.Add(this.btnAddRouter);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Router Warranty Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutOfWarranty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Button btnAddRouter;
        private System.Windows.Forms.Button btnSearchRouter;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBoxOutOfWarranty;
    }
}
