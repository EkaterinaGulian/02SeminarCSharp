// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

if(B == A*A)
{
    System.Console.WriteLine("да");
}
else if(A == B*B)
{
    System.Console.WriteLine("да");
}
else 
{
    System.Console.WriteLine("нет");
}