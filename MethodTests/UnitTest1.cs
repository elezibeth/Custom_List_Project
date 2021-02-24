using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Custom_List_Project;

namespace MethodTests
{
    [TestClass]
    public class UnitTest1
    {
        
        
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
                int actual = list.capacity;//capacity method

                //Assert
                Assert.AreNotEqual(expected, actual);
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
                int actual = list._items[4];
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
                int actual = list.count;
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
                int actual = list.count;
                //Assert
                Assert.AreEqual(expected, actual);
            }

        /// 

    }
        
}
