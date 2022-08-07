// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);


int count = 0 , result = 1, sum = 0;
   
while(number > 0) {
result = number % 10;
// Console.WriteLine($"{result}");
number = number / 10;
sum = sum + result;
// Console.WriteLine($"результат сложения {sum}");
count = count + 1;
// Console.WriteLine($"{number}");
}
Console.WriteLine($"результат сложения {sum}");
