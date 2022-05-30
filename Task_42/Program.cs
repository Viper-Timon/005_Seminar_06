// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// ____________________________________________________ПЕРЕДЕЛАТЬ____________

fdsfds // подсветка для проводника

Console.WriteLine("Введите число для перевода");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите систему счисления");
int y = int.Parse(Console.ReadLine());
int len = 8;
int[] result = new int[len];
int wholePart = x; //целая часть 
int remainderPart = y; // остаточная часть

for (int i = 0; wholePart > 0; i++)
{
    // if (wholePart<=y)
    // {
    // result[i] = wholePart;
    // }
    // else
    // {
    remainderPart = wholePart % y;
    wholePart = wholePart / y;
    result[i] = remainderPart;

    Console.WriteLine($"i= {i} whole = {wholePart} rem {remainderPart}");
}
result.Reverse();


Console.WriteLine($"{String.Join(" ", result)}");