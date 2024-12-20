using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class ArrayProcessorTests
{
    private ArrayProcessor? _processor;

    [TestInitialize]
    public void Setup()
    {
        _processor = new ArrayProcessor();
    }

    // Тест на сортировку массива
    [TestMethod]
    public void SortArray_ShouldSortArrayCorrectly()
    {
        // Arrange
        int[] input = { 5, 3, 8, 1 };
        int[] expected = { 1, 3, 5, 8 };

        // Act
        int[] result = _processor.SortArray(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Тест на обработку null массива при сортировке
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void SortArray_ShouldThrowException_WhenArrayIsNull()
    {
        // Act
        _processor.SortArray(null);
    }

    // Тест на пустой массив
    [TestMethod]
    public void SortArray_ShouldHandleEmptyArray()
    {
        // Arrange
        int[] input = { };
        int[] expected = { };

        // Act
        int[] result = _processor.SortArray(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Тест на нахождение максимального числа
    [TestMethod]
    public void FindMax_ShouldReturnMaxValue()
    {
        // Arrange
        int[] input = { 5, 3, 8, 1 };
        int expected = 8;

        // Act
        int result = _processor.FindMax(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // Тест на пустой массив для нахождения максимального числа
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FindMax_ShouldThrowException_WhenArrayIsEmpty()
    {
        // Act
        _processor.FindMax(new int[] { });
    }

    // Тест на вычисление среднего арифметического
    [TestMethod]
    public void CalculateAverage_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] input = { 5, 3, 8, 1 };
        double expected = 4.25;

        // Act
        double result = _processor.CalculateAverage(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // Тест на пустой массив для среднего арифметического
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateAverage_ShouldThrowException_WhenArrayIsEmpty()
    {
        // Act
        _processor.CalculateAverage(new int[] { });
    }
}
