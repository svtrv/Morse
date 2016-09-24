using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Created & published by Ilya Kalitov 
 * swterr@outlook.com
 * github.com/svtrv 
 */
// 0 means - , 1 means ---
public sealed class MorseLib
{
    public static byte dot = 0, dash = 1;
    public static Dictionary<char, byte[]> dictionary = new Dictionary<char, byte[]>(){ //International (ITU) code
        {'a',new byte[] {dot, dash}},
        {'b',new byte[] {dash, dot, dot, dot}},
        {'c',new byte[] {dash, dot, dash, dot}},
        {'d',new byte[] {dash, dot, dot}},
        {'e',new byte[] {dot}},
        {'f',new byte[] {dot, dot, dash, dot}},
        {'g',new byte[] {dash, dash, dot}},
        {'h',new byte[] {dot, dot, dot, dot}},
        {'i',new byte[] {dot, dot}},
        {'j',new byte[] {dot, dash, dash, dash}},
        {'k',new byte[] {dash, dot, dash}},
        {'l',new byte[] {dot, dash, dot, dot}},
        {'m',new byte[] {dash, dash}},
        {'n',new byte[] {dash, dot}},
        {'o',new byte[] {dash, dash, dash}},
        {'p',new byte[] {dot, dash, dash, dot}},
        {'q',new byte[] {dash, dash, dot, dash}},
        {'r',new byte[] {dot, dash, dot}},
        {'s',new byte[] {dot, dot, dot}},
        {'t',new byte[] {dash}},
        {'u',new byte[] {dot, dot, dash}},
        {'v',new byte[] {dot, dot, dot, dash}},
        {'w',new byte[] {dot, dash, dash}},
        {'x',new byte[] {dash, dot, dot, dash}},
        {'y',new byte[] {dash, dot, dash, dash}},
        {'z',new byte[] {dash, dash, dot, dot}},

    };
    public string MorseToText(BitArray input)
    {
        return "";
    }
   public static byte[][] TextToMorseBits(string input)
    {
        byte[][] result = null;
        input = input.ToLower();//there is no case-specific Morse codes, so ToLower looks necessary
        var punctuation = input.Where(Char.IsPunctuation).Distinct().ToArray();
        var words = input.Split().Select(x => x.Trim(punctuation));
        foreach (string word in words)
        {
            int i = 1;
            foreach (char c in word)
            {
                byte[] morseCode;
                if (dictionary.TryGetValue(c, out morseCode))
                {
                    result[i] = morseCode;
                }
                i++;
            }
        }
        return result;
    }
    public static string TextToMorse(string input)
    {
        string result = "";
        input = input.ToLower();//there is no case-specific Morse codes, so ToLower looks necessary
        var punctuation = input.Where(Char.IsPunctuation).Distinct().ToArray();
        var words = input.Split().Select(x => x.Trim(punctuation));
        foreach (string word in words)
        {
            foreach (char c in word)
            {
                byte[] morseCode;
                if (dictionary.TryGetValue(c, out morseCode))
                {
                    foreach (byte b in morseCode)
                    {
                        switch (b)
                        {
                            case 0:
                                result += ".";
                                break;
                            case 1:
                                result += "-";
                                break;
                            default:
                                break;
                        }
                    }
                    result += " ";
                }
                else
                {
                    result += "@";
                }
            }
            result += "    ";
        }
        return result;
    }
}