using System;

namespace ITEC104_ACT4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Emails = { "waleed.pogi025@yahoo.com", 
                                "juanillowlaeed@yahoo.com", 
                                "waleed.juanillo69@yahoo.com" };

            string[] Usernames = {  "waleed022", 
                                    "wjuanillo069", 
                                    "Jwaleed025" };

            string[] Passwords = { "TBH569", 
                                   "tinining0123", 
                                   "parak66" };

            Console.Write("Index : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Email    : " + Emails[x]);
            Console.WriteLine("Username : " + Usernames[x]);
            Console.WriteLine("Password : " + Passwords[x]);       

        }
    }
}

