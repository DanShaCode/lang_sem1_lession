int num1;
int num2;

num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 / num2 == num2)
{
    Console.WriteLine("Первое введеное число ЯВЛЯЕТСЯ квадратом второго");
}
else
{
    Console.WriteLine("Первое введеное число НЕ ЯВЛЯЕТСЯ квадратом второго");
}