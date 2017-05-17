using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstFoodSupplierCollection
    {
        [TestMethod]
        public void InstancePatientCollectionOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplierCollection TestPatientCollection = new clsFoodSupplierCollection();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestPatientCollection);
        }
    }
}
