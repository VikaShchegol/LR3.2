using System;

class Parent
{
    protected double Pole1;
    protected double Pole2;

    public Parent()
    {
        Pole1 = 0;
        Pole2 = 0;
    }

    public Parent(double a, double b)
    {
        Pole1 = a;
        Pole2 = b;
    }

    public void Print()
    {
        Console.WriteLine($"a={Pole1} b={Pole2}");
    }

    public double Metod1()
    {
        return Pole1 * Pole2;
    }

    public double Metod2()
    {
        return 2 * (Pole1 + Pole2);
    }
}

class Child : Parent
{
    private double Radius;

    public Child(double a) : base(a, a)
    {
        Radius = a / 2;
    }

    public double Metod3()
    {
        return Math.PI * Radius * Radius;
    }

    public double Metod4()
    {
        return 2 * Math.PI * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            double a = random.Next(1, 5);
            double b = random.Next(1, 5);

            if (a == b)
            {
                Child square = new Child(a);
                square.Print();
                Console.WriteLine($"Квадрат: площа={square.Metod1()} периметр={square.Metod2()}");
                Console.WriteLine($"Описане коло. Площа={square.Metod3():F2} Довжина={square.Metod4():F2}");
            }
            else
            {
                Parent rectangle = new Parent(a, b);
                rectangle.Print();
                Console.WriteLine($"Прямокутник: площа={rectangle.Metod1()} периметр={rectangle.Metod2()}");
            }
        }
    }
}
