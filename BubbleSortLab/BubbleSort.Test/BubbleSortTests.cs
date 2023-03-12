using BubbleSort.App;

namespace BubbleSort.Test;

public class BubbleSortTests
{

    
    [TestCase(new int[] {5, 3, 2, 4, 1}, new int[] { 1, 2, 3, 4, 5 })]
    [TestCase(new int[] {20, 10, 17, 23, 34}, new int[] { 10, 17, 20, 23, 34 })]
    [TestCase(new int[] {999, 777, 1111, 333, 123}, new int[] { 123, 333, 777, 999, 1111 })]
    public void SortArray_WhenGivenAnArrayOfInts_ReturnSortedArray(int[] array, int[] expectedResult)
    {
        
        // Act
        var result = BubbleSorter.SortArray(array);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }


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