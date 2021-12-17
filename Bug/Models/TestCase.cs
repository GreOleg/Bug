using System;
using System.Collections.Generic;
using Bug.Interfaces;


namespace Bug
{
    public class TestCase : Issue
    {

        public List<Step> Steps { get; set; }

        public override IIssue Get()
        {
            return this;
        }

        public override void Set(IIssue issue)
        {

            var testCase = issue as TestCase;
            if (testCase != null)
            {
                Id = testCase.Id;
                CreationDate = testCase.CreationDate;
                Priority = testCase.Priority;
                Summary = testCase.Summary;
                Precondition = testCase.Precondition;
                Steps = testCase.Steps;

            }
            else {
                throw new InvalidCastException("Ошибка преобразования");
            }
         
        }
  

        public TestCase()
        {
            Steps = new List<Step>();
        }

        public override string ToString()
        {
            string stepsStr = string.Empty;

            foreach (var step in Steps)
            {
                stepsStr = stepsStr + step.ToString() + " ";
            }

            return $"Id = {Id}, \n CreationDate = {CreationDate}, \n" +
                $"Priority = {Priority}, \n" +
                $"Summary = {Summary}, \n" +
                $"Precondition = {Precondition}, \n" +
                $"Status = {Status}, \n" +
                $"Step = {stepsStr}";
        }
    }
}
