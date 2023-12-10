using System;


namespace Email_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Email :- ");
            string email = Console.ReadLine();
            string rep_email = email.Replace("@", "[atrate]").Replace(".", "[dot]");
            Console.Write("Replace Email :-" + rep_email);
            Console.ReadKey();
        }
    }
}