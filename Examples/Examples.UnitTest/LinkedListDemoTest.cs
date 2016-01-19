using System;
using System.Collections.Generic;
using System.Linq;
using Examples.Algorithm.LinkedList;
using NUnit.Framework;

namespace Examples.UnitTest
{
    [TestFixture]
    public class LinkedListDemoTest
    {
        [SetUp]
        public void Init()
        {

        }

        [Test]
        public void RemoveDuplicated_GivenAListWithDuplcatedItems_ShouldRemoveDuplcatedItem()
        {
            // arrange
            var lst = new LinkedList<int>(new int[] { 1, 2, 3, 4, 4 });
            // action
            var actual = LinkedListDemo.RemoveDuplicated(lst);
            // assert
            Assert.AreEqual(4, actual.Count);
            Assert.IsTrue(CompareTo(new LinkedList<int>(new int[] { 1, 2, 3, 4 }), actual));
        }

        private bool CompareTo(LinkedList<int> source, LinkedList<int> target)
        {
            if (source.Count != target.Count)
            {
                return false;
            }
            else
            {
                return source.All(target.Contains);
            }
        }
    }
}
