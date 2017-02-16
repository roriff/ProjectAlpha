using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstWardCollection
    {
        [TestMethod]
        public void InstanceWardCollectionOK()
        {
            //create an instance of the class we want to create
            clsWardCollection TestWardCollection = new clsWardCollection();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestWardCollection);
        }
    }
}
