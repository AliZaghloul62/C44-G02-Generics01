using CS_ADV01;

namespace C_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
                Range<int> intRange = new Range<int>(-100, 100);
                Console.WriteLine($"Range: {intRange}");
                Console.WriteLine($"Is 15 in range? {intRange.IsInRange(15)}");
                Console.WriteLine($"Is 250 in range? {intRange.IsInRange(250)}");
                Console.WriteLine($"Length: {intRange.Length()}"); 

                Console.WriteLine("=============================================");

                Range<double> doubleRange = new Range<double>(-2.5, 5.75);
                Console.WriteLine($"Range: {doubleRange}");
                Console.WriteLine($"Is 3.14 in range? {doubleRange.IsInRange(3.14)}");
                Console.WriteLine($"Is -3.14 in range? {doubleRange.IsInRange(-3.14)}");
                Console.WriteLine($"Length: {doubleRange.Length()}");

                Console.WriteLine("=============================================");

                Range<char> charRange = new Range<char>('a', 'z');
                Console.WriteLine($"Range: {charRange}");
                Console.WriteLine($"Is c in range? {charRange.IsInRange('c')}");
                Console.WriteLine($"Is C in range? {charRange.IsInRange('C')}");
                Console.WriteLine($"Length: {charRange.Length()}");
            #endregion
        }
    }
}