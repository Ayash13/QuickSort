using System;

namespace QUickSort
{
    class Program
    {
        //array of intergers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; //number of comparison 
        private int mov_count = 0; //number of data movements

        //number of elements in array
        private int n;

        void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements in the array");
                string s = Console.ReadLine();
            }
        }
    }
}