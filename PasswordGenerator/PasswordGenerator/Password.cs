using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PasswordGenerator
{
    public class Password
    {
        public int passLen { get; set; }

        public bool includeUpper = false;
        public bool includeLower = false;
        public bool includeSpecial = false;
        public bool includeNum = false;

        public char[] specialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '=', '?' };
        public char[] numberChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public string generatePass()
        {
            StringBuilder sb = new StringBuilder();

            int counter = 0;

            while (counter < passLen)
            {
                if (includeUpper && counter < passLen)
                {
                    Random r = new Random();
                    int num = r.Next(0, 26);
                    char letter = (char)('A' + num);
                    sb.Append(letter);
                    counter++;
                }
                if (includeLower && counter < passLen)
                {
                    Random r = new Random();
                    int num = r.Next(0, 26);
                    char letter = (char)('a' + num);
                    sb.Append(letter);
                    counter++;
                }
                if (includeSpecial && counter < passLen)
                {
                    Random r = new Random();
                    int index = r.Next(specialChars.Length);
                    char letter = specialChars[index];
                    sb.Append(letter);
                    counter++;
                }
                if (includeNum && counter < passLen)
                {
                    Random r = new Random();
                    int index = r.Next(numberChars.Length);
                    char randomChar = numberChars[index];
                    sb.Append(randomChar);
                    counter++;
                }   
            }
            string pass = sb.ToString();
            char[] charArray = pass.ToCharArray();
            Random rnd = new Random();

            for (int i = charArray.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }

            string passShuffled = new string(charArray);

            return passShuffled;

        }
    }
}
