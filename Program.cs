// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int GetPositiveNum(int num)
{
    int cur = 0;
    int count =0;

    while(cur < num)
    {
        Console.WriteLine("Введите число :");
        int a = Convert.ToInt32(Console.ReadLine());
        cur++;
    if ( a > 0)
    
        count ++;
   
    }
    return count;
}

Console.WriteLine("Введите количество чисел:");
int num = Convert.ToInt32(Console.ReadLine());

int GetPositivenum = GetPositiveNum(num);
Console.WriteLine(GetPositivenum);
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Getnum(double b1, double k1, double b2, double k2)
{   

    if(k1 == k2)
    Console.Write("Прямые параллельны ");
    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения прямых x = {x}, y = {y} ");
        
        
    }
}

Console.WriteLine("Введите число b1 : ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k1 :");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введие число b2");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2 :");
int k2 = Convert.ToInt32(Console.ReadLine());

Getnum(b1,k1,b2,k2);
