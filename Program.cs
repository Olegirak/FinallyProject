// Эадача
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решениями не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return result;
}

// string CreateStr()
// {
//     var rnd = new Random();
//     var lenstr = rnd.Next(1, 5);
//     string str = string.Empty;
//     while (lenstr > 0)
//     {
//         str += (char)rnd.Next(0, 156);
//         lenstr -= 1;
//     }
//     return str;
// }

// string[] GetMasString(int N)
// {
//     string[] array = new string[N];
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = CreateStr();
//     }
//     return array;
// }

int NumSymbStr(string str)
{
    int k = 0;
    while (str != string.Empty)
    {
        str = str[..^1];
        k = k + 1;
    }
    return k;
}

string[] SortMas(string[] mas, int sortlen)
{
    int y = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (NumSymbStr(mas[i]) <= sortlen)
        {
            y = y + 1;
        }
    }
    string[] a = new string[y];
    int k = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (NumSymbStr(mas[i]) <= sortlen)
        {
            a[k] = mas[i];
            k = k + 1;
        }
    }
    return a;
}

void printArray(string[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + array[i] + ";";
    }
    result = result[..^1] + "]";
    Console.WriteLine(result);
}

int sort = GetDataFromUser("Введите число символов для сортировки");
int n = GetDataFromUser("Введите число элементов массива");
// string[] Array = GetMasString(n);
string [] Array = new string [n];
for( int i = 0;i<n;i++)
{
    Array[i]=Console.ReadLine();
}


printArray(Array);
printArray(SortMas(Array, sort));
