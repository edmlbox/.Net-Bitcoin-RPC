using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using BitcoinRpc;
using BitcoinRpc.CoreRPC;
using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.Wallet;
using BitcoinRpc.GetInfo;
using BitcoinRpc.RequestModels.RawTransactions;
using System.Text.Json;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {



            Yes().Wait();

        }

        async static Task Yes()
        {
            BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

            string hex = "020000000001012ec9d65ba255e44b85810beac4cad16418fa5c263a1d9f45ab03a4001edf24650000000000ffffffff01e803000000000000160014f998998746cb1bb34377075a79d0d9c494569d2102473044022039fc28874fc1fbf14c4297a4160acfb9793d341f32c61ccc27818fff5d47433102203c091fa28c69e3b2a337b560e20823f0a1b0aa7069d5f98dbe325a6807caa19e012102fc6958eee747f2471d4f34d5e4d7639de5c1abc32dbf05d876554cd7af66608900000000";
            string sendrawtransaction = await rawTransaction.SendRawTransaction(hex);
            
            Console.WriteLine(sendrawtransaction);
            
            
           


        }
    }
}
