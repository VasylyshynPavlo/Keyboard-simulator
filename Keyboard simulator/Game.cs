using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_simulator
{
    public class Game
    {
        public string text;
        public string next;
        public char current;
        public string history;
        public int miss;
        public Game(string text)
        {
            this.text = text;
            next = text.Substring(1);
            current = text.First();
            history = "";
            miss = 0;
        }
        public void Step(string s)
        {
            if (s.Length == 1 || s == "Space")
            {
                if (s == "Space") s = " ";
                if (current == s[0])
                {
                    if (next != "")
                    {
                        history += current;
                        current = next.First();
                        next = next.Substring(1);
                    }
                    else
                    {
                        history += current;
                        current = ' ';
                    }
                }
            }
        }
    }
}
