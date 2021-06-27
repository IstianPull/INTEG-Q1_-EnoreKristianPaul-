using BMSYS.DL;

using System;
using System.Collections.Generic;

namespace BMSYS.BL
{
    public class AdminValidation
    {
      List<Admins> AdminCredentials = new List<Admins>()
        {
            
        };
        public bool LogIn() 
        {
            AdminServices services = new AdminServices();
           
            int maxAttemp = 0;
            bool successfull = false;
            do
            {
                Console.Write("Enter Username: ");
                var username = Console.ReadLine();
                Console.Write("Enter Password: ");
                var password = Console.ReadLine();

                foreach (Admins user in AdminCredentials)
                {
                    if (username == user.username && password == user.password)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You have successfully logged in !!!");
                        Console.WriteLine("");
                        successfull = true;
                        services.AdminCatalogue();
                        return true;


                    }
                }
                if (!successfull)
                {
                    maxAttemp++;
                    Console.WriteLine("");
                    Console.WriteLine("ATTEMPT TO LOG IN ({0})", maxAttemp);
                    Console.WriteLine("  MAX ATTEMPT IS 3 ");
                    Console.WriteLine("");

                }

            } while (maxAttemp != 3);
            Console.WriteLine("Max Attemp Exceed!");
            Console.WriteLine("Operation Operation Suspend!...");
            return false;
             

        }

        public bool Register()
        {
            Console.Write("Enter your username:");
            var username = Console.ReadLine();

            Console.Write("Enter your password:");
            var password = Console.ReadLine();

           


            AdminCredentials.Add(new Admins(username, password));

            Console.WriteLine("");
            Console.WriteLine("**       Successfully registered      **");
            Console.WriteLine("|Please Log in your Registered Account|");
            Console.WriteLine("");
            
            return LogIn(); 
        }


    }
    
}
