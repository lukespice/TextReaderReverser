using System.Linq;

namespace TextReaderReverser
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
    }
}
