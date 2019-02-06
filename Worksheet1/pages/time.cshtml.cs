using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Worksheet1.pages
{
    public class timeModel : PageModel
    {
        public string Message { get; set; } = "";

        public string[] DaysArray { get; set; } = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        [BindProperty]
        public bool[] ChosenDay { get; set; } = new bool[7];


        [BindProperty]
        public bool[] MonthChosen { get; set; } = new bool[5];

        public string[] MonthList { get; set; } = { "January", "February", "March", "April", "May" };

        [BindProperty]
        public string[] ChosenMonths { get; set; } = { };

        public void OnGet()
        {

        }

        public void OnPost( )
        {
           
           
        }
    }
}