    /*Задача 2: Напишите программу, которая на вход принимает два числа
     и выдаёт, какое число большее, а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3
    


Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if(num1 > num2)
{
    max = num1;
    min = num2;
}
else 
{
    max = num2;
    min = num1;
}

Console.WriteLine("Это число является большим - " + max);
Console.Write("Это число является меньшим - " + min);
*/

/*
    Задача 4: Напишите программу, которая принимает на вход три числа
     и выдаёт максимальное из этих чисел.
    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22


Console.Write("Enter numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)

    max = num2;

if(num3 > max)

    max = num3;

Console.Write("Наибольшее из введенных " + max);
*/

        /*Задача 6
        Напишите программу, которая на вход принимает число и 
        выдаёт, является ли число чётным (делится ли оно на два без остатка).
        

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("Число " + num + " является четным.");

else
    Console.WriteLine("Число " + num + " не является четным.");
*/

        /*Задача 8
        Напишите программу, которая на вход принимает число (N),
        а на выходе показывает все чётные числа от 1 до N
        


Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= num)
{
        if(current % 2 == 0)
    {
        Console.WriteLine(current + " ");
    }
    current++;
}
*/

