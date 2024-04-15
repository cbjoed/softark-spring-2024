using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace SearchMethods
{
    public class Search
    {
        /// <summary>
        /// Finder tallet i arrayet med en lineær søgning.
        /// </summary>
        /// <param name="array">Det array der søges i.</param>
        /// <param name="tal">Det tal der skal findes.</param>
        /// <returns></returns>
        public static int FindNumberLinear(int[] array, int tal) {
            for (var i = 0; i <array.Length; i++)
            {
                if(array[i] == tal)
                {
                    return i;
                }
            }
            return -1;

        }
        /// <summary>
        /// Finder tallet i arrayet med en binær søgning.
        /// </summary>
        /// <param name="array">Det array der søges i.</param>
        /// <param name="tal">Det tal der skal findes.</param>
        /// <returns></returns>
        public static int FindNumberBinary(int[] array, int tal) {
        int min = 0; // Declare min and max variables and initialize them
        int max = array.Length - 1;

        while (min <= max) { // Change condition to include equality
        int mid = (min + max) / 2; // Declare mid variable and add semicolon
        if (tal == array[mid])
            return mid;
        else if (tal < array[mid])
            max = mid - 1;
        else
            min = mid + 1;
        }
        return -1;
        }


        private static int[] sortedArray { get; set; } =
            new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        private static int next = 0;

        /// <summary>
        /// Indsætter et helt array. Arrayet skal være sorteret på forhånd.
        /// </summary>
        /// <param name="sortedArray">Array der skal indsættes.</param>
        /// <param name="next">Den næste ledige plads i arrayet.</param>
        public static void InitSortedArray(int[] sortedArray, int next)
        {
            Search.sortedArray = sortedArray;
            Search.next = next;
        }

        /// <summary>
        /// Indsætter et tal i et sorteret array. En kopi af arrayet returneres.
        /// Array er fortsat sorteret efter det nye tal er indsat.
        /// </summary>
        /// <param name="tal">Tallet der skal indsættes</param>
        /// <returns>En kopi af det sorterede array med det nye tal i.</returns>
       public static int[] InsertSorted(int tal)
{
    if (next >= sortedArray.Length || tal <= 0) // Check if array is full or tal is not positive
    {
        return sortedArray; // Return a copy of the array without changes
    }

    int indexToInsert = next; // Initialize indexToInsert with next available index
    for (int i = 0; i < next; i++)
    {
        if (sortedArray[i] > tal) // Find the correct index to insert tal while maintaining sorting
        {
            indexToInsert = i;
            break;
        }
    }

    // Shift elements to the right to make space for the new element
    for (int i = next; i > indexToInsert; i--)
    {
        sortedArray[i] = sortedArray[i - 1];
    }

    sortedArray[indexToInsert] = tal; // Insert tal at the correct index
    next++; // Increment next to indicate the next available index
    return sortedArray; // Return a copy of the updated array
}

    }
}