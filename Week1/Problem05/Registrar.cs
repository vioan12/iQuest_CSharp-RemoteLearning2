using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class Registrar
    {
        public Registrar()
        {
        }
        protected Domain CreateNewDomain(string name, string hosts, string ownerDetails)
        {
            Domain newDomain = new Domain(name, hosts, ownerDetails);
            return newDomain;
        }
        public class Domain
        {
            public string Name { get; private set; }
            public string Hosts { get; private set; }
            public string OwnerDetails { get; private set; }
            public Domain(string name, string hosts, string ownerDetails)
            {
                Name = name;
                Hosts = hosts;
                OwnerDetails = ownerDetails;
            }
            public bool IsEqualsNameHosts(string name, string hosts)
            {
                if (Name == name)
                {
                    if (Hosts == hosts)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
