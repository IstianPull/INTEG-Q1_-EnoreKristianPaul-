

namespace BMSYS.DL
{

    public class Admins
    {

        public string username {get;set;}
        public string password { get; set; }
        public Admins (string username, string password) 
        {
            this.username = username;
            this.password = password;
        }

    }
    
}
