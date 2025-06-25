using MedicineLocator.Controller;
using MedicineLocator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MedicineLocator.View
{

    public partial class ForgotPasswordForm : Form
    {
        string currentOtp = "";
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
        public string GenerateOTP()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }
        public void SendOtpToEmail(string Email, string otp)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("medicinefindersystem@gmail.com"); 
            mail.To.Add(Email);
            mail.Subject = "Your OTP Code";
            mail.Body = "Dear User,\nYour OTP is: " + otp;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("medicinefindersystem@gmail.com", "csmq qqvl rqhu zedx");
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
                MessageBox.Show("OTP Sent to your Email!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP: " + ex.Message);
            }
        }
        public string ValidEmailCheck(string email)
        {
            string mail = MailTextBox.Text;
            if (!mail.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Enter A vailid Email");
                return null;

            }
            else
            {
                return mail;
            }
        }
        private void SendOtpButton_Click(object sender, EventArgs e)
        {
            try
            {
                string email = ValidEmailCheck(MailTextBox.Text);
                if(email!=null)
                {

                    string userEmail = MailTextBox.Text;
                    currentOtp = GenerateOTP();
                    SendOtpToEmail(userEmail, currentOtp);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        public string ValidOtp(string otp)
        {
            string OtpN= OTPTextBox.Text;
            if (OtpN.Length!=6)
            {
                MessageBox.Show("Please Enter Valid OTP");
                return null;
            }
            else
            {
                return OtpN;
            }

        }
        private void VerifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                string o = ValidOtp(OTPTextBox.Text);
                if(o!=null)
                {
                    if (OTPTextBox.Text == currentOtp)
                    {

                        MessageBox.Show("YOUR OTP CORRECT");
                        UserIdLabel.Visible = true;
                        IdtextBox.Visible = true;
                        SecurityAnswerLabel.Visible = true;
                        SecurityTextbox.Visible = true;
                        NewPasswordLabel.Visible = true;
                        NewpasswordTextbox.Visible = true;
                        EmailLabel.Visible = false;
                        MailTextBox.Visible = false;
                        OTPLabel.Visible = false;
                        OTPTextBox.Visible = false;
                        VerifyButton.Visible = false;
                        SendOtpButton.Visible = false;

                        MessageBox.Show("Now Fill Up The Next Answer");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Your OTP Try Again Later");
                        this.Hide();
                        LoginForm lf = new LoginForm();
                        lf.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string userId = IdtextBox.Text.Trim();
            string securityAnswer = SecurityTextbox.Text.Trim();
            string newPassword = NewpasswordTextbox.Text.Trim();

            LoginController lc = new LoginController();
            Login login = lc.UserValidate(userId, securityAnswer);
            if (login != null)
            {


                login.Password = newPassword;
                lc.UpdatePassword(login);
                MessageBox.Show("Password Reset Successfull");
            }
            else
            {
                MessageBox.Show("Please Fill Up Answer Correctly");
            }
            IdtextBox.Clear();
            SecurityTextbox.Clear();
            NewpasswordTextbox.Clear();

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            UserIdLabel.Visible = false;
            IdtextBox.Visible = false;
            SecurityAnswerLabel.Visible = false;
            SecurityTextbox.Visible = false;
            NewPasswordLabel.Visible = false;
            NewpasswordTextbox.Visible = false;
            passwordCheckBox.Visible = false;
        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckBox.Checked == true)
            {
                NewpasswordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                NewpasswordTextbox.UseSystemPasswordChar = true;
            }
        }

       
    }
}
