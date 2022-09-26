Console.Write("Введите координату x для a:");
double xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y для a:");
double ya = double.Parse(Console.ReadLine())!;
Console.Write("Введите координату z для a:");
double za = double.Parse(Console.ReadLine())!;

Console.Write("Введите координату x для b:");
double xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y для b:");
double yb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату z для b:");
double zb = double.Parse(Console.ReadLine()!);

double d = Math.Sqrt( Math.Pow((xa-xb),2) + Math.Pow((ya-yb),2) + Math.Pow((za-zb),2));
d = Math.Round(d,2);
Console.Write(d);