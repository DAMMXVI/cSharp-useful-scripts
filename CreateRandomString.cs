using System;
using System.Linq;
using System.Net.Mail;

namespace Web_Programming_Project.Methods 
{
    public class CreateRandomString 
    {
        private static Random random = new Random();
        public static string randomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
