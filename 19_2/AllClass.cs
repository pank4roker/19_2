using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_2
{
    class DerivedClass : IMeth
    {
        public void Method()
        {
            Console.WriteLine("Метод, реализованный в классе DerivedClass");
        }
    }
    class TVSet : ISwitchable
    {
        public void Off()
        {
            Console.WriteLine("Включение");
        }

        public void On()
        {
            Console.WriteLine("Выключение");
        }
    }
    class Task3 : IInterface3
    {
        public void Method1()
        {
            Console.WriteLine("Method1()");
        }

        public void Method2()
        {
            Console.WriteLine("Method2()");
        }

        public void Method3()
        {
            Console.WriteLine("Method3()");
        }
    }
    class PersonalComputer : ISwitchable
    {
        public void Off()
        {
            Console.WriteLine("Включение");
        }

        public void On()
        {
            Console.WriteLine("Выключение");
        }
    }
    class MyClass : IPi, INumber, ISq, IRoot
    {
        public int X { get; set; }
        public MyClass() { }
        public MyClass(int x)
        {
            X = x;
        }
        public int Number()
        {
            return X;
        }

        public double Pi()
        {
            return Math.PI;
        }

        public double Root()
        {
            return Math.Pow(X, 2);
        }

        public double Sq()
        {
            return Math.Sqrt(X);
        }
        public void Info()
        {
            Console.WriteLine($"{Number()}\n{Pi()}\n{Root()}\n{Sq()}");
        }
    }
    class People : ITalk, IThink
    {
        public void Talkloud()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование!");
        }
        public void Think()
        {
            Console.WriteLine("Думает - A С# больше всего");
        }
        public void Talkok()
        {
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры");
        }
    }
    class A: IBasicArithmetic
    {
        public virtual double Add(double x, double y)
        {
            return x + y;
        }

        public virtual double Subtract(double x, double y)
        {
            return x - y;
        }

        public virtual double Multiply(double x, double y)
        {
            return x * y;
        }

        public virtual double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("На 0 делить нельзя");
            }
            return x / y;
        }
    }
    class Aa: A
    {
        public override double Multiply(double x, double y)
        {
            return base.Multiply(x, y);
        }

        public override double Divide(double x, double y)
        {
            return base.Divide(x, y);
        }
    }
    class Ab : A, IAdvancedOperations
    {
        public double Square(double x)
        {
            return x * x;
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
    class Player : IRecordable , IPlaybale
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание...");
        }

        public void Record()
        {
            Console.WriteLine("Запись..");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза.");
        }

        public void Stop()
        {
            Console.WriteLine("Остановка.");
        }
    }

}
