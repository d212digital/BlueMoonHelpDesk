using System.ComponentModel.DataAnnotations;

namespace BlueMoonHelpDesk.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

}
