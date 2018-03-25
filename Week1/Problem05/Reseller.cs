using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class Reseller : Subject, IObserver 
    {
        public void Update(Domain domain)
        {
            Notify(domain);
        }
    }
}
