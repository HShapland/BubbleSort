using BubbleSort.App;

namespace BubbleSort.Test;

public class BubbleSortTests
{

    /*
    [TestCaseSource(nameof(array))]
    public void SortArray_WhenGivenAnArrayOfInts_ReturnSortedArray(int[] array, int[] expectedResult)
    {
        // Arrange
        // Act
        var result = BubbleSorter.SortArray(array);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    public static object[] array =
    {
        new int[] { 5, 3, 2, 4, 1 },
        new int[] { 1, 2, 3, 4, 5 }
    }; */

    [Test]
    public void MergeArrays_WhenGivenNullArrays_ReturnArgumentException()
    {
        Assert.That(() => BubbleSorter.MergeArrays(null, null), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void MergeArrays_WhenGiven0LengthArrays_ReturnEmptyString()
    {
        // Arrange
        int[] arrayOne = { };
        int[] arrayTwo = { };
        int[] expected = { };

        // Act
        var result = BubbleSorter.MergeArrays(arrayOne, arrayTwo);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MergeArrays_WhenGivenArraysWithDifferentLengths_ReturnSortedMergedArray()
    {
        // Arrange
        int[] arrayOne = { 12, 14, 16, 18, 20 };
        int[] arrayTwo = { 11, 12, 13, 14, 15, 16, 17 };
        int[] expected = { 11, 12, 12, 13, 14, 14, 15, 16, 16, 17, 18, 20 };

        // Act
        var result = BubbleSorter.MergeArrays(arrayOne, arrayTwo);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MergeArrays_WhenGivenArraysWithOverlappingContents_ReturnSortedMergedArray()
    {
        // Arrange
        int[] arrayOne = { 1, 2, 3, 4, 5};
        int[] arrayTwo = { 1, 3, 3, 3, 6 };
        int[] expected = { 1, 1, 2, 3, 3, 3, 3, 4, 5, 6 };

        // Act
        var result = BubbleSorter.MergeArrays(arrayOne, arrayTwo);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}