int a, b, c, d, s;
d = 10000; // Distance
a = 1; // Speed 1
b = 2; // Speed 2
c = 5; // Speed dog
s = (1, 2);
int count = 0;
int time = 0;

while (d >= 10)
{
    if (s = 1)
    {
        time = d / (a + c);
        s = 2;
    }
 
    if (s = 2)
    {
        time = d / (b + c);
        s = 1;
    }

    d = d - (a + b) * time;
    count = count + 1;
}
Console.WriteLine(count);