
string[,] table = new string[2, 5]; //Создание двумерного массива "table" - название, "2" - кол-во строк, "5" - кол-во столбцов
//String.Empty - константа инициализации строк (пустая строка)
//table[0, 0]  table[0, 1] table[0, 2]  table[0, 3] table[0, 4]
//table[1, 0]  table[1, 1] table[1, 2]  table[1, 3] table[1, 4]


// table[1, 2] = "слово";// обращение к элементу в массиве - "1" - индекс строки, "2" - индекс стобца.

// for (int rows = 0; rows < 2; rows++) //rows - индекс (название) счётчика по строкам (типа i) сипользовать можно любой символ/название
// {
//     for (int columns = 0; columns < 5; columns++)//columns - индекс (название) счётчика по столбцам (типа i) сипользовать можно любой символ/название
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

//Метод создания двумерного массива
//_________________________________

// int[,] matrix = new int[3, 4]; //задаём двумерный массив (матрицу) 3 строки, 4 столбца


// for (int rows = 0; rows < matrix.GetLength(0); rows++) // "matrix.GetLength(0)" - кол-во строк в массиве
// {
//     for (int columns = 0; columns < matrix.GetLength(1); columns++) // "matrix.GetLength(1)" - кол-во столбцов в массиве
//     {
//         Console.Write($"{matrix[rows, columns]} "); //выводим столбцы в строку
//     }
// Console.WriteLine(); //при окончании цикла, вывод строк начинаем с новой строки
// }

//Метод создания двумерного массива с выводом
//___________________________________________

// int[,] matrix = new int[3, 4]; //задаём двумерный массив (матрицу) 3 строки, 4 столбца

// void PrintArray(int[,] matr)  //метод вывода на экран массива с заполнением числами
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++) // "matr.GetLength(0)" - кол-во строк в массиве
//     {
//         for (int columns = 0; columns < matr.GetLength(1); columns++) // "matr.GetLength(1)" - кол-во столбцов в массиве
//         {
//             Console.Write($"{matr[rows, columns]} "); //выводим столбцы в строку
//         }
//     Console.WriteLine(); //при окончании цикла, вывод строк начинаем с новой строки
//     }
// }

// int[,] matrix = new int[3, 4]; //задаём двумерный массив (матрицу) 3 строки, 4 столбца

// PrintArray(matrix);

//Метод создания двумерного массива с печатью и заполнением случайными числами
//______________________________________________________________________________

void PrintArray(int[,] matr)  //метод вывода на экран массива
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // "matr.GetLength(0)" - кол-во строк в массиве
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // "matr.GetLength(1)" - кол-во столбцов в массиве
        {
            Console.Write($"{matr[rows, columns]} "); //выводим столбцы в строку
        }
    Console.WriteLine(); //при окончании цикла, вывод строк начинаем с новой строки
    }
}

void FillArray(int[,] matr)// метод заполнения матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i, j] = new Random(). Next(1, 10);  
        }
    }
}
int[,] matrix = new int[3, 4]; //задаём двумерный массив (матрицу) 3 строки, 4 столбца
PrintArray(matrix);// Печать шаблона
FillArray(matrix); // Заполнение случайными числами
Console.WriteLine();// пустая строка между шаблоном и заполненным массивом
PrintArray(matrix); //Печать заполненного масива