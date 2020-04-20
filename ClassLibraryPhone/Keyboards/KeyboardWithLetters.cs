using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class KeyboardWithLetters : KeyboardSimple
    {
        public List<char> Letters { get { return vLetters; } }
        private List<char> vLetters;

        public override string ToString()
        {
            return "Keyboard with letters";
        }
    }
}
