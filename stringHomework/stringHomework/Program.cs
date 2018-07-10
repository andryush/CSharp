using System;

namespace stringHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string myText = "This too shall pass".ToLower();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string result = string.Empty;

            int key = 3;
            int position;
            int positionKey;
            
            char eachChar = ' ';


            //Console.WriteLine(Encode(myText));
            Console.WriteLine(Decode("wklvcwrrcvkdoocsdvvw"));


            //Function for text Encoding
            string Encode(string textToEncode)
            {
                for (int i = 0; i < textToEncode.Length; i++)
                {
                    eachChar = textToEncode[i];
                    position = alphabet.IndexOf(eachChar);
                    if ((position + key) > alphabet.Length)
                    {
                        positionKey = position - 0;
                    }
                    else
                    {
                        positionKey = position + key;
                    }
                    
                    result += alphabet[positionKey];
                }
                return result;
            }

            //Function for Decoding
            string Decode(string textToDecode)
            {
                for (int i = 0; i < textToDecode.Length; i++)
                {
                    eachChar = textToDecode[i];
                    position = alphabet.IndexOf(eachChar);
                    if((position - key) < alphabet.IndexOf("a"))
                    {
                        positionKey = position + 0;
                    }
                    else
                    {
                        positionKey = position - key;
                    }
                    
                    result += alphabet[positionKey];
                }
                return result;
            }


            Console.ReadLine();
        }
    }
}
