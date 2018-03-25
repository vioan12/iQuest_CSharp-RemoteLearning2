using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    public class Connection
    {
        public int id { get; private set; }
        protected Connection(int id)
        {
            this.id = id;
        }
    }
}
