using System;

namespace BMSYS.BL
{
    class AdminServices
    {
        public void AdminCatalogue()
        {
            ManageBook admin = new ManageBook();
        START:
            Console.WriteLine("|====================================|");
            Console.WriteLine("|           ADMI:CATALOGUE           |");
            Console.WriteLine("|====================================|");
            Console.WriteLine("|(1)View Books                       |");
            Console.WriteLine("|(2)Add Book                         |");
            Console.WriteLine("|(3)Remove Book                      |");
            Console.WriteLine("|(4)EXIT                             |");
            Console.WriteLine("|====================================|");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    admin.ViewBooks();
                    goto START;
                case 2:
                    admin.AddBooks();
                    goto START;
                case 3:
                    admin.RemoveBooks();
                    goto START;
                default:
                    break;
            }
        }
    }
}
