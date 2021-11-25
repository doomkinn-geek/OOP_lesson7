using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    public interface ICoder
    {
        public string Encode(string input);
        public string Decode(string input);
    }
}
