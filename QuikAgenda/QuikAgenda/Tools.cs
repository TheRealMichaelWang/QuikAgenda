using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuikAgenda
{
    class Tools
    {
        static public string CutString(string text, int choplenght)
        {
            string ret = text;
            while (ret.Length != choplenght)
            {
                if (ret.Length > choplenght)
                {
                    ret = ret.Substring(0, ret.Length - 1);
                }
                if (ret.Length < choplenght)
                {
                    ret += " ";
                }
            }
            return ret;
        }
    }
}
