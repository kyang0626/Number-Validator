using System;

namespace Number_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your phone number.");
            string userDigits = Console.ReadLine();

            Validator1.TelephoneValidator(userDigits);

            var validator = new Validator2();
            validator.TelephoneValidator(userDigits);
        }
    }
}
