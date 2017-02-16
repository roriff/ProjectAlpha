using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstObservationCollection
    {
        [TestMethod]
        public void InstanceObservationCollectionOK()
        {
            //create an instance of the class we want to create
            clsObservationCollection TestObservationCollection = new clsObservationCollection();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestObservationCollection);
        }
    }
}
