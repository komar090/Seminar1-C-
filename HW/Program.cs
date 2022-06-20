// ДОМАШНЕЕ ЗАДАНИЕ 1

// Задача 2

/*

int num1, num2;

Console.Write("Введите 1-е число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Большее: " + num1);
    Console.WriteLine("Меньшее: " + num2);
}

else
{
    Console.WriteLine("Большее: " + num2);
    Console.WriteLine("Меньшее: " + num1);
}

*/

// Задача 4

/*

int num1, num2, num3;

Console.Write("Введите 1-е число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3-е число: ");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 && num1 > num3)
{
    Console.WriteLine("Наибольшее: " + num1);
}
else if(num2 > num3)
{
    Console.WriteLine("Наибольшее: " + num2);
}
else
{
    Console.WriteLine("Наибольшее: " + num3);
}

*/

// Задача 6

/*

int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число " + num + " четное");
}
else
{
    Console.WriteLine("Число " + num + " нечетное");
}

*/

// Задача 8

int num, cur;

cur = 2;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

while (cur <= num)
{
    Console.Write(cur + " ");
    cur = cur + 2;
}