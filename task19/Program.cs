/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("введите пятизначное число");
string number = Console.ReadLine();
char[]numberReverse = number.ToCharArray();
Array.Reverse(numberReverse);
string palindrom = new string(numberReverse);

if( number == palindrom)
{
    Console.WriteLine("число " + number + " является палиндромом");
}

if(number != palindrom) 
{
    Console.WriteLine("число " + number + " не является палиндромом");
}















