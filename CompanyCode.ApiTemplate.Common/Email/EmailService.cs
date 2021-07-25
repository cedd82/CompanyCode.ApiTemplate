using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

using CompanyCode.ApiTemplate.Common.Configuration;
using CompanyCode.ApiTemplate.Common.ErrorMessages;
using CompanyCode.ApiTemplate.Common.Models;

using Microsoft.Extensions.Logging;

namespace CompanyCode.ApiTemplate.Common.Email
{
    public class EmailService : IEmailService
    {
        private readonly CommonAppSettings _commonAppSettings;
        private readonly EmailSettings _emailSettings;
        private readonly ILogger<EmailService> _logger;
        
        public EmailService(EmailSettings emailSettings, CommonAppSettings commonAppSettings, ILogger<EmailService> logger)
        {
            _emailSettings     = emailSettings;
            _logger            = logger;
            _commonAppSettings = commonAppSettings;
        }

        public Result SendEmail(string toEmailAddresses, string subject, string body, Attachment attachment = null)
        {
            string fromEmail = !string.IsNullOrEmpty(_emailSettings.FromEmail) ? _emailSettings.FromEmail : "au.sys@cevalogistics.com";
            string smtpServer = !string.IsNullOrEmpty(_emailSettings.SmtpServer) ? _emailSettings.SmtpServer : "cevasmtp";

            List<string> allEmails = toEmailAddresses.Split(new[] {";"}, StringSplitOptions.RemoveEmptyEntries).Select(e => e.ToLower()).ToList();
            List<string> cevaEmails = allEmails.Where(e => e.Contains("@cevalogistics.com")).ToList();
            List<string> emailsToSend = _commonAppSettings.EnvironmentName == "Production" ? allEmails : cevaEmails;

            try
            {
                using SmtpClient mailClient = new(smtpServer);
                using MailMessage message = new();
                foreach (string address in emailsToSend)
                {
                    message.To.Add(address);
                }

                MailAddress fromMail = new(fromEmail);
                message.From    = fromMail;
                message.Subject = subject;
                message.Body    = body;
                if (attachment != null)
                    message.Attachments.Add(attachment);

                mailClient.Send(message);
            }
            catch (Exception exception)
            {
                _logger.LogCritical(exception, "Unable to send email");
                return Result.Fail(CommonErrorMessages.UnableToSendEmail);
            }

            return Result.Ok();
        }

        public void Send(string toEmailAddresses, string subject, string body, Attachment attachment = null)
        {
            string fromEmail = !string.IsNullOrEmpty(_emailSettings.FromEmail) ? _emailSettings.FromEmail : "au.sys@cevalogistics.com";
            string smtpServer = !string.IsNullOrEmpty(_emailSettings.SmtpServer) ? _emailSettings.SmtpServer : "cevasmtp";

            List<string> allEmails = toEmailAddresses.Split(new[] {";"}, StringSplitOptions.RemoveEmptyEntries).Select(e => e.ToLower()).ToList();
            List<string> cevaEmails = allEmails.Where(e => e.Contains("@cevalogistics.com")).ToList();
            List<string> emailsToSend = _commonAppSettings.EnvironmentName == "Production" ? allEmails : cevaEmails;

            try
            {
                using SmtpClient mailClient = new(smtpServer);
                using MailMessage message = new();
                foreach (string address in emailsToSend)
                {
                    message.To.Add(address);
                }

                MailAddress fromMail = new(fromEmail);
                message.From    = fromMail;
                message.Subject = subject;
                message.Body    = body;
                if (attachment != null)
                    message.Attachments.Add(attachment);

                mailClient.Send(message);
            }
            catch (Exception exception)
            {
                _logger.LogCritical(exception, "Unable to send email");
            }
        }

        public void SendErrorEmail(EmailDto emailDto)
        {
            SendErrorEmail(emailDto.Subject, emailDto.Body, emailDto.Attachment);
        }

        public void SendErrorEmail(string subject, string body, Attachment attachment = null)
        {
            if (!_emailSettings.SendErrorEmail)
                return;
            try
            {
                subject = $"ERROR: {_commonAppSettings.ApplicationName} : {subject}";
                subject = subject.Trim().Replace('\r', ' ').Replace('\n', ' ');
                subject = subject.Substring(0, Math.Min(subject.Length, 200));
                string recipients = _emailSettings.ErrorEmailRecipients;
                SendErrorEmail(recipients, subject, body, attachment);
            }
            catch (Exception exception)
            {
                _logger.LogCritical(exception, $"Unable to send error email Recipients {_emailSettings.ErrorEmailRecipients}");
            }
        }
        
        private void SendErrorEmail(string toEmailAddresses, string subject, string body, Attachment attachment = null)
        {
            string fromEmail = !string.IsNullOrEmpty(_emailSettings.FromEmail) ? _emailSettings.FromEmail : "au.sys@cevalogistics.com";
            string smtpServer = !string.IsNullOrEmpty(_emailSettings.SmtpServer) ? _emailSettings.SmtpServer : "cevasmtp";

            List<string> emailsToSend = toEmailAddresses.Split(new[] {";"}, StringSplitOptions.RemoveEmptyEntries).Select(e => e.ToLower()).ToList();
            using SmtpClient smtpClient = new(smtpServer);
            using MailMessage message = new();
            foreach (string address in emailsToSend)
            {
                message.To.Add(address);
            }

            MailAddress fromMail = new(fromEmail);
            message.From    = fromMail;
            message.Subject = subject;
            message.Body    = body;
            if (attachment != null)
                message.Attachments.Add(attachment);

            smtpClient.Send(message);
        }
    }
}