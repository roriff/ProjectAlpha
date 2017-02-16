using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestStaff);
        }
    }
}
