  using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SkrotOchKorn.Pages
{
    public class IndexModel : PageModel
    {
        public string MainTitle1 { get; set; }
        public string MainTitle2 { get; set; }
        public string MainText1 { get; set; }
        public string MainText2 { get; set; }

        public void OnGet()
        {
            MainTitle1 = "Vi erbjuder";
            MainText1 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure molestias recusandae vero, a ab fuga\r\n                aspernatur dicta quaerat libero ducimus? Fugit ea corporis dolores. Quaerat adipisci vel repellendus\r\n                blanditiis accusantium?<";

            MainTitle2 = "Kort om oss";
            MainText2 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Provident, commodi ipsa placeat minima\r\n                praesentium amet distinctio aliquid, maiores architecto sapiente mollitia repellat. Minus molestias\r\n                perferendis aut eligendi ut? Magni, rerum.";
            
        }
    }
}
