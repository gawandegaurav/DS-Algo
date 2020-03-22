using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;
using Queue.Exceptions;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class LinkedListQueueTests
    {
        [TestMethod]
        [ExpectedException(typeof(QueueUnderflowException))]
        public void PopItemFromEmptyQueue()
        {
            var queue = new LinkedListQueue<int>();
            var item = queue.Dequeue();

            Assert.AreEqual(0, queue.Length);
            Assert.IsNull(item);
        }

        [TestMethod]
        public void CreateALinkedListQueue()
        {
            var queue = new LinkedListQueue<int>();
            queue.Enqueue(1);

            Assert.AreEqual(1, queue.Length);
        }

        [TestMethod]
        public void PushItemsToTheQueue()
        {
            var queue = new LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(5);

            Assert.AreEqual(4, queue.Length);
            Assert.AreEqual("1->2->3->5", queue.ToString());
        }

        [TestMethod]
        public void PushAndPopItemsIntoTheQueue()
        {
            var queue = new LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Dequeue();

            Assert.AreEqual(4, queue.Length);
            Assert.AreEqual("2->3->4->5", queue.ToString());
        }

        [TestMethod]
        public void PeekItemFromQueue()
        {
            var queue = new LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            var item = queue.Peek();

            Assert.AreEqual(1, item);
        }
    }
}