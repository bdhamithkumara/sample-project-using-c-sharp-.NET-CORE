using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample04.Model
{
    public class ClothsModelClass
    {
        public string ClothsNameForDisplay { get; set; }

        public string ClothsSizeForDisplay { get; set; }

        public float ClothsPriceForDisplay { get; set; }

        public string ClothsImageNameForDisplay { get; set; }

        //this is for custom order page

        public string ClothsCustomerName { get; set; }

        public string ClothsSize { get; set; }

        public string ClothsType { get; set; }

        public string ClothsBrand { get; set; }

        public float ClothsBasePrice { get; set; } = 100;
    }
}
