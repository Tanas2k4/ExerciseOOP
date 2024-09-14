using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB2
{
    internal class ListNameA
    {
        public static IEnumerable<Student>
            GetListNameA(List<Student> students)
        {
            var listNameA = from student in students 
                            where student.Name1.StartsWith("A")
                            select student;
            return listNameA;
        }
    }
}
