using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SkrotOchKorn.Pages
{
    public class ContactUsModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Adress { get; set; }
        [BindProperty]
        public string Telephone { get; set; }
        [BindProperty]
        public string UserType { get; set; }
        public string[] UserTypes { get; set; } = ["Privatperson", "Företag"];
        [BindProperty]
        public string Size{ get; set; }
        public string[] Sizes { get; set; } = ["1-10", "11-50", "51-100", "101-500", "500+"];
        [BindProperty]
        public string Message { get; set; }
        [BindProperty]
        public string Newsletter { get; set; }
        [BindProperty]
        public bool ContactOverPhone { get; set; }

        public void OnGet()
        {

        }
    }
}
