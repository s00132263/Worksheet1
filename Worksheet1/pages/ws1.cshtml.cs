﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Worksheet1.pages
{
    public class ws1Model : PageModel
    {

        public string[] MyTestArray { get; set; } = { "England", "Ireland", "Scotland", "Wales" };

        public string Message { get; set; }

        [BindProperty]
        public string Name { get; set; }



        public void OnGet()
        {
            Message = "Hello World from the Get method";
        }

        public void OnPost()
        {
            Message = $"Hello {Name}";
        }
    }


}