using System;

namespace Class_Library
{
    public class clsFoodSupplier
    {
        //private data member for the FoodID property
        private Int32 foodSupplierID;
        //private data member for the FoodSupplierName property
        private string foodSupplierName;
        //private data member for the FoodAupplierAddress property
        private string foodSupplierAddress;
        //private data member for the FoodSupplierPostCode property
        private string foodSupplierPostCode;
        //private data member for the FoodSupplierCity property
        private string foodSupplierCity;
        //private data member for the FoodSupplierCounty property
        private string foodSupplierCounty;
        //private data member for the FoodSupplierRegion property
        private string foodSupplierRegion;
        //private data member for the FoodSupplierPhoneNo property
        private string foodSupplierPhoneNo;
        //private data member for the FoodSupplierMobileNo property
        private string foodSupplierMobileNo;
        //private data member for the FoodSupplierEmail property
        private string foodSupplierEmail;

        public string FoodSupplierAddress
        {
            get
            {
                //return the private data
                return foodSupplierAddress;
            }
            set
            {
                //set the value of the private data member
                foodSupplierAddress = value;
            }
        }

        public string FoodSupplierCity
        {
            get
            {
                //return the private data
                return foodSupplierCity;
            }
            set
            {
                //set the value of the private data member
                foodSupplierCity = value;
            }
        }

        public string FoodSupplierCounty
        {
            get
            {
                //return the private data
                return foodSupplierCounty;
            }
            set
            {
                //set the value of the private data member
                foodSupplierCounty = value;
            }
        }

        public string FoodSupplierEmail
        {
            get
            {
                //return the private data
                return foodSupplierEmail;
            }
            set
            {
                //set the value of the private data member
                foodSupplierEmail = value;
            }
        }

        public int FoodSupplierID
        {
            get
            {
                //return the private data
                return foodSupplierID;
            }
            set
            {
                //set the value of the private data member
                foodSupplierID = value;
            }
        }

        public string FoodSupplierMobileNo
        {
            get
            {
                //return the private data
                return foodSupplierMobileNo;
            }
            set
            {
                //set the value of the private data member
                foodSupplierMobileNo = value;
            }
        }

        public string FoodSupplierName
        {
            get
            {
                //return the private data
                return foodSupplierName;
            }
            set
            {
                //set the value of the private data member
                foodSupplierName = value;
            }
        }

        public string FoodSupplierPhoneNo
        {
            get
            {
                //return the private data
                return foodSupplierPhoneNo;
            }
            set
            {
                //set the value of the private data member
                foodSupplierPhoneNo = value;
            }
        }

        public string FoodSupplierPostCode
        {
            get
            {
                //return the private data
                return foodSupplierPostCode;
            }
            set
            {
                //set the value of the private data member
                foodSupplierPostCode = value;
            }
        }

        public string FoodSupplierRegion
        {
            get
            {
                //return the private data
                return foodSupplierRegion;
            }
            set
            {
                //set the value of the private data member
                foodSupplierRegion = value;
            }
        }

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