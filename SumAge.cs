using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB2
{
    internal class SumAge
    {
        public static int GetSumAge(List<Student> students) 
        {
            int sumAge = students.Sum(student => student.Age1);
            return sumAge;
        }
    }
}
