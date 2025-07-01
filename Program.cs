namespace eight_queens;

class Program
{
    static void Main()
    {
        var backtrackingService = new BacktrackingService();
        var results = backtrackingService.GetResults();
        PrintResults(results);
        
        Console.WriteLine("\n");
    }
    
    static void PrintResults(List<int[]> solutions)
    {
        for (int i = 0; i < solutions.Count; i++)
        {
            Console.WriteLine($"//Solution {i + 1}:");
            PrintBoard(solutions[i]);
            Console.WriteLine();
        }
    }
    
    static void PrintBoard(int[] queens)
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (queens[row] == col)
                    Console.Write("Q");
                else
                    Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}
