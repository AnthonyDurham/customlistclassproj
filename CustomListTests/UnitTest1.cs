using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OneValueToEmptyCustomList_CountOfAddedValue()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(value1);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_FourValuesToEmptyCustomList_CountOfAddedValues()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int value4 = 40;

            int expected = 4;
            int actual;

            // act

            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_OneValueToEmptyCustomList_CheckCapacity()
        {

            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int expected = 4;
            int actual;


            //act
            testList.Add(value1);
            actual = testList.Capacity;


            //asert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_SixValuesToEmptyCustomList_CheckCapacity()
        {

            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int value4 = 40;
            int value5 = 50;
            int value6 = 60;
            int expected = 8;
            int actual;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            testList.Add(value6);

            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }
        

        [TestMethod]
        public void Add_ThreeValues_CheckIndexZero()
        {

            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int expected = 10;
            int actual;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ThreeValues_CheckIndexOne()
        {

            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int expected = 20;
            int actual;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        // REMOVE METHODS

             [TestMethod]
        public void Remove_OneValueToEmptyCustomList_CountOfAddedValue()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int expected = 0;
            int actual;

            // act
            testList.Add(value1);
            testList.Remove(value1);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneValueToEmptyCustomList_CountOfAddedValues()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int value4 = 40;

            int expected = 3;
            int actual;

            // act

            testList.Add(value1);
            testList.Add(value2);
            testList.Remove(value2);
            testList.Add(value3);
            testList.Add(value4);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneValueToEmptyCustomList_CheckCapacity()
        {

            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int expected = 4;
            int actual;


            //act
            testList.Add(value1);
            testList.Remove(value1);
            actual = testList.Capacity;


            //asert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_OneValuesToEmptyCustomList_CheckCapacity()
        {

            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int value4 = 40;
            int value5 = 50;
           
            int expected = 4;
            int actual;

            //act
            testList.Add(value1);
            testList.Remove(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            

            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneValue_CheckIndexZero()
        {

            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int expected = 20;      
            int actual;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(value1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneeValues_CheckIndexOne()
        {

            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int expected = 30;
            int actual;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Remove(value2);
            testList.Add(value3);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}

