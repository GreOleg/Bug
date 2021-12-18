using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug
{
    public static class Action
    {
        public static int Choose(params string[] menuPoints)
        {
            while (true)
            {
                ShowoOptions(menuPoints);

                Console.WriteLine("Please choose action number");
                var point = Console.ReadLine();

                var inputParsed = int.TryParse(point, out int userPoint);

                if (!inputParsed || userPoint > menuPoints.Length)
                {
                    ShowoOptions(menuPoints);
                    continue;
                }
                return userPoint;
            }
        }

        public static int ChooseEnumOptions<T>()
            where T : Enum
        {
            var str = new List<string>();
            foreach (var option in Enum.GetValues(typeof(T)))
            {
                str.Add(option.ToString());
            }

            return Choose(str.ToArray());
        }

        private static void ShowoOptions(string[] menuPoints)
        {
            for (int i = 0; i < menuPoints.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {menuPoints[i]}");
            }
        }

    }
}
