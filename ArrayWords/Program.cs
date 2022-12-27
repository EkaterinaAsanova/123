// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] ArrayWords = new string[] { };
ArrayWords = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write(" Введите {0} слово: ", i + 1);
        ArrayWords[i] = Console.ReadLine();
    }
Console.Write("Вы ввели следующие значения: ");
PrintArrayWords(ArrayWords);

int size = 3;   // Максимальная длина строки в новом массиве

string[] NewArrayWords = new string[ArrayWords.Length];

int Choice(string[] ArrayWords, string[] NewArrayWords)  
{   // функция возвращает количество элементов нового массива
    int count = 0;
    for (int i = 0; i < ArrayWords.Length; i++)
    {
        if (ArrayWords[i].Length <= size)
        {
            NewArrayWords[count] = ArrayWords[i];
            count++;
        }
    }
return count;
}

Console.WriteLine();
Console.WriteLine("Итоговый массив слов, длина которых меньше или равна 3: ");
Array.Resize(ref NewArrayWords, Choice(ArrayWords, NewArrayWords));
PrintArrayWords(NewArrayWords);
Console.WriteLine();

void PrintArrayWords(string[] Array)
{   // Форматированный вывод массива
    Console.Write(" [ ");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write("\"{0}\" ", Array[i]);
        if (i != Array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("] ");
    return;
}