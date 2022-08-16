
//Сортировка массива от Максимального к минимальному
Console.Clear();
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) // метод "void", печать (вывод массива) в качестве аргумента - массив
{
    int count = array.Length; //получение кол-ва элементов

    for (int i = 0; i < count; i++) //цикл "for" в котором пробегаем по всем элементам массива
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++) // текущий элемент. Отнимаем 1 от array.Length так как проверку начинаем с i + 1
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++) // поиск максимального элемента со второго элемента (i + 1)
                                                    // по всему массиву  (array.Length)
        {
            if (array[j] > array[maxPosition]) maxPosition = j; //сохранение выявленного Макс значения
        }

        int temporary = array[i];
        array [i] = array[maxPosition]; // обмен данных ежду переменными
        array[maxPosition] = temporary;//temporary - временная переменная
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
