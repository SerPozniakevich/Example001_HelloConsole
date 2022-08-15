// Вид 1
void Method1() // в скобках не указываются никакие аргументы
{
    Console.WriteLine("Автор. . ."); //метод вывода чего-то на экран
}
//Method1(); (закомментен)//Вызов метода: указать идентификатор с использоваием скобок без данных











// Вид2
void Method2(string msg) //ничего не возвращают, но принимают какие-то аргументы
    {
        Console.WriteLine(msg); //Указывая операторы, использовать принятые аргументы
    }
// Method2(msg: "Текст сообщения"); //Закомментено

// void Method21(string msg, int count) //Вывод сообщения необходимое кол-во раз
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method21(msg: "Текст", count: 4); //указывание какому аргументу, какое значение 
//Method21(count: 4, msg: "Новый текст"); //при использовании именнованных аргументов можно использовать их не попорядку







// Вид3 что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);










//Вид4  Самые важные - принимают и возвращают
// string Method4(int count, string text) //Возвращать будем строку, передавать "int count"- 
// {
//     int i = 0; //цикл
//     string result = String.Empty; //переменная для "хранения" результата "String.Empty" - изначально пустая переменная

//     while (i < count)
//     {
//         result = result + text;
//          i++;
//     }
//     return result; //оператор "return" с указанием ожидаемой переменной
// }

// string res = Method4(10, "asdf");//для вызова метода необходимо создать нужную нам переменную
                                     // "string res" (сшивание строки требуемое количество раз)

// Console.WriteLine(res);

// цикл с "for"

// string Method4(int count, string text) //Возвращать будем строку, передавать "int count"- 
// {
//     string result = String.Empty; //переменная для "хранения" результата "String.Empty" - изначально пустая переменная
//     for (int i = 0; i < count; i++) //"int i" - инициализация счётчика "i < count" - проверка условия, "i++" - инкримент
//     {
//         result = result + text;
//     }
//     return result; //оператор "return" с указанием ожидаемой переменной
// }

// string res = Method4(10, "Z");//для вызова метода необходимо создать нужную нам переменную 'string res" (сшивание строки требуемое количество раз)
// Console.WriteLine(res);

// //Цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


// // ==== Работа с текстом
// // Дан текст. В тексте нихно заменить все пробелы черточками, 
// // малеотнике буквы "к" заенить большими "К",
// // а большие "С" заменить маленькими "с".

// // Ясна ли задача?

// string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// //string s = "qwerty"
// //            012345
// //s[3] // r    

// string Replace(string text, char oldValue, char newValue) //"string text"-указание текста,
// // "char" - указание конкретного символа, "oldValue" старое значение, "newValue" новое начение
// {
//     string result = String.Empty; //переменная для "хранения" результата "String.Empty" - изначально пустая переменная

//     int length = text.Length;// свойство показывающее кол-во символов в строке
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";// "если текущий текст совпал со старым значением, то 
//         //в результат мы должны положить новое значение
//         else result = result + $"{text[i]}"; //если совпадений не обнаружено то в result добавить текущий символ
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');//"в новом тексте присвоить (Replace) текст "пробел" заенить на  "|"

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К'); // добавляем к новому тексту следующие условия замены
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с'); 
// Console.WriteLine(newText);



//Сортировка массива

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) // метод "void", в качестве аргумента - массив
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
    for (int i = 0; i < array.Length -1 ; i++) // текущий элемент
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++) // поиск минимального элемента
        {
            if (array[j] < array[minPosition]) minPosition = j; 
        }

        int temporary = array[i];
        array [i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);







