using Lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Output
{
    public class FakeOutput : IOutput
    {
        public string OutputString;
        public void Write(string text)
        {
            OutputString = text;
        }

        public void WriteLine(string text)
        {
            OutputString = text;
        }
    }
}
