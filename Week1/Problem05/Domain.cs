using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class Domain
    {
        public string name { get; private set; }
        public string hosts { get; private set; }
        public string ownerDetails { get; private set; }
        public Domain(string name, string hosts, string ownerDetails)
        {
            this.name = name;
            this.hosts = hosts;
            this.ownerDetails = ownerDetails;
        }
        public bool IsEquals(Domain domain)
        {
            if(name == domain.name)
            {
                if(hosts == domain.hosts)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
