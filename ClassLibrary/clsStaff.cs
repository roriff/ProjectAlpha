using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private variables
        private Int32 staffID;

        //Now we de-encapsulate them variables by creating the variables individual public property making them public
        public Int32 StaffID { get { return staffID; } set { staffID = value; } }


    }
}