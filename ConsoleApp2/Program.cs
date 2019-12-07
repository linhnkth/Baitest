using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        public List<Student> students;
        static void Main(string[] args)
        {
            var main = new Main();

            main.GenerateMenu();
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":

                    break;
                case "2":
                    break;

            }
        }
    }
}
