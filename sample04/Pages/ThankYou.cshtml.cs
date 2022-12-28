using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample04.Pages
{
    [BindProperties(SupportsGet =true)]
    public class ThankYouModel : PageModel
    {
        public float baseprice { get; set; }

        public string ClothsCustomerName { get; set; }

        public string ClothsType { get; set; }

        public string ClothsSize { get; set; }

        public string ClothsBrand { get; set; }


        public void OnGet()
        {
        }
    }
}
