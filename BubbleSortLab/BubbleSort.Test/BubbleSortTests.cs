using BubbleSort.App;

namespace BubbleSort.Test;

public class BubbleSortTests
{
    [TestCaseSource(nameof(array))]
    public void SortArray_WhenGivenAnArrayOfInts_ReturnSortedArray(int[] array)
    {
        // Arrange
        int[] expected = expectedResult;

        // Act
        var result = BubbleSort.SortArray(array);

        // Assert
        Assert.Pass();
    }

    public static int[] array = { 5, 3, 2, 4, 1 };
    public static int[] expectedResult = { 1, 2, 3, 4, 5 };


    }