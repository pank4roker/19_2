using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_2
{
    //Task1
    interface IMeth
    {
        void Method();
    }
    //Task 2
    interface IPi
    {
        double Pi();
    }
    interface INumber
    {
        int Number();
    }
    interface ISq
    {
        double Sq();
    }
    interface IRoot
    {
        double Root();
    }
    //Task 3
    interface IInterface1
    {
        void Method1();
    }
    interface IInterface2 : IInterface1
    {
        void Method2();
    }
    interface IInterface3 : IInterface2
    {
        void Method3();
    }
    //Task4
    interface ITalk
    {
        void Talkloud();
        void Talkok();
    }
    interface IThink
    {
        void Think();
    }
    //task 5
    interface ISwitchable
    {
        void On();
        void Off();
    }
    //Task6
    interface IBasicArithmetic
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
    }

    interface IAdvancedOperations
    {
        double Square(double x);
        double SquareRoot(double x);
    }
    interface IPlaybale
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

}
