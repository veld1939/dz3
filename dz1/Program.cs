// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;
int Number = number;
int numbers;

while(number > 0)
{
   numbers = number%10;
   result = result*10 + numbers;
   number = number / 10;

}
if(Number == result)
{
    System.Console.Write("Да ");
}
else
{
    System.Console.Write("Нет ");
}