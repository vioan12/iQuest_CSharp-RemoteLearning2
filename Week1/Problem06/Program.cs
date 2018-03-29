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
            connectionManager = new ConnectionManager(3);
            Connection connection;
            client = new Client("Dan", "Florea", "015714", "dandan2@gmail.com");
            try
            {
                connection = connectionManager.ConnectionRequest(20);
                System.Console.WriteLine(connection.id);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                connection = connectionManager.ConnectionRequest(1000);
                System.Console.WriteLine(connection.id);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                connection = connectionManager.ConnectionRequest(50);
                System.Console.WriteLine(connection.id);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                connection = connectionManager.ConnectionRequest(550);
                System.Console.WriteLine(connection.id);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                connection = connectionManager.ConnectionRequest(848);
                System.Console.WriteLine(connection.id);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
