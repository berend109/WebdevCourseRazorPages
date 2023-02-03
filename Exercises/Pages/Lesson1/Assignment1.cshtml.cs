using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        public int AddHomeScore { get; set; }
        public int AddAwayScore { get; set; }
        public int DecreaseHomeScore { get; set; }
        public int DecreaseAwayScore { get; set; }

        public int ResetScore { get; set; } = 0;

        public int HomeScore { get; set; } = 0;
        public int AwayScore { get; set; } = 0;

        public void OnGet()
        {
            if (Request.Cookies.ContainsKey("homeScore"))
            {
                HomeScore = Convert.ToInt32(Request.Cookies["homeScore"]);
            }

            if (Request.Cookies.ContainsKey("awayScore"))
            {
                AwayScore = Convert.ToInt32(Request.Cookies["awayScore"]);
            }

            if (Request.Query.ContainsKey("addHomeScore"))
            {
                AddHomeScore = Convert.ToInt32(Request.Query["addHomeScore"].First());
                HomeScore++;
                Response.Cookies.Append("homeScore", HomeScore.ToString());
            }

            if (Request.Query.ContainsKey("addAwayScore"))
            {
                AddAwayScore = Convert.ToInt32(Request.Query["addAwayScore"].First());
                AwayScore++;
                Response.Cookies.Append("awayScore", AwayScore.ToString());
            }

            if (Request.Query.ContainsKey("decreaseHomeScore"))
            {
                DecreaseHomeScore = Convert.ToInt32(Request.Query["decreaseHomeScore"].First());
                HomeScore--;
                Response.Cookies.Append("homeScore", HomeScore.ToString());
            }

            if (Request.Query.ContainsKey("decreaseAwayScore"))
            {
                DecreaseAwayScore = Convert.ToInt32(Request.Query["decreaseAwayScore"].First());
                AwayScore--;
                Response.Cookies.Append("awayScore", AwayScore.ToString());
            }

            if (Request.Query.ContainsKey("resetScore"))
            {
                // maakt de score weer 0 en verwijder de cookies
                HomeScore = 0;
                AwayScore = 0;
                Response.Cookies.Delete("homeScore");
                Response.Cookies.Delete("awayScore");
            }
        }
    }
}
