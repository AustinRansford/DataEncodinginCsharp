using System;

namespace DataEncodinginCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher;
            cipher = new Cipher(5);
            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            Console.WriteLine($"The encrypted message is: {encrypted}");
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
