Console.WriteLine("Input numbers of day: ");
int N = Convert.ToInt32(Console.ReadLine());
int T = 0;
int i = 1;
int count = 0;
int max = 0;

while(i <= N)
{
Console.Write("Input Temp: ");
T = Convert.ToInt32(Console.ReadLine());
i++;
    if(T > 0)
    count++;
    if(count > max)
    max = count;
    if(T < 1)
    count = 0;
}

Console.WriteLine(max);
