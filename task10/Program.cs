Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
    int digit1 = number / 10;
    int digit2 = digit1 % 10;
    Console.WriteLine(digit2);
}
else 
{
    Console.WriteLine("Вы ввели неверное число");
}