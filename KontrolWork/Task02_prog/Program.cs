// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите массив значений через пробел: ");
string inputText = Console.ReadLine();
string[] stringArray = inputText.Split(' ');
string[] newarray = new string[stringArray.Length];
int count = 0;
foreach (string value in stringArray)
{
    if (value.Length <= 5)
        {
            newarray[count] = value;
            count++;
        }
}
Console.Write("[");
Console.Write(string.Join(", ", newarray, 0, count));
Console.Write("]");