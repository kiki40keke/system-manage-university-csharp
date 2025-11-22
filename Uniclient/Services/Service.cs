using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;


namespace Services
{
  public  class Service
    {
      public bool verifyEmail(string emailCheck)
      {
          try
          {
              MailAddress mail = new MailAddress(emailCheck);
              return true;
          }
          catch (Exception e)
          {
              return false;
          }


      }
      public string sendEmail(string toEmail,string corp,string subject)
      {
          Random rand = new Random();
          int passcode = rand.Next(1000, 9999);


          MailMessage msg;
          string message = "";
          passcode.ToString();
          try
          {
              msg = new MailMessage();
              msg.From = new MailAddress("rosalvoricardo45@gmail.com");
              msg.Sender = new MailAddress("rosalvoricardo45@gmail.com");
              msg.To.Add(toEmail);
              msg.IsBodyHtml = true;
              msg.Subject = subject;
              
              msg.Body = corp;
              // login = new NetworkCredential("smtp.gmail.com",);

              SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
              smtp.UseDefaultCredentials = false;
              smtp.Credentials = new NetworkCredential("rosalvoricardo45@gmail.com", "hydzmvohzhrkjsjh");

              //smtp.DeliveryMethod = SmtpDeliveryMethod;
              smtp.EnableSsl = true;
              smtp.Send(msg);
              message = "email Envoyer";
          }
          catch (Exception e)
          {
              message = "erreur; " + e;

          }

          return message;


      }
     
    }
}
