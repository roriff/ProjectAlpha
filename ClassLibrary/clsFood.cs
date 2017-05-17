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
        //private data member for the FoodName property
        private string foodName;
        //private data member for the FoodPrice property
        private string foodPrice;
        //private data member for the Quantity property
        private string quantity;

        public int FoodID
        {

            get
            {
                //return the private data
                return foodId;
            }
            set
            {
                //set the value of the private data member
                foodId = value;
            }
        }
        public string FoodName
        {

            get
            {
                //return the private data
                return foodName;
            }
            set
            {
                //set the value of the private data member
                foodName = value;
            }
        }
        public string FoodPrice
        {

            get
            {
                //return the private data
                return foodPrice;
            }
            set
            {
                //set the value of the private data member
                foodPrice = value;
            }
        }
        public string Quantity
        {

            get
            {
                //return the private data
                return quantity;
            }
            set
            {
                //set the value of the private data member
                quantity = value;
            }
        }
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

        public void Find(int primaryKey)
        {
            throw new NotImplementedException();
        }
    }
}