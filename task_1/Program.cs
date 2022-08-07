// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Решение через цикл for
// Console.WriteLine("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// A = Math.Abs(A);
// B = Math.Abs(B);

// int result = 1;

// for(int i = 1; i <= B; i++)
// {
//    result = result * A;
// }
// Console.WriteLine($"{A} в степени {B} = {result}");


// Решение через цикл while

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите степень числа {A}: ");
int B = Convert.ToInt32(Console.ReadLine());
A = Math.Abs(A);
B = Math.Abs(B);

int result = 1;
int count = 1;
while(count <= B){
   result = result * A;
   count = count + 1;
}
Console.WriteLine($"{A} в степени {B} = {result}");
