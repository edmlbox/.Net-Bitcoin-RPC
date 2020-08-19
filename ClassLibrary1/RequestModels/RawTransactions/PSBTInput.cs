using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
   public class PSBTInput
    {
        public string Txid { get; set; }
        public int Vout { get; set; }
        public int? Sequence { get; set; }

        public PSBTInput(string txid, int vout)
        {
            this.Txid = txid;
            this.Vout = vout;
        }
        public PSBTInput(string txid, int vout, int sequence)
        {
            this.Txid = txid;
            this.Vout = vout;
            this.Sequence = sequence;
        }
    }
}
