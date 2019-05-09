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
            Student student = new Student(007,"Cobe");
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.WriteLine("====================");
            Student student2 = new Student();
            Console.WriteLine(student2.ID);
            Console.WriteLine(student2.Name);

            Calulator c = new Calulator();
            int r = c.Add(1, 2, 3);
            Console.WriteLine("====================");
            Console.WriteLine(r);
        }
    }

    class Calulator
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
