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
