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

   
    [Test] 
    public void test()
    {
        int[] array = { 5, 3, 2, 4, 1 };
        int[] expectedResult = { 1, 2, 3, 4, 5 }; 
        Assert.That(BubbleSorter.SortArray(array), Is.EqualTo(expectedResult));
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
}