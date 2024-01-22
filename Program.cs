// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа,
//сумма цифр которого чётная.

//using System;
//class Program
//{
//static void Main()
//{
//while (true)
//{
//Console.Write("Введите число или 'q' для выхода: ");
//string input = Console.ReadLine();
//if (input == "q")
//{
//break;
//}
//int number;
//if (int.TryParse(input, out number))
//int sum = 0;
//while (number > 0)
//{
//sum += number % 10;
//number /= 10;
//}
//if (sum % 2 == 0)
//{
//Console.WriteLine("Stop");
//break;
//}
//}
//else
//{
//Console.WriteLine("Введите целое число или 'q'.");
//}
//}
//}
//}



//Задайте массив заполненный случайными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//using System;
//class Program
//{
//static void Main()
//{
//int[] numbers = new int[10];
//Random random = new Random();
//int evenCount = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//numbers[i] = random.Next(100, 1000);
//Console.Write(numbers[i] + " ");

//if (numbers[i] % 2 == 0)
//{
//evenCount++;
//}
//}

//Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
//}
//}


//Напишите программу, которая перевернёт одномерный массив
//(первый элемент станет последним, второй – предпоследним и т.д.)


using System;
class Program
{
static void Main()
{
int[] numbers = {5, 7, 3, 1, 6, 8};
int temp;
Console.Write("Исходный массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}
for (int i = 0; i < numbers.Length / 2; i++)
{
temp = numbers[i];
numbers[i] = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = temp;
}
Console.Write("\nПеревернутый массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}
}
}