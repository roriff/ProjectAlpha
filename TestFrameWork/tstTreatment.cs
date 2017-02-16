using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstTreatment
    {
        [TestMethod]
        public void InstanceTreatmentOK()
        {
            //create an instance of the class we want to create
            clsTreatment TestTreatment = new clsTreatment();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestTreatment);
        }
    }
}
