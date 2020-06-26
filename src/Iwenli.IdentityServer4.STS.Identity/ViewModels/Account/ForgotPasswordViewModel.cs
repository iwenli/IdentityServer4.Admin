using System.ComponentModel.DataAnnotations;

namespace Iwenli.IdentityServer4.STS.Identity.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}






