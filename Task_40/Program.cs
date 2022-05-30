// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите 1е число -> ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите 2е число -> ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите 3е число -> ");
int c = int.Parse(Console.ReadLine());

string txt = "Треугольника с такими сторонами не существует";
if ((a + b) > c && (a + c) > b && (b + c) > a) txt = "Треугольник с такими сторонами может существовать";

Console.WriteLine(txt);

// int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
// Console.Write($"{array[0]} {array[1]} {array[2]}");