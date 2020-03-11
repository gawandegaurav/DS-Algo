using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class SinglyLinkedListTests
    {
        [TestMethod]
        public void CreateLinkedList()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();

            //Act
            linkedList.InsertAtBeginning(1); 

            // Assert
            Assert.AreEqual("1", linkedList.ToString());
        }

        [TestMethod]
        public void CreateLinkedList_InsertingAtBeginning()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();

            //Act
            linkedList.InsertAtBeginning(1);
            linkedList.InsertAtBeginning(2);
            linkedList.InsertAtBeginning(3);
            linkedList.InsertAtBeginning(4);
            linkedList.InsertAtBeginning(5);

            // Assert
            Assert.AreEqual("5->4->3->2->1", linkedList.ToString());
        }

        [TestMethod]
        public void CreateLinkedList_InsertingAtEnd()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();

            //Act
            linkedList.InsertAtEnd(1);
            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(3);
            linkedList.InsertAtEnd(4);
            linkedList.InsertAtEnd(5);

            // Assert
            Assert.AreEqual("1->2->3->4->5", linkedList.ToString());
        }

        [TestMethod]
        public void CreateLinkedList_InsertingAtPosition()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            linkedList.InsertAtEnd(1);
            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(4);
            linkedList.InsertAtEnd(5);

            //Act
            linkedList.InsertAfterPosition(2,3); 

            // Assert
            Assert.AreEqual("1->2->3->4->5", linkedList.ToString());
        }

        //[TestMethod]
        //public void CreateLinkedList()
        //{
        //    //Arrange

        //    //Act

        //    // Assert
        //}
        //[TestMethod]
        //public void CreateLinkedList()
        //{
        //    //Arrange

        //    //Act

        //    // Assert
        //}
        //[TestMethod]
        //public void CreateLinkedList()
        //{
        //    //Arrange

        //    //Act

        //    // Assert
        //}
    }
}