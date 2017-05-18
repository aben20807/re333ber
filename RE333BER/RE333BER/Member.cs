using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;//hashSHA512

namespace RE333BER
{
    class Member
    {
        public static List<Member> memberData = new List<Member>();
        public static Member signinMember;

        private string _username;
        private string _password;
        private string _notification;
        
        public Member(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public static string hashSHA512(string password)
        {
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            return Convert.ToBase64String(sha512.ComputeHash(Encoding.Default.GetBytes(password)));
        }
        public string Username{
            set { _username = value; }
            get { return _username; }
        }
        public String Password
        {
            set { _password = hashSHA512(value); }
            get { return _password; }
        }
        public string Notification
        {
            set { _notification = value; }
            get { return _notification; }
        }
    }
}
