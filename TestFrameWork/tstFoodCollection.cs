using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstFoodCollection
    {
        [TestMethod]
        public void InstanceObservationCollectionOK()
        {
            //create an instance of the class we want to create
            clsFoodCollection TestFoodCollection = new clsFoodCollection();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestFoodCollection);
        }
    }
}
