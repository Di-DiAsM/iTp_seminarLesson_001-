// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();

int firstDevider = 7;
int secondDevider = 23;

int num = ReadInt("Введите число: ");

// Console.WriteLine("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());

// if(num % 7 == 0 && num % 23 ==0)
if (Multiple(num, firstDevider) || Multiple(num, secondDevider))
{
    Console.WriteLine("Число " + num + " кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Число " + num + " некратно одновременно 7 и 23");
}


bool Multiple(int a, int b)
{
    return a % b == 0;
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
