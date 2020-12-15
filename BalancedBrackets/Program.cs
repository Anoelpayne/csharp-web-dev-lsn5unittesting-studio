using System;

namespace BalancedBracketsNS
{
    class Program
    {
        static void Main(string[] args)
            
        {
            var testing = BalancedBrackets.HasBalancedBrackets("[]");
            Console.WriteLine(testing.GetType());
        }
    }
}
