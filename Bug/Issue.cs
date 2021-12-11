using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug.Models;

namespace Bug
{
    public abstract class Issue : IIssue
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Priority Priority { get; set; }
        public string Summary { get; set; }
        public string Precondition { get; set; }
        public Status Status { get; set; }

        
        public virtual IIssue Get()
        {
            return this;
        }

        public virtual void Set(IIssue issue)
        {

        }

    }
}
