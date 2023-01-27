// Напишите программу, котороя на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
int Num = int.Parse(Console.ReadLine()!)!;
int Arr = 0;
while (Arr < Num) {
    Arr += 1;
    Console.WriteLine(Arr);
}

