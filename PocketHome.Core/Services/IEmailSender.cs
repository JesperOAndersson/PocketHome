﻿using System.Threading.Tasks;

namespace PocketHome.Core.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
