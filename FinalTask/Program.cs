/* Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

Console.Clear();

string[] allElementsArray = FillArray();
GetArray(allElementsArray);

string[] FillArray()
{
    Console.WriteLine("Введите строки (элементы) массива:");
    int size = 0;
    string[] аrrayStr = new string[size];
    string str;
    string[] аrray; // временный промежуточный массив
    do
    {
        str = Console.ReadLine();
        if (str != "")
        {
            size++;
            аrray = new string[size];
            for (int i = 0; i < аrray.Length - 1; i++) 
                аrray[i] = аrrayStr[i];
            аrray[size - 1] = str;
            аrrayStr = аrray;
        }
    } while (str != "");

    for (int i = 0; i < аrrayStr.Length; i++)
    {
        Console.Write('"' + аrrayStr[i] + '"' + ", ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
    Console.WriteLine();
    Console.ReadKey();
    return аrrayStr;
}

void GetArray(string[] array)
{
    string[] arrayStr = new string[array.Length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayStr[index] = array[i];
            Console.Write('"' + arrayStr[index] + '"' + ", ");
            index++;
        }
    } 
    Console.Write("\b\b ");
}

