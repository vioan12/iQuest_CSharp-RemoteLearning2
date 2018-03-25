using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public abstract class Subject : ISubject
    {
        private List<IObserver> observersList = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            observersList.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            observersList.Remove(observer);
        }
        public void Notify(Domain domain)
        {
            foreach (IObserver observer in observersList)
            {
                observer.Update(domain);
            }
        }
    }
}
