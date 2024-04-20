using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.Intrinsics.X86;
using static System.Net.WebRequestMethods;

namespace SkrotOchKorn.Pages
{
    public class MediaPageModel : PageModel
    {
        public string MainTitle { get; set; }
        public string[] MediaTitle { get; set; }
        public VideoLink[] MediaLink { get; set; }
        public class VideoLink
        {
            public string Url { get; set; }
            public string Title { get; set; }
            public string FrameBorder { get; set; }
            public string Allow { get; set; }
            public string AllowFullScreen { get; set; }
        }

        public void OnGet()
        {
            MainTitle = "Här har vi videos och bilder på våra maskiner i arbete";

            MediaTitle = new string[]
            {
                "Här kan vi see en bulldozer i arbete",
                "Här så kan vi se en grävmaskin arbeta",
                "Här så lyfter en kran en annan kran"
            };

            MediaLink = new VideoLink[]
            {
            new VideoLink
            {
                Url = "https://www.youtube.com/embed/hJIBp98DztA?si=ftNjbOyVcilr2EBL",
                Title = "Youtube video player",
                FrameBorder = "0",
                Allow = "accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture",
                AllowFullScreen = "true"
            },
            new VideoLink
            {
                Url = "https://www.youtube.com/embed/2lDcyfgIJLs?si=tudco8y8Ft1rcHgl",
                Title = "Youtube video player",
                FrameBorder = "0",
                Allow = "accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture",
                AllowFullScreen = "true"
            },
            new VideoLink
            {
                Url = "https://www.youtube.com/embed/MqQ1-5VkNz8?si=PxEmT08esGUExB_E",
                Title = "Youtube video player",
                FrameBorder = "0",
                Allow = "accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture",
                AllowFullScreen = "true"
            }
            };
        }
    }
}
    


