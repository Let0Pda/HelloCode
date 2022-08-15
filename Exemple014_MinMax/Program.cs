// 1/ Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

//int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // определение  массива "[]", определение значений массива {}

int[] arr = new int[44];
Random rand = new Random();
for (int y = 0; y < arr.Length; y++)
{
    arr[y] = rand.Next(1, 10);
}

void PrintArray(int[] array)  // Метод вывода массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // Метод сортировки
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j; // поиск минимального элемента

        }

        int temporary = array[i];           //замена элементов местами
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);