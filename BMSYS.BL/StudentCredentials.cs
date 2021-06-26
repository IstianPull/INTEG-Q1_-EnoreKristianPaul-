using BMSYS.DL;
using System;
using System.Collections.Generic;

namespace BMSYS.BL
{
    public class StudentCredentials
    {
        public List<Students> StudentsCredentials = new List<Students>() 
        {
            new Students("2019-00337-BN-0","Kristian","Enore", DateTime.Now),
            new Students("2019-00338-BN-0","King","Budger", DateTime.Now),
            new Students("2019-00339-BN-0","Andrew","E.", DateTime.Now),
        };
        public void StudentView() 
        {
            foreach (Students item in StudentsCredentials)
            {
                Console.WriteLine("STUDENT NO:{0}|NAME:{1} {2}|Date:{3}",item.StudentNumber, item.firstname, item.lastname, item.datelog);
            }
        }
        public void StudentAdd() 
        {
            Console.Write("Enter your Student number:");
            string addStudentNumber = Console.ReadLine();
            Console.Write("Enter your First Name:");
            string addFirstname = Console.ReadLine();
            Console.Write("Enter your Last Name:");
            string addLastname = Console.ReadLine();
            DateTime addDatelog = DateTime.Now;

            StudentsCredentials.Add(new Students(addStudentNumber,addFirstname,addLastname,addDatelog));

            foreach (Students item in StudentsCredentials)
            {
                Console.WriteLine("STUDENT NO:{0}|NAME:{1} {2}|Date:{3}", item.StudentNumber, item.firstname, item.lastname, item.datelog);
            }
        }
        
    }
}
