using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class Reseller : IReseller
    {
        public List<Registrar.Domain> CreatedDomains { get; private set; }
        private IRegistrar registrar { get; set; }
        public Reseller(IRegistrar registrar)
        {
            CreatedDomains = new List<Registrar.Domain>();
            this.registrar = registrar;
        }
        public bool CreateNewDomain(string name, string hosts, string ownerDetails)
        {
            Registrar.Domain newDomain;
            foreach (Registrar.Domain domain in CreatedDomains)
            {
                if (domain.IsEqualsNameHosts(name, hosts))
                {
                    return false;
                }
            }
            newDomain = registrar.CreateNewDomain(name, hosts, ownerDetails);
            CreatedDomains.Add(newDomain);
            return true;
        }
    }
}
