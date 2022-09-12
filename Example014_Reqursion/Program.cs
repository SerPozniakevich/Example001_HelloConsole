// Собрать строку с числами от a до b, a <= b.

Console.Clear();
// // Способ решения без рекурсии (интеративный подход).
// string NumbersFor (int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} "; // сбор строки, следущая увеличена на единицу
//     }
//     return result;
// }

// //Способ с рекурсией.
// string NumbersRec (int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec (a +1, b);
//     else return string.Empty; //возврат пустой строки в случае не выполнения условия (а <= b)
// }

// System.Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// System.Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// // Собрать строку с числами от a до b, a >= b.


// // Способ решения без рекурсии (интеративный подход).
// string NumbersFor (int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} "; // сбор строки, следущая уменьшена на единицу
//     }
//     return result;
// }

// //Способ с рекурсией.
// string NumbersRec (int a, int b)
// {
//     if (a <= b) return NumbersRec (a +1, b) + $"{a} ";
//     else return string.Empty; //возврат пустой строки в случае не выполнения условия (а <= b)
// }

// System.Console.WriteLine(NumbersFor(10, 1)); // 10 9 8 7 6 5 4 3 2 1 
// System.Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1 

// //Найти сумму чисел от 1 до n.

// int SumFor (int n) // интеративный способ (без рекурсии).
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec (int n) // Метод с рекурсией.
// {
//     // if (n == 0) return 0; // окончание рекурсии: при достижении 0, возвращается нейтральное для сложения значение "0".
//     if (n == 1) return 1; // альтернативное окончание рекурсии: при достижении 1, возвращается конечное для сложения значение "1".
//     else return n + SumRec (n - 1);
// }

// System.Console.WriteLine(SumFor(10)); //result 55
// System.Console.WriteLine(SumRec(10)); //result 55


// //Факториал числаю

// int FactorialFor (int n) // интеративный метод.
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }

// int FactorialRec (int n) // решение рекурсией
// {
//     if (n == 1) return 1; // Момент выхода из рекурсии нейтральное число.
//     else return n * FactorialRec (n - 1);
// }

// System.Console.WriteLine(FactorialFor(10)); //result 3628800
// System.Console.WriteLine(FactorialRec(10)); //result 3628800

// //Вычислить a^n.

// int PowerFor (int a, int n) //интеративный способ.
// {   int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec (int a, int n)
// {   
//     return n == 0 ? 1 : PowerRec (a, n - 1) * a; // сокращённое написание кода с рекурсией.
//     // if (n == 0) return 1;
// //     else return PowerRec (a, n - 1) * a;
// }

// int PowerRecMath (int a, int n) //Улучшенная версия решения задачи с рекурсией.
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath (a * a, n / 2);
//     else return PowerRecMath (a, n - 1) * a;
// }

// System.Console.WriteLine(PowerFor(2, 10));      //result 1024
// System.Console.WriteLine(PowerRec(2, 10));      //result 1024
// System.Console.WriteLine(PowerRecMath(2, 10));  //result 1024

// Перебор слов:
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с", и "в".
// Покажите слова, состоящие из Т букв, которые можно построить из букв этого алфавита.

// Способ вывода однобуквенных слов.
// char[] s = { 'а', 'и', 'с', 'в'}; 
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     System.Console.WriteLine($"{n++,-5}{s[i]} " );
// }

// Способ вывода двубуквенных слов. Для вывода многобуквенных слов нужно добавлять for для каждой буквы.
// char[] s = { 'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//        System.Console.WriteLine($"{n++,-5}{s[i]}{s[j]} " ); 
//     }
// }

// int n = 1;
// void FindWords (string alphabet, char[] word, int length = 0) // 
// {
//     if (length == word.Length)
//     {
//         System.Console.WriteLine($"{n++} {new String(word) } "); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords("аисв", new char[2]);

// Как посмотреть директории.

//Просмотр информации в папке.
// string path = "C:/Users/User/Documents/Geekbrains/Examples/Example002_HelloUser";
// DirectoryInfo di = new DirectoryInfo (path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo [] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }


//Рекурсия для просмотра содержания в папках.

void CatalogInfo (string patch, string indent = "") //string (аргумент) patch - путь к текущей папке, 
// indent - второй аргумент, делающий отступы, чтобы отслеживать структуру папки.
{
    DirectoryInfo catalog = new DirectoryInfo(patch);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}" );
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}" );
    }
}

string patch = @"C:/Users/User/Documents/Geekbrains/Examples";
CatalogInfo(patch);