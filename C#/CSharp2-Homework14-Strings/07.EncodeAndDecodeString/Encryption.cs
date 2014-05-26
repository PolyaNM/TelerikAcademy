// Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Collections.Generic;
using System.Text;

class Encryption
{
    static void Main()
    {
        Console.WriteLine("Please enter the encryption key");
        string cipher = Console.ReadLine();
        Console.WriteLine("Please enter the text for encoding/decoding");
        string text = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        while (sb.Length < text.Length)
        {
            sb.Append(cipher);
        }
        string extendedCipher = sb.ToString();


        string encrypted = EncryptDecrypt(text, extendedCipher);
        Console.WriteLine("Encrypted - {0}", encrypted);
        Console.WriteLine("Decrypted - {0}", EncryptDecrypt(encrypted, extendedCipher));
    }

    static string EncryptDecrypt(string str, string key)
    {
        var sb = new StringBuilder();

        for (int i = 0, j = 0; i < str.Length; i++, j++)
        {
            sb.Append((char)(str[i] ^ key[j]));
        }
        return sb.ToString();
    }
}

