// See https://aka.ms/new-console-template for more information
using BubbleSort.App;

//Bubble sort
int[] x = { 1, 2, 3, 4, 5 };
int[] y = { 1, 2, 3, 4, 5, 6 };

//Merge arrays (including array with different lengths)
int[] z = { 12, 14, 16, 18, 20 };
int[] a = { 11, 12, 13, 14, 15, 16, 17 };

//Merge arrays - empty arrays
int[] empty = { };
int[] empty2 = { };

int[] result = BubbleSorter.MergeArrays(x, y);

foreach (var num in result)
{
    Console.Write($"{num} ");
}

