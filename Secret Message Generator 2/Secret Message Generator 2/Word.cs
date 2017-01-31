using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Message_Generator_2
{
    class Word
    {
        private readonly Random randNumber = new Random();
        public List<string> _letters = new List<string>();
        public int spacing = 2;
        public string _Word;

        public Word(string word)
        {
            _Word = word;
        }

        public string ConvertToString(string[] array)
        {
            string final = "";
            for(int i = 0; i < array.Length;i++)
            {
                final += array[i] + Environment.NewLine;
            }
            return final;
        }

        public string[] Combine()
        {
            string[] finalStringArray = new string[10];
            char[] letters = _Word.ToCharArray();
            string[] storedletters = new string[letters.Length];
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    storedletters[i] = Letters.getLetter(letters[i]);
                    int letterLength = Letters.MaxLetterLength(letters[i].ToString());
                    string[] linesForLetter = Letters.GetLines(Letters.getLetter(letters[i].ToString().ToUpper().ToCharArray()[0])).Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    string spaces = "";
                    while (spaces.Length != spacing + letterLength - linesForLetter[k].Length)
                    {
                        spaces += " ";
                    }
                    
                    finalStringArray[k] += linesForLetter[k] + spaces;
                    
                }
            }

            return finalStringArray;

            // take the strings  from each first line and combine them into one line add spaces to fill
            // the words so they are squarelike and the words match up
        }

        public string Disguise(string[] text)
        {
           string[] finaltext = new string[text.Length];
           for(int y = 0; y < text.Length;y++)
           {
                char[] chars = text[y].ToCharArray();
                for(int x = 0; x < chars.Length;x++)
                {
                    if (chars[x] == ' ')
                    {
                        finaltext[y] += randNumber.Next(0,8).ToString();
                    }
                    else
                    {
                        finaltext[y] += chars[x].ToString();
                    }                  
                }
                text[y] = new string(chars);
           }
            return ConvertToString(finaltext);
        }

        public string Write()
        {
            return Disguise(Combine());
        }


    }
}
