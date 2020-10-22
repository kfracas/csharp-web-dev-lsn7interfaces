using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            int difference = x.Allergens.Count - y.Allergens.Count;
            if (difference < 0)
                return -1;
            if (difference > 0)
                return 1;
            else
                return 0;
        }
    }
}
