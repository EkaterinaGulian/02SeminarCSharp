// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


System.Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A % 7 == 0 && A % 23 == 0)
{
    System.Console.WriteLine($"число {A} кратно 7 и 23");
}
else 
{
    System.Console.WriteLine($"число {A} не кратно 7 и 23");
}