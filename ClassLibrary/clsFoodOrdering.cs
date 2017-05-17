using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsFoodOrdering
    {
        //private data member for the FoodID property
        private Int32 foodOrderingID;
        //private data member for the FoodID property
        private Int32 restaurantID;

            public int FoodOrderingID
        {
            get
            {
                //return the private data
                return foodOrderingID;
            }
            set
            {
                //set the value of the private data member
                foodOrderingID = value;
            }
        }
        public int RestaurantID
        {
            get
            {
                //return the private data
                return restaurantID;
            }
            set
            {
                //set the value of the private data member
                restaurantID = value;
            }
        }

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