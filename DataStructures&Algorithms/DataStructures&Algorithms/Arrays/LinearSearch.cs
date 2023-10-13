    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DataStructures_Algorithms.Arrays
    {
        public class LinearSearch
        {

        //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int[] array { get; } = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            public bool Search(int[] array, int key)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == key) { return true; }
                }
                return false;
            }
        }
    }
