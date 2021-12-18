using System;
using System.Collections.Generic;
using Bug.Interfaces;
using Bug.Enums;

namespace Bug
{
    public class Bug : Issue
    {
        public int TestCaseId { get; set; }
        public int? StepNumber { get; set; }
        public string ActualResult { get; set; }
        public string ExpectedResult { get; set; }

        public override IIssue Get()
        {
            return this;
        }

        public override void Set(IIssue issue)
        {
            var bug = issue as Bug;
            if (bug != null)
            {
                Id = bug.Id;
                CreationDate = bug.CreationDate;
                Priority = bug.Priority;
                Summary = bug.Summary;
                Precondition = bug.Precondition;
                Status = bug.Status;
                TestCaseId = bug.TestCaseId;
                StepNumber = bug.StepNumber;
                ActualResult = bug.ActualResult;
                ExpectedResult = bug.ExpectedResult;
            }
            else
            {
                throw new InvalidCastException("Ошибка преобразования");
            }
        }

        public override string ToString()
        {
            return $"Id = {Id}, \n CreationDate = {CreationDate}, \n" +
                $"Priority = {Priority}, \n" +
                $"Summary = {Summary}, \n" +
                $"Precondition = {Precondition}, \n" +
                $"Status = {Status}, \n" +
                $"TestCaseId = {TestCaseId}, \n" +
                $"StepNumber = {StepNumber}, \n" +
                $"ActualResult = {ActualResult}, \n" +
                $"ExpectedResult = {ExpectedResult}";
        }
    }
}
