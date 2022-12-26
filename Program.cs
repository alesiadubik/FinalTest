// Написать программу, которая из имеющегося массива строк
// формирует массив из строк,длина которых меньше либо равна 3 символа.
//Первоначально массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

string[] array = new string [6] {"hello", "world", "yes", "123", "no", "ok"};
string[] arraynew = new string [array.Length];

void FinalArray(string[] array, string[] arraynew)
{
    int index =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            arraynew[index]=array[i];
            index++;
        }
    }
}
void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
System.Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
FinalArray(array, arraynew);
System.Console.WriteLine("Новый массив:");
PrintArray(arraynew);