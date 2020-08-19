using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class CreatePSBT
    {
        public List<PSBTInput> PSBT_Inputs { get; set; }
        public List<PSBTOutput> PSBT_Outputs { get; set; }
        public int? Locktime { get; set; }
        public bool? Replaceable { get; set; }

        //hex data for 2 argument. There is one data can be;
        public string Data { get; set; }
    }
}
