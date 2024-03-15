namespace Numerology.Tests;

public class Tests
{
    NumberReplacer numberReplacer;

    [SetUp]
    public void Setup()
    {
        numberReplacer = new NumberReplacer();
    }

    [Test]
    public void Replace_EmptyArray_ShouldReturnEmptyArray()
    {
        int[] inputArray = [];
        int[] actualResult = numberReplacer.Replace(inputArray);
        Assert.That(actualResult is [], Is.True);
    }

    [Test]
    public void Replace_One9_WithTwo10()
    {
        int[] inputArray = [9];
        int[] actualResult = numberReplacer.Replace(inputArray);
        Assert.True(actualResult is [10, 10]);
    }

    [Test]
    public void Replace_InStep1ExampleArray()
    {
        int[] inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int[] expectedResult = [1, 1, 3, 4, 5, 6, 7, 8, 10, 10, 10];

        int[] actualResult = numberReplacer.Replace(inputArray);

        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }

    [Test]
    public void Replace_WhenArrayHasOnlyOne2_ShouldReturn_EmptyArray()
    {
        int[] inputArray = [2];
        int[] expectedResult = [];

        int[] actualResult = numberReplacer.Replace(inputArray);

        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }

    [Test]
    public void Replace_WhenArrayHasOnly2_ShouldReplace()
    {
        int[] inputArray = [2, 3];
        int[] expectedResult = [3];

        int[] actualResult = numberReplacer.Replace(inputArray);

        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }

    [Test]
    public void Replace_WhenArrayHasOne1AndOne2_ShouldReturn_11()
    {
        int[] inputArray = [1, 2];
        int[] expectedResult = [1, 1];

        int[] actualResult = numberReplacer.Replace(inputArray);

        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }

}
