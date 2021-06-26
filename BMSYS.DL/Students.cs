using System;
namespace BMSYS.DL
{
    public class Students
    {
        public string StudentNumber;
        public string firstname;
        public string lastname;
        public DateTime datelog;
        public Students(string StudentNumber, string firstname, string lastname , DateTime datelog) 
        {
            this.StudentNumber = StudentNumber;
            this.firstname = firstname;
            this.lastname = lastname;
            this.datelog = datelog;

        }

    }
}
