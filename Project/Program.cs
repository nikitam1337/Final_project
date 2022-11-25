//* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array1 = new string[5] { "Hello", "my", "name", "is", "Nikita" };

string[] array2 =  GetArray2(array1);

PrintArray(array2);

////// Methods ///////////

string[] GetArray2(string[] Array1)
{
    int count = 0;
    int temp = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
        if (Array1[i].Length <= 3) count++;
    }

    string[] array2 = new string[count];
    
    for (int j = 0; j < Array1.Length; j++)
    {
        if (Array1[j].Length <= 3)
        {
            array2[temp] = Array1[j];
            temp++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
