using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controller
{
    class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("PrintListStudent  {0}  {1}", student.RollNumber, student.FullName);
            }
        }
        public Student CreateStudent()
        {
            Student student = new Student();
            Console.WriteLine("input Student RollNumber: ");
            student.RollNumber = Console.ReadLine();
            Console.WriteLine("input Student FullName: ");
            student.FullName = Console.ReadLine();
            Console.WriteLine("input Student Birthday: ");
            student.Birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("input Student Email: ");
            student.Email = Console.ReadLine();
            Console.WriteLine("input Student Phone: ");
            student.Phone = Console.ReadLine();
            Console.WriteLine("input Student CreateAd: ");
            student.CreatedAt = Convert.(Console.ReadLine());
            Console.WriteLine("input Student Status: ");
            student.Status = Student.StudentStatus.Active;
            return student;
        }
    }
}
