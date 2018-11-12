using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace StockSearch
{
    class Entry
    {
        static void Main(string[] args)
        {

            //files are inputted
            string filename = "Open_128.txt";
            string path1 = Path.GetFullPath(filename);
            string filename2 = "High_128.txt";
            string path2 = Path.GetFullPath(filename2);
            string filename3 = "Low_128.txt";
            string path3 = Path.GetFullPath(filename3);
            string filename4 = "Change_128.txt";
            string path4 = Path.GetFullPath(filename4);
            string filename5 = "Close_128.txt";
            string path5 = Path.GetFullPath(filename5);

            string filename6 = "Open_256.txt";
            string path6 = Path.GetFullPath(filename6);
            string filename7 = "High_256.txt";
            string path7 = Path.GetFullPath(filename7);
            string filename8 = "Low_256.txt";
            string path8 = Path.GetFullPath(filename8);
            string filename9 = "Change_256.txt";
            string path9 = Path.GetFullPath(filename9);
            string filename10 = "Close_256.txt";
            string path10 = Path.GetFullPath(filename10);

            string filename11 = "Open_1024.txt";
            string path11 = Path.GetFullPath(filename11);
            string filename12 = "High_1024.txt";
            string path12 = Path.GetFullPath(filename12);
            string filename13 = "Low_1024.txt";
            string path13 = Path.GetFullPath(filename13);
            string filename14 = "Change_1024.txt";
            string path14 = Path.GetFullPath(filename14);
            string filename15 = "Close_1024.txt";
            string path15 = Path.GetFullPath(filename15);

            string[] Open128 = File.ReadAllLines(path1);
            string[] High128 = File.ReadAllLines(path2);
            string[] Low128 = File.ReadAllLines(path3);
            string[] Change128 = File.ReadAllLines(path4);
            string[] Close128 = File.ReadAllLines(path5);

            string[] Open256 = File.ReadAllLines(path6);
            string[] High256 = File.ReadAllLines(path7);
            string[] Low256 = File.ReadAllLines(path8);
            string[] Change256 = File.ReadAllLines(path9);
            string[] Close256 = File.ReadAllLines(path10);

            string[] Open1024 = File.ReadAllLines(path11);
            string[] High1024 = File.ReadAllLines(path12);
            string[] Low1024 = File.ReadAllLines(path13);
            string[] Change1024 = File.ReadAllLines(path14);
            string[] Close1024 = File.ReadAllLines(path15);

            //files converted into decimal arrays for easier manipulation
            decimal[] intOpen128 = Array.ConvertAll(Open128, decimal.Parse);
            decimal[] intHigh128 = Array.ConvertAll(High128, decimal.Parse);
            decimal[] intLow128 = Array.ConvertAll(Low128, decimal.Parse);
            decimal[] intChange128 = Array.ConvertAll(Change128, decimal.Parse);
            decimal[] intClose128 = Array.ConvertAll(Close128, decimal.Parse);

            decimal[] intOpen256 = Array.ConvertAll(Open256, decimal.Parse);
            decimal[] intHigh256 = Array.ConvertAll(High256, decimal.Parse);
            decimal[] intLow256 = Array.ConvertAll(Low256, decimal.Parse);
            decimal[] intChange256 = Array.ConvertAll(Change256, decimal.Parse);
            decimal[] intClose256 = Array.ConvertAll(Close256, decimal.Parse);

            decimal[] intOpen1024 = Array.ConvertAll(Open1024, decimal.Parse);
            decimal[] intHigh1024 = Array.ConvertAll(High1024, decimal.Parse);
            decimal[] intLow1024 = Array.ConvertAll(Low1024, decimal.Parse);
            decimal[] intChange1024 = Array.ConvertAll(Change1024, decimal.Parse);
            decimal[] intClose1024 = Array.ConvertAll(Close1024, decimal.Parse);

            //user asked which array they wish to analyse and what value they wish to find
            decimal value;
            int binarystep = 0;
            Console.WriteLine("Which array do you wish to analyse? Please enter either;\n'Open', 'high', 'low', 'change', 'close' or 'merge' followed by the number with no space in between");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();
            Console.WriteLine("Do you want to analyse the array in ascending or descending order? Enter 1 for ascending and 2 for descending");
            string skew = Console.ReadLine();
            Console.WriteLine("What value do you wish to find?");
            //makes sure the user has entered a valid value
            if (!decimal.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("\nError: Please enter a value in the range: [-79228162514264337593543950335,79228162514264337593543950335]");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }

            //ASCENDING*************************************
            if (skew == "1")
            {
                //selection statement containing all the possible options of array
                if ((choice == "OPEN128") || (choice == "OPEN256") || (choice == "OPEN1024"))
                {
                    int n;
                    Console.WriteLine("\n**SORTED USING BUBBLE SORT**\n");
                    Thread.Sleep(500);
                    if (choice == "OPEN128")
                    {
                        n = Open128.Length;
                        //bubble sort
                        BubbleSort(intOpen128, n);
                        Print_List(intOpen128);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearch(intOpen128, n, value);
                    }
                    else if (choice == "OPEN256")
                    {
                        n = Open256.Length;
                        //bubble sort
                        BubbleSort(intOpen256, n);
                        Print_List(intOpen256);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearch(intOpen256, n, value);
                    }
                    else
                    {
                        n = Open1024.Length;
                        //bubble sort
                        BubbleSort(intOpen1024, n);
                        Print_List(intOpen1024);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearch(intOpen1024, n, value);
                    }
                }
                else if ((choice == "HIGH128") || (choice == "HIGH256") || (choice == "HIGH1024"))
                {
                    int n;

                    if (choice == "HIGH128")
                    {
                        int steps;
                        n = High128.Length;
                        //selection sort
                        Console.WriteLine("\n**SORTED USING SELECTION SORT**\n");
                        Thread.Sleep(500);
                        steps = SelectionSort(intHigh128, n);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intHigh128);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearch(intHigh128, n, value);
                    }
                    else if (choice == "HIGH256")
                    {
                        int steps;
                        n = High256.Length;
                        //selection sort
                        Console.WriteLine("\n**SORTED USING SELECTION SORT**\n");
                        Thread.Sleep(500);
                        steps = SelectionSort(intHigh256, n);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intHigh256);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearch(intHigh256, n, value);
                    }
                    else
                    {
                        int steps;
                        n = High1024.Length;
                        //selection sort
                        Console.WriteLine("\n**SORTED USING SELECTION SORT**\n");
                        Thread.Sleep(500);
                        steps = SelectionSort(intHigh1024, n);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intHigh1024);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearch(intHigh1024, n, value);
                    }

                }
                else if ((choice == "LOW128") || (choice == "LOW256") || (choice == "LOW1024"))
                {
                    Console.WriteLine("\n**SORTED USING QUICK SORT**\n");
                    Thread.Sleep(500);
                    int n;
                    int step = 0;
                    if (choice == "LOW128")
                    {
                        n = Low128.Length;
                        //quick sort
                        int steps = Quick_Sort(intLow128, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intLow128);
                        //binary search
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        BinarySearch(value, intLow128, 0, n, 0, ref binarystep);
                        //if no value has been round binarystep will equal 0 and the statement below should not be printed
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else if (choice == "LOW256")
                    {
                        n = Low256.Length;
                        //quick sort
                        int steps = Quick_Sort(intLow256, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intLow256);
                        //binary search
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        BinarySearch(value, intLow256, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        n = Low1024.Length;
                        //quick sort
                        int steps = Quick_Sort(intLow1024, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intLow1024);
                        //binary search
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        BinarySearch(value, intLow1024, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }

                    }
                }
                else if ((choice == "CHANGE128") || (choice == "CHANGE256") || (choice == "CHANGE1024"))
                {
                    Console.WriteLine("\n**SORTED USING HEAP SORT**\n");
                    Thread.Sleep(500);
                    int n;
                    if (choice == "CHANGE128")
                    {
                        n = Change128.Length;
                        //heap sort
                        HeapSort(intChange128);
                        Print_List(intChange128);
                        //binary search
                        BinarySearch(value, intChange128, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else if (choice == "CHANGE256")
                    {
                        n = Change256.Length;
                        //heap sort
                        HeapSort(intChange256);
                        Print_List(intChange256);
                        //binary search
                        BinarySearch(value, intChange256, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        n = Change1024.Length;
                        //heap sort
                        HeapSort(intChange1024);
                        Print_List(intChange1024);
                        //binary search
                        BinarySearch(value, intChange1024, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                }
                else if ((choice == "CLOSE128") || (choice == "CLOSE256") || (choice == "CLOSE1024"))
                {
                    Console.WriteLine("\n**SORTED USING QUICK SORT**\n");
                    Thread.Sleep(500);
                    int n;
                    int step = 0;
                    if (choice == "CLOSE128")
                    {
                        n = Close128.Length;
                        //quick sort
                        int steps = Quick_Sort(intClose128, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intClose128);
                        //binary search
                        BinarySearch(value, intClose128, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else if (choice == "CLOSE256")
                    {
                        n = Close256.Length;
                        //quick sort
                        int steps = Quick_Sort(intClose256, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intClose256);
                        //binary search
                        BinarySearch(value, intClose256, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        n = Close1024.Length;
                        //quick sort
                        int steps = Quick_Sort(intClose1024, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intClose1024);
                        //binary search
                        BinarySearch(value, intClose1024, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                }
                else if (choice == "MERGE128")
                {
                    int step = 0;
                    Console.WriteLine("\n**SORTED USING QUICK SORT**\n");
                    Thread.Sleep(500);
                    //new array is created with the length of the 2 arrays to be merged added together
                    decimal[] merged = new decimal[Close128.Length + High128.Length];
                    //values are copied to the new array
                    Array.Copy(intClose128, merged, Close128.Length);
                    Array.Copy(intHigh128, 0, merged, Close128.Length, High128.Length);
                    int n = merged.Length;
                    //quick sort
                    int steps = Quick_Sort(merged, 0, n - 1, ref step);
                    Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                    Thread.Sleep(3000);
                    Print_List(merged);
                    //binary search
                    BinarySearch(value, merged, 0, n, 0, ref binarystep);
                    if (binarystep > 0)
                    {
                        Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                        Thread.Sleep(3000);
                    }
                }
                else if (choice == "MERGE256")
                {
                    int step = 0;
                    Console.WriteLine("\n**SORTED USING QUICK SORT**\n");
                    Thread.Sleep(500);
                    //new array is created with the length of the 2 arrays to be merged added together
                    decimal[] merged = new decimal[Close256.Length + High256.Length];
                    //values are copied to the new array
                    Array.Copy(intClose256, merged, Close256.Length);
                    Array.Copy(intHigh256, 0, merged, Close256.Length, High256.Length);
                    int n = merged.Length;
                    //quick sort
                    int steps = Quick_Sort(merged, 0, n - 1, ref step);
                    Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                    Thread.Sleep(3000);
                    Print_List(merged);
                    //binary search
                    BinarySearch(value, merged, 0, n, 0, ref binarystep);
                    if (binarystep > 0)
                    {
                        Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                        Thread.Sleep(3000);
                    }
                }
                else if (choice == "MERGE1024")
                {
                    Console.WriteLine("\n**SORTED USING HEAP SORT**\n");
                    Thread.Sleep(500);
                    //new array is created with the length of the 2 arrays to be merged added together
                    decimal[] merged = new decimal[Close1024.Length + High1024.Length];
                    //values are copied to the arrays
                    Array.Copy(intClose1024, merged, Close1024.Length);
                    Array.Copy(intHigh1024, 0, merged, Close1024.Length, High1024.Length);
                    int n = merged.Length;
                    //heap sort
                    HeapSort(merged);
                    Print_List(merged);
                    //binary search
                    BinarySearch(value, merged, 0, n, 0, ref binarystep);
                    if (binarystep > 0)
                    {
                        Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                        Thread.Sleep(3000);
                    }
                }
                //error catching if the user entered an invalid response
                else
                {
                    Console.WriteLine("\nError: Please enter either;\n'Open', 'high', 'low', 'change', 'close' or 'merge' followed by the number with no space in between");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                }
            }
            //DESCENDING************************************
            else if (skew == "2")
            {
                if ((choice == "OPEN128") || (choice == "OPEN256") || (choice == "OPEN1024"))
                {
                    int n;
                    Console.WriteLine("\n**SORTED USING BUBBLE SORT**\n");
                    Thread.Sleep(500);
                    if (choice == "OPEN128")
                    {
                        n = Open128.Length;
                        //bubble sort
                        BubbleSortDE(intOpen128, n);
                        Print_List(intOpen128);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearchDE(intOpen128, n, value);
                    }
                    else if (choice == "OPEN256")
                    {
                        n = Open256.Length;
                        //bubble sort
                        BubbleSortDE(intOpen256, n);
                        Print_List(intOpen256);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearchDE(intOpen256, n, value);
                    }
                    else
                    {
                        n = Open1024.Length;
                        //bubble sort
                        BubbleSortDE(intOpen1024, n);
                        Print_List(intOpen1024);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearchDE(intOpen1024, n, value);
                    }
                }
                else if ((choice == "HIGH128") || (choice == "HIGH256") || (choice == "HIGH1024"))
                {
                    int n;

                    if (choice == "HIGH128")
                    {
                        int steps;
                        n = High128.Length;
                        //selection sort
                        Console.WriteLine("\n**SORTED USING SELECTION SORT**\n");
                        Thread.Sleep(500);
                        steps = SelectionSortDE(intHigh128, n);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intHigh128);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearchDE(intHigh128, n, value);
                    }
                    else if (choice == "HIGH256")
                    {
                        int steps;
                        n = High256.Length;
                        //selection sort
                        Console.WriteLine("\n**SORTED USING SELECTION SORT**\n");
                        Thread.Sleep(500);
                        steps = SelectionSortDE(intHigh256, n);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intHigh256);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearchDE(intHigh256, n, value);
                    }
                    else
                    {
                        int steps;
                        n = High1024.Length;
                        //selection sort
                        Console.WriteLine("\n**SORTED USING SELECTION SORT**\n");
                        Thread.Sleep(500);
                        steps = SelectionSortDE(intHigh1024, n);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intHigh1024);
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        //linear search
                        LinearSearchDE(intHigh1024, n, value);
                    }

                }
                else if ((choice == "LOW128") || (choice == "LOW256") || (choice == "LOW1024"))
                {
                    Console.WriteLine("\n**SORTED USING QUICK SORT**\n");
                    Thread.Sleep(500);
                    int n;
                    int step = 0;
                    if (choice == "LOW128")
                    {
                        n = Low128.Length;
                        //quick sort
                        int steps = Quick_SortDE(intLow128, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intLow128);
                        //binary search
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        BinarySearchDE(value, intLow128, 0, n, 0, ref binarystep);
                        //if no value has been round binarystep will equal 0 and the statement below should not be printed
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else if (choice == "LOW256")
                    {
                        n = Low256.Length;
                        //quick sort
                        int steps = Quick_SortDE(intLow256, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intLow256);
                        //binary search
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        BinarySearchDE(value, intLow256, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        n = Low1024.Length;
                        //quick sort
                        int steps = Quick_SortDE(intLow1024, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intLow1024);
                        //binary search
                        Console.WriteLine("\nThe item you are trying to find will now be searched for");
                        Thread.Sleep(2000);
                        BinarySearchDE(value, intLow1024, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }

                    }
                }
                else if ((choice == "CHANGE128") || (choice == "CHANGE256") || (choice == "CHANGE1024"))
                {
                    Console.WriteLine("\n**SORTED USING HEAP SORT**\n");
                    Thread.Sleep(500);
                    int n;
                    if (choice == "CHANGE128")
                    {
                        n = Change128.Length;
                        //heap sort
                        HeapSortDE(intChange128);
                        Print_List(intChange128);
                        //binary search
                        BinarySearchDE(value, intChange128, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else if (choice == "CHANGE256")
                    {
                        n = Change256.Length;
                        //heap sort
                        HeapSortDE(intChange256);
                        Print_List(intChange256);
                        //binary search
                        BinarySearchDE(value, intChange256, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        n = Change1024.Length;
                        //heap sort
                        HeapSortDE(intChange1024);
                        Print_List(intChange1024);
                        //binary search
                        BinarySearchDE(value, intChange1024, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                }
                else if ((choice == "CLOSE128") || (choice == "CLOSE256") || (choice == "CLOSE1024"))
                {
                    Console.WriteLine("\n**SORTED USING QUICK SORT**\n");
                    Thread.Sleep(500);
                    int n;
                    int step = 0;
                    if (choice == "CLOSE128")
                    {
                        n = Close128.Length;
                        //quick sort
                        int steps = Quick_SortDE(intClose128, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intClose128);
                        //binary search
                        BinarySearchDE(value, intClose128, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else if (choice == "CLOSE256")
                    {
                        n = Close256.Length;
                        //quick sort
                        int steps = Quick_SortDE(intClose256, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intClose256);
                        //binary search
                        BinarySearchDE(value, intClose256, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        n = Close1024.Length;
                        //quick sort
                        int steps = Quick_SortDE(intClose1024, 0, n - 1, ref step);
                        Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                        Thread.Sleep(3000);
                        Print_List(intClose1024);
                        //binary search
                        BinarySearchDE(value, intClose1024, 0, n, 0, ref binarystep);
                        if (binarystep > 0)
                        {
                            Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                            Thread.Sleep(3000);
                        }
                    }
                }
                else if (choice == "MERGE128")
                {
                    int step = 0;
                    Console.WriteLine("\n**SORTED USING QUICK SORT**\n");
                    Thread.Sleep(500);
                    //new array is created with the length of the 2 arrays to be merged added together
                    decimal[] merged = new decimal[Close128.Length + High128.Length];
                    //values are copied to the new array
                    Array.Copy(intClose128, merged, Close128.Length);
                    Array.Copy(intHigh128, 0, merged, Close128.Length, High128.Length);
                    int n = merged.Length;
                    //quick sort
                    int steps = Quick_SortDE(merged, 0, n - 1, ref step);
                    Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                    Thread.Sleep(3000);
                    Print_List(merged);
                    //binary search
                    BinarySearchDE(value, merged, 0, n, 0, ref binarystep);
                    if (binarystep > 0)
                    {
                        Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                        Thread.Sleep(3000);
                    }
                }
                else if (choice == "MERGE256")
                {
                    int step = 0;
                    Console.WriteLine("\n**SORTED USING QUICK SORT**\n");
                    Thread.Sleep(500);
                    //new array is created with the length of the 2 arrays to be merged added together
                    decimal[] merged = new decimal[Close256.Length + High256.Length];
                    //values are copied to the new array
                    Array.Copy(intClose256, merged, Close256.Length);
                    Array.Copy(intHigh256, 0, merged, Close256.Length, High256.Length);
                    int n = merged.Length;
                    //quick sort
                    int steps = Quick_SortDE(merged, 0, n - 1, ref step);
                    Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
                    Thread.Sleep(3000);
                    Print_List(merged);
                    //binary search
                    BinarySearchDE(value, merged, 0, n, 0, ref binarystep);
                    if (binarystep > 0)
                    {
                        Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                        Thread.Sleep(3000);
                    }
                }
                else if (choice == "MERGE1024")
                {
                    Console.WriteLine("\n**SORTED USING HEAP SORT**\n");
                    Thread.Sleep(500);
                    //new array is created with the length of the 2 arrays to be merged added together
                    decimal[] merged = new decimal[Close1024.Length + High1024.Length];
                    //values are copied to the arrays
                    Array.Copy(intClose1024, merged, Close1024.Length);
                    Array.Copy(intHigh1024, 0, merged, Close1024.Length, High1024.Length);
                    int n = merged.Length;
                    //heap sort
                    HeapSortDE(merged);
                    Print_List(merged);
                    //binary search
                    BinarySearchDE(value, merged, 0, n, 0, ref binarystep);
                    if (binarystep > 0)
                    {
                        Console.WriteLine("\nThe number of steps binary search took to try to find the value is {0}\n", binarystep);
                        Thread.Sleep(3000);
                    }
                }
                else
                {
                    Console.WriteLine("\nError: Please enter either;\n'Open', 'high', 'low', 'change', 'close' or 'merge' followed by the number with no space in between");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter either 1 or 2 to select which way you want the array to be sorted.\n1 for ascending and 2 for descending");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }

            //restart feature
            Console.WriteLine("\nDo you want to search for another value?\nType 'yes' to find another value or enter anything else to close application");
            string restart = Console.ReadLine();
            restart = restart.ToUpper();
            if ((restart == "YES") || (restart=="Y"))
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("\n***Application will now close***");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
        
        //ASCENDING
        private static int Quick_Sort(decimal[] arr, int left, int right,  ref int step)
        {

            int i, j;
            decimal pivot, temp;
            //bounds of the array
            i = left;
            j = right;
            //pivot selected
            pivot = arr[(left + right) / 2];
            //values compared and swaped
            do
            {
                while ((arr[i] < pivot) && (i < right)) i++;
                while ((pivot < arr[j]) && (j > left)) j--;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                    //counter increases with every iteration
                    step++;

                }
            } while (i <= j);
            if (left < j) Quick_Sort(arr, left, j, ref step);
            if (i < right) Quick_Sort(arr, i, right, ref step);
            return step;
        }
        public static void HeapSort(decimal[] Heap)
        {
            int count=0;
            int HeapSize = Heap.Length;
            int i;
            
            //makes sure max heap is always maintained
            for (i = (HeapSize - 1) / 2; i >= 0; i--)
            {
                Max_Heapify(Heap, HeapSize, i, ref count);
            }
            //removes items from heap and then max heapifies the remaining heap
            for (i = Heap.Length - 1; i > 0; i--)
            {
                decimal temp = Heap[i];
                Heap[i] = Heap[0];
                Heap[0] = temp;
                HeapSize--;
                Max_Heapify(Heap, HeapSize, 0, ref count);
                count++;
            }
            Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", count);
            Thread.Sleep(3000);
        }
        private static void Max_Heapify(decimal[] Heap, int HeapSize, int Index, ref int count)
        {
            int Left = (Index + 1) * 2 - 1;
            int Right = (Index + 1) * 2;
            int largest = 0;
            if (Left < HeapSize && Heap[Left] > Heap[Index])
            {
                largest = Left;
            }
            else
            {
                largest = Index;
            }
            if (Right < HeapSize && Heap[Right] > Heap[largest])
            {
                largest = Right;
            }
            if (largest != Index)
            {
                decimal temp = Heap[Index];
                Heap[Index] = Heap[largest];
                Heap[largest] = temp;
                count++;
                Max_Heapify(Heap, HeapSize, largest, ref count);
            }
        }
        private static int SelectionSort(decimal[] arr, int n)
        {
            int pos_min;
            decimal temp;
            int steps = 0;
            for (int i = 0; i < n - 1; i++)
            {
                pos_min = i;//set pos_min to the current index of array

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                    steps++;
                }
            }
            return steps;
        }
        private static void BubbleSort(decimal[] arr, int n)
        {
            int steps = 0;
            Thread.Sleep(1000);
            //bubblesort
            //iterates over each item in the list
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    //swaps values if they are out of place
                    if (arr[j + 1] < arr[j])
                    {
                        decimal temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        steps++;
                    }
                }
            }
            Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
            Thread.Sleep(3000);
        }
        private static void LinearSearch(decimal[] arr, int n, decimal Element)
        {
            //checks if item exists in array using linear search
            bool found = false;
            int step = 0;
            bool contains = Linear_loop(arr, n, Element, found, ref step);
            //if item not in array closest value is calculated
            if (contains == false)
            {
                Closest_Value(arr, Element, found, n);
            }
            Console.WriteLine("\nThe number of steps Linear search took trying to find the value(s) is {0} (per independent value)", step);
            Thread.Sleep(3000);
        }
        static int BinarySearch(decimal key, decimal[] arr, int low, int high, int first, ref int step)
        {
            //first 2 if statements check if the value is in the array
            if (first == 0)
            {
                high = high - 1;
                Console.WriteLine("\nInitial values: Lower bound = 0, Upper bound = {0}", high);
                Thread.Sleep(2000);
            }
            int length = arr.Length;
            bool found_new = false;
            if ((first == 0) && ((key < arr.Min()) || (key > arr.Max())))
            {
                Closest_Value(arr, key, found_new, length);
                return -1;
            }
            else
            {
                step++;
                first++;
                int x = arr.Length;
                int Index;
                int count = 1;
                int check = 1;

                //if the lower bound becomes greater than the higher bound the item is not in the list and an error is returned
                if (low > high)
                {
                    Console.WriteLine("\nLow: {0} > High: {1}", low, high);
                    Thread.Sleep(1000);
                    Closest_Value(arr, key, found_new, length);
                    return -1;
                }
                //calculates mid point
                int mid = (low + high) / 2;
                Console.WriteLine("\nMid: Item pos {0}  = {1} ", mid, arr[mid]);
                Thread.Sleep(1000);
                if (key == arr[mid])
                {
                    Console.WriteLine("\nItem has been found at position: {0}", mid);
                    Thread.Sleep(1000);
                    //checking if the value appears again in the remaining array....
                    Console.WriteLine("\nArray will now be checked to see if there are multiple instances of the key value");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    for (int y = 0; y < high + 1; y++)
                    {
                        //finds hows many more times a value is repeated excluding the mid point (value already found)
                        //this prevents values that are not repeated from incrementing the counter to 2 and triggering the subsequent if statement
                        if ((arr[y] == key) && (y != mid))
                            count++;
                    }

                    //....if it does a linear search is conducted
                    if (count > 1)
                    {
                        //adds one to the counter to make sure all instances are found
                        //
                        count += 1;
                        Console.WriteLine("\nThe remaining array will now be searched linearly");
                        Console.WriteLine("The value is contained {0} more time(s)", count - 2);
                        //search goes to end of remaining array or until the number of instances of the value have been found
                        for (int i = 0; i <= high; i++)
                        {

                            //if current value is equal to item we are looking for this statement is triggered
                            if (key == arr[i])
                            {
                                //checks to see if position of current value is the mid point. If it is the value is ignored as it has already been registered 
                                if (i != mid)
                                {
                                    Index = i;
                                    Console.WriteLine("\nItem has also been found at position: {0}", Index);
                                    check++;
                                }
                            }
                            /* to prevent the search going all the way through the remaining array check is compared to count
                            Check is set to 1 as 1 instance of the value has already been found 
                            When all instances have been found check will be equal to count and there will be no need to check any remaining values*/
                            if (check == count - 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo more instances found");
                    }
                    return 1;
                }
                //if statements to calculate new bounds
                if (key < arr[mid])
                {

                    Console.WriteLine("{0} < midpoint therefore new bounds are...", key);
                    Thread.Sleep(1000);
                    Console.WriteLine("Lower bound: Item pos {0} = {1}\nUpper bound: Item pos {2} = {3}", low, arr[low], mid - 1, arr[mid - 1]);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    return BinarySearch(key, arr, low, mid - 1, first, ref step);
                }
                else
                {
                    Console.WriteLine("{0} > midpoint therefore new bounds are...", key);
                    Thread.Sleep(1000);
                    Console.WriteLine("Lower bound: Item pos {0} = {1}\nUpper bound: Item pos {2} = {3}", mid + 1, arr[mid + 1], high, arr[high]);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    return BinarySearch(key, arr, mid + 1, high, first, ref step);
                }
            }
        }
        static void Closest_Value(decimal[] arr, decimal Element, bool found, int n)
        {
            int step = 0;
            decimal LB;
            decimal UB;
            decimal newElement;
            Console.WriteLine("\nError: The item does not exist in this array\n");
            Thread.Sleep(500);
            Console.WriteLine("The item(s) closest to this value will now be calculated\nand the array will then be linearly searched for these nearby items\n");
            Thread.Sleep(1000);
            //in order to add an item to an array the array must be converted into a list
            var tempList = arr.ToList();
            //item is added
            tempList.Add(Element);
            //list converted back to array
            arr = tempList.ToArray();
            //new length calculated and the array is sorted with the new value
            int newlength = arr.Length;
            SelectionSort(arr, newlength);
            //index of new value is calculated
            int Index = Array.IndexOf(arr, Element);
            //if the value is at the start of the array the cloest value is the item in the next location
            if (Index == 0)
            {
                newElement = arr[Index + 1];
                Console.WriteLine("Item(s) closest to chosen value is/are {0}\n", newElement);
                Thread.Sleep(1000);
                //the added item is removed from the list by converting the array to a list, removing the item and then converting it back to an array
                tempList = arr.ToList();
                tempList.Remove(Element);
                arr = tempList.ToArray();
                //array is then searched for the closest value
                Linear_loop(arr, n, newElement, found, ref step);
            }
            //if the value is at the end of the array the cloest value is the item in the previous location
            else if (Index == n)
            {
                newElement = arr[Index - 1];
                Console.WriteLine("Item(s) closest to chosen value is/are {0}\n", newElement);
                Thread.Sleep(1000);
                tempList = arr.ToList();
                tempList.Remove(Element);
                arr = tempList.ToArray();
                Linear_loop(arr, n, newElement, found, ref step);
            }
            //if the value is in the middle of the array the cloest values are the items in the previous and next locations
            else
            {
                UB = arr[Index + 1];
                LB = arr[Index - 1];
                Console.WriteLine("Items closest to chosen value are {0} and {1}\n", UB, LB);
                Thread.Sleep(1000);
                tempList = arr.ToList();
                tempList.Remove(Element);
                arr = tempList.ToArray();
                Linear_loop(arr, n, UB, found, ref step);
                Linear_loop(arr, n, LB, found, ref step);

            }
        }
        //DESCENDING
        private static void BubbleSortDE(decimal[] arr, int n)
        {
            int steps = 0;
            Thread.Sleep(1000);
            //bubblesort
            //iterates over each item in the list
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    //swaps values if they are out of place
                    if (arr[j + 1] > arr[j])
                    {
                        decimal temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        steps++;
                    }
                }
            }
            Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", steps);
            Thread.Sleep(3000);
        }
        private static int SelectionSortDE(decimal[] arr, int n)
        {
            int pos_max;
            decimal temp;
            int steps = 0;
            for (int i = 0; i < n - 1; i++)
            {
                pos_max = i;//set pos_min to the current index of array

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[pos_max])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_max = j;
                    }
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_max != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_max];
                    arr[pos_max] = temp;
                    steps++;
                }
            }
            return steps;
        }
        private static int Quick_SortDE(decimal[] arr, int left, int right, ref int step)
        {

            int i, j;
            decimal pivot, temp;
            //bounds of the array
            i = left;
            j = right;
            //pivot selected
            pivot = arr[(left + right) / 2];
            //values compared and swaped
            do
            {
                while ((arr[i] > pivot) && (i < right)) i++;
                while ((pivot > arr[j]) && (j > left)) j--;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                    //counter increases with every iteration
                    step++;

                }
            } while (i <= j);
            if (left < j) Quick_SortDE(arr, left, j, ref step);
            if (i < right) Quick_SortDE(arr, i, right, ref step);
            return step;
        }
        public static void HeapSortDE(decimal[] Heap)
        {
            int count = 0;
            int HeapSize = Heap.Length;
            int i;

            //makes sure max heap is always maintained
            for (i = (HeapSize - 1) / 2; i >= 0; i--)
            {
                Min_Heapify(Heap, HeapSize, i, ref count);
            }
            //removes items from heap and then max heapifies the remaining heap
            for (i = Heap.Length - 1; i > 0; i--)
            {
                decimal temp = Heap[i];
                Heap[i] = Heap[0];
                Heap[0] = temp;
                HeapSize--;
                Min_Heapify(Heap, HeapSize, 0, ref count);
                count++;
            }
            Console.WriteLine("\nThe number of steps the algorithm took to order the array is {0}\n", count);
            Thread.Sleep(3000);
        }
        private static void Min_Heapify(decimal[] Heap, int HeapSize, int Index, ref int count)
        {
            int Left = (Index + 1) * 2 - 1;
            int Right = (Index + 1) * 2;
            int largest = 0;
            if (Left < HeapSize && Heap[Left] < Heap[Index])
            {
                largest = Left;
            }
            else
            {
                largest = Index;
            }
            if (Right < HeapSize && Heap[Right] < Heap[largest])
            {
                largest = Right;
            }
            if (largest != Index)
            {
                decimal temp = Heap[Index];
                Heap[Index] = Heap[largest];
                Heap[largest] = temp;
                count++;
                Min_Heapify(Heap, HeapSize, largest, ref count);
            }
        }
        static void Closest_ValueDE(decimal[] arr, decimal Element, bool found, int n)
        {
            int step = 0;
            decimal LB;
            decimal UB;
            decimal newElement;
            Console.WriteLine("\nError: The item does not exist in this array\n");
            Thread.Sleep(500);
            Console.WriteLine("The item(s) closest to this value will now be calculated\nand the array will then be linearly searched for these nearby items\n");
            Thread.Sleep(1000);
            //in order to add an item to an array the array must be converted into a list
            var tempList = arr.ToList();
            //item is added
            tempList.Add(Element);
            //list converted back to array
            arr = tempList.ToArray();
            //new length calculated and the array is sorted with the new value
            int newlength = arr.Length;
            SelectionSortDE(arr, newlength);
            //index of new value is calculated
            int Index = Array.IndexOf(arr, Element);
            //if the value is at the start of the array the cloest value is the item in the next location
            if (Index == 0)
            {
                newElement = arr[Index + 1];
                Console.WriteLine("Item(s) closest to chosen value is/are {0}\n", newElement);
                Thread.Sleep(1000);
                //the added item is removed from the list by converting the array to a list, removing the item and then converting it back to an array
                tempList = arr.ToList();
                tempList.Remove(Element);
                arr = tempList.ToArray();
                //array is then searched for the closest value
                Linear_loop(arr, n, newElement, found, ref step);
            }
            //if the value is at the end of the array the cloest value is the item in the previous location
            else if (Index == n)
            {
                newElement = arr[Index - 1];
                Console.WriteLine("Item(s) closest to chosen value is/are {0}\n", newElement);
                Thread.Sleep(1000);
                tempList = arr.ToList();
                tempList.Remove(Element);
                arr = tempList.ToArray();
                Linear_loop(arr, n, newElement, found, ref step);
            }
            //if the value is in the middle of the array the cloest values are the items in the previous and next locations
            else
            {
                UB = arr[Index + 1];
                LB = arr[Index - 1];
                Console.WriteLine("Items closest to chosen value are {0} and {1}\n", UB, LB);
                Thread.Sleep(1000);
                tempList = arr.ToList();
                tempList.Remove(Element);
                arr = tempList.ToArray();
                Linear_loop(arr, n, UB, found, ref step);
                Linear_loop(arr, n, LB, found, ref step);

            }
        }
        static int BinarySearchDE(decimal key, decimal[] arr, int low, int high, int first, ref int step)
        {
            //first 2 if statements check if the value is in the array
            if (first == 0)
            {
                high = high - 1;
                Console.WriteLine("\nInitial values: Lower bound = 0, Upper bound = {0}", high);
                Thread.Sleep(2000);
            }
            int length = arr.Length;
            bool found_new = false;
            if ((first == 0) && ((key < arr.Min()) || (key > arr.Max())))
            {
                Closest_ValueDE(arr, key, found_new, length);
                return -1;
            }
            else
            {
                step++;
                first++;
                int x = arr.Length;
                int Index;
                int count = 1;
                int check = 1;

                //if the lower bound becomes greater than the higher bound the item is not in the list and an error is returned
                if (low > high)
                {
                    Console.WriteLine("\nLow: {0} > High: {1}", low, high);
                    Thread.Sleep(1000);
                    Closest_ValueDE(arr, key, found_new, length);
                    return -1;
                }
                //calculates mid point
                int mid = (low + high) / 2;
                Console.WriteLine("\nMid: Item pos {0}  = {1} ", mid, arr[mid]);
                Thread.Sleep(1000);
                if (key == arr[mid])
                {
                    Console.WriteLine("\nItem has been found at position: {0}", mid);
                    Thread.Sleep(1000);
                    //checking if the value appears again in the remaining array....
                    Console.WriteLine("\nArray will now be checked to see if there are multiple instances of the key value");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    for (int y = 0; y < high + 1; y++)
                    {
                        //finds hows many more times a value is repeated excluding the mid point (value already found)
                        //this prevents values that are not repeated from incrementing the counter to 2 and triggering the subsequent if statement
                        if ((arr[y] == key) && (y != mid))
                            count++;
                    }

                    //....if it does a linear search is conducted
                    if (count > 1)
                    {
                        //adds one to the counter to make sure all instances are found
                        //
                        count += 1;
                        Console.WriteLine("\nThe remaining array will now be searched linearly");
                        Console.WriteLine("The value is contained {0} more time(s)", count - 2);
                        //search goes to end of remaining array or until the number of instances of the value have been found
                        for (int i = 0; i <= high; i++)
                        {

                            //if current value is equal to item we are looking for this statement is triggered
                            if (key == arr[i])
                            {
                                //checks to see if position of current value is the mid point. If it is the value is ignored as it has already been registered 
                                if (i != mid)
                                {
                                    Index = i;
                                    Console.WriteLine("\nItem has also been found at position: {0}", Index);
                                    check++;
                                }
                            }
                            /* to prevent the search going all the way through the remaining array check is compared to count
                            Check is set to 1 as 1 instance of the value has already been found 
                            When all instances have been found check will be equal to count and there will be no need to check any remaining values*/
                            if (check == count - 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo more instances found");
                    }
                    return 1;
                }
                //if statements to calculate new bounds
                if (key < arr[mid])
                {
                    Console.WriteLine("{0} < midpoint therefore new bounds are...", key);
                    Thread.Sleep(1000);
                    Console.WriteLine("Lower bound: Item pos {0} = {1}\nUpper bound: Item pos {2} = {3}", mid + 1, arr[mid + 1], high, arr[high]);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    return BinarySearchDE(key, arr, mid + 1, high, first, ref step);
                }
                else
                {
                    Console.WriteLine("{0} > midpoint therefore new bounds are...", key);
                    Thread.Sleep(1000);
                    Console.WriteLine("Lower bound: Item pos {0} = {1}\nUpper bound: Item pos {2} = {3}", low, arr[low], mid - 1, arr[mid - 1]);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    return BinarySearchDE(key, arr, low, mid - 1, first, ref step);
                }
            }
        }
        private static void LinearSearchDE(decimal[] arr, int n, decimal Element)
        {
            //checks if item exists in array using linear search
            bool found = false;
            int step = 0;
            bool contains = Linear_loop(arr, n, Element, found, ref step);
            //if item not in array closest value is calculated
            if (contains == false)
            {
                Closest_ValueDE(arr, Element, found, n);
            }
            Console.WriteLine("\nThe number of steps Linear search took trying to find the value(s) is {0} (per independent value)", step);
            Thread.Sleep(3000);
        }
        //OTHER
        static bool Linear_loop(decimal[] arr, int n, decimal Element, bool found, ref int step)
        {
            List<int> list = new List<int>();
            int Index;
            int count = 0;
            //goes through each item in the list comparing it to the chosen value one by one
            for (int i = 0; i < n; i++)
            {
                //item displayed in green if it is found
                if (Element == arr[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0}: {1} = {2}",count, arr[i], Element);
                    Thread.Sleep(1000);
                    Console.ResetColor();
                    Index = i;
                    list.Add(Index);
                    found = true;
                }
                else
                {
                    Console.WriteLine("{0}: {1} != {2}",count, arr[i], Element);
                    Thread.Sleep(5);
                }
                step++;
                count++;
            }
            //every position the item has been found is displayed to the user
            foreach (int item in list)
            {
                Console.WriteLine("\n{0} has been found at position: {1}\n", Element, item);
                Thread.Sleep(4000);
            }
            
            return found;
        }
        static void Print_List(decimal[] arr)
        {
            //loop which simply prints the ordered list and each items corresponding position
            int count = 0;
            string value;
            foreach (var item in arr)
            {
                value = item.ToString();
                Console.WriteLine("{0}: {1}", count, value);
                count++;
            }
            Console.WriteLine("\nThere are {0} items in this array", count);
            Thread.Sleep(1500);
        }
    }
}
