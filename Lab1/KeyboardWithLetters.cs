using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class KeyboardWithLetters : KeyboardSimple
    {
        List<char> letters;

        public override string ToString()
        {
            return "Keyboard with letters";
        }
    }
}
