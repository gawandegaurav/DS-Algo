using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class SinglyLinkedListTests
    {
        [TestMethod]
        public void LinkedList_InsertOneItemAtBeginning()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();

            //Act
            linkedList.InsertAtBeginning(1);

            // Assert
            Assert.AreEqual("1", linkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_InsertingAtBeginning()
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
        public void LinkedList_InsertingAtEnd_WhenListIsEmpty()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();

            //Act
            linkedList.InsertAtEnd(1);

            // Assert
            Assert.AreEqual("1", linkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_InsertingAtEnd()
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
        public void LinkedList_InsertingAtPositionZero()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();

            //Act
            linkedList.InsertAfterPosition(2, 3);

            // Assert
            Assert.AreEqual("3", linkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_InsertingAtNegativePosition()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            linkedList.InsertAtBeginning(1);
            //Act
            linkedList.InsertAfterPosition(-2, 3);

            // Assert
            Assert.AreEqual("3->1", linkedList.ToString());
        }


        [TestMethod]
        public void LinkedList_InsertingAtPositivePosition()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            linkedList.InsertAtEnd(1);
            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(4);
            linkedList.InsertAtEnd(5);

            //Act
            linkedList.InsertAfterPosition(2, 3);

            // Assert
            Assert.AreEqual("1->2->3->4->5", linkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_DeleteAtBeginning_WhenListEmpty()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();

            //Act
            var list = linkedList.DeleteAtBeginning();

            // Assert
            Assert.IsNull(list);
            Assert.AreEqual("", linkedList.ToString());
        }


        [TestMethod]
        public void LinkedList_DeleteAtBeginning()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            linkedList.InsertAtEnd(1);
            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(3);
            linkedList.InsertAtEnd(4);
            linkedList.InsertAtEnd(5);

            //Act
            linkedList.DeleteAtBeginning();

            // Assert
            Assert.AreEqual("2->3->4->5", linkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_DeleteFromEnd()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            linkedList.InsertAtEnd(1);
            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(3);
            linkedList.InsertAtEnd(4);
            linkedList.InsertAtEnd(5);

            //Act
            linkedList.DeleteFromEnd();

            // Assert
            Assert.AreEqual("1->2->3->4", linkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_DeleteFromPosition_WhenListIsEmpty()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();

            //Act
            var list = linkedList.DeleteFromPosition(2);

            // Assert
            Assert.IsNull(list);
            Assert.AreEqual("", linkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_DeleteFromNegativePosition()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            linkedList.InsertAtEnd(1);
            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(3);

            //Act
            linkedList.DeleteFromPosition(-2);

            // Assert
            Assert.AreEqual("2->3", linkedList.ToString());
        }


        [TestMethod]
        public void LinkedList_DeleteFromPosition()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            linkedList.InsertAtEnd(1);
            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(3);
            linkedList.InsertAtEnd(4);
            linkedList.InsertAtEnd(5);

            //Act
            linkedList.DeleteFromPosition(2);

            // Assert
            Assert.AreEqual("1->3->4->5", linkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_DeleteAll()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            linkedList.InsertAtEnd(1);
            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(3);
            linkedList.InsertAtEnd(4);
            linkedList.InsertAtEnd(5);

            //Act
            linkedList.DeleteAll();

            // Assert
            Assert.AreEqual("", linkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_Contains()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            linkedList.InsertAtEnd(1);
            linkedList.InsertAtEnd(2);
            linkedList.InsertAtEnd(3);
            linkedList.InsertAtEnd(4);
            linkedList.InsertAtEnd(5);

            //Act
            var result = linkedList.Contains(3);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void LinkedList_Contains_WhenEmptyList()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();
            
            //Act
            var result = linkedList.Contains(3);

            // Assert
            Assert.AreEqual(false, result);
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