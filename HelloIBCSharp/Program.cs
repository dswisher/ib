using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IBApi;

namespace HelloIBCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // IBs main object
            EWrapperImpl ibClient = new EWrapperImpl();

            // Connect
            Console.WriteLine("Connecting to the IB gateway...");
            ibClient.ClientSocket.eConnect("127.0.0.1", 4001, 0);

            // Request market data
            Contract contract = new Contract();
            contract.Symbol = "EUR";
            contract.SecType = "CASH";
            contract.Currency = "GBP";
            contract.Exchange = "IDEALPRO";

            ibClient.ClientSocket.reqMktData(1, contract, "", false, null);

            // Stay alive for a little while
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);

            Console.WriteLine("Got a key!");

            ibClient.ClientSocket.Close();

            Console.WriteLine("IB gateway connection closed.");
        }
    }
}
