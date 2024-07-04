namespace TakeIEnumerable
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = arr.Take(5);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
