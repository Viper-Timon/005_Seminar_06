// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 *  x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// y1 = k1 * x + b1;
// y2 = k2 * x + b2;
// --> k1 * x + b1 = k2 * x + b2; --> x = (b1 - b2) / (k2 - k1);

Console.WriteLine("Введите значения переменных для уравнений прямых");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("И");
Console.WriteLine("y = k2 * x + b2");


Console.Write("Введите b1 -> ");
var b11 = ChangeDot(Console.ReadLine());
double b1 = Convert.ToDouble(b11);

Console.Write("Введите k1 -> ");
var k11 = ChangeDot(Console.ReadLine());
double k1 = Convert.ToDouble(k11);

Console.Write("Введите b2 -> ");
var b21 = ChangeDot(Console.ReadLine());
double b2 = Convert.ToDouble(b21);

Console.Write("Введите k2 -> ");
var k21 = ChangeDot(Console.ReadLine());
double k2 = Convert.ToDouble(k21);

double xCross = (b1 - b2) / (k2 - k1);
double yCross = k1 * xCross + b1;

Console.WriteLine("Точка пересечения прямых");
Console.WriteLine($"при заданных параметрах будет в ({xCross}; {yCross})");


string ChangeDot(string txt)
{
    string tempTxt = String.Empty;
    int len = txt.Length;
    char dot = '.';
    char comm = ',';
    for (int i = 0; i < len; i++)
    {
        if (txt[i] == dot)  tempTxt = tempTxt+$"{comm}";
        else tempTxt = tempTxt+$"{txt[i]}";
    }
    txt = tempTxt;
    return txt;
}

