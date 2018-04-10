using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class UnitTest1
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

        [TestMethod]
        public void Remove_Int_FirstMatchingIntRemoved()
        {
            //Arrange
            MyList<int> intList = new MyList<int>() { 1, 0, 2, 0, 3 };
            int intitialValueAtIndexTwo = intList[2];
            //Act
            intList.Remove(0);
            //remove the first instance of value 0
            //expected result intList = [1, 2, 0, 3]
            //Assert
            Assert.AreEqual(intitialValueAtIndexTwo, intList[1]); //intList[1] = 2;
        }

        [TestMethod]
        public void Remove_Int_OtherMatchingIntsNotRemoved()
        {
            //Arrange
            MyList<int> intList = new MyList<int>() { 1, 0, 2, 0, 3 };

            //Act
            intList.Remove(0);
            int expectedResult = 0;
            //remove the first instance of value 0
            //expected result intList = [1, 2, 0, 3]
            //Assert
            Assert.AreEqual(intList[2], expectedResult); //intList[2] = 0;
        }

        [TestMethod]
        public void Remove_Bool_FirstMatchingBoolRemoved()
        {
            //Arrange
            MyList<bool> boolList = new MyList<bool>() { false, true, false, true, false };
            //Act
            boolList.Remove(true);
            //Assert
            Assert.AreEqual(boolList[1], false);
        }

        [TestMethod]
        public void Remove_Double_FirstMatchingDoubleRemoved()
        {
            //Arrange
            MyList<double> doubleList = new MyList<double>() { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //Act
            doubleList.Remove(2.2);
            //Assert
            Assert.AreEqual(doubleList[1], 3.3);
        }

        [TestMethod]
        public void Remove_Array_FirstMatchingArrayRemoved()
        {
            //Arrange
            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = new int[3] { 4, 5, 6 };
            int[] array3 = new int[3] { 7, 8, 9 };
            MyList<Array> arrayList = new MyList<Array>() { array1, array2, array3 };
            //Act
            arrayList.Remove(array2);
            //Assert
            Assert.AreEqual(arrayList[1], array3);
        }

        [TestMethod]
        public void Remove_CheckReturn_True()
        {
            //Arrange
            MyList<double> doubleList = new MyList<double>() { 1.1, 2.2, 3.3, 4.4, 5.5 };
            bool expectedReturnValue = true;
            //Act
            bool returnValue = doubleList.Remove(2.2);
            //Assert
            Assert.AreEqual(returnValue, expectedReturnValue);
        }

        [TestMethod]
        public void Remove_CheckReturn_False()
        {
            //Arrange
            MyList<double> doubleList = new MyList<double>() { 1.1, 2.2, 3.3, 4.4, 5.5 };
            bool expectedReturnValue = false;
            //Act
            bool returnValue = doubleList.Remove(2.3);
            //Assert
            Assert.AreEqual(returnValue, expectedReturnValue);
        }

        [TestMethod]
        public void Remove_Count_Decrememnts()
        {
            //Arrange
            MyList<int> intList = new MyList<int>() { 1, 0, 2, 0, 3 };
            //Act
            intList.Remove(0);
            //Assert
            Assert.AreEqual(intList.Count, 4);
        }

        //[TestMethod]
        //I want the custom list class to be iterable.
        //public void Remove_Count_Decrememnts()
        //{
        //    //Arrange
        //    MyList<int> intList = new MyList<int>() { 1, 0, 2, 0, 3 };
        //    //Act
        //    intList.Remove(0);
        //    //Assert
        //    Assert.AreEqual(intList.Count, 4);
        //}
        [TestMethod]
        public void ToString_Int_ToString()
        {
            //Arrange
            MyList<int> intList = new MyList<int>() { 1, 2, 3 };
            string expected = "123";
            //Act
            string result = intList.ToString();
            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void ToString_Bool_ToString()
        {
            //Arrange
            MyList<bool> boolList = new MyList<bool>() { true, false, true };
            string expected = "truefalsetrue";
            //Act
            string result = boolList.ToString();
            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void ToString_String_ToString()
        {
            //Arrange
            MyList<string> stringList = new MyList<string>() { "I'm", "a", "string!" };
            string expected = "I'mastring!";
            //Act
            string result = stringList.ToString();
            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void PlusOverload_AddIntMyLists_Combined()
        {
            //Arrange
            MyList<int> myList1 = new MyList<int>() { 1, 2, 3 };
            MyList<int> myList2 = new MyList<int>() { 4, 5, 6 };
            MyList<int> expected = new MyList<int>() { 1, 2, 3, 4, 5, 6 };
            //Act
            MyList<int> result = myList1 + myList2;
            //Assert
            Assert.AreEqual(expected[2], result[2]);
        }

        [TestMethod]
        public void PlusOverload_AddStringMyLists_Combined()
        {
            //Arrange
            MyList<string> myList1 = new MyList<string>() { "one", "two", "three" };
            MyList<string> myList2 = new MyList<string>() { "four", "five", "six" };
            MyList<string> expected = new MyList<string>() { "one", "two", "three", "four", "five", "six" };
            //Act
            MyList<string> result = myList1 + myList2;
            //Assert
            Assert.AreEqual(expected[2], result[2]);
        }

        [TestMethod]
        public void PlusOverload_AddBoolMyLists_Combined()
        {
            //Arrange
            MyList<bool> myList1 = new MyList<bool>() { true, false, true };
            MyList<bool> myList2 = new MyList<bool>() { false, true, false };
            MyList<bool> expected = new MyList<bool>() { true, false, true, false, true, false };
            //Act
            MyList<bool> result = myList1 + myList2;
            //Assert
            Assert.AreEqual(expected[3], result[3]);
        }

        [TestMethod]
        public void MinusOverload_SubtractIntLists_MatchValuesRemoved()
        {
            //Arrange
            MyList<int> myList1 = new MyList<int>() { 1, 2, 3, 4, 5, 6 };
            MyList<int> myList2 = new MyList<int>() { 1, 3, 5 };
            MyList<int> expected = new MyList<int>() { 2, 4, 6 };
            //Act
            MyList<int> result = myList1 - myList2;
            //Assert
            Assert.AreEqual(expected[2], result[2]);
        }

        [TestMethod]
        public void MinusOverload_SubtractStringMyLists_MatchValuesRemoved()
        {
            //Arrange
            MyList<string> myList1 = new MyList<string>() { "one", "two", "three", "four", "five", "six" };
            MyList<string> myList2 = new MyList<string>() { "one", "three", "five" };
            MyList<string> expected = new MyList<string>() { "two", "four", "six" };
            //Act
            MyList<string> result = myList1 - myList2;
            //Assert
            Assert.AreEqual(expected[2], result[2]);
        }

        [TestMethod]
        public void MinusOverload_SubtractBoolMyLists_MatchValuesRemoved()
        {
            //Arrange
            MyList<bool> myList1 = new MyList<bool>() { true, false, true, false, true };
            MyList<bool> myList2 = new MyList<bool>() { false, false };
            MyList<bool> expected = new MyList<bool>() { true, true, true };
            //Act
            MyList<bool> result = myList1 - myList2;
            //Assert
            Assert.AreEqual(expected[1], result[1]);
        }

        [TestMethod]
        public void Add_Count_Increments()
        {
            //Arrange
            MyList<int> list = new MyList<int>();
            int valueToAdd = 2018;
            int expectedLength = 1;
            //Act
            list.Add(valueToAdd);
            //Assert
            Assert.AreEqual(list.Count, expectedLength);
        }


    }
}

