using System;

namespace Class_Library
{
    public class clsFoodSupplier
    {
        public clsFoodSupplier()
        {
        }

        public string FoodSupplier { get; set; }
        public string FoodSupplierAddress { get; set; }
        public string FoodSupplierCity { get; set; }
        public string FoodSupplierCounty { get; set; }
        public string FoodSupplierEmail { get; set; }
        public int FoodSupplierID { get; set; }
        public string FoodSupplierMobileNo { get; set; }
        public string FoodSupplierName { get; set; }
        public string FoodSupplierPhoneNo { get; set; }
        public string FoodSupplierPostCode { get; set; }
        public string FoodSupplierRegion { get; set; }

        public bool Valid(string SomeFoodSupplier)
        {
            //if the name of the Food Supplier is not blank
            if (SomeFoodSupplier != "")
            {
                //return true
                return true;
            }
            //otherwise return false
            else
            {
                //return false
                return false;
            }
        }
    }
}