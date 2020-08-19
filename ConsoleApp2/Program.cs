using System;

using BitcoinRpc;
using BitcoinRpc.CoreRPC;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333","alice:pass");

            Blockchain blockchain = new Blockchain(bitcoinClient);

            string xx = blockchain.GetbBlockchainInfo().Result;
            Console.WriteLine(xx);
        }
    }
}
