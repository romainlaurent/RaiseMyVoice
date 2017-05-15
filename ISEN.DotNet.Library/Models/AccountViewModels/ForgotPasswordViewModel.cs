using System.ComponentModel.DataAnnotations;

namespace RaiseMyVoice.Library.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
