// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadInt("Введите первое число ");
int b = ReadInt("Введите второе число ");

//if (num1 == num2 * num2 || num2 == num1 * num1)
if (a == Sqr(b) || b == Sqr(a))
{
    Console.WriteLine("Да, одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine("Нет, ни одно из чисел не является квадратом другого");
}

int Sqr(int c)
{
    int result = c * c;
    return result;
}

