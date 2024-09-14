using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB2
{
    internal class Program
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(326, "Tran Trong Tan", 20),
                new Student(112, "An" , 16),
                new Student(222, " Vu", 24),
                new Student(411, " Kha", 17),
                new Student(188, " Khang", 19)
            };
            Student st = new Student();           
            int t;
            do
            {
                Console.WriteLine(" ========================= MENU =========================");
                Console.WriteLine("|   1. In toan bo danh sach                              |");
                Console.WriteLine("|   2. Tim va in danh sach hoc sinh tu 15 den 18 tuoi    |");
                Console.WriteLine("|   3. Hoc sinh co ten chu cai dau la 'A'                |");
                Console.WriteLine("|   4. Tinh tong tuoi cua cac hoc sinh trong danh sach   |");
                Console.WriteLine("|   5. Tim va in hoc sinh co tuoi lon nhat               |");
                Console.WriteLine("|   6. Sap xep va in hoc sinh theo tuoi tang dan         |");
                Console.WriteLine(" ======================== EXIT(0) =======================");
                Console.Write("                     XIN MOI CHON: ");
                 t = int.Parse(Console.ReadLine());
                
                switch (t)
                {   
                    case 1:
                        { 
                            st.Danhsach(studentList);
                            Console.ReadLine();                          
                        }
                        break;
                    case 2:
                        {
                            var studentList1518 = StudentList1518.GetStudenDtList1518(studentList);
                            Console.WriteLine("\t  DANH SACH HOC SINH TU 15 DEN 18 TUOI");
                            foreach (var student in studentList1518)
                            {
                                student.output(); 
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        {
                            var lisNameA = ListNameA.GetListNameA(studentList);
                            Console.WriteLine("\t DANH SACH HOC SINH BAT DAU BANG CHU 'A'");
                            foreach(var  student in lisNameA)
                            {
                                student.output();
                            }
                            Console.ReadLine();
                        }break;
                    case 4:
                        {
                            var sumAge = SumAge.GetSumAge(studentList);
                            Console.Write($"\tTONG SO TUOI CUA HOC SINH TRONG DANH SACH: {sumAge}");
                        }break;
                    case 5:
                        {
                            var studentMaxAge = StudentMaxAge.GetStudentmaxAge(studentList);
                            Console.WriteLine("\t\tHOC SINH CO TUOI LON NHAT: ");
                                studentMaxAge.output();   
                            Console.ReadLine ();    
                        }break;
                    case 6:
                        {
                            var ageAscending = AgeAscending.GetAgeAscending(studentList);
                            Console.WriteLine("\t   DANH SACH HOC SINH TANG DAN THEO TUOI");
                            foreach(var student in ageAscending)
                            {
                                student.output ();
                            }
                        }break;            
                }
                Console.ReadKey();
                Console.Clear();
            } while( t != 0);
            
        }
    }
}
