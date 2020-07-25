using QuanlityTest1.Controllers;
using QuanlityTest1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace QuanlityTest1
{
    class Program
    {
        public static void GenerateMenu()
        {
            Console.WriteLine("*-*-*-  GenerateMenu  -*-*-*-*");
            Console.WriteLine(" 1. Them moi sinh vien");
            Console.WriteLine(" 2. Danh sach sv");
            Console.WriteLine(" 3. Exit");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        }
         static void Main(string[] args)
        {
            List<StudentsModel> lst = new List<StudentsModel>();
            StudentController stc = new StudentController();
            int check;
            GenerateMenu();
            while (true)
            {
                Console.WriteLine("Nhap lua chon:  ");
                check = int.Parse(Console.ReadLine());
                switch (check){
                    case 1 :
                        Console.WriteLine("1.Them moi sinh vien");
                        var a= stc.CreateStudent();
                        lst.Add(a);
                        Console.WriteLine("Them moi thanh cong");
                        break;
                    case 2 :
                        Console.WriteLine("2. Danh sach sv");
                        stc.PrintListStudent(lst);
                        break;
                    case 3 :
                        //System.Application.Exit;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhap lai lua chon");
                        break;
                }
            }

            //DateTime time = DateTime.Now.AddDays(-61);
            //bool a = st.IsNewStudent(time);
            //if (a)
            //{
            //    Console.WriteLine("Ban la hs moi");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Ban la hs cu");
            //    Console.ReadLine();

            //}
            //StudentController stc = new StudentController();
            // stc.CreateStudent();
            //Console.ReadLine();
        }

    }
}
