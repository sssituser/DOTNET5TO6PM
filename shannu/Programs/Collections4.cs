using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Student1 : IComparable
    {

        public int id;
        public string name;
        public int age;

        public Student1() { }
        public Student1(int id, string name, int age)
        {
            this.id = id;
            this.name = name;   
            this.age = age;
        }

        public int CompareTo(object obj)
        {
            Student1 stu1 = obj as Student1;
            //if (this.id < stu1.id)
            //    return -1;
            //if (this.id > stu1.id)
            //    return 1;
            //return 0;
            return this.name.CompareTo(stu1.name);
        }
        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Age: {age}";
        }

    }

    class Student2
    {
        public string SName;
        public int SId;
        public Student2() { }
        public Student2 (string SName, int SId)
        {
            this.SName = SName;
            this.SId = SId;
        }
        public override string ToString()
        {
            return $"Name: {SName}\t S Id: {SId}";
        }
    }
    internal class Collections4
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Student1(11,"Shannu",25));
            arrayList.Add(new Student1(12, "RAj", 25));
            arrayList.Add(new Student1(13, "ajay", 25));
            arrayList.Add(new Student1(17, "yuvaraj", 25));
            arrayList.Add(new Student1(19, "vikas", 25));
            arrayList.Add(new Student1(14, "mahes", 25));


            arrayList.Sort();
            arrayList.Reverse();

            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }

            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add(new Student2("shannu", 13));
            arrayList2.Add(new Student2("RAj", 11));
            arrayList2.Add(new Student2("ajay", 16));
            arrayList2.Add(new Student2("yuvaraj", 18));
            arrayList2.Add(new Student2("mahes", 11));


            foreach(object i in arrayList2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
