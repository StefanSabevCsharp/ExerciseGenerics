﻿namespace ExerciseGenerics
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
            Console.WriteLine(box.ToString());
        }
    }
}