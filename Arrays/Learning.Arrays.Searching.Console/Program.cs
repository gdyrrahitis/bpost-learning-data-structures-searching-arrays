namespace Learning.Arrays.Sorting.Console
{
    using Learning.Arrays.Searching.Console;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var keyToSearch = 440;
            var array = Enumerable.Range(0, 10001).ToArray();
            var searcher = new BinarySearcher(array);

            // Imperative example. Uncomment to run.
            //var result = searcher.Find(keyToSearch);

            // Recursive example. Uncomment to run.
            // var result = searcher.FindRec(keyToSearch);
            // System.Console.WriteLine($"Found {result}");
        }
    }
}
