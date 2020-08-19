using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
   public class TransactionOutputs
    {
        public string Txid { get; set; }
        public int Vout { get; set; }


        public TransactionOutputs(string txid, int vout)
        {

            this.Txid = txid;
            this.Vout = vout;

        }
    }
}
