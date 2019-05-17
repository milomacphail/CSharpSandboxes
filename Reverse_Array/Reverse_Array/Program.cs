using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace Reverse_Array
{
    class Solution
    {
        private static int Main(string[] args)
        {
            int Number = Convert.ToInt32(Console.ReadLine());
            string[] storageArray = Console.ReadLine().Split(' ');
            int[] outputArray = Array.ConvertAll(storageArray, Int32.Parse);

            for (var index = Number - 1; index > -1; index--)
            {
                Console.Write(outputArray[index] + " ");
            }

            return 1;

        }
    }
}