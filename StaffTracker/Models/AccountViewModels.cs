using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StaffTracker.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile_No { get; set; }

        [Required]
        [Display(Name = "Medical Conditions")]
        public string Medical_Conditions { get; set; }

        [Required]
        [MinLength(12, ErrorMessage = "The {0} must be 12 characters long.")]
        [Display(Name = "DBS Certificate Number")]
        public string DBS_No { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "DBS Clearance Date")]
        public DateTime DBS_Clearance_Date { get; set; }

        [Required]
        [Display(Name = "Lifeguard Qualification")]
        public string Lifeguard_Qualification { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Lifeguard Qualification Expiry Date")]
        public DateTime Lifeguard_Qualification_Expiry_Date { get; set; }

        [Required]
        [Display(Name = "Teaching Qualification")]
        public string Teaching_Qualification { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Teaching Qualification Expiry Date")]
        public DateTime Teaching_Qualification_Date { get; set; }

        public RegisterViewModel()
        {
            Email = "snix99@ntlworld.com";
            Password = "Elephant!2£";
            ConfirmPassword = "Elephant!2£";
            FullName = "Nick Gibson";
            Address = "123 Any Street";
            Mobile_No = "07777 123123";
            Medical_Conditions = "No Medical Conditions";
            DBS_No = "0123456789012";
            Lifeguard_Qualification = "Baywatch";
            Teaching_Qualification = "Grange Hill";
        }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
