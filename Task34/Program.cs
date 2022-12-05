/*Задайте массив, заполненный случайными 3-хзначными числами. 
Напишите программу, которая покажет кол-во четных чисел в массиве.*/

int number = ReadIn("Enter the number of array elements: ");
int[] array= new int[number];

for(int i=0; i<array.Length; i++)
{
    array[i]= new Random().Next(100,1000);
    Console.Write(array[i]+" ");
}

int countEven=0;
for(int j=0;j<array.Length; j++)
{
    if(array[j]%2==0)
    {
        countEven++;
    }
}

Console.WriteLine($" -> In this array are {countEven} even elements.");

int ReadIn(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}