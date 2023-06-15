namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            
            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }
            double element = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(element));
            
        }
    }
}