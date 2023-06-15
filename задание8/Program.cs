Console.Clear();
Console.Write("Введите число:");
string userInput1 = Console.ReadLine() ?? "";
int n = int.Parse(userInput1);

int count = 1;
while (count <= n)
{
    int what = new Random().Next(1, n);
    if (what % 2 == 0)
    {
        Console.WriteLine($" what = {what}");
        count = count + 1;
    }
}

