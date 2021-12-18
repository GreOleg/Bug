using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug.Interfaces;
using Bug.Enums;

namespace Bug
{
    public static class ICollectionExtensions
    {
        public static void AddIssue<T>(this ICollection<T> issueList)
            where T : IIssue, new()
        {
            T issue = new();

            issue.Set(issue);

            issueList.Add(issue);
        }

        public static void ShowAll<T>(this ICollection<T> issueList)
            where T : IIssue
        {
            foreach (var issue in issueList)
            {
                Console.WriteLine(issue.Get());
            }
        }

        public static IEnumerable<T> GetIssueById<T>(this ICollection<T> issueList, Guid id)
            where T : IIssue
        {
            return issueList.Where(issue => issue.Id == id);
        }

        public static void ShowIssueById<T>(this ICollection<T> issues)
            where T : IIssue 
        {
            Console.WriteLine("Please enter id");
            Guid id = new Guid(Console.ReadLine());
            var element = issues.Where(x => x.Id == id).FirstOrDefault();
            Console.WriteLine(element);
        }

        public static void SortIssues<T>(this ICollection<T> issues, string orderBy, int dest)
            where T : IIssue
        {
            issues.OrderBy(x => x.Status).Reverse();
        }

        public static void FilterIssues<T>(this ICollection<T> issues, string filterBy, string value)
            where T : IIssue
        {
            Console.WriteLine("Please enter value for filter");
            filterBy = Console.ReadLine();
            var element = issues.Where(x => x.Summary == filterBy).FirstOrDefault();
            Console.WriteLine(element);
        }

        public static void RunTestCaseById<T>(this ICollection<TestCase> testCases)
            where T : IIssue
        {
            Console.WriteLine("Gap");
        }
        public static void ChangeBugStatusById(this ICollection<Bug> bugs, ICollection<TestCase> testCases)
             
        {
            Console.WriteLine("Please enter Test id");
            int id = int.Parse(Console.ReadLine());
            var element = bugs.Where(x => x.TestCaseId == id).FirstOrDefault();
            element.Status = Status.Done;
        }

        public static void DeleteIssueById<T>(this ICollection<T> issues)
             where T : IIssue
        {
            Console.WriteLine("Please enter id") ;
            Guid id = new Guid(Console.ReadLine());
            var element = issues.Where(x => x.Id == id).FirstOrDefault();
            issues.Remove(element);
        }

    }
}