using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiringProcess.Emails
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmailOptions);
    }
}
