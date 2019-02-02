using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Worksheet1.pages
{
    public class WS1bModel : PageModel
    {

        public string Message { get; set; }

        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int Number2 { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            Message = $"{Number1} + {Number2} = {Number1 + Number2}";
        }
    }
}