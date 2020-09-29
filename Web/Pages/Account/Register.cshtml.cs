using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return LocalRedirect("~/");
            }
            return Page();
        }

        [BindProperty]
        public RegisterInput Input { get; set; }

        public class RegisterInput
        {
            [Required]
            [EmailAddress]

            public string Email { get; set; }

            [Required]
            [StringLength(100, MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare(nameof(Password))]
            public string ConfirmPassword { get; set; }
        }
    }
}
