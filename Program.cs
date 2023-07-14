double PI = 3.14;

//1. Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).

System.Console.Write("Task 1.\nEnter a: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Enter b: ");
int b = int.Parse(Console.ReadLine());
int S = a*b;
int P = 2*(a+b);
System.Console.WriteLine($"Ploshad': {S} / Perimetr: {P}");


//2.Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14.

System.Console.Write("\nTask 2.\nEnter d: ");
int d = Convert.ToInt32(Console.ReadLine());
double L = PI * d;
System.Console.WriteLine($"Dlina Okruzhnosti: {L}");


//3. Дана длина ребра куба a. Найти объем куба V = a^3 и площадь его поверхности S = 6·a^2 .

System.Console.Write("\nTask 3.\nEnter a: ");
int a1 = int.Parse(Console.ReadLine());
double V = Math.Pow(a1,3);
double S1 = 6 * Math.Pow(a1,2);
System.Console.WriteLine($"Ob'em kuba: {V} / Ploshad' poverxnosti: {S1}");


//4. Даны длины ребер a, b, c прямоугольного параллелепипеда. Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).

System.Console.Write("\nTask 4.\nEnter a: ");
int a4 = int.Parse(Console.ReadLine());
System.Console.Write("Enter b: ");
int b4 = int.Parse(Console.ReadLine());
System.Console.Write("Enter c: ");
int c4 = int.Parse(Console.ReadLine());
int V4 = a4*b4*c4;
int S4 = 2*(a4*b4 + b4*c4 + a4*c4);
System.Console.WriteLine($"Ob'em Pryamougolnika: {V4} / Ploshad' poverxnosti: {S4}");


//5. Найти длину окружности L и площадь круга S заданного радиуса R: L = 2·π·R, S = π·R^2 . В качестве значения π использовать 3.14
System.Console.Write("\nTask 5.\nEnter R: ");
int R = int.Parse(Console.ReadLine());
double L2 = 2*PI*R;
double S2 = PI*Math.Pow(R,2);
System.Console.WriteLine($"Dlina Okruzhnosti: {L2} / Ploshad' Kruga: {S2}");


//6. Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.

System.Console.Write("\nTask 6.\nEnter FirstNumber: ");
double number1 = double.Parse(Console.ReadLine());
System.Console.Write("Enter SecondNumber: ");
double number2 = double.Parse(Console.ReadLine());
    if (number1 == 0 || number2 == 0)
        {
            System.Console.WriteLine("Numbers cannot be 0!");
        }
        else 
            {
                System.Console.WriteLine($"Summa: {number1} + {number2} = {number1+number2}");
                System.Console.WriteLine($"Raznost: {number1} - {number2} = {number1-number2}");
                System.Console.WriteLine($"Proizvedenie: {number1} * {number2} = {number1*number2}");
                System.Console.WriteLine($"Chastnoe: {number1} / {number2} = {number1/number2}");
            }


//7. Даны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и периметр P: c = √ a^2 + b^2 , P = a + b + c.


//8. Дано расстояние L в сантиметрах. Используя операцию деления нацело, найти количество полных метров в нем (1 метр = 100 см).

System.Console.Write("\nTask 8.\nEnter L: ");
int L3 = int.Parse(Console.ReadLine());
int M = L3/100;
System.Console.WriteLine($"{M} meter");


//9. Дана масса M в килограммах. Используя операцию деления нацело, найти количество полных тонн в ней (1 тонна = 1000 кг).

System.Console.Write("\nTask 9.\nEnter L: ");
int L4 = int.Parse(Console.ReadLine());
int T = L4/1000;
System.Console.WriteLine($"{T} ton");


//10. Дан размер файла в байтах. Используя операцию деления нацело, найти количество полных килобайтов, которые занимает данный файл (1 килобайт = 1024 байта).

System.Console.Write("\nTask 10.\nEnter byte: ");
int byte1 = int.Parse(Console.ReadLine());
int kbyte = byte1/1024;
System.Console.WriteLine($"{kbyte} kbyte");


//11. Даны целые положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений). 


//12. Используя операцию деления нацело, найти количество отрезков B, размещенных на отрезке A.


//13. Дано целое число A. Проверить истинность высказывания: «Число A является положительным».

System.Console.Write("\nTask 13.\nEnter A: ");
int A = int.Parse(Console.ReadLine());
bool B = (A>0);
System.Console.WriteLine(B);


//14. Дано целое число A. Проверить истинность высказывания: «Число A является нечетным».

System.Console.Write("\nTask 14.\nEnter A: ");
int A1 = int.Parse(Console.ReadLine());
bool B1 = (A1%2!=0);
System.Console.WriteLine(B1);


//15. Дано целое число A. Проверить истинность высказывания: «Число A является четным».

System.Console.Write("\nTask 15.\nEnter A: ");
int A2 = int.Parse(Console.ReadLine());
bool B2 = (A2%2==0);
System.Console.WriteLine(B2);