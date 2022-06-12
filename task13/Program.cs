Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
    while(number %   >= 1)
       {
           int digit1 = number % 10;
           int digit2 = number / 10;
           int digit3 = digit2 /10;
       }
       Console.WriteLine(digit3);
}

else
{
    Console.WriteLine("Третьей цифры нет");
}


