using BMSYS.BL;
using System;

namespace BMSYS.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|======================================|");
            Console.WriteLine("|  WELCOME TO BOOK MANAGEMENT SYSTEM   |");
            Console.WriteLine("|======================================|");
            Console.WriteLine("|(1)Admin                              |");
            Console.WriteLine("|(2)Student                            |");
            Console.WriteLine("|(3)EXIT                               |");
            Console.WriteLine("|======================================|");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    AdminFunc();
                    break;
                case 2:
                    StudentFunc();
                    break;
                default:
                    break;
            }

        }

        static void AdminFunc()
        {
            AdminValidation admin = new AdminValidation();


            Console.WriteLine("|======================================|");
            Console.WriteLine("|BOOK MANAGEMENT SYSTEM : ADMINISTRATOR|");
            Console.WriteLine("|======================================|");
            Console.WriteLine("|(1)LOG IN                             |");
            Console.WriteLine("|(2)REGISTER                           |");
            Console.WriteLine("|(3)EXIT                               |");
            Console.WriteLine("|======================================|");
            int adminInput = int.Parse(Console.ReadLine());
            if (adminInput == 1)
            {
                admin.LogIn();
            }
            else if (adminInput == 2)
            {
                admin.Register();
            }
            else
            {
                Console.WriteLine("Operation Cease...");
            }
        }
        static void StudentFunc()
        {
            StudentCredentials student = new StudentCredentials();
            Console.WriteLine("|======================================|");
            Console.WriteLine("|BOOK MANAGEMENT SYSTEM :  STUDENT     |");
            Console.WriteLine("|======================================|");
            Console.WriteLine("|(1)Fill Up                            |");
            Console.WriteLine("|(2)EXIT                               |");
            Console.WriteLine("|======================================|");
            int studentInput = int.Parse(Console.ReadLine());
            if (studentInput == 1)
            {
                student.StudentAdd();
            }
           
            else
            {
                Console.WriteLine("Operation Cease...");
            }



        }

    }
}
