using System;
using Bug.Models;

namespace Bug
{
    public class Bug
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Priority Priority { get; set; }
        public string Summary { get; set; }
        public string Precondition { get; set; }
        public Status Status { get; set; }
        public int TestCaseId { get; set; }
        public int StepNumber { get; set; }
        public string ActualResult { get; set; }
        public string ExpectedResult { get; set; }

        public Bug()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
            Status = Status.New;
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
