using System;
using System.Collections.Generic;

namespace hacker_rank_balanced_brackets
{
    class Program
    {
        static void Main()
        {
            List<string> charSequences = new List<string> { "{[()]}", "{[(])}", "{{[[(())]]}}" };
            charSequences.ForEach(sequence => Console.WriteLine(IsBalanced(sequence)));
        }

        private static string IsBalanced(string s)
        {
            char[] brackets = s.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < brackets.Length; i++)
            {
                if (AreOpeningBrackets(brackets[i]))
                {
                    stack.Push(brackets[i]);
                }
                else
                {
                    if (stack.IsEmpty())
                    {
                        return "NO";
                    }
                    else
                    {
                        char popValue = stack.Pop();
                        if (brackets[i] == '}' && popValue != '{')
                        {
                            return "NO";
                        }
                        else if (brackets[i] == ')' && popValue != '(')
                        {
                            return "NO";
                        }
                        else if (brackets[i] == ']' && popValue != '[')
                        {
                            return "NO";
                        }
                    }
                }
            }

            if (stack.Count == 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        private static bool AreOpeningBrackets(char value)
        {
            return (value == '{' || value == '(' || value == '[');
        }
    }
}
