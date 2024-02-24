using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{

    abstract class person
    {
        public string FirstName;
        public string LastName;
        public int age;
        public string PhoneNumber;

        public abstract void PrintDetails();
    }

    class student : person
    {
        public int RollNo;
        public int Fees;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Student Name is : {0}", name);
            Console.WriteLine("Student Age is : {0}", this.age);
            Console.WriteLine("Student Phone No is : {0}", this.PhoneNumber);
            Console.WriteLine("Student Roll No is : {0}", this.RollNo);
            Console.WriteLine("Student Fees is : {0}", this.Fees);
        }
    }

    class teacher : person    
    {
        public string qualificatoin;
        public int salary;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Teacher Name is : {0}", name);
            Console.WriteLine("Teacher Age is : {0}", this.age);
            Console.WriteLine("Teacher Phone No is : {0}", this.PhoneNumber);
            Console.WriteLine("Teacher Qualification No is : {0}", this.qualificatoin);
            Console.WriteLine("Teacher Salary is : {0}", this.salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student Anas = new student();
            Anas.FirstName = "Anas";
            Anas.LastName = "Qureshi";
            Anas.age = 21;
            Anas.PhoneNumber = "1234567890";
            Anas.RollNo = 111;
            Anas.Fees = 5000;
            Anas.PrintDetails();
            

            Console.WriteLine("----------------------------------------------------------");

            teacher Asad = new teacher();
            Asad.FirstName = "Asad";
            Asad.LastName = "Mughal";
            Asad.age = 25;
            Asad.PhoneNumber = "1234567890";
            Asad.qualificatoin = "MCA";
            Asad.salary = 30000;
            Asad.PrintDetails();


            Console.ReadLine();
        }
    }
}
