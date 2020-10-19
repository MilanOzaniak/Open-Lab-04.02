using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string str = "";
            foreach(var o in original)
            {
                str = str + o + o;
            }
            return str;
        }
    }
}
