using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab14
{
    internal static class LittleJohn
    {
        public static Arrow[] GetArrows()
        {
            var arrows = new Arrow[]
            {
                new Arrow {Type = ">----->", Amount = 0},
                new Arrow {Type = ">>----->", Amount = 0},
                new Arrow {Type = ">>>----->>", Amount = 0}
            };

            for (int i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();
                var matches = Regex.Matches(input, $"(>----->)|(>>----->)|(>>>----->>)");

                foreach (Match item in matches)
                {
                    arrows.Where(x => x.Type == item.Value).First().Amount++;
                }
            }

            return arrows;
        }

        public static string AppendReverse(string binary)
        {
            var result = binary;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                result = string.Concat(result, binary[i]);
            }

            return result;
        }
    }
}
