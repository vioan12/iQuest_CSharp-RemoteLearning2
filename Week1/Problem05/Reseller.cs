using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class Reseller : Registrar, IReseller
    {
        public List<Domain> CreatedDomains { get; private set; }
        public Reseller()
        {
            CreatedDomains = new List<Domain>();
        }
        public new bool CreateNewDomain(string name, string hosts, string ownerDetails)
        {
            Domain newDomain;
            foreach (Domain domain in CreatedDomains)
            {
                if (domain.IsEqualsNameHosts(name, hosts))
                {
                    return false;
                }
            }
            newDomain = base.CreateNewDomain(name, hosts, ownerDetails);
            CreatedDomains.Add(newDomain);
            return true;
        }
    }
}
