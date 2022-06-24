
/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. (выполнено)

int a, b;

Console.Write("Input number 1: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = " + a + " больше чем " + b);
}
else
{
    Console.WriteLine("max = " + b + " больше чем " + a);
}
*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double a, b, c;

Console.Write("Введите 1 число: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2 число: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 3 число: ");
c = Convert.ToDouble(Console.ReadLine());

double max = a;

if(b>max)
{
    max = b;
}
if(c>max)
{
    max = c;
}

Console.WriteLine("Максимальное число: "+ max);
*/




/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). (выполнено)

int a, result;

Console.Write("Input number: ");
a = Convert.ToInt32(Console.ReadLine());
result = a;
a = a % 2;

if (a == 0) 
{
    Console.WriteLine("число " + result + " делиться без остатка и = " + a);
}

else
{
    Console.WriteLine("число " + result + " не делиться без остатка и = " + a);
}
*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 1;

while (b<=a)
{
    if(b%2==0)
    {
        Console.Write(b + " ");
    }
b++;    
}

*/
