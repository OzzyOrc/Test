using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo.Tests
{
    [TestFixture]
    public class QuestionTwoTests
    {
        [Test]
        public void LetterDictionaryLoadsWithAllLettersAndZeroCount()
        {
            Pangram pangram = new Pangram();

            var dictionary = pangram.LoadDictionary();

            // There are 26 letters in the dictionary 
            Assert.AreEqual(dictionary.Count, 26);

            // For each letter we should have a count of zero
            foreach (var letterCount in dictionary)
            {
                Assert.AreEqual(letterCount.Value, 0);
            }
        }

        [Test]
        public void ValidPangramReturnsOne()
        {
            Pangram pangram = new Pangram();

            Assert.AreEqual(pangram.IsPangram("We promptly judged antique ivory buckles for the next prize"), 1);
        }

        [Test]
        public void InvalidPangramReturnsZero()
        {
            Pangram pangram = new Pangram();

            Assert.AreEqual(pangram.IsPangram("We promptly judged antique ivory buckles for the prize"), 0);
        }

        [Test]
        public void MissingOneLetterToQualifyAsPangram()
        {
            Pangram pangram = new Pangram();

            Assert.AreEqual(pangram.IsPangram("Pac my box with five dozen liquor jugs."), 0);
        }

        [Test]
        public void InvalidPangramReturnsZeroAgain()
        {
            Pangram pangram = new Pangram();

            Assert.AreEqual(pangram.IsPangram("Hello World"), 0);
        }

        [Test]
        public void ValidPangramTooLong()
        {
            Pangram pangram = new Pangram();

            Assert.AreEqual(pangram.IsPangram("We promptly judged antique ivory buckles for the prize" +
                "We promptly judged antique ivory buckles for the prize We promptly judged antique ivory buckles for the prize"), 0);
        }

        [Test]
        public void InValidPangramTooShort()
        {
            Pangram pangram = new Pangram();

            //Pass in nothing
            Assert.AreEqual(pangram.IsPangram(String.Empty), 0);
        }
    }
}
