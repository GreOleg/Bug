using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug.Enums;

namespace Bug.Interfaces
{
    public interface IIssue
    {
        public Guid Id { get; }
        public DateTime CreationDate { get; }
        public Priority Priority { get; set; }
        public string Summary { get; set; }
        public string Precondition { get; set; }
        public Status Status { get; set; }

        IIssue Get();
        void Set(IIssue issue);
    }
}
