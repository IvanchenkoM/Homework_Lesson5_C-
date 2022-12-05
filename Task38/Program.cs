/*Задайте массив, вещественных чисел. 
Найдите разницу между max и min элементом массива.
*/

int number = ReadIn("Enter the number of array elements: ");
double[] array= new double[number];

FillArrayRandomNumbers(array);//функция заполнения массива
PrintArray(array);//функция печати массива

double max=array[0];
double min=array[0];
for(int j=0;j<array.Length; j++)
{
    if (array[j]>max)
    {
        max=array[j];
    }
    else if (array[j]<min)
    {
        min=array[j];
    }
}

Console.WriteLine($"The max array elements is {max}.");
Console.WriteLine($"The min array elements is {min}.");
Console.WriteLine($"The max difference between max and min is {max-min}.");

int ReadIn(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(double[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]= Convert.ToDouble(new Random().Next(-10,11));
    }
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("]");
}