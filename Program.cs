
Console.Clear();

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
    Console.WriteLine ("Введенное число является четным");
else
Console.WriteLine("Введенное число является нечетным");
