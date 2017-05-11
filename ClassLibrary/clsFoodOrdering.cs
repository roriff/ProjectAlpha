using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsFoodOrdering
    {
        //private data member for the FoodID property
        private Int32 foodOrderingId;
        //private data member for the FoodID property
        private string restaurantID;

            public int FoodOrderingID { get; set; }
            public int RestaurantID { get; set; }

        public bool Valid(string SomeFoodOrdering)
        {
            //if the name of the food is not blank
            if (SomeFoodOrdering != "")
            {
                //return true
                return true;
            }
            else
            //otherwise return false
            {
                //return false
                return false;
            }

        }
    }
}