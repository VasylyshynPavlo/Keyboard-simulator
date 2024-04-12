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
        public string name;
        public string text;
        public string next;
        public char current;
        public string history;
        public int miss;
        public Game(Text _text)
        {
            this.text = _text.text;
            next = _text.text.Substring(1);
            current = _text.text.First();
            history = "";
            miss = 0;
            this.name = _text.Name;
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
                else
                {
                    miss++;
                }
            }
        }
    }
}
