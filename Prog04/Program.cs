int a, b, c, d, e;
d = 10000; // Distance
a = 1; // Speed 1
b = 2; // Speed 2
c = 5; // Speed dog
e = (1, 2);
count = 0;
int time = 0;

while (d >= 10)
{
    if (e = 1)
    {
        time = d / (a + c);
        e = 2;
    }

    if (e = 2)
    {
        time = d / (b + c);
        e = 1;
    }

    d = d - (a + b) * time;
    count = count + 1;
}
Console.WriteLine(count);