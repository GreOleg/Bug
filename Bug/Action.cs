using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug
{
    public static class Actions
    {
        public static int Choose(params string[] menuPoints)
        {
            while (true)
            {
                Console.Clear();
                WriteMenuPoints(menuPoints);

                Console.WriteLine("Please choose action number");
                var point = Console.ReadLine();

                var inputParsed = int.TryParse(point, out int userPoint);

                if (!inputParsed || userPoint > menuPoints.Length)
                {
                    WriteMenuPoints(menuPoints);
                    continue;
                }

                return userPoint - 1;
            }
        }

        private static void WriteMenuPoints(string[] menuPoints)
        {
            for (int i = 0; i < menuPoints.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {menuPoints[i]}");
            }
        }
    }
}
