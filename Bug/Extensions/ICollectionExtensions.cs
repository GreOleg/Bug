using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug.Interfaces;

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

        public static IEnumerable<T> GetIssueById<T>(this ICollection<T> issueList, long id)
            where T : IIssue
        {
            return issueList.Where(issue => issue.Id == id);
        }

        public static void ShowIssueById<T>(this ICollection<T> issues, long id)
            where T : IIssue 
        {

        }

        public static void SortIssues<T>(this ICollection<T> issues, string orderBy, int dest)
            where T : IIssue
        {
            issues.OrderBy(x => x.Status).Reverse();
        }

        public static void FilterIssues<T>(this ICollection<T> issues, string filterBy, string value)
            where T : IIssue
        {

        }

        public static void RunTestCaseById<T>(this ICollection<TestCase> testCases, long id)
            where T : IIssue
        {

        }
    }
}
