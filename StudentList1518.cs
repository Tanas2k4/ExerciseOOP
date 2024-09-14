using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB2
{
    internal class StudentList1518
    {
        public static IEnumerable<Student>
            GetStudenDtList1518(List<Student> students)           
        {
            var studentList1518 = from student in students 
                                  where student.Age1 >= 15 && student.Age1 <=18
                                  select student;
            return studentList1518;
        }            
    }
}
