using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
        public void Add_Int_ToEndOfArray()
        {
            //Arrange
            MyList<int> list = new MyList<int>() { 1, 2, 3 };
            int addedValue = 4;
            //Act
            list.Add(addedValue);
            //Assert
            Assert.AreEqual(list[3], addedValue);
        }

        [TestMethod]
        public void Add_String_ToEndOfArray()
        {
            //Arrange
            MyList<string> list = new MyList<string>() { "one", "two", "three" };
            string addedValue = "four";
            //Act
            list.Add(addedValue);
            //Assert
            Assert.AreEqual(list[3], addedValue);
        }

        [TestMethod]
        public void Add_Double_ToEndOfArray()
        {
            //Arrange
            MyList<double> list = new MyList<double>() { 1.1, 2.2, 3.3 };
            double addedValue = 4.4;
            //Act
            list.Add(addedValue);
            //Assert
            Assert.AreEqual(list[3], addedValue);
        }

        [TestMethod]
        public void Add_Bool_ToEndOfArray()
        {
            //Arrange
            MyList<bool> list = new MyList<bool>() { false, false, false };
            bool addedValue = true;
            //Act
            list.Add(addedValue);
            //Assert
            Assert.AreEqual(list[3], addedValue);
        }

        [TestMethod]
        public void Add_Array_ToLastIndex()
        {
            //Arrange
            MyList<Array> myList = new MyList<Array>();
            int[] arrayToAdd = { 4, 5, 6 };
            //Act
            myList.Add(arrayToAdd);
            //Assert
            Assert.AreEqual(myList[0], arrayToAdd);
        }

        [TestMethod]
        public void Add_List_ToLastIndex()
        {
            //Arrange
            MyList<List> myList = new MyList<List>();
            int[] listToAdd = { 4, 5, 6 };
            //Act
            myList.Add(listToAdd);
            //Assert
            Assert.AreEqual(myList[0], listToAdd);
        }




    }
}

