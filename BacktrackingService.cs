using System.Collections.Generic;

namespace eight_queens;

public interface ISolver
{
    List<int[]> GetResults();
}

public class BacktrackingService : ISolver
{
    private List<int[]> _solutions = new();
    private int[] _queens = new int[8];
    
    public List<int[]> GetResults()
    {
        _solutions = new List<int[]>();
        _queens = new int[8];
        Backtrack(0);
        return _solutions;
    }
    
    private void Backtrack(int row)
    {
        if (row == 8)
        {
            int[] solution = new int[8];
            Array.Copy(_queens, solution, 8);
            _solutions.Add(solution);
            return;
        }
        
        for (int col = 0; col < 8; col++)
        {
            if (IsSafe(row, col))
            {
                _queens[row] = col;
                Backtrack(row + 1);
            }
        }
    }
    
    private bool IsSafe(int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            if (_queens[i] == col)
                return false;
            
            if (Math.Abs(_queens[i] - col) == Math.Abs(i - row))
                return false;
        }
        return true;
    }
}