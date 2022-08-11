// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли первое число кратным второму. Если число 1 не кратно числу 2,
// то программа выводит остаток от деления.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = ReadInt("Введите первое число: ");
int num2 = ReadInt("Введите второе сисло: ");


int remeinderOfDivision = num1 % num2;

if (remeinderOfDivision == 0)
{
    Console.WriteLine(num1 + " кратно " + num2);
}
else
{
    int ostatok = num1 % num2;
    Console.WriteLine("остаток от деления " + ostatok);
}

