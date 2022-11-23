using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221122_MVOP
{
    class CaesarCipher
    {
      
        //Caesar Cipher
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public string EncryptionAlpha(string text, int move)
        {
            string result = string.Empty;

            foreach (var item in text)
            {
                int index = 0;
                foreach (var item0 in alphabet)
                {
                    if (item0.ToString() == item.ToString().ToLower())
                    {
                        index += move;

                        if (index > alphabet.Length - 1)
                        {
                            index -= alphabet.Length;
                            char ch = alphabet[index];
                            result += ch;
                        }
                        else
                        {
                            char ch = alphabet[index];
                            result += ch;
                        }
                    }
                    
                    index++;
                }
            }

            return result;
        }

        public string DecryptionAlpha(string text, int move)
        {
            string result = string.Empty;

            foreach (var item in text)
            {
                int index = 0;
                foreach (var item0 in alphabet)
                {
                    if (item0.ToString() == item.ToString().ToLower())
                    {
                        index -= move;

                        if (index < 0)
                        {
                            index += alphabet.Length;
                            char ch = alphabet[index];
                            result += ch;
                        }
                        else
                        {
                            char ch = alphabet[index];
                            result += ch;
                        }
                    }

                    index++;
                }
            }

            return result;
        }


        //VigenereCipher
        public string VigenereCipher(string text, string key, int i)
        {
            int i0 = 0, i1;
            string result = "";
            text = text.ToUpper();
            key = key.ToUpper();
            foreach (char t in text)
            {

                if (t < 65)
                {
                    continue;
                }

                i1 = t - 65 + i * (key[i0] - 65);

                if (i1 < 0)
                {
                    i1 += 26;

                }

                result += Convert.ToChar(65 + (i1 % 26));

                if (++i0 == key.Length)
                {
                    i0 = 0;
                }

            }

            return result;
        }
        
    }
}
