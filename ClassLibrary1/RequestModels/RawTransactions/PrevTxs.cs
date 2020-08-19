using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    public class PrevTxs
    {
        public string Txid { get; set; }
        public int Vout { get; set; }
        public string ScriptPubKey { get; set; }
        public string RedeemScript { get; set; }
        public string WitnessScript { get; set; }
        public object Amount { get; set; }


        //ctor amount as string type
        public PrevTxs(
            string txid,
            int vout,
            string scriptPubKey,

            string amount,
            string redeemScript = "",
            string witnessScript = ""
            )
        {
            this.Txid = txid;
            this.Vout = vout;
            this.ScriptPubKey = scriptPubKey;
            this.RedeemScript = redeemScript;
            this.WitnessScript = witnessScript;
            this.Amount = amount;

        }
        //ctor amount as float type
        public PrevTxs(
            string txid,
            int vout,
            string scriptPubKey,

            float amount,
            string redeemScript = "",
            string witnessScript = ""
            )
        {
            this.Txid = txid;
            this.Vout = vout;
            this.ScriptPubKey = scriptPubKey;
            this.RedeemScript = redeemScript;
            this.WitnessScript = witnessScript;
            this.Amount = amount;

        }
    }
}
