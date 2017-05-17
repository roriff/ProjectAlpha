using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using Class_Library;

namespace TNovationTestFramework
{
    [TestClass]
    public class tstFoodCollection
    {
        [TestMethod]
        public void InstanceOK()

        {
            //create an instance of the class we want to create 
            clsFoodCollection AllFood = new clsFoodCollection();
            //test to see that it exists
            Assert.IsNotNull(AllFood);


        }

        [TestMethod]
        public void FoodListOK()
        {
            //create an instance of the class we want to create 
            clsFoodCollection AllFood = new clsFoodCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsFood> TestList = new List<clsFood>();
            //add an item to the list
            //create the item of the test data
            clsFood TestItem = new clsFood();
            //set its properties
            TestItem.FoodID = "1";
            TestItem.FoodName = "Steak";
            TestItem.FoodPrice = "£20";
            TestItem.Quantity = "2";
            //add the item to the item test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllFood.FoodList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFood.FoodList, TestList);
        }
        
        [TestMethod]
        public void ThisFoodPropertyOK()
        {
            //create an instance of the class we want to create 
            clsFoodCollection AllFood = new clsFoodCollection();
            //create some test data to assign to the property
            clsFood TestClient = new clsFood();
            //set the properties of the test object
            TestItem.FoodID = "1";
            TestItem.FoodName = "Steak";
            TestItem.FoodPrice = "£20";
            TestItem.Quantity = "2";
            //assign the data to the property
            AllFood.ThisFood = TestFood;
            //test to see that the two values are the same
            Assert.AreEqual(AllFood.ThisFood, TestFood);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsFoodCollection AllFood = new clsFoodCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsFood> TestList = new List<clsFood>();
            //add an item to the list
            //create the item of the test data
            clsFood TestItem = new clsFood();
            //set its properties
            TestItem.FoodID = "1";
            TestItem.FoodName = "Steak";
            TestItem.FoodPrice = "£20";
            TestItem.Quantity = "2";
            //add the item to the item test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllFood.FoodList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFood.Count, TestList.Count);

        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsFoodCollection AllFood = new clsFoodCollection();
            //create the item of the test data
            clsFood TestItem = new clsFood();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FoodID = "1";
            TestItem.FoodName = "Steak";
            TestItem.FoodPrice = "£20";
            TestItem.Quantity = "2";
            //set ThisAddress to the test data
            AllFood.ThisFood = TestItem;
            //add the record
            PrimaryKey = AllFood.Add();
            //set the primary key of the test data
            TestItem.FoodID = PrimaryKey;
            //find the record
            AllFood.ThisFood.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllFood.ThisFood, TestItem);

        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsFoodCollection AllFood = new clsFoodCollection();
            //create the item of the test data
            clsFood TestItem = new clsFood();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FoodID = "1";
            TestItem.FoodName = "Steak";
            TestItem.FoodPrice = "£20";
            TestItem.Quantity = "2";
            //set ThisAddress to the test data
            AllFood.ThisFood = TestItem;
            TestItem.FoodID = PrimaryKey;
            //find the record
            AllFood.ThisFood.Find(PrimaryKey);
            //delete the record
            AllFood.Delete();
            //now find the record
            Boolean Found = AllFood.ThisFood.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsFoodCollection AllFood = new clsFoodCollection();
            //create the item of the test data
            clsFood TestItem = new clsFood();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FoodID = "1";
            TestItem.FoodName = "Steak";
            TestItem.FoodPrice = "£20";
            TestItem.Quantity = "2";
            //set ThisAddress to the test data
            AllFood.ThisFood = TestItem;

            //set the primary key of the test data
            TestItem.FoodID = PrimaryKey;
            //modify the test data
            TestItem.FoodID = "1";
            TestItem.FoodName = "Steak";
            TestItem.FoodPrice = "£20";
            TestItem.Quantity = "2";
            //set the record based on new test data
            AllFood.ThisFood = TestItem;
            //update the record
            AllFood.Update();
            //find the record
            AllFood.ThisFood.Find(PrimaryKey);
            //test to see this address matches the test data
            Assert.AreEqual(AllFood.ThisFood, TestItem);
        }
    }
}
