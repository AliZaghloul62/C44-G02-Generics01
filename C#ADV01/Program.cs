using CS_ADV01;

namespace C_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2- create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
            //Range<int> intRange = new Range<int>(-100, 100);
            //Console.WriteLine($"Range: {intRange}");
            //Console.WriteLine($"Is 15 in range? {intRange.IsInRange(15)}");
            //Console.WriteLine($"Is 250 in range? {intRange.IsInRange(250)}");
            //Console.WriteLine($"Length: {intRange.Length()}"); 

            //Console.WriteLine("=============================================");

            //Range<double> doubleRange = new Range<double>(-2.5, 5.75);
            //Console.WriteLine($"Range: {doubleRange}");
            //Console.WriteLine($"Is 3.14 in range? {doubleRange.IsInRange(3.14)}");
            //Console.WriteLine($"Is -3.14 in range? {doubleRange.IsInRange(-3.14)}");
            //Console.WriteLine($"Length: {doubleRange.Length()}");

            //Console.WriteLine("=============================================");

            //Range<char> charRange = new Range<char>('a', 'z');
            //Console.WriteLine($"Range: {charRange}");
            //Console.WriteLine($"Is c in range? {charRange.IsInRange('c')}");
            //Console.WriteLine($"Is C in range? {charRange.IsInRange('C')}");
            //Console.WriteLine($"Length: {charRange.Length()}");
            #endregion

            # region 1- The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm And implement the code of this optimized bubble sort algorithm

            /*
             * Time Complexity of this Optimized Bubble Sort:
             *
             * 1. Worst Case: O(n^2)
             *    - Happens when the list is in reverse order (e.g., [9, 8, 7, ...])
             *    - Swaps happen in every comparison and all elements must be moved.
             *
             * 2. Best Case: O(n)
             *    - Happens when the list is already sorted (e.g., [1, 2, 3, ...])
             *    - No swaps occur during the first pass, so the loop ends early.
             *
             * 3. Average Case: Between O(n) and O(n^2)
             *    - Depends on how "unsorted" the list is.
             *    - The more sorted it is, the closer it performs to O(n).
             *    - The more random it is, the closer it gets to O(n^2).
             *
             * Optimization Notes:
             * - We track the last position where a swap happened (newN),
             *   and reduce the next round's range to that point.
             * - This avoids checking already sorted parts of the list.
             */

            List<int> numbers = new List<int> { 5, 1, 4, 2, 8 };
            Console.WriteLine($"Before: {{{string.Join(", ", numbers)}}}");
            BubbleSort.OptimizedBubbleSort(numbers);
            Console.WriteLine($"After: {{{string.Join(", ", numbers)}}}");
            #endregion
        }
    }
}