using System;

namespace DataEncodinginCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath;
            filepath = args[0];
            Console.WriteLine($"Loading '{filepath}'");

            string message;
            message = System.IO.File.ReadAllText(filepath);
            Console.WriteLine($"The encrytped message is; {message}");

            int shift;
            shift = 1;
            while (shift <= 10)
            {
                Cipher cipher;
                cipher = new Cipher(shift);
                string decrypted;
                decrypted = cipher.Decrypt(message);
                Console.WriteLine($"the dycrypted message is {decrypted}");
                shift = shift + 1;
                // return message;
            }






            // string message;
            // message = System.IO.File.ReadAllText("secrets/1.txt");
            // Console.WriteLine($"The encrypted message is: {message}");


            // Cipher cipher;
            // cipher = new Cipher(3);
            // string decrypted;
            // decrypted = cipher.Decrypt($"{message}");
            // Console.WriteLine($"The decrypted message is: {decrypted}");

            // string decrypted;
            // decrypted = cipher.Decrypt(encrypted);
            // Console.WriteLine($"The encrypted message is: {decrypted}");

            // char ch;
            // ch = 'A';
            // Console.WriteLine($"ch is stroing the value: {ch}");
            // int ch_decimal;
            // ch_decimal = ch;
            // Console.WriteLine($"The decimal value of ch is {ch_decimal}");
            // int ToConvert;
            // Console.WriteLine("Enter an integer: ");
            // ToConvert = int.Parse(Console.ReadLine());
            // char AsChar;
            // AsChar = (char)ToConvert;
            // Console.WriteLine($"The integer {ToConvert} cast to char is '{AsChar}'");
            // char b;
            // b = (char)('Z' + 3);
            // Console.WriteLine($" A + 1 = {b}");



        }
    }
}
