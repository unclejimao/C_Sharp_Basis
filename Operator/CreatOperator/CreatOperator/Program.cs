using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Name = "Jerry";
            person2.Name = "Rabbit";
            //List<Person> nation = Person.GetMarry(person1, person2);
            List<Person> nation = person1 + person2;
            foreach (var p in nation)
            {
                Console.WriteLine(p.Name);
            }
        }
    }

    class Person
    {
        public string Name;

        // GetMarry()方法
        public static List<Person> GetMarry(Person person1,Person person2)
        {
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = person1.Name + "&" + person2.Name + "s'child";
                people.Add(child);
            }

            return people;
        }

        //下面创建自定义操作符“+”来完成GetMarry()方法的功能
        public static List<Person> operator +(Person person1,Person person2)
        {
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = person1.Name + "&" + person2.Name + "s'child";
                people.Add(child);
            }

            return people;
        }
    }
}
