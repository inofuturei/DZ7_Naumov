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

    // ���� �� ���������� �������
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

    // ���� �� ��������� null ������� ��� ����������
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void SortArray_ShouldThrowException_WhenArrayIsNull()
    {
        // Act
        _processor.SortArray(null);
    }

    // ���� �� ������ ������
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

    // ���� �� ���������� ������������� �����
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

    // ���� �� ������ ������ ��� ���������� ������������� �����
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FindMax_ShouldThrowException_WhenArrayIsEmpty()
    {
        // Act
        _processor.FindMax(new int[] { });
    }

    // ���� �� ���������� �������� ���������������
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

    // ���� �� ������ ������ ��� �������� ���������������
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateAverage_ShouldThrowException_WhenArrayIsEmpty()
    {
        // Act
        _processor.CalculateAverage(new int[] { });
    }
}
