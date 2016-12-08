using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace FeedBackSystem
{
    public partial class ReportIssue : UserControl
    {
        public ReportIssue()
        {
            InitializeComponent();
            NameText.Text = Reviewer.Name;
            EmailText.Text = Reviewer.Email;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SubjectText.Text) || String.IsNullOrEmpty(BodyText.Text))
            {
                MessageBox.Show("Subject or body cannot be empty!", "Missing value");
                return;
            }

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("happytechfeedbacksystem@gmail.com");
                mail.Subject = SubjectText.Text;

                mail.To.Add(new MailAddress("happytechfeedbacksystem@gmail.com"));
                mail.Body = BodyText.Text + "\n\n Reported by: " + NameText.Text + "\nContact via: " + EmailText.Text;

                SmtpServer.Port = 587;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("happytechfeedbacksystem@gmail.com", "happytech123");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            } catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Unable to send mail");
            }
            MessageBox.Show("Issue succesfully reported!");

            //clear the contents
            SubjectText.Text = "";
            BodyText.Text = "";
        }
    }
}
