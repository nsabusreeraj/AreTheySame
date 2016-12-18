using System;

namespace AreTheySame
{
    internal class Program
    {
        private static void Main(string[] args)
        {

        }
    }

    public class AreTheySame
    {
        public static bool Comp(int[] a, int[] b)
        {
            bool result = false;
            if (b == null || a == null)
                return false;
            if (a.Length != b.Length)
                return false;
            if (a.Length == 0 && b.Length == 0)
                return true;

            Array.Sort(a);
            Array.Sort(b);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(b[i] + "," + a[i]);
                result = false;
                if (a[i]*a[i] == Math.Abs(b[i]))
                    result = true;

                if (result == false)
                    return false;
            }

            return result;
        }
    }
}
