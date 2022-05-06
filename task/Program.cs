/* Написать программу, которая из имеющегося массива строк формирует массив
из строк, длина которых меньше либо равно 3 символа. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
решении не рекоммендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами. */

string[] array = new string[6] { "123", "array", "homework", "GB", ":-)", "Viktor" };
string[] newArray = new string[array.Length];

FillArray(array, newArray);
PrintArray(newArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
}
void FillArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}
