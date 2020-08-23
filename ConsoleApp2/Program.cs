using System;
using System.Collections.Generic;
using BitcoinRpc;
using BitcoinRpc.CoreRPC;
using BitcoinRpc.Enums;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            Mining mining = new Mining(bitcoinClient);

            string txid = "4f642090847babf1e09e63e6be63a446c5327a30c5b6d41cd533b90a2df8ef01";
            string prioritisetransaction = await mining.PrioritiseTransaction(txid, 2);
            
            Console.WriteLine(BitcoinRpc.Debug.JsonRequest.GetRequestAsString(true));
            Console.WriteLine(prioritisetransaction);



        }
    }
}
