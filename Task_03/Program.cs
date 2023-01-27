// Напишите программу, котороя на вход принимает число и выдает, являеться ли оно четным. 
Console.Clear();
Console.WriteLine("Введите число: ");
int Num = int.Parse(Console.ReadLine()!)!;
if (Num % 2 == 0) {
    Console.WriteLine("Число " + Num + " Да");
}
else {
    Console.WriteLine("Число " + Num + " Нет");
}
