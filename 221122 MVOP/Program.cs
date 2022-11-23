using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221122_MVOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher cc = new CaesarCipher();

            string text = "Albert";
            int move = 5;

            string res = cc.EncryptionAlpha(text, move);
            Console.WriteLine(res);
            Console.ReadLine();

            string fin = cc.DecryptionAlpha(res, move);
            Console.WriteLine(fin);
            Console.ReadLine();

            string key = "abeceda";
            string res_vig = cc.VigenereCipher(text, key,1);
            Console.WriteLine(res_vig);
            Console.ReadLine();

            string res_back = cc.VigenereCipher(res_vig, key, -1);
            Console.WriteLine(res_back);
            Console.ReadLine();

        }
    }
}
