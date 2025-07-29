using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ADV01
{
    public class BubbleSort
    {
        // This method sorts a list using an optimized version of Bubble Sort
        public static void OptimizedBubbleSort<T>(List<T> list) where T : IComparable<T>
        {
            // Get the number of items in the list
            int n = list.Count;

            // This variable will store the last index where a swap happened
            int newN;

            // Repeat this loop until no swaps happen in a full pass
            do
            {
                // At the start of each round, assume no swaps happened yet
                newN = 0;

                // Loop through the list starting from index 1 to n - 1
                for (int i = 1; i < n; i++)
                {
                    // Compare the item before (i - 1) with the current item (i)
                    // If the previous item is bigger, we need to swap them
                    if (list[i - 1].CompareTo(list[i]) > 0)
                    {
                        // Swap the two items
                        T temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;

                        // Remember the position of this swap
                        // So we know where to stop in the next round
                        newN = i;
                    }
                }

                // After the inner loop, we know that all items after newN are sorted
                // So next time we only need to check up to newN
                n = newN;
            }
            // Keep repeating while there was at least one swap in this round
            while (newN != 0);
        }
    }
}
