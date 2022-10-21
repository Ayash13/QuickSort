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
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("Array can have maximum 20 elements");
            }
            Console.WriteLine("===================");
            Console.WriteLine("Enter Array Element");
            Console.WriteLine("===================");

            //get array element
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swap the element at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;
            //partition the list into two parts
            //one containing ements less than or equal to pivot
            //other containing elements greather than pivot

            i = low + 1;
            j = high;
            pivot = arr[low];

            while (i<= j)
            {
                //search for an element greater than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //search for an elemenrt less than or equal to pivot
                while ((arr[j] > pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;
                
                if (i < j) //if the greater elemenet is on the leftt of the element 
                {
                    //swap th element at index i whit the element at index j
                    swap(i, j);
                    mov_count++;
                }
                //J now contains the index of the last element in the sorted list 

                if (low < j)
                {
                    //Move the pivot to its correct position in the list
                    swap(low, j);
                    mov_count++;
                }
                //sort the list on the left of pivot using quick sort
                q_sort(low, j - 1);

                //Sort the list on the right of pivot using sort
                q_sort(j + 1, high);
            }
            
        }
        void display()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Sorted Array Element");
            Console.WriteLine("====================");

            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[j]);
            }

            Console.WriteLine("Number Comparison" + cmp_count);
            Console.WriteLine("Number of data elements" + mov_count);
        }
        int getSize()
        {
            return (n);
        }
        static void Main(string[] args)
        {
            //Declaring the object of tge class
            Program myList = new Program();
            //Accept array elements
            myList.input();
            //Calling the sorting function
            //first call to quick sort algorithm
            myList.q_sort(0, myList.getSize() - 1);
            myList.display();
            // To exit form console
            Console.WriteLine("press enter to exit");
            Console.Read();

        }
    }
}