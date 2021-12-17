using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug.Application
{
    public class App
    {
        public List<Bug> bugs { get; set; }
        public List<TestCase> testCases { get; set; }

        string[] options = {"Create a test case",
            "Show a test case by id",
            "Show all test cases",
            "Delete test case by id",
            "Run a test case by id", "Show a bug by id",
            "Show all bugs",
            "Change a bug status by id",
            "Delete a bug",
            "Exit"};

        public void Run()
        {
            var choice = Actions.Choose(options);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Create a test case");
                    break;
                case 2:
                    Console.WriteLine("Show a test case by id");
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please follow the instructions above");
                    break;
            }
            //var bug = bugs.Where(x => x.Id == input);
            //bugs.Remove(bug);
        }

        //private static TestCase InitTestCase()
        //{
        //    Priority priority;
        //    while (true)
        //    {
        //        Console.WriteLine("Enter Test Case priority: l for low, m for medium, h for high");
        //        string priorityStr = Console.ReadLine().ToUpper();
        //        if (priorityStr == "M" || priorityStr == "L" || priorityStr == "H")
        //        {
        //            priority = ProcessPriority(priorityStr);
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Uncorrect data, try on");
        //            continue;
        //        }
        //    }
        //}
    }
}
