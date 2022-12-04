// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<=99999)
{
  int numReverse = 0;
  int numCopy = num;
  while (num > 0)
  {
    numReverse = numReverse * 10 + (num %10);
    num = num / 10;
  };
  if (numReverse == numCopy) Console.Write("Число является палиндромом");
  else Console.Write("Число не является палиндромом");
} 
else Console.Write("Введено неправильное число");
