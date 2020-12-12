using System.Collections.Generic;

namespace hacker_rank_balanced_brackets
{
    public static class StackExtensions
    {
        public static bool IsEmpty(this Stack<char> stack)
        {
            if (stack is null)
                return false;

            return stack.Count == 0;
        }
    }
}
