using System;

namespace MyLib
{
    public class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthDate { get; set; }
        public string email { get; set; }
        public string avatarPath;
    }
}
