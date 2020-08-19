
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;
namespace BitcoinRpc.RequestModels.Wallet
{
   public class MultiData
    {
        public string Desc { get; set; }
        public string ScriptPubKey { get; set; }
        public object Timestamp { get; set; }
        public string RedeemScript { get; set; }
        public string WitnessScript { get; set; }

        public List<string> Pubkeys = new List<string>();
        public List<string> Keys = new List<string>();
        public object Range { get; set; }
        public bool? Internal { get; set; }
        public bool? WatchOnly { get; set; }
        public string Label { get; set; }
        public bool? Keypool { get; set; }

        private ScriptPubKeyType? scriptPubKeyType;


        public void SetScriptPubKey(string addressOrScript, ScriptPubKeyType scriptPubKeyType)
        {
            ScriptPubKey = addressOrScript;
            this.scriptPubKeyType = scriptPubKeyType;
        }


        public void SetTimestamp(long timeStamp) { Timestamp = timeStamp; }
        public void SetTimestamp(CreationTime creationTime) { Timestamp = creationTime; }

        public void SetRange(int endRange) { Range = endRange; }
        public void SetRange(int beginRange, int endRange)
        {

            Range = new int[] { beginRange, endRange };

        }

        public ScriptPubKeyType? GetScriptPubKeyType()
        {
            return scriptPubKeyType;
        }

    }
}
