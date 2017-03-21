using System;

namespace ClassLibrary
{
    public class clsFoodPayment
    {
        public string FoodOrdering { get; set; }
        public string FoodPayment { get; set; }
        public string FoodPaymentAccountNumber { get; set; }
        public string FoodPaymentCardNumber { get; set; }
        public string FoodPaymentCardVerificationCode { get; set; }
        public string FoodPaymentExpiryDate { get; set; }
        public int FoodPaymentID { get; set; }
        public string FoodPaymentNameOnCard { get; set; }
        public string FoodPaymentSortCode { get; set; }
        public string FoodPaymentStaffID { get; set; }

        public bool Valid(string SomeFoodPayment)
        {
            //if the name of the food payment is not blank
            if (SomeFoodPayment != "")
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