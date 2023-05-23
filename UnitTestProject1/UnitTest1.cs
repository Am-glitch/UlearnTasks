using System;
using System.Collections;
using NUnit.Framework;
using SeminarTasks;

namespace SeminarTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void StackReturnsRightItemAfterPopTest()
        {
            var stack = new VersionStack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
        }

        [Test]
        public void MultipleRollBackTest()
        {
            var stack = new VersionStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Rollback(2);
            stack.Push(3);
            stack.Rollback(4);
            Assert.AreEqual(3, stack.Pop());
        }

        [Test]
        public void RollBackTest()
        {
            var stack = new VersionStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Push(4);
            stack.Rollback(5);
            Assert.AreEqual(4, stack.Pop());
        }

        [Test]
        public void StackForgetTest()
        {
            var stack = new VersionStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Forget();
            Assert.AreEqual(null, stack.History);
        }
    }

    [TestFixture]
    public class KadaneAlgorithmTest
    {
        [Test]
        public void KadaneTest()
        {
            var nums = new[] {0, 1, -2, 3, 4 };

            Assert.AreEqual(KadaneAlgorithm.KadaneFindMaxSum(nums), 6);
           
        }
    }
}