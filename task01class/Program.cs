// Программа, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа 
// Нужно сгенерировать рандомное число
// целочисленное деление (/) остаток от деления (%)

Random rand = new Random();
int number = rand.Next(10,100); //левое включается, правое значение не включается
System.Console.WriteLine($"Случайное число: {number}");

int leftNumber = number/10;
int rightNumber = number%10;

// System.Console.WriteLine($"{leftNumber} {rightNumber}");

if(leftNumber>rightNumber)
{
    System.Console.WriteLine($"левое число больше и равно {leftNumber}");
}
else if(leftNumber<rightNumber)
{
    System.Console.WriteLine($"правое число больше и равно {rightNumber}");
}
else
{
    System.Console.WriteLine("Правое число равно левому числу");
}