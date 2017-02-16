using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsWard
    {
        private int wardNo;
        private string wardName;


        public int WardNo { get { return wardNo; } set { wardNo = value; } }
        public string WardName { get { return wardName; } set { wardName = value; } }
        

        public bool ValidateWard(string WardName)
        {
            //boolean attribute to indicate that everything is OK
            Boolean OK = true;
            //if the name of the county is blank
            if (WardName == "")
            {
                // show an error
                OK = false;
            }
            //if the name of the ward is more than 20 characters
            if (WardName.Length > 20)
            {
                //show an error
                OK = false;
            }
            return OK;
        }
    }
}