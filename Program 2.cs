
Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if(a > b)
{
    max = a;
}
else{
    max = b;
}
if(c > max)
{ 
    max = c;

}
 Console.WriteLine("Максимальное из этих чисел:" +max);
 
