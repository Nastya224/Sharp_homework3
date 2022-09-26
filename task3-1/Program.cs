Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());

int first = N / 10000;
int second = N/1000 % 10;
int third = N/100 % 10;
int forth = N/10 % 10;
int five = N % 10;

if (first == five & second == forth)
{
    Console.Write(N);
    Console.WriteLine("-> да");
}
else
{Console.Write(N);
    Console.WriteLine("-> нет");
}
