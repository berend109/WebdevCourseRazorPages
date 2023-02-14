using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        public int FirstInput { get; set; }

       public void OnPost([FromForm] int input)
        {
            FirstInput = input;
        }
    }
}
