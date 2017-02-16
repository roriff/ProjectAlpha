using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceStaffCollectionOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection TestStaffCollection = new clsStaffCollection();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestStaffCollection);
        }
    }
}
