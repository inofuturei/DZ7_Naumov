public class ArrayProcessor
{
    // Метод для сортировки массива (Bubble Sort)
    public int[] SortArray(int[] array)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array), "Массив не может быть null");

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        return array;
    }

    // Метод для нахождения максимального числа
    public int FindMax(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Массив не может быть пустым или null");

        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
                max = num;
        }

        return max;
    }

    // Метод для вычисления среднего арифметического
    public double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Массив не может быть пустым или null");

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ArrayProcessor processor = new ArrayProcessor();

        // Пример использования методов ArrayProcessor
        try
        {
            int[] array = { 5, 3, 8, 1 };
            Console.WriteLine("Исходный массив: " + string.Join(", ", array));

            // Сортировка массива
            int[] sortedArray = processor.SortArray(array);
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", sortedArray));

            // Нахождение максимального элемента
            int max = processor.FindMax(array);
            Console.WriteLine("Максимальный элемент: " + max);

            // Вычисление среднего арифметического
            double average = processor.CalculateAverage(array);
            Console.WriteLine("Среднее арифметическое: " + average);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
