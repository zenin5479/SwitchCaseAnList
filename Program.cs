namespace SwitchCaseAnList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string> { "Apple", "Pear" };
            switch (myList)
            {
                case var _ when myList.Contains("Apple"):
                    // do apple stuff
                    break;
                case var _ when myList.Contains("Pear"):
                    // do pear stuff
                    break;
                default:
                    throw new ArgumentException("Some error message", nameof(myList));
            }


            var numbers = new int[] { 10, 20, 30 };
            Console.WriteLine(GetSourceLabel(numbers));  // output: 1

            var letters = new List<char> { 'a', 'b', 'c', 'd' };
            Console.WriteLine(GetSourceLabel(letters));  // output: 2

            static int GetSourceLabel<T>(IEnumerable<T> source) => source switch
            {
                Array array => 1,
                ICollection<T> collection => 2,
                _ => 3,
            };


            
        }
    }
}