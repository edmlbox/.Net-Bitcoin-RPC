
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Wallet
{
   public class SendToAddress
    {
        public string Address { get; set; }
        public object Amount { get; set; }
        public string Comment { get; set; }
        public string CommentTo { get; set; }
        public bool? SubtractFeeFromAmount { get; set; }
        public bool? Replaceable { get; set; }
        public int? ConfTarget { get; set; }
        public EstimateMode? EstimateMode { get; set; }
        public bool? AvoidReuse { get; set; }


        public SendToAddress(string address, string amount)
        {
            this.Address = address; this.Amount = amount;
        }

        public SendToAddress(string address, float amount)
        {
            this.Address = address; this.Amount = amount;
        }
    }
}
