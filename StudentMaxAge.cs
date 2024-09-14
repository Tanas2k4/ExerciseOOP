using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB2
{
    internal class StudentMaxAge
    {
        public static  Student GetStudentmaxAge(List<Student> students)
        {
            var studentMaxAge = students.OrderByDescending(student => student.Age1).First();
            return studentMaxAge;
        }
    }
}
