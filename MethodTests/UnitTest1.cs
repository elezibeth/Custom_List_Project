﻿using Custom_List_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodTests
{
    [TestClass]
    public class UnitTest1
    {

        //test user story any type of data in array 1. ints
        [TestMethod]
        public void ConfrimCapacityIncrease()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            // We are going to add five items
            // Initial capacity is 4 but by the time the fifth items is added,
            // we expect the capacity to double to 8
            int expected = 8;

            //Action

            // At this point - Count: 0, Capacity: 4
            list.Add(2);
            // At this point - Count: 1, Capacity: 4
            list.Add(4);
            // At this point - Count: 2, Capacity: 4
            list.Add(3);
            // At this point - Count: 3, Capacity: 4
            list.Add(3);
            // At this point - Count: 4, Capacity: 4

            // The next line will add the fifth item
            list.Add(1);
            // At this point - Count: 5, Capacity: 8
            // Capacity is the property that we use to check the internal array size
            int actual = list.Capacity;//capacity method

            //Assert
            Assert.AreEqual(expected, actual);
            }
        [TestMethod]
            public void TestForItemsAtNewCapacityLevel()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 88;
            //Action
            list.Add(5);//1st item
            list.Add(4);//2nd item
            list.Add(3);//3rd item
                list.Add(2);//4th item
                list.Add(88);//5th item, over capacity, new array created.
                int actual = list[4];
            //This test checks for that; initially the capacity is eight, 
            //when we add the fifth item, and it is transfered, the capacity should double; if it did not increment, we would not have a value at [4].

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void AddOne_CheckCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
                //Action
                list.Add(4);
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

            [TestMethod]

        public void CountAccurateAfterCapactiyIncrease()//
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 5;
                //Action
                list.Add(4);
            list.Add(4);
            list.Add(4);
            list.Add(4);
            list.Add(4);
            int actual = list.Count;
                //Assert
                Assert.AreEqual(expected, actual);
        }
        //user story any data type in array 2. bool data type
        [TestMethod]
        public void TestTwoCapacityIncreasesForAccurateTranfer()
        {
            //Arrange
            CustomList<bool> list = new CustomList<bool>();
            bool expected = false;

            //Action
            list.Add(true);
            list.Add(false);//expected at recall
            list.Add(true);
            list.Add(false);
            //first capacity increase next
            list.Add(true);
            list.Add(false);
            list.Add(true);
            list.Add(false);
            //second capacity increase next
            list.Add(true);
            list.Add(false);
            list.Add(true);
            list.Add(false);//12th item at index 11 on list._items
            bool actual = list[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// Count property tests
        [TestMethod]
        public void CountisAProperty()
        {
            //Assemble
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            //Action
            list.Add(3);
            
            int actual = list.Count;



            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod] will not run because list.Count is read only


        //public void CountPropertyIsReadOnly()
        //{
        //    //Assemble
        //    CustomList<int> list = new CustomList<int>();
        //    int expected = 1;

        //    //Action
        //    list.Count = 4;




        //    int actual = list.Count;



        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //remove tests

        [TestMethod]

        public void TestCountAfterItemRemoved()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 0;


            list.Add(4);
            list.Remove(4);
            int actual = list.Count;

            Assert.AreEqual(expected, actual);
        }
        //user story any data type in array 3. string 
        [TestMethod]
        public void IndexContentAtIndexRemoved()
        {
            CustomList<string> list = new CustomList<string>();
            string expected = "Nice";

            list.Add("hello");
            list.Add("Nice");
            list.Add("See");
            list.Remove("hello");
            string actual = list[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCapacityAfterItemsRemoved()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 8;

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            //capacity should increase to 8
            list.Add(5);
            list.Remove(4);
            //capacity should not decrease
            int actual = list.Capacity;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CountDecreasesWhenItemsRemoved()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 4;

            list.Add(4);
            list.Add(5);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Remove(7);
            int actual = list.Count;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void RemovesOnlyOneInstance()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 1;


            list.Add(9);
            list.Add(9);
            list.Remove(9);
            int actual = list.Count;

            Assert.AreEqual(expected, actual);

        }
        //test indexer
        //add, remove, retrieve at
        //user story any data type in array 4 char
        [TestMethod]
        public void AddAtIndexNumber()
        {
            //Arrange
            CustomList<char> list = new CustomList<char>();
            char expected = 'x';

            //Action
            list.Add('r');
            list[1] = 'x';
            char actual = list[1];

            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void RemoveAtIndexNumber()//also tests retrieve at index number
        {
            CustomList<string> list = new CustomList<string>();
            string expected = "No";

            list.Add("hi");
            list.Add("Hello");
            list.Add("No");
            list.Remove(list[2]);
            string actual = list[2];

            Assert.AreEqual(expected, actual);

        }
        //[TestMethod]
        //public void RetrieveAtIndexNumber()
        //{


        //}
        //overload + / - operators

        [TestMethod]
        public void TestOverloadPlusOperator()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();
            int expected = 3;



            //Action
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(4);

            listTwo.Add(8);
            listTwo.Add(7);
            listTwo.Add(5);

            listThree = listTwo + listOne;
            int actual = listThree[5];

            //Assert
            Assert.AreEqual(expected, actual);


        }

        //[TestMethod]
        //public void TestMinusOverloadOperator()
        //{
        //    CustomList<string> listOne = new CustomList<string>();
        //    CustomList<string> listTwo = new CustomList<string>();
        //    CustomList<string> listThree = new CustomList<string>();
        //    CustomList<string> listFour = new CustomList<string>();


        //    //Action
        //    listOne.Add("Hello");
        //    listOne.Add("Hi");
        //    listOne.Add("Hey");

        //    listTwo.Add("What's up?");
        //    listTwo.Add("How are you?");
        //    listTwo.Add("How's it goin'?");

        //    listThree = listTwo + listOne;
        //    listFour = listThree - listTwo;
        //    string actual = listFour[4];


        //    Assert.IsNull(actual);

        //}
        //[TestMethod]
        //public void TestAssignmentOperatorWithOverloadOperator()
        //{
        //    CustomList<string> listOne = new CustomList<string>();
        //    CustomList<string> listTwo = new CustomList<string>();
        //    CustomList<string> listThree = new CustomList<string>();



        //    //Action
        //    listOne.Add("Hello");
        //    listOne.Add("Hi");
        //    listOne.Add("Hey");

        //    listTwo.Add("What's up?");
        //    listTwo.Add("How are you?");
        //    listTwo.Add("How's it goin'?");

        //    listThree = listTwo + listOne;
        //    listThree = listThree - listTwo;
        //    string actual = listThree[4];


        //    Assert.IsNull(actual);

        //}
        //capacity increase
        [TestMethod]
        public void TestCapacityIncrease()
        {
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();
            CustomList<string> listThree = new CustomList<string>();
            int expected = 8;


            //Action
            listOne.Add("Hello");
            listOne.Add("Hi");
            listOne.Add("Hey");

            listTwo.Add("What's up?");
            listTwo.Add("How are you?");
            listTwo.Add("How's it goin'?");

            listThree = listTwo + listOne;

            int actual = listThree.Capacity;


            Assert.AreEqual(expected, actual);

        }
        //count increase
        [TestMethod]
        public void TestAssignmentOperatorCount()
        {
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();
            CustomList<string> listThree = new CustomList<string>();
            int expected = 8;


            //Action
            listOne.Add("Hello");
            listOne.Add("Hi");
            listOne.Add("Hey");

            listTwo.Add("What's up?");
            listTwo.Add("How are you?");
            listTwo.Add("How's it goin'?");

            listThree = listTwo + listOne;
            int actual = listThree.Count;


            Assert.AreEqual(expected, actual);

        }
        //user story any data type in array 5. double
        [TestMethod]
        public void TestDataTypeDoubleInArray()
        {
            CustomList<double> list = new CustomList<double>();
            double expected = 2.7;

            list.Add(2.7);
            double actual = list[0];

            Assert.AreEqual(expected, actual);

        }
        //entire list plus operator
        [TestMethod]
        public void TestOverloadPlusOperatorList()//tests to string method, as well

        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();
            CustomList<int> listFour = new CustomList<int>();

            



            //Action
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(4);

            listTwo.Add(8);
            listTwo.Add(7);
            listTwo.Add(5);

            listFour.Add(8);
            listFour.Add(7);
            listFour.Add(5);
            listFour.Add(0);
            listFour.Add(1);
            listFour.Add(3);
            listFour.Add(4);

            listThree = listTwo + listOne;
            string actual = listThree.ToString();
            string expected = listFour.ToString();

            //Assert
            Assert.AreEqual(actual, expected);


        }
        //entire list - operator
        //[TestMethod]
        //public void TestMinusOverloadOperatorList()
        //{
        //    //Arrange
        //    CustomList<int> listOne = new CustomList<int>();
        //    CustomList<int> listTwo = new CustomList<int>();
        //    CustomList<int> listThree = new CustomList<int>();
        //    CustomList<int> listFour = new CustomList<int>();

        //    expected = listTwo.ToString();



        //    //Action
        //    listOne.Add(1);
        //    listOne.Add(3);
        //    listOne.Add(4);

        //    listTwo.Add(8);
        //    listTwo.Add(7);
        //    listTwo.Add(5);



        //    listThree = listTwo + listOne;
        //    listFour = listThree - listOne;
        //    actual = listFour.ToString();

        //    //Assert
        //    Assert.AreEqual(expected, actual);

        //}



        //zipper tests
        //capacity increases
        //[TestMethod]
        //public void TestZipperCapacityIncrease()
        //{
        //    //Assble
        //    CustomList<int> listOne = new CustomList<int>();
        //    CustomList<int> listTwo = new CustomList<int>();
        //    CustomList<int> listThree = new CustomList<int>();
        //    int expected = 8;


        //    //Act
        //    listOne.Add(0);
        //    listOne.Add(2);
        //    listOne.Add(4);
        //    listTwo.Add(1);
        //    listTwo.Add(3);
        //    listTwo.Add(5);
        //    listThree = Zip(listOne, listTwo);
        //    int actual = listThree.Capacity;



        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //item at even index test
        //[TestMethod]///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //public void TestZipperAtEvenIndex()
        //{
        //    //Assble
        //    CustomList<int> listOne = new CustomList<int>();
        //    CustomList<int> listTwo = new CustomList<int>();
        //    CustomList<int> listThree = new CustomList<int>();
        //    int expected = 2;

        //    //Act
        //    listOne.Add(0);
        //    listOne.Add(2);
        //    listOne.Add(4);
        //    listTwo.Add(1);
        //    listTwo.Add(3);
        //    listTwo.Add(5);
        //    listThree.Zip(listOne, listTwo);
        //    int actual = listThree[2];

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //item at odd index test
        //[TestMethod]
        //public void TestZipperAtOddIndex()
        //{
        //    //Assble
        //    CustomList<int> listOne = new CustomList<int>();
        //    CustomList<int> listTwo = new CustomList<int>();
        //    CustomList<int> listThree = new CustomList<int>();

        //    int expected = 3;

        //    //Act
        //    listOne.Add(0);
        //    listOne.Add(2);
        //    listOne.Add(4);
        //    listTwo.Add(1);
        //    listTwo.Add(3);
        //    listTwo.Add(5);

        //    listThree = Zip(listOne, listTwo);
        //    int actual = listThree[3];

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //    }
        //count increase
        //[TestMethod]
        //public void TestZipperCountIncrease()
        //{
        //    //Assble
        //    CustomList<int> listOne = new CustomList<int>();
        //    CustomList<int> listTwo = new CustomList<int>();
        //    CustomList<int> listThree = new CustomList<int>();
        //    int expected = 6;
        //    //Act
        //    listOne.Add(0);
        //    listOne.Add(2);
        //    listOne.Add(4);
        //    listTwo.Add(1);
        //    listTwo.Add(3);
        //    listTwo.Add(5);
        //    listThree.Zip(listOne, listTwo);
        //    int actual = listThree.Count;
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //entire list comparer
        [TestMethod]
        public void TestZipperEntireListCompare()
        {
            //Assble
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();
            CustomList<int> listFour = new CustomList<int>();
           


            //Act
            listOne.Add(0);
            listOne.Add(2);
            listOne.Add(4);
            listTwo.Add(1);
            listTwo.Add(3);
            listTwo.Add(5);
            listThree = CustomList<int>.Zip(listOne, listTwo); //will output 8 chars to string
            listFour.Add(0);
            listFour.Add(1);
            listFour.Add(2);
            listFour.Add(3);
            listFour.Add(4);
            listFour.Add(5);//6.. will output 8 chars to string
            string expected = listFour.ToString();
            string actual = listThree.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //zip twice,  test capacity
        //capacity read only user story tested here also
        [TestMethod]
        public void TestCapacity_ZipperTwice()
        {
            //Assble
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();
            CustomList<int> listFour = new CustomList<int>();
            CustomList<int> listFive = new CustomList<int>();
            int expected = 16;


            //Act
            listOne.Add(0);
            listOne.Add(2);
            listOne.Add(4);
            listTwo.Add(1);//doubles to 8 on next
            listTwo.Add(3);//ct = 5
            listTwo.Add(5);//6
            listThree = CustomList<int>.Zip(listOne, listTwo);//should be 6
            listFour.Add(0);//1
            listFour.Add(1);//2
            listFour.Add(2);//3
            listFour.Add(3);//14
            listFour.Add(4);//15
            listFour.Add(5);//6 - capacity will be 8, but 
            listFive = CustomList<int>.Zip(listFour, listThree);//6 + 6
            int actual = listFive.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //indexer tests
        //retrieve
        //add
        //remove
        [TestMethod]
        public void Indexer_GetAt()
        {
            CustomList<bool> list = new CustomList<bool>();
            bool expected = false;


            list.Add(true);
            list.Add(false);
            list.Add(true);
            bool actual = list[1];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Indexer_AddAt()
        {
            CustomList<char> list = new CustomList<char>();
            char expected = 'a';


            list.Add('a');
            list.Add('c');
            list.Add('d');
            list[1] = 'a';
            char actual = list[1];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Indexer_RemoveAt()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 7;


            list.Add(3);
            list.Add(5);
            list.Add(7);
            list.Remove(list[1]);//filo, may fail
            int actual = list[1];

            Assert.AreEqual(expected, actual);
        }
        //iterable
        //[TestMethod]
        //public void ListIsIterable()
        //{

        //}
        //[TestMethod]
        //public void ToStringMethod()
        //{

        //}
        [TestMethod]
        public void CapacityIsAProperty()
        {
            CustomList<char> list = new CustomList<char>();
            int expected = 4;

            list.Add('I');
            int actual = list.Capacity;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestToStringMethod()
        {
            CustomList<bool> list = new CustomList<bool>();
            string expected = "TrueTrueTrueTrue";

            list.Add(true);
            list.Add(true);
            list.Add(true);
            list.Add(true);

            string actual = list.ToString();

            Assert.AreEqual(expected, actual);
        }



    }
        
}
