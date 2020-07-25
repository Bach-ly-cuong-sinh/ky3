using QuanlityTest1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlityTest1.Controllers
{
    class StudentController
    {
        public void PrintListStudent(List<StudentsModel> st)
        {
            if(st != null && (st.Count) >0 )
            {
                foreach(var i in st)
                {
                    Console.WriteLine("RollNumbe : {0} ", i.RollNumber);
                    Console.WriteLine("FullName: {0} ", i.FullName);
                    Console.WriteLine("BirthDay: {0} ", i.BirthDay);
                    Console.WriteLine("Email : {0} ", i.Email);
                    Console.WriteLine("Phone : {0} ", i.Phone);
                    Console.WriteLine("CreatedAt : {0} ", i.CreatedAt);
                    Console.WriteLine("Status : {0} ", i.Status);
                    Console.WriteLine("/n");

                }
            }
            else
            {
                Console.WriteLine("Khong ton tai hoc sinh nao");
            }
            return  ;
        }

        public StudentsModel CreateStudent()
        {
            StudentsModel st = new StudentsModel();

            Console.WriteLine("RollNumber: ");
            st.RollNumber = Console.ReadLine();

            Console.WriteLine("Full Name: ");
            st.FullName = Console.ReadLine();

            Console.WriteLine("BirthDay(dd/mm/yyyy): ");
            //string bd = Console.ReadLine();
            var bd = Console.ReadLine();
            st.BirthDay = DateTime.Parse(bd);

            Console.WriteLine("Email: ");
            st.Email = Console.ReadLine();

            Console.WriteLine("Phone: ");
            st.Phone = Console.ReadLine();

            //var CreatedAt = DateTime.Now;
            Console.WriteLine("CreatedAt(dd/mm/yyyy): ");
            st.CreatedAt = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("Status: ");
            //st.Status =
            return st;
        }
    }
}
