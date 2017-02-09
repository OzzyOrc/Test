using NUnit.Framework;
using QuestionOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.Tests
{
    [TestFixture]
    public class QuestionOneTest
    {
        [Test]
        public void MergeTwoValidArrays()
        {
            // Default constructor
            ArrayComputation compute = new ArrayComputation();

            // Two arrays of the same size
            int[] a = { 1, 3, 5, 7, 9 };
            int[] b = { 2, 4, 6, 8, 10 };
            
            compute.mergeArray(a, b, a.Length);

            Assert.AreEqual(5, a.Length);
        }

        [Test]
        public void MergeTwoValidArraysAndCheckArraySize()
        {
            // Default constructor
            ArrayComputation compute = new ArrayComputation();

            // Two arrays of the same size
            int[] a = { 1, 3, 5, 7, 9 };
            int[] b = { 2, 4, 6, 8, 10 };

            Assert.IsNotNull(a.Length, "The input array has not been initialized yet");
            
            int expectedMergedLength = a.Length * 2;
            compute.mergeArray(a, b, a.Length);

            Assert.AreEqual(expectedMergedLength, compute.SortedArray.Length);
        }
    }
}
