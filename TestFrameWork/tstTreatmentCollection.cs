using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstTreatmentCollection
    {
        [TestMethod]
        public void InstanceTreatmentCollectionOK()
        {
            //create an instance of the class we want to create
            clsTreatmentCollection TestTreatmentCollection = new clsTreatmentCollection();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestTreatmentCollection);
        }
    }
}
