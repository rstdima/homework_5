// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (вводим массив с клавиатуры (т. е. через консоль :) ))


// Вывод массива через цикл
// int[] array = new int[8];
// Random rand = new Random();

// for(int i =0; i < array.Length; i++)
// {
//    array[i] = rand.Next(-9,50);
// }
// Console.WriteLine('[' + string.Join(", ", array) + ']');


// Ввыод масива через консоль
int[] array = new int[8];
Console.WriteLine("Введите числа: ");
int n0 = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
int n4 = Convert.ToInt32(Console.ReadLine());
int n5 = Convert.ToInt32(Console.ReadLine());
int n6 = Convert.ToInt32(Console.ReadLine());
int n7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine('[' + string.Join(", ", n0, n1, n2, n3, n4, n5, n6, n7) + ']');


