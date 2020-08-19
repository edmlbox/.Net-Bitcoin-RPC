using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
   public class RawInput
    {
        public string Txid { get; set; }
        public int Vout { get; set; }
        public int? Sequence { get; set; }


        public RawInput(string txid, int vout, int? sequence = null)
        {
            this.Txid = txid;
            this.Vout = vout;
            this.Sequence = sequence;
        }
    }
}
