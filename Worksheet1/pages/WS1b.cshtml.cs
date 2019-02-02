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

        public void OnPost(string firstname, int Number1, int Number2, string operation)
        {
            Message = $"{Number1} + {Number2} = {Number1 + Number2}";

            switch (operation)
            {
                case "plus":
                    Message = $"{Number1} plus {Number2} equals {Number1 + Number2}";
                    break;
                case "minus":
                    Message = $"{Number1} minus {Number2} equals {Number1 - Number2}";
                    break;
                case "multiply":
                    Message = $"{Number1} multipled by {Number2} equals {Number1 * Number2}";
                    break;
                case "divide":
                    float Num2 = (float)Number2; // necessary because result might not be an integer
                    Message = $"{Number1} divided by {Number2} equals {Number1 / Num2}";
                    break;
            }
        }
    }
}