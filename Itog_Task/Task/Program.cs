//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

string[] array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

string[] GetStringsLengthless3(string[] array)
{
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int i = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            resultArray[i] = str;
            i++;
        }
    }
    return resultArray;
}

void PrintresultArray(string[] result)
{
    Console.Write("[");
    for (int i = 0; i < result.Length; i++)
    {
        if (i < result.Length - 1)
        {
            Console.Write($"{result[i]}, ");
        }
        else
        {
            Console.Write($"{result[i]}");
        }
    }
    Console.WriteLine("]");
}

string[] result = GetStringsLengthless3(array);
PrintresultArray(result);