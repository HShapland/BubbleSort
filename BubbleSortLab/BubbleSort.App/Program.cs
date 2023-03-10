// See https://aka.ms/new-console-template for more information
using BubbleSort.App;

int[] x = { 1, 2, 3, 4, 5 };
int[] y = { 1, 2, 3, 4, 5, 6 };

int[] z = { 12, 14, 16, 18, 20 };
int[] a = { 11, 12, 13, 14, 15, 16, 17 };

int[] empty = { };
int[] empty2 = { };

int[] result = BubbleSorter.MergeArrays(x, y);

foreach (var num in result)
{
    Console.Write($"{num} ");
}

