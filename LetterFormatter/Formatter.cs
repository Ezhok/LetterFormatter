using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterFormatter
{
    public static class Formatter
    {
        public static string FormatText(int K, List<string> lines)
        {
            var result = new List<string>();

            foreach (var line in lines)
            {
                
                var trimmedLine = line.Trim();

                
                if (trimmedLine.Length > K)
                {
                    return "Impossible.";
                }

                
                int totalSpaces = K - trimmedLine.Length;
                int leadingSpaces = totalSpaces / 2;
                int trailingSpaces = totalSpaces - leadingSpaces;

                
                string formattedLine = new string('+', leadingSpaces) + trimmedLine + new string('+', trailingSpaces);
                result.Add(formattedLine);
            }

            return string.Join("\n", result);
        }
    }
}
