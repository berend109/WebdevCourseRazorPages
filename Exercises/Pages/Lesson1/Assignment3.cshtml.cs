using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        public int Input { get; set; }

        public void OnPost([FromForm] int input)
        {
            Input = input;
        }
    }
}
