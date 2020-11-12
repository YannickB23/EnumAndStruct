using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAndStruct
{
    public enum Subjects
    {
        CSharp = 1, Java, Networking, Taal
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the student pls.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the students age pls.");
            int age = int.Parse(Console.ReadLine());

            //Subjects subjects = Subjects.CSharp;    => manier 1
            Console.WriteLine("Pls enter the subject.");
            int subjects = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the students email pls.");
            string email = Console.ReadLine();
            Console.WriteLine("-----------");
            Student student = new Student(name, age, (Subjects)subjects, email);
            student.PrintStudentInfo();
        }
    }
    public struct Student
    {
        public string Name;
        public int Age;
        public Subjects Subject;
        public string Email;

        public Student(string name, int age, Subjects subjects, string email)
        {
            Name = name;
            Age = age;
            Subject = subjects;
            Email = email;
        }
        public void PrintStudentInfo()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
            Console.WriteLine(this.Subject);
            Console.WriteLine(this.Email);
        }
    }
}
