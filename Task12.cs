using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSHARP
{
    public class Task12
    {
        //the enumarate can take the datatype and it cannot take string datatype here
        enum subject
        {
            Dotnet,
            Java = 8,
            Angular,
            ASPDOTNET,
            Database,
            Python,
            Oops,
            AWS
        }

        //want to access in method do it as public
        public enum grade 
        {
            A,
            B,
            C,
            D
        }
     
        public static void Main()
        {
           Console.WriteLine(subject.Python);
           int m=(int)subject.Dotnet;
            Console.WriteLine(m);
            int j=(int)subject.Angular;
            Console.WriteLine(j);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            gradeMarks(grade.B);
            gradeMarks(grade.D);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------------------------------");
            employee();
        }
        public static void gradeMarks(grade g)
        {
            //It will give A=A
            if (g == grade.A)
            {
                Console.WriteLine("The Mraks is above 90 and the Grade is A");
            }
            //This will give 1=1
            else if ((int)g == 1)
            {
                Console.WriteLine("The Mraks is above 80 and less than 90, the Grade is B");
            }
            else if (g == grade.C)
            {
                Console.WriteLine("The Mraks is above 70 and less than 80, the Grade is C");
            }
            else
            {
                Console.WriteLine("The Mraks is above 60 and less than 70, the Grade is D");
            }
        }
        public void employee1(int id,string name,long mobile)
        {

            Console.WriteLine("The Employee {0}, ID is {1} and You can contact them by {2}", name, id, mobile);

        }
        public static void employee()
        {
            Console.WriteLine("Enter the details");
            Console.WriteLine("Enter the Employee ID");
            int emplid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            string emplname = Console.ReadLine();
            Console.WriteLine("Enter the Employee Mobile number");
            long emplmobile = Convert.ToInt64(Console.ReadLine());
            Task12 t = new Task12();
            t.employee1(emplid,emplname, emplmobile);
        }

        
    }
}
