using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public interface IReseller
    {
        bool CreateNewDomain(string name, string hosts, string ownerDetails);
    }
}
