using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
   public class RawOutput
    {
        public string Address { get; set; }
        public string Amount { get; set; }
        public float? AmountInFloat { get; set; }

        public RawOutput(string address, string amount)
        {
            this.Address = address;
            this.Amount = amount;
        }
        public RawOutput(string address, float amount)
        {
            this.Address = address;
            this.AmountInFloat = amount;
        }
    }
}
