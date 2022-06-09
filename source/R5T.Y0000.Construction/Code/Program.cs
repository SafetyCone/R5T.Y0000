using System;


namespace R5T.Y0000.Construction
{
    static class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine($"{Convert.ToChar(i)}: {i:000}");
            }
        }
    }
}