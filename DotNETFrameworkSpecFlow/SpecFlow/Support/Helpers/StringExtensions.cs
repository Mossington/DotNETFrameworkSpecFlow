using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETFrameworkSpecFlow.SpecFlow.Support.Helpers
{
    internal static class StringExtensions
    {
        public static IEnumerable<string> SplitStringByCharacterLengh(this string _Number, Int32 SplitByNumberofCharacters)
        {
            if (_Number == null)
            {
                throw new ArgumentNullException(nameof(_Number));
            }

            if (SplitByNumberofCharacters <= 0)
            {
                throw new ArgumentNullException("Part length has to be positive.", nameof(SplitByNumberofCharacters));
            }

            for (var i = 0; i < _Number.Length; i += SplitByNumberofCharacters)
            {
                yield return _Number.Substring(i, Math.Min(SplitByNumberofCharacters, _Number.Length - i));
            }
        }

        public static List<string> SortCoSplitNumberByLength(string Number)
        {
            var parts = SplitStringByCharacterLengh(Number, 2);
            List<string> a = new List<string>(parts);
            return a;
        }
    }
}
