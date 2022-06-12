
Console.Write("Введите число от 1 до 7:");

int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number < 6)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine ("Нет");
}