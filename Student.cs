using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB2
{
    internal class Student
    {
        //field
        private int ID;
        private string Name;
        private int Age;

        //set - get
        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int Age1 { get => Age; set => Age = value; }

        public Student() { }

        public Student(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;  
            this.Age = Age; 
        }
        
       
        public void input() 
        {
            Console.WriteLine("------------------ ");
            Console.Write("Nhap ma so sinh vien: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            Name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Age = int.Parse(Console.ReadLine());
        }

        public void output()
        {   Console.WriteLine("\t\t ------------------------- ");
            Console.WriteLine($"\t\t   MSSV: {this.ID}\n\t\t   Ho ten: {this.Name}\n\t\t   Tuoi: {this.Age}");
        }
        
        // Xuat danh sach sinh vien
        public void Danhsach(List<Student> studentList)
        {
            Console.WriteLine("\t    === DANH SACH CHI TIET SINH VIEN ===");
            foreach (Student student in studentList)
            {
                student.output();
            }
        }
    }
}
