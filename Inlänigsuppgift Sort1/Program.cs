using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sortering
{
    class Program

    {

        static void BubbleSort(List<int> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = 0; j < myList.Count - 1; j++)
                {
                    if (myList[j] > myList[j + 1])
                    {

                        int temp = myList[j];
                        myList[j] = myList[j + 1];
                        myList[j + 1] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(List<int> list)
        {
            int i, j;
            for (i = 1; i < list.Count; i++)
            {
                int item = list[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < list[j])
                    {
                        list[j + 1] = list[j];
                        j--;
                        list[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
        }
        static void SkapaSlumplista(List<int> myList, int size)
        {
            Random slump = new Random();
            for (int i = 0; i < size; i++)
            {
                myList.Add(slump.Next(100000));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Listan är sorterad!");

            Stopwatch sw = new Stopwatch();
            int listSize = 1000;
            List<int> tallista1 = new List<int>();
            List<int> tallista2 = new List<int>();

            SkapaSlumplista(tallista1, listSize);
            SkapaSlumplista(tallista2, listSize);

            sw.Reset();
            sw.Start();
            BubbleSort(tallista1);
            sw.Stop();
            Console.WriteLine("Bubblesort: " + sw.ElapsedMilliseconds + " Millisekunder");

            sw.Reset();
            sw.Start();
            InsertionSort(tallista2);
            sw.Stop();
            Console.WriteLine("Insertionsort: " + sw.ElapsedMilliseconds + " Millisekunder");
        }
    }
}
