using Problem06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    public class ConnectionManager
    {
        private Connection[] connectionList;
        private int numberOfConnection;
        public ConnectionManager(int sizeOfConnectionList)
        {
            connectionList = new Connection[sizeOfConnectionList];
            numberOfConnection = 0;
        }
        public Connection ConnectionRequest(int id)
        {
            
            if(numberOfConnection < connectionList.Length)
            {
                connectionList[numberOfConnection++] = new Connection(id);
                return connectionList[numberOfConnection - 1];
            }
            else
            {
                return null;
            }
            
        }
        public class Connection
        {
            public int Id { get; private set; }
            internal Connection(int id)
            {
                Id = id;
            }
        }
    }
}
