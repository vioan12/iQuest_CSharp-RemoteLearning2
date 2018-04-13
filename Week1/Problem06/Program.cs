using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    public class Program
    {
        private static ConnectionManager connectionManager;
        private static Client client;
        public static void Main(string[] args)
        {
            ReadFile readFile = new ReadFile(Constants.ClientFileName);
            ClientConverter clientConverter = new ClientConverter();
            client = clientConverter.Convert(readFile.Read()).ElementAt(0);
            connectionManager = new ConnectionManager(3);
            ConnectionManager.Connection connection;
            try
            {
                connection = connectionManager.ConnectionRequest(20);
                System.Console.WriteLine(connection.Id);
                connection = connectionManager.ConnectionRequest(1000);
                System.Console.WriteLine(connection.Id);
                connection = connectionManager.ConnectionRequest(50);
                System.Console.WriteLine(connection.Id);
                connection = connectionManager.ConnectionRequest(550);
                if (connection != null)
                {
                    System.Console.WriteLine(connection.Id);
                }
                else
                {
                    System.Console.WriteLine("null");
                }
                connection = connectionManager.ConnectionRequest(848);
                if (connection != null)
                {
                    System.Console.WriteLine(connection.Id);
                }
                else
                {
                    System.Console.WriteLine("null");
                }
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
