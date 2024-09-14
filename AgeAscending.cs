using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB2
{
    internal class AgeAscending
    {
        public static IEnumerable<Student> GetAgeAscending(List<Student> students)
        {
            var ageAscending = students.OrderBy(student => student.Age1);
            return ageAscending;
        }
    }
}
