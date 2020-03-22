using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue.Exceptions;

namespace DataStructures.UnitTests
{
    [TestClass]
    public class FixedSizeArrayQueueTests
    {
        [TestMethod]
        public void CreateAQueueOfGivenSize()
        {
            var queueSize = 10;
            var queue = new Queue.FixedSizeArrayQueue<int>(queueSize);

            Assert.AreEqual(queueSize, queue.Size);
        }

        [TestMethod]
        public void PushElementInQueue()
        {
            var queue = new Queue.FixedSizeArrayQueue<int>(10);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.AreEqual(3, queue.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(QueueOverflowException))]
        public void WhenPushedElementInQueueMoreThanItsSize_ThenOverflowExceptionThrown()
        {
            var queue = new Queue.FixedSizeArrayQueue<int>(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
        }

        [TestMethod]
        [ExpectedException(typeof(QueueUnderflowException))]
        public void PopElementFromEmptyQueue_ThenExceptionInThrown()
        {
            var queue = new Queue.FixedSizeArrayQueue<int>(10);
            var result = queue.Dequeue();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void PopElementFromQueue()
        {
            var queue = new Queue.FixedSizeArrayQueue<int>(10);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var result = queue.Dequeue();

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ClearQueue()
        {
            var queue = new Queue.FixedSizeArrayQueue<int>(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Clear();

            Assert.AreEqual(0, queue.Length);
        }

        [TestMethod]
        public void ReturnsTrueIfItemIsInQueue()
        {
            var queue = new Queue.FixedSizeArrayQueue<int>(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var result = queue.Contains(3);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnsFalseIfItemIsNotInQueue()
        {
            var queue = new Queue.FixedSizeArrayQueue<int>(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var result = queue.Contains(6);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PeekElementFromQueue()
        {
            var queue = new Queue.FixedSizeArrayQueue<int>(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var result = queue.Peek();

            Assert.AreEqual(1, result);
        }
    }
}