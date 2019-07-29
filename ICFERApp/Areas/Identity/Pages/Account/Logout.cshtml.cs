using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICFERApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NToastNotify;

namespace ICFERApp.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LogoutModel> _logger;
        private readonly IToastNotification _toastNotification;

        public LogoutModel(SignInManager<ApplicationUser> signInManager,
            ILogger<LogoutModel> logger,
            IToastNotification toastNotification
            )
        {
            _signInManager = signInManager;
            _logger = logger;
            _toastNotification = toastNotification;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            _toastNotification.AddInfoToastMessage("You have successfully logged out.");
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return Page();
            }
        }
    }
}