namespace BubbleSort.App;

public class BubbleSorter
{
    public static int[] SortArray(int[] array)
    {
        bool isSorted = false;
        while (!isSorted)
        {
            isSorted = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i+1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    isSorted = false;
                }
            }
        }
        return array;
    }

    public static int[] MergeArrays(int[] arrayOne, int[] arrayTwo)
    {
        if (arrayOne == null || arrayTwo == null) throw new ArgumentException();
        List<int> mergedArray = arrayOne.ToList();

        for (int i = 0; i < arrayTwo.Length; i++)
        {
            for (int j = 0; j < mergedArray.Count; j++)
            {
                if (arrayTwo[i] <= mergedArray[j])
                {
                    mergedArray.Insert(j, arrayTwo[i]);
                    break;
                } 
            }
        }

        int difference = (arrayOne.Length + arrayTwo.Length) - mergedArray.Count;
        if (difference > 0)
        {
            for (int k = arrayTwo.Length - difference; k < arrayTwo.Length; k++)
            {
                mergedArray.Add(arrayTwo[k]);
            }
        }
        return mergedArray.ToArray();
    }
}
