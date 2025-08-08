namespace Assignment_5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 4;
            Console.WriteLine(stepCombinations(steps));
        }
        static int stepCombinations(int steps)
        {
            if (steps == 0) { return 1; }
            if (steps < 0) { return 0; }

            return stepCombinations(steps - 1) + stepCombinations(steps - 2);
        }
    }
}
