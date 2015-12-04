using System;
using IBApi;

namespace HelloIBCSharp
{
    class Program
    {
        static void Main()
        {
            // IBs main object
            EWrapperImpl ibClient = new EWrapperImpl();

            // Connect
            Console.WriteLine("Connecting to the IB gateway...");
            ibClient.ClientSocket.eConnect("127.0.0.1", 4001, 0);

            // Request RT market data
            Console.WriteLine("Requesting a real-time quote for EUR...");
            Contract eurContract = new Contract
            {
                Symbol = "EUR",
                SecType = "CASH",
                Currency = "GBP",
                Exchange = "IDEALPRO"
            };

            ibClient.ClientSocket.reqMktData(1, eurContract, "", true, null);

            // Request some historical data
            Console.WriteLine("Requesting historical data...");
            Contract msftContract = new Contract
            {
                ConId = 0,
                Symbol = "MSFT",
                SecType = "STK",
                Currency = "USD",
                Exchange = "SMART",
                PrimaryExch = "nasdaq"
            };

            ibClient.ClientSocket.reqHistoricalData(2, msftContract, "20151204 11:55:00", "1 W", "1 day", "TRADES", 1, 1, null);

            // Stay alive for a little while
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);

            Console.WriteLine("Got a key!");

            ibClient.ClientSocket.eDisconnect();

            Console.WriteLine("IB gateway connection closed.");
        }
    }
}
