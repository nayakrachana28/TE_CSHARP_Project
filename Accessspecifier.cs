using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSHARP
{
    public class access
    {
        private string name;
        public int age;
        internal int id;

        public access(string ename,int eage, int id)
        {
            name = ename;
            age = eage;
            this.id = id;
        }

        public void display()
        {
            Console.WriteLine($"{name}");
        }
    }

    internal class encap
    {
        private string designation;
        private int salary;
        private int v;

        /// <summary>
        /// Encapuslation-wrapping into a singe function
        /// </summary>
        /// <param name="v"></param>
        public encap(int v)
        {
            this.v = v;
        }

        public int va
        {
            get { return v; }
            set { v = value; }
        }
        /// <summary>
        /// Here we use string because it is string type and get and set the details
        /// </summary>
        public string desig
        {
            
            //get { return designation; }
            set { designation = value; }
        }
        public int sal
        {

            get { return salary; }
            set { salary = value; }
        }

        public void give()
        {
            Console.WriteLine($"{designation}: {salary} :{v}");
            //here the desig showes error because it does not have get method
            //Console.WriteLine($"{desig}:{sal}");
        }

    }
    public class Accessspecifier
    {
        public static void Main()
        {
            access spec = new access("rachana",20,7);
            //It is private cannot access the name propeties
            //Console.WriteLine(spec.name);
            spec.display();
            //internal is same like a public but they can be accessed in another project
            Console.WriteLine(spec.id++);
            Console.WriteLine(spec.id);
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n");

            //Encapuslation
            encap e = new encap(4);
            e.sal = 1000;
            e.desig = "Developer";
            Console.WriteLine(e.sal);
            //Here the get method is not called so it showes errot
            //Console.WriteLine(e.desig);
            //if I give value v here it will set as 6
            //e.va = 6;
            e.give();
            //If the value v is set here it will give 4 then it will be 6
            e.va = 6;
            Console.WriteLine(e.va);

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n");

        }
    }
}
