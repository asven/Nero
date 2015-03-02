using Nero.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Nero.Controllers
{
    public class EmailController : Controller
    {
        //
        // GET: /Email/


        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(EmailUser emailUser)
        {
            SmtpClient client = new SmtpClient("s18227524.onlinehome-server.com");
            MailMessage message = new MailMessage();

            List<string> emailsToSendTo = ConfigurationManager.AppSettings["contactEmail"].ToString().Split(';').ToList();

            foreach (string email in emailsToSendTo.Where(etst => !string.IsNullOrEmpty(etst)).ToList())
            {
                message.To.Add(email);
            }

            
            message.From = new MailAddress("info@neroeng.com");
            message.Subject = "Contact form completed on neroeng.com";
            message.IsBodyHtml = true;

            StringBuilder html = new StringBuilder();
            html.Append("<table>");
            html.Append("<tr>");
            html.Append("<td>");
            html.Append("Name");
            html.Append("</td>");
            html.Append("<td>");
            html.Append(emailUser.Name);
            html.Append("</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>");
            html.Append("Email Address");
            html.Append("</td>");
            html.Append("<td>");
            html.Append(emailUser.EmailAddress);
            html.Append("</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>");
            html.Append("Message");
            html.Append("</td>");
            html.Append("<td>");
            html.Append(emailUser.Message);
            html.Append("</td>");
            html.Append("</tr>");
            html.Append("</table>");

            message.Body = html.ToString();

            client.Send(message);


            return View();
        }

    }
}
