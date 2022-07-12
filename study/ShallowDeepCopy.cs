using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    class ShallowDeepCopy
    {

        public static void Test()
        {
            // 创建Person实例并为其字段赋值
            Person p1 = new Person();
            p1.Age = 42;
            p1.Name = "Sam";
            p1.IdInfo = new IdInfo(6565);

            // 执行p1的浅拷贝并将其分配给p2
            Person p2 = p1.ShallowCopy();

            // 输出p1和p2的值
            Console.WriteLine("Original values of p1 and p2:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // 更改p1属性的值并输出p1和p2的值  (现象: p1的Age、Name、IdInfo改变后，p2的Age、Name不变，但IdInfo变化)
            p1.Age = 32;
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // 制作一个p1的深拷贝并将其分配给p3
            Person p3 = p1.DeepCopy();
            // 将p1的成员更改为新值以显示深度副本 (现象: p1的Age、Name、IdInfo改变后，p2的Age、Name、IdInfo都不变)
            p1.Name = "George";
            p1.Age = 39;
            p1.IdInfo.IdNumber = 8641;
            Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
            Console.WriteLine("      Value: {0:d}", p.IdInfo.IdNumber);
        }
    }

    //IdInfo类
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    //Person类
    public class Person
    {
        public int Age;
        public string Name;

        //引用类型
        public IdInfo IdInfo;

        //浅拷贝方法
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        //深拷贝方法
        public Person DeepCopy()
        {
            //对浅拷贝副本为引用类型的任何属性或字段赋值

            Person other = (Person)this.MemberwiseClone();
            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            return other;
        }
    }
}
