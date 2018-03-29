using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class Registrar : Subject, IObserver
    {
        public List<Domain> createdDomains { get; private set; }
        public Registrar()
        {
            createdDomains = new List<Domain>();
        }
        private void CreateNewDomain(Domain domain)
        {
            foreach (Domain element in createdDomains)
            {
                if (element.IsEquals(domain))
                    throw new Exception("Domain already exists!!!");
            }
            createdDomains.Add(domain);
        }
        public void Update(Domain domain)
        {
            CreateNewDomain(domain);
            Notify(domain);
        }
    }
}
