using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class program
    {
        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of ellements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\narray can have maximum 20 elements \n");

            }
            Console.WriteLine("n===================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("====================");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
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
            i = low + 1;
            j = high;

            pivot = arr[low];
            while (i <= j)
            {
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j)
                {
                    swap(i, j);
                    mov_count++;
                }
            }

            if (low < j)
            {
                swap(low, j);
                mov_count++;
            }
            q_sort(low, j - 1);

            q_sort(j + i, high);
        }
        void display()
        {

        }
    }
}
