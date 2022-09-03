Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
int c = 1;
if (a>9 || a<1)
Console.WriteLine("Введено неверное число");
    else
    {
    while (b<=a)
        {
        Console.WriteLine(c);
        b=b+1;
        c=(c*10)+b;
    
        }
    }