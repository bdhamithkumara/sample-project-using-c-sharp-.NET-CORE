using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sample04.Model;

namespace sample04.Pages
{
    public class ProductsModel : PageModel
    {

        public List<ClothsModelClass> FromClothsModel = new List<ClothsModelClass>()
        {
            new ClothsModelClass() {
                ClothsNameForDisplay= "tshirt",
                ClothsSizeForDisplay="M",
                ClothsPriceForDisplay=150,
                ClothsImageNameForDisplay="tshirt"},

            new ClothsModelClass() {
                ClothsNameForDisplay= "sweater",
                ClothsSizeForDisplay="S",
                ClothsPriceForDisplay=251,
                ClothsImageNameForDisplay="sweater"},

            new ClothsModelClass() {
                ClothsNameForDisplay= "coat",
                ClothsSizeForDisplay="L",
                ClothsPriceForDisplay=240,
                ClothsImageNameForDisplay="coat"},

            new ClothsModelClass() {
                ClothsNameForDisplay= "socks",
                ClothsSizeForDisplay="XL",
                ClothsPriceForDisplay=310,
                ClothsImageNameForDisplay="socks"},
            
            new ClothsModelClass() {
                ClothsNameForDisplay= "shorts",
                ClothsSizeForDisplay="M",
                ClothsPriceForDisplay=221,
                ClothsImageNameForDisplay="shorts"},
            
            new ClothsModelClass() {
                ClothsNameForDisplay= "tie",
                ClothsSizeForDisplay="S",
                ClothsPriceForDisplay=310,
                ClothsImageNameForDisplay="tie"},
        };

        public void OnGet()
        {
        }
    }
}











