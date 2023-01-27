// Напишите программу, котороя на вход принимает два числа и выдает, какое сичло больше, а какое меньше.
Console.Clear();
Console.WriteLine("Введите два числа: ");
int Num_1 = int.Parse(Console.ReadLine());
int Num_2 = int.Parse(Console.ReadLine());
if (Num_1 > Num_2) {
    Console.WriteLine("Первое число больше второго");
}
else if (Num_2 > Num_1) {
    Console.WriteLine("Второе число больше первого");
}