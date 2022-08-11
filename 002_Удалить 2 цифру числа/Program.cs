// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


int randomNumber = GetRandomNumber(100, 999);
Console.WriteLine(randomNumber);



// int firstDigit = randomNumber / 100;
// int lastDigit = randomNumber % 10;

// Console.Write(firstDigit * 10 + lastDigit);
 
int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max+1);
}

int DelSecNum (int num)
 {
    int firstDigit = randomNumber / 100;
    int lastDigit = randomNumber % 10;
    return firstDigit * 10 + lastDigit;
} 

Console.Write(DelSecNum(randomNumber));