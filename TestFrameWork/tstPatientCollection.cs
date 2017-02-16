using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstPatientCollection
    {
        [TestMethod]
        public void InstancePatientCollectionOK()
        {
            //create an instance of the class we want to create
            clsPatientCollection TestPatientCollection = new clsPatientCollection();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestPatientCollection);
        }
    }
}
