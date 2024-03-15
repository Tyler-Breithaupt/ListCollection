namespace ListCollection;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>();
        myList.Add(5);
        myList.Add(3);
        myList.Add(8);
        myList.Add(1);
        myList.Add(6);

        myList.AddRange(new int[] { 9, 4, 2 });

        myList.Sort();
        Console.WriteLine("Sorted List:");
        foreach (int item in myList)
        {
            Console.WriteLine(item);
        }

        myList.Remove(3);

        // Sort the list in reverse order and print all items
        myList.Sort((a, b) => b.CompareTo(a)); // Sort in descending order
        Console.WriteLine("\nSorted List in Reverse Order:");
        foreach (int item in myList)
        {
            Console.WriteLine(item);
        }
    }
}

