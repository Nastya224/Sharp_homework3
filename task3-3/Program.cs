Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine());

for (int i = 1; i <= a; i=i+1)
{
    int d = i*i*i;
    Console.Write(d);
    Console.Write(" ");
}