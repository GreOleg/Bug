using System;
using System.Collections.Generic;
using Bug.Models;

namespace Bug
{
    public class TestCase
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Priority Priority { get; set; }
        public string Summary { get; set; }
        public string Precondition { get; set; }
        public Status Status { get; set; }
        public List<Step> Steps { get; set; }

        public TestCase()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
            Status = Status.New;
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
