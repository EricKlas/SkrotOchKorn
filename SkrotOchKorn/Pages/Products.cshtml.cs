using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SkrotOchKorn.Pages
{
    public class ProductsModel : PageModel
    {
        public string Title { get; set; }
        public string[] ProductImg {  get; set; }
        public string[] ProductName { get; set; }
        public int[] ProductPrice { get; set; }
        public int[] HorsePower { get; set; }
        public int[] CarryCapcity { get; set; }
        public void OnGet()
        {
            ProductImg = new string[]
                        {
                "img/crane.jpg",
                "img/digger.jpg",
                "img/truck.jpg"
                        };

            ProductName = new string[]
            {
                "Lyftkran",
                "GrävMaskin",
                "Lastbil"
            };

            ProductPrice = new int[]
            {
                1000000,
                2000000,
                5000000
            };

            HorsePower = new int[]
            {
                600,
                1000,
                1600
            };

            CarryCapcity = new int[]
            {
                10000,
                6000,
                60000
            };

        }

    }
}
