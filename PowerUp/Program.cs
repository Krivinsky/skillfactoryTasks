// See https://aka.ms/new-console-template for more information
Console.WriteLine("Task 5.5.8");

Console.WriteLine(PowerUp(2, 2));
Console.WriteLine(PowerUp(2, 3));
Console.WriteLine(PowerUp(2, 4));

static int PowerUp(int N, byte pow)
{
    if (pow == 0) return 1;
    else
    {
    N = N * (PowerUp(N, --pow));

    }
    return N;
}