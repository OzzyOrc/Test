using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    public class ArrayComputation
    {
        /// <summary>
        /// For the sake of the scope of this problem,
        /// constructor will not instantiate anything.
        public ArrayComputation()
        {
        }

        public int ArraySize { get; private set; }

        public int ArraySizeDouble { get; private set; }

        public int[] SortedArray { get; private set; }

        /// <summary>
        /// Method takes in two sorted arrays and 
        /// will merge them into the second array 
        /// with double the size. Since we are assuming 
        /// the capacity of both arrays, I have no use 
        /// for M in terms of merging the two.
        /// </summary>
        /// <param name="a">Sorted array of size M</param>
        /// <param name="b">Sorted array of same size but capacity of (M * 2)</param>
        /// <param name="M">Size of an array</param>
        public void mergeArray(int[] a, int[] b, int M)
        {
            // Used to validate the use cases in unit tests
            // M can never come in as null
            ArraySize = M;
            ArraySizeDouble = ArraySize * 2;

            // Discrete math teacher taught me well
            // Leveraged Linq here
            // I know I could have iterated through both arrays 
            // in a loop then compared values and sorted them 
            // into another array.
            SortedArray = b.Union(a).OrderBy(i => i).ToArray();

            Console.WriteLine("The result of the two merged arrays are: " + SortedArray.ToString()
                + "\n Please press any key to exit");
        }
    }
}
