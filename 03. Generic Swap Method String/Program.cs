namespace ExerciseGenerics
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }

            int[] ints = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            box.Swap(ints[0], ints[1]);
            Console.WriteLine(box.ToString());
        }
    }
}