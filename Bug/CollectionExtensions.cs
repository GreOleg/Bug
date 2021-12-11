using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug
{
    public static class CollectionExtensions
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
            where T : Issue
        {
            return issueList.Where(issue => issue.Id == id);
        }
    }
}
