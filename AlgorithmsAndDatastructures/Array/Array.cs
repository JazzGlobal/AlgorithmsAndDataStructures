using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDatastructures
{
    public static class ArrayAlgorithms
    {
        public static T[] RotateArray<T>(T[] array, int spaces)
        {
            if(spaces > array.Length)
            {
                spaces = spaces % array.Length;
            }
            T[] temp = new T[array.Length];
            Array.Copy(array, spaces, temp, 0, array.Length - spaces);
            var index = 0;
            for(int i = array.Length - spaces; i < array.Length; i++)
            {
                temp[i] = array[index];
                index++;
            }
            return temp;
        }

        /// <summary>
        /// Returns the index of the first occurrence of the passed value. Passed array must be sorted.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static KeyValuePair<bool, int> GetIndex(int[] array, int value)
        {
            int split = array.Length / 2; 
            if(value > array[split])
            {
                // Search Upper Half
                for (int index = split; index < array.Length; index++)
                {
                    if(value == array[index])
                    {
                        return new KeyValuePair<bool, int>(true, index);
                    }
                }
            } else
            {
                // Search Lower Half
                for (int index = 0; index < split; index++)
                {
                    if(value == array[index])
                    {
                        return new KeyValuePair<bool, int>(true, index);
                    }
                }
            }
            return new KeyValuePair<bool, int>(false, -1);
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach(var item in array)
            {
                Console.Write($" |{item}| ");
            }
            Console.WriteLine("");
        }
    }
}
