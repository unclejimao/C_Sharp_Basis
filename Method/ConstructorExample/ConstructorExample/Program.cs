using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Calculator.GetConeVolume(100, 100);
        }
    }

    class Calculator
    {
        public static double  GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }

        public static double GetCylinderVolume(double h,double r)
        {
            double a = GetCircleArea(r);
            return h * a;
        }

        public static double GetConeVolume(double h,double r)
        {
            double cv = GetCylinderVolume(h, r);
            return cv / 3;
        }
    }

    class MathCalulator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public double Add(double a,double b)
        {
            return a + b;
        }

        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
    }

    class Student
    {
        public Student()
        {
            this.ID = 1;
            this.Name = "No Name";
        }
        public Student(int initId,string initName)
        {
            this.ID = initId;
            this.Name = initName;
        }
        public Student(int text)
        {
            this.Name = "please input your name";
            this.ID = 0;
        }

        public int ID;
        public string Name;
    }
}
