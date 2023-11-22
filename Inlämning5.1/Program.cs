using System;
namespace inlämning5.__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mening = new string[] { "Dett är en mening", "Detta är en till mening", "Wow tre i rad" };
            for (int i = 0; i < mening.Length; i++)
            {
                Console.WriteLine(mening[i]);
                Console.WriteLine();
            }
        }
    }
}
