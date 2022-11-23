Console.WriteLine("Hello, World!");
Console.WriteLine(123);
Console.WriteLine(4567);

string myName1 = "Bob";
Console.WriteLine(myName1);

int age = 32;
Console.WriteLine(age);

int result;
result = age  * 10;
Console.WriteLine(result);

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Это число {num + 1000}");

if(num > age) // УСЛОВИЕ без точки с запятой
{
    Console.WriteLine($"{num} > {age}"); //ТЕЛО цикла
}
else
{
    Console.WriteLine($"{num} меньше {age}"); // Что будет выведено на экран, если не будет выполнено уловие в ТЕЛЕ цикла
}





