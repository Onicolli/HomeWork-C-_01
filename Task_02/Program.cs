// Напишите программу, котороя на вход принимает три числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите три числа: ");
Console.Clear();
int Num_1 = int.Parse(Console.ReadLine()!)!;
int Num_2 = int.Parse(Console.ReadLine()!)!;
int Num_3 = int.Parse(Console.ReadLine()!)!;
int max = Num_1;
if (Num_1 > Num_2) {
    max = Num_1;
    if (Num_3 > max) {
        max = Num_3;
        Console.WriteLine(max);
    }
    else {
        max = Num_2;
        Console.WriteLine(max);
    }
    Console.WriteLine(max);
}
else {
    max = Num_2;
    if (Num_2 > Num_3)
    {
        max = Num_2;
        Console.WriteLine(max);
    }
    else {
        max = Num_3;
        Console.WriteLine(max); 
        
    }
}
