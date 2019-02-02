using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Worksheet1.pages
{
    public class ws1Model : PageModel
    {
        public void OnGet()
        {
            Message = "GET METHOD!";
        }

        public string[] MyTestArray { get; set; } = { "England", "Ireland", "Scotland", "Wales" };
        public string Message { get; set; }

        public void OnPost(int number1)
        {
           Message = string.Format("POST METHOD, number was {0}",number1);
        }
    }


}