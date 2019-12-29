using System;

namespace EncryptionDecryptionUsingSymmetricKey
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guid key generated with base64encoded and uppercase combination 
            var key = "A+W2nzdpbEe3UHrCBZU5Qw==";                       

            //Console.WriteLine("Please enter a secret key for the symmetric algorithm.");  
            //var key = Console.ReadLine();  

            Console.WriteLine("Please enter a string for encryption");
            var str = Console.ReadLine();
            var encryptedString = AesAlgorithm.Encrypt(key, str);
            Console.WriteLine($"encrypted string = {encryptedString}");

            var decryptedString = AesAlgorithm.Decrypt(key, encryptedString);
            Console.WriteLine($"decrypted string = {decryptedString}");

            Console.ReadKey();
        }
    }
}
