// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли первое число кратным второму. Если число 1 не кратно числу 2,
// то программа выводит остаток от деления.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine(num1 + " кратно " + num2);
}
else
{
    int ostatok = num1 % num2;
    Console.WriteLine("остаток от деления " + ostatok);
}