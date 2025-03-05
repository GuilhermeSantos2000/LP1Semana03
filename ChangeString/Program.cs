using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float [,] A = new float[2, 2];
            float [,] B = new float[2, 1];

            A[0, 0] = float.Parse(args[0]);
            A[0, 1] = float.Parse(args[1]);
            A[1, 0] = float.Parse(args[2]);
            A[1, 1] = float.Parse(args[3]);
            B[0, 0] = float.Parse(args[4]);
            B[1, 0] = float.Parse(args[5]);
        }
    }
}
