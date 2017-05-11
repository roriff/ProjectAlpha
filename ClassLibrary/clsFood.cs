using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsFood
    {
        //private data member for the FoodID property
        private Int32 foodId;
        //private data member for the FoodID property
        private string foodName;
        //private data member for the CompanyEmailAddress property
        private string foodPrice;

        public string Food { get; set; }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public string FoodPrice { get; set; }
        public string Quantity { get; set; }

        public bool Valid(string SomeFood)
        {
            //if the name of the food is not blank
            if (SomeFood != "")
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