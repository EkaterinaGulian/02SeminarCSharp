// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <=7) 
{
	if (day >= 6) 
    {
		Console.Write("Да, это выходной день)");
	} 
    else 
    {
		Console.Write("Нет, это рабочий день");
	}
} 
else 
{
	Console.Write("Введите цифру от 1 до 7, соответствующую дню недели");
}