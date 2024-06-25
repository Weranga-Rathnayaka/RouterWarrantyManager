using System;
using System.Data.SQLite;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace RouterWarrantyManager
{
    public partial class Form1 : Form
    {
        private string dbConnectionString = "Data Source=warranty.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Add this line
            CreateDatabase();
            //pictureBoxWarranty.Image = null;
            pictureBoxOutOfWarranty.Image = null;
        }

        private void CreateDatabase()
        {
            using (var connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Routers (
                                                SN TEXT PRIMARY KEY,
                                                CustomerName TEXT,
                                                PurchaseDate TEXT,
                                                WarrantyEndDate TEXT
                                            )";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnAddRouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSN.Text) || string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                lblStatus.Text = "Please fill in both fields.";
                return;
            }

            string sn = txtSN.Text;
            string customerName = txtCustomerName.Text;
            string purchaseDate = DateTime.Now.ToString("yyyy-MM-dd");
            string warrantyEndDate = DateTime.Now.AddMonths(6).ToString("yyyy-MM-dd");
            string customerEmail = txtCustomerEmail.Text;

            using (var connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Routers (SN, CustomerName, PurchaseDate, WarrantyEndDate) VALUES (@SN, @CustomerName, @PurchaseDate, @WarrantyEndDate)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@SN", sn);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                    command.Parameters.AddWithValue("@WarrantyEndDate", warrantyEndDate);
                    command.ExecuteNonQuery();
                }
            }
            lblStatus.Text = "Router added successfully.";
           
            SendEmail(customerEmail, customerName, purchaseDate, warrantyEndDate, sn);
            txtSN.Clear();
            txtCustomerName.Clear();
        }

        private void SendEmail(string customerEmail, string customerName, string purchaseDate, string warrantyEndDate, string sn)
        {
            string subject = "Router Registration Confirmation";
            string body = $@"
     <div style='background-color:#f2f2f2;padding:15px'>
            <div style='background-color:#fff;padding:15px;color:#4d4d4d;font-size:14px'>
                Hi {customerName},<br>
                Thank <span class='il'>You</span> <span class='il'>For</span> Your Order. <span style='margin-top:5px;margin-bottom:5px;font-size:24px;font-weight:bold;display:block'></span>
                <br>
                <b>Customer Name:</b> {customerName}<br>
                <b>Purchase Date:</b> {purchaseDate}<br>
                <b>Warranty End Date:</b> {warrantyEndDate}<br>
                <b>EMEI No:</b> {sn}<br>
                <br><font color='#888888'>
                <b><span class='il'>Shenzen</span> <span class='il'>Bilian</span> Electronic Co Ltd</b>
            </div>
        </div>";

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); // Use your SMTP server here

                string fromEmail = "shenzhenbilianelectronic@gmail.com";
                string fromDisplayName = "Shenzhen Bilian Electronic Co Ltd";

                mail.From = new MailAddress(fromEmail, fromDisplayName);
                mail.To.Add(customerEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587; // Use your SMTP server port
                SmtpServer.Credentials = new NetworkCredential("shenzhenbilianelectronic@gmail.com", "hnal zksk anbo rqpe");
                SmtpServer.EnableSsl = true;

                
                SmtpServer.Send(mail);
                lblStatus.Text += " Email sent";
                txtCustomerEmail.Clear();
            }
            catch (Exception ex)
            {
                lblStatus.Text += $" Email sending failed: {ex.Message}";
            }
        }


        private void btnSearchRouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSN.Text))
            {
                lblStatus.Text = "Please enter the Serial Number.";
                return;
            }

            string sn = txtSN.Text;

            using (var connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                string selectQuery = "SELECT CustomerName, PurchaseDate, WarrantyEndDate FROM Routers WHERE SN = @SN";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@SN", sn);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string customerName = reader["CustomerName"].ToString();
                            DateTime purchaseDate = DateTime.Parse(reader["PurchaseDate"].ToString());
                            DateTime warrantyEndDate = DateTime.Parse(reader["WarrantyEndDate"].ToString());
                            string warrantyStatus = DateTime.Now <= warrantyEndDate ? "In Warranty" : "Out of Warranty";

                            lblStatus.Text = $"Customer: {customerName}\nPurchase Date: {purchaseDate:yyyy-MM-dd}\nWarranty End Date: {warrantyEndDate:yyyy-MM-dd}\nStatus: {warrantyStatus}";

                            if (warrantyStatus == "In Warranty")
                            {
                                pictureBoxOutOfWarranty.Image = System.Drawing.Image.FromFile("Images/Correct.png");
                                //pictureBoxOutOfWarranty.Image = null;
                            }
                            else
                            {
                                pictureBoxOutOfWarranty.Image = System.Drawing.Image.FromFile("Images/incorrect.png");
                                //pictureBoxWarranty.Image = null;
                            }
                        }
                        else
                        {
                            lblStatus.Text = "Router not found.";
                            //pictureBoxWarranty.Image = null;
                            pictureBoxOutOfWarranty.Image = null;
                        }
                    }
                }
            }
        }
    }
}
