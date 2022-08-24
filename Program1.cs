citConsole.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine("Максимальное из этих чисел:" +a);
    Console.WriteLine("Минимальное из этих чисел:" +b);
}
else
{
    Console.WriteLine("Максимальное из этих чисел:" +b);
    Console.WriteLine("Минимальное из этих чисел:" +a);
}


