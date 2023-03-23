
Console.Clear();
string[] Array1 = new string[7] {"Воронеж","Уфа","Москва","Обь","Лоо","Тверь","111"};
string[] Array2 = new string[Array1.Length];

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(Array1, Array2);
PrintArray(Array2);