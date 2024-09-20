using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Lab_4.Pages
{
    public class MindSyncPremiumModel : PageModel
    {
        private readonly ILogger<MindSyncPremiumModel> _logger;

        public MindSyncPremiumModel(ILogger<MindSyncPremiumModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string Name { get; set; } = string.Empty;

        [BindProperty]
        public int SerialNumber { get; set; }

        [BindProperty]
        public string CreditCard { get; set; } = string.Empty;

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            _logger.LogInformation("Form submitted with Name: {Name}, SerialNumber: {SerialNumber}, CreditCard: {CreditCard}", Name, SerialNumber, CreditCard);

            return RedirectToPage("Success");
        }
    }
}
