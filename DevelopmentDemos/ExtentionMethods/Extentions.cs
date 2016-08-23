using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public static class IntExtentions
    {
        public static int Add50(this int integer)
        {
            return integer += 50;
        }
    }

    public static class StringExtentions
    {
        public static string HelloWord(this string value)
        {
            return $"{value} Hello World";
        }
    }
}
