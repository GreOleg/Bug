using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug
{
    public interface IIssue
    {
        IIssue Get();
        void Set(IIssue issue);
    }
}
