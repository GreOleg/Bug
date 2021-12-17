using System;

namespace Bug
{
    public class Step
    {
        public int Number { get; }
        public string Action { get; set; }
        public string Result { get; set; }


        public override string ToString()
        {
            return $"Step Number = {Number}, \n " +
                $"Step Action = {Action}, \n " +
                $"Step Result = {Result}. \n";
        }
    }
}
