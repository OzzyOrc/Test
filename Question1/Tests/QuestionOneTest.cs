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

        [Test]
        public void MergeTwoValidArraysAndCheckIfSortedCorrectly()
        {
            // Default constructor
            ArrayComputation compute = new ArrayComputation();

            // Two arrays of the same size
            int[] a = { 100, 23, 454, 6, 7, 8 };
            int[] b = { 1, 222, 43, 2, 56, 8 };

            Assert.IsNotNull(a.Length, "The input array has not been initialized yet");

            int expectedMergedLength = a.Length * 2;
            compute.mergeArray(a, b, a.Length);

            // Let's compare all values are ordered from least to greatest
            var sortedArray = compute.SortedArray;
            for (int i = 0; i <= sortedArray.Length; i++)
            {
                var leftNode = sortedArray.ElementAt(i);

                // We are at the end of the array, let's break out 
                // so we don't throw an exception
                if (i == sortedArray.Length - 1)
                {
                    break;
                }

                var rightNode = sortedArray.ElementAt(++i);
                if (leftNode > rightNode)
                {
                    Assert.Fail("The array is not properly sorted!");
                }
            }
        }
    }
}
