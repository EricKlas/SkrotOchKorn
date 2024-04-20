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
            MainText1 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure molestias recusandae vero, a ab fuga aspernatur dicta quaerat libero ducimus? Fugit ea corporis dolores. Quaerat adipisci vel repellendus blanditiis accusantium?";

            MainTitle2 = "Kort om oss";
            MainText2 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Provident, commodi ipsa placeat minima praesentium amet distinctio aliquid, maiores architecto sapiente mollitia repellat. Minus molestias perferendis aut eligendi ut? Magni, rerum.";

        }
    }
}