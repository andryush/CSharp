using System;

namespace stringHomework
{
    class Program
    {
        public static string myText = "This too shall passwxyz".ToLower();
        public static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public static string result = string.Empty;

        public static int key = 3;
        public static int position;
        public static int positionKey;

        public static char eachChar = ' ';

        static void Main(string[] args)
        {
            //Console.WriteLine(Encode(myText));
            //Console.WriteLine(Decode("wklvcwrrcvkdoocsdvvzabc"));

            string myText = "Text for decode".ToLower();
            string decoded = string.Empty;

            for (int i = 0; i < myText.Length; i++)
            {
                char x = myText[i];

                int keyCode = (int)x;
                if (x != ' ')
                {
                    keyCode += i;
                }

                char newChar = (char)keyCode;
                decoded += newChar;

            }
            Console.WriteLine(decoded);


        }

        //Function for text Encoding
        public static string Encode(string textToEncode)
        {
            for (int i = 0; i < textToEncode.Length; i++)
            {
                eachChar = textToEncode[i];
                position = alphabet.IndexOf(eachChar);
                //if ((position + key) >= alphabet.Length)
                //{
                positionKey = (position + key) % alphabet.Length;
                //positionKey = position + 0;
                //}
                //else
                //{
                //    positionKey = (position + key) % alphabet.Length;
                //}
                ////if(position >= (alphabet.Length - key))
                ////{
                //    position %= (alphabet.Length - key); 
                ////}

                result += alphabet[positionKey];
            }
            return result;
        }

        //Function for Decoding
        public static string Decode(string textToDecode)
        {
            for (int i = 0; i < textToDecode.Length; i++)
            {
                eachChar = textToDecode[i];
                position = alphabet.IndexOf(eachChar);
                if ((position - key) < 0)
                {
                    positionKey = (position - key) + alphabet.Length;
                }
                else
                {
                    positionKey = position - key;
                }

                result += alphabet[positionKey];
            }
            return result;


            //Console.ReadLine();
        }
    }
}

