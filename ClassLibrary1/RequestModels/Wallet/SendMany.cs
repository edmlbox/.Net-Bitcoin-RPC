
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Wallet
{
   public class SendMany
    {//Must be set to "" for backwards compatibility.
        public string Dummy { get; set; } = "";

        public List<AddressAmount> AddressesAmounts = new List<AddressAmount>();


        //Ignored dummy value
        public int? MinConf { get; set; }
        public string Comment { get; set; }
        public List<string> SubtractFeeFrom { get; set; }
        public bool? Replaceable { get; set; }
        public int? ConfTarget { get; set; }
        public EstimateMode? EstimateMode { get; set; }


        public SendMany()
        {

        }
    }
}
