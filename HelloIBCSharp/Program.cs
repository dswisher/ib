using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloIBCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // IBs main object
            EWrapperImpl ibClient = new EWrapperImpl();

            // Connect
            ibClient.ClientSocket.eConnect("127.0.0.1", 4001, 0);

            // Stay alive for a little while
            Thread.Sleep(10000);
        }
    }
}
