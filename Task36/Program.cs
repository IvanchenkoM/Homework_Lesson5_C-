/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму эл-тов, стоящих в нечетных позициях.*/

int number = ReadIn("Enter the number of array elements: ");
int[] array= new int[number];

for(int i=0; i<array.Length; i++)
{
    array[i]= new Random().Next(-10,11);
    Console.Write(array[i]+" ");
}

int sumOdd=0;
for(int j=1;j<array.Length; j+=2)
{
    sumOdd+=array[j];
}

Console.WriteLine($" -> The sum of odd array elements is {sumOdd}.");

int ReadIn(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}