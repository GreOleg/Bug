using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug.Enums;

namespace Bug.Application
{ 
    public class App
    {
        static List<Bug> bugs { get; set; } = new List<Bug>();
        static List<TestCase> testCases { get; set; } = new List<TestCase>();

        string[] options = {
            "Create a test case",
            "Show a test case by id",
            "Show all test cases",
            "Delete test case by id",
            "Run a test case by id", 
            "Show a bug by id",
            "Show all bugs",
            "Change a bug status by id",
            "Delete a bug",
            "Create a bug",
            "Exit"
        };

        public void Run()
        {
            var choice = Action.Choose(options);
            switch (choice)
            {
                case 1:
                    var testCase = InitTestCase();
                    testCases.Add(testCase);
                    break;
                case 2:
                    ICollectionExtensions.ShowIssueById(testCases);
                    break;
                case 3:
                    testCases.ForEach(Console.WriteLine); 
                    break;
                case 4:
                    ICollectionExtensions.DeleteIssueById(testCases);
                    //DeleteTestCaseById();
                    break;
                case 5:
                    ICollectionExtensions.RunTestCaseById<TestCase>(testCases);
                    break;
                case 6:
                    ICollectionExtensions.ShowIssueById(bugs);
                    break;
                case 7:
                    bugs.ForEach(Console.WriteLine);
                    break;
                case 8:
                    ICollectionExtensions.ChangeBugStatusById(bugs, testCases);
                    break;
                case 9:
                    ICollectionExtensions.DeleteIssueById(bugs);
                    //DeleteBugById();
                    break;
                case 10:
                    var bug = InitBug();
                    bugs.Add(bug);
                    break;
                case 11:
                    Environment.Exit(11);
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please follow the instructions above");
                    break;
            }

        }

        private static TestCase InitTestCase()
        {
            Console.WriteLine("Please choose priority");
            Priority priority = 0;
            int enumOptions = Action.ChooseEnumOptions<Priority>();
            switch (enumOptions)
            {
                case 1:
                    priority = Priority.Low;
                    break;
                case 2:
                    priority = Priority.Medium;
                    break;
                case 3:
                    priority = Priority.High;
                    break;
                case 4:
                    priority = Priority.Critical;
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please follow the instructions above");
                    break;
            }

            //summary for TestCase

            string summary = string.Empty;
            bool validInputRecievedSummary = true;
            do
            {
                Console.WriteLine($"Enter {nameof(TestCase.Summary)}");
                var input = Console.ReadLine();
                var isInputValid = !(string.IsNullOrEmpty(input));
                if (!isInputValid) continue;
                summary = input;
                validInputRecievedSummary = false;

            } while (validInputRecievedSummary);

            //precondition for TestCase

            string precondition = string.Empty;
            bool validInputRecievedPrecondition = true;
            do
            {
                Console.WriteLine($"Enter {nameof(TestCase.Precondition)}");
                var input = Console.ReadLine();
                var isInputValid = !(string.IsNullOrEmpty(input));
                if (!isInputValid) continue;
                precondition = input;
                validInputRecievedPrecondition = false;

            } while (validInputRecievedPrecondition);


            var steps = new List<Step>();
            var step = InitStep();
            steps.Add(step);
           
            var testCase = new TestCase()
            {
                Priority = priority,
                Summary = summary,
                Precondition = precondition,
                Steps = steps,
            };

            return testCase;
        }

        private static Step InitStep()
        {
            //action for Step

            string action = string.Empty;
            bool validInputRecievedAction = true;
            do
            {
                Console.WriteLine($"Enter Step {nameof(Step.Action)}");
                var input = Console.ReadLine();
                var isInputValid = !(string.IsNullOrEmpty(input));
                if (!isInputValid) continue;
                action = input;
                validInputRecievedAction = false;

            } while (validInputRecievedAction);

            //result for Step

            string result = string.Empty;
            bool validInputRecievedResult = true;
            do
            {
                Console.WriteLine($"Enter Step {nameof(Step.Result)}");
                var input = Console.ReadLine();
                var isInputValid = !(string.IsNullOrEmpty(input));
                if (!isInputValid) continue;
                result = input;
                validInputRecievedResult = false;

            } while (validInputRecievedResult);


            var step = new Step()
            {
                Action = action,
                Result = result,
            };

            return step;

        }

        private static Bug InitBug()
        {
            //priority for bug

            Console.WriteLine("Please choose priority");
            Priority priority = 0;
            int enumOptions = Action.ChooseEnumOptions<Priority>();
            switch (enumOptions)
            {
                case 1:
                    priority = Priority.Low;
                    break;
                case 2:
                    priority = Priority.Medium;
                    break;
                case 3:
                    priority = Priority.High;
                    break;
                case 4:
                    priority = Priority.Critical;
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please follow the instructions above");
                    break;
            }
           
            //summary for Bug

            string summary = string.Empty;
            bool validInputRecievedSummary = true;
            do
            {
                Console.WriteLine($"Enter {nameof(Bug.Summary)}");
                var input = Console.ReadLine();
                var isInputValid = !(string.IsNullOrEmpty(input));
                if (!isInputValid) continue;
                summary = input;
                validInputRecievedSummary = false;

            } while (validInputRecievedSummary);

            //precondition for Bug

            string precondition = string.Empty;
            bool validInputRecievedPrecondition = true;
            do
            {
                Console.WriteLine($"Enter {nameof(Bug.Precondition)}");
                var input = Console.ReadLine();
                var isInputValid = !(string.IsNullOrEmpty(input));
                if (!isInputValid) continue;
                precondition = input;
                validInputRecievedPrecondition = false;

            } while (validInputRecievedPrecondition);

            //testCaseId for Bug

            string testCaseIdStr = string.Empty;
            int testCaseId = 0;
            do
            {
                Console.WriteLine($"Enter {nameof(Bug.TestCaseId)}");
                testCaseIdStr = Console.ReadLine();
            } while (!(int.TryParse(testCaseIdStr, out testCaseId)));

            //stepNumber for Bug

            string stepNumberStr = string.Empty;
            int stepNumber = 0;
            do
            {
                Console.WriteLine($"Enter {nameof(Bug.StepNumber)}");
                stepNumberStr = Console.ReadLine();
            } while (!(int.TryParse(stepNumberStr, out stepNumber)));

            //actualResult for Bug

            string actualResult = string.Empty;
            bool validInputRecievedActualResult = true;
            do
            {
                Console.WriteLine($"Enter {nameof(Bug.ActualResult)}");
                var input = Console.ReadLine();
                var isInputValid = !(string.IsNullOrEmpty(input));
                if (!isInputValid) continue;
                actualResult = input;
                validInputRecievedActualResult = false;

            } while (validInputRecievedActualResult);

            //expectedResult for Bug

            string expectedResult = string.Empty;
            bool validInputRecievedExpectedResult = true;
            do
            {
                Console.WriteLine($"Enter {nameof(Bug.ExpectedResult)}");
                var input = Console.ReadLine();
                var isInputValid = !(string.IsNullOrEmpty(input));
                if (!isInputValid) continue;
                expectedResult = input;
                validInputRecievedExpectedResult = false;

            } while (validInputRecievedExpectedResult);

            var bug = new Bug()
            {
                Priority = priority,
                Summary = summary,
                Precondition = precondition,
                TestCaseId = testCaseId,
                StepNumber = stepNumber,
                ActualResult = actualResult,
                ExpectedResult = expectedResult
            };

            return bug;
        }
    }
}
