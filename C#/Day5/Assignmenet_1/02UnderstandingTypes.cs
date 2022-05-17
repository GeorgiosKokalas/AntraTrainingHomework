namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-8} {1,-3} {2}", "sbyte", 1, SByte.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "byte", 1, Byte.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "short", 2, Int16.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "ushort", 2, UInt16.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "int", 4, Int32.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "uint", 4, UInt32.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "long", 8, Int64.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "ulong", 8, UInt64.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "float", 4, float.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "double", 8, double.MaxValue);
            Console.WriteLine("{0,-8} {1,-3} {2}", "decimal", 16, decimal.MaxValue);
        }
    }
}
