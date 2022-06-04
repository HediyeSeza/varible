using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Hedi";
            var age = 21;
            var isStudent = true;
            Type nametype = name.GetType();
            Type agetype = age.GetType();
            Type isStudenttype = isStudent.GetType();
            Console.WriteLine($"name is of type{nametype}");
            Console.WriteLine($"age is of type{agetype}");
            Console.WriteLine($"isstudent is of type{isStudenttype}");
            Console.ReadKey();
        }
    }
}
