using QuestionOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayComputation compute = new ArrayComputation();

            int[] a = { 100, 23, 454, 6, 7, 8 };
            int[] b = { 1, 222, 43, 2, 56, 8 };

            compute.mergeArray(a, b, a.Length);
        }
    }
}
