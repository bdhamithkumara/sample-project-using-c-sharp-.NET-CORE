using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sample04.Model;

namespace sample04.Pages
{
    public class CustomOrderModel : PageModel
    {
        [BindProperty]

        public ClothsModelClass ClothsModelClassFrom { get; set; }
        // for the storing price
        public float baseprice { get; set; }

        public IActionResult OnPost()
        {

            baseprice = ClothsModelClassFrom.ClothsBasePrice;

            if(ClothsModelClassFrom.ClothsType == "tshirt")
            {
                baseprice += 150;
            }

            if (ClothsModelClassFrom.ClothsType == "sweater")
            {
                baseprice += 150;
            }

            if (ClothsModelClassFrom.ClothsType == "coat")
            {
                baseprice += 150;
            }

            if (ClothsModelClassFrom.ClothsType == "socks")
            {
                baseprice += 150;
            }

            if (ClothsModelClassFrom.ClothsType == "shorts")
            {
                baseprice += 150;
            }

            if (ClothsModelClassFrom.ClothsType == "tie")
            {
                baseprice += 150;
            }

            return RedirectToPage("/ThankYou", new { 
                baseprice, 
                ClothsModelClassFrom.ClothsCustomerName , 
                ClothsModelClassFrom.ClothsType,
                ClothsModelClassFrom.ClothsSize,
                ClothsModelClassFrom.ClothsBrand,
            });
        }

        public void OnGet()
        {
        }
    }
}
