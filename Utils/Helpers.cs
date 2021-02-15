using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumProcesso.Utils
{
   public class Helpers
    {
        public static string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);
            var _random = new Random();
            char offset = lowerCase ? 'a' : 'A';
            int lettersOffset = 26; // A...Z or a..z: length = 26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
    }
}
