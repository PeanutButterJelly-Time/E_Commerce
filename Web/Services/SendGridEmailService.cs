﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using SendGrid;
using System.Text.RegularExpressions;
using SendGrid.Helpers.Mail;

namespace Web.Services
{
    public interface IEmailService
    {
        public async Task SendEmail(string toEmail, string subject, string htmlContent);
    }

    public class SendGridEmailService : IEmailService
    {
        private readonly IConfiguration configuration;

        public SendGridEmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task SendEmail(string toEmail, string subject, string htmlContent)
        {
            var apiKey = configuration["SendGrid:Key"];
            var client = new SendGridClient(apiKey);

            var fromEmail = configuration["SendGrid:FromEmail"];
            var from = new EmailAdress(fromEmail);

            var to = new EmailAdress(toEmail);

            var textContent = Regex.Replace(htmlContent, "<[^>]+>", "");
            var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlContent);

            var response = await client.SendEmailAsync(msg);
        }

        public TaskTemp()
        {
            var apiKey = Environment.GetEnvironmentVariable("NAME_OF_THE_ENVIRONMENT_VARIABLE_FOR_YOUR_SENDGRID_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("test@example.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("test@example.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
