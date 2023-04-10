// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] ConvertStringsToArray()
{
    int count = 0;
    string[] array = new string[count];
    string[] temp;
    string s;
    do
    {
        s = Console.ReadLine();
        if (s != "")
        {
            count++;
            temp = new string[count];
            for (int i = 0; i < temp.Length - 1; i++)
            {
                temp[i] = array[i];
            }
            temp[count - 1] = s;
            array = temp;
        }
    } while (s != "");
    return array;
}

void PrintArrayStrings(string[] set)
{
    Console.Write("[");
    for (int i = 0; i < set.Length - 1; i++)
    {
        Console.Write($"{set[i]}, ");
    }
    Console.Write($"{set[set.Length - 1]}]");
    Console.WriteLine();
}

string[] DetermineLengthElementFormNewArrayStrings(string[] set) 
{
    int count = 0;
    string[] arrstring = new string[count];
    string[] temp;
    for (int i = 0; i < set.Length; i++)
    {
        string k = set[i];
        int length = k.Length;
        if (length < 4)
        {
            count++;
            temp = new string[count];
            for (int j = 0; j < temp.Length - 1; j++)
            {
                temp[j] = arrstring[j];
            }
            temp[count - 1] = k;
            arrstring = temp;
        }
    }
    return arrstring;
}

Console.WriteLine("Введите несколько строк. После каждой строки нажмите <Enter>.");
Console.WriteLine("После завершения ввода нажмите <Enter>.");
string[] array = ConvertStringsToArray();
PrintArrayStrings(array);
string[] arrstring = DetermineLengthElementFormNewArrayStrings(array);
PrintArrayStrings(arrstring);

