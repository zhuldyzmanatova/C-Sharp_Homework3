#pragma warning disable

// Домашка
// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]
// массив [10 21 14 93 23] => 2

/*
int[] array = new int[10];
Console.Write("массив [");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,101);
    Console.Write(array[i] +" ");
}
Console.Write("] => ");

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 19 && array[i] < 90)
    {
        count++;
    } 
}
Console.Write(count);
*/

// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

/*
int[] array = new int[10];
Console.Write("массив [");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,101);
    Console.Write(array[i] +" ");
}
Console.Write("] => ");

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] %2 == 0)
    {
        count++;
    } 
}
Console.Write(count);
*/

// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

/*
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

double[] array = new double[num];
Console.Write("массив [");

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.NextDouble() * 100;
    Console.Write($"{array[i]:F2} ");
}
Console.Write("] => ");

double max = array[0];
double min = array[0];

for(int i = 0; i < array.Length; i++)
{
    if(max < array[i])
    {
        max = array[i]; 
    } 
    if(min > array[i])
    {
        min = array[i];
    }
}
Console.Write($"{(max-min):F2}");
 */
