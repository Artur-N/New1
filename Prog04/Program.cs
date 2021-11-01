int a, b, c, d, s;
d = 10000; // Distance
a = 1; // Speed 1
b = 2; // Speed 2
c = 5; // Speed dog
s = 2;
int count = 0;
int time;

while (d > 5)
{
    if (s == 1)
    {
        time = d / (a + c);
        s = 2;
    }

    else
    {
        time = d / (b + c);
        s = 1;
    }

    d = d - (a + b) * time;
    count++;
}
Console.WriteLine(count);
Console.WriteLine(d);
