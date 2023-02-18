// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());


if (B % A == 0)
{
    System.Console.WriteLine("числа кратны");
}
else 
{
    System.Console.WriteLine("Числа не кратны, остаток равен "  + B % A);
}

