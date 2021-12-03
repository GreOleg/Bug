using System;

namespace Bug
{
    public class Step
    {
        public Guid Number { get; set; }
        public string Action { get; set; }
        public string Result { get; set; }

        public Step()
        {
            Number = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"Step Number = {Number}, \n " +
                $"Step Action = {Action}, \n " +
                $"Step Result = {Result}. \n";
        }
    }
}
