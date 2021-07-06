using BlueMoonHelpDesk.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueMoonHelpDesk.Services
{
    public interface IEmailSender
    {

        Task SendEmailAsync(string email, string v1, string v2);
    }
}