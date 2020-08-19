using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
   public class QueryOptions
    {
        public object MinimumAmount { get; set; }
        public object MaximumAmount { get; set; }
        public int? MaximumCount { get; set; }
        public object MinimumSumAmount { get; set; }


        public void SetMinimumAmount(string amount) { this.MinimumAmount = amount; }
        public void SetMinimumAmount(float amount) { this.MinimumAmount = amount; }
        public void SetMaximumAmount(string amount) { this.MaximumAmount = amount; }
        public void SetMaximumAmount(float amount) { this.MaximumAmount = amount; }
        public void SetMinimumSumAmount(string amount) { this.MinimumSumAmount = amount; }
        public void SetMinimumSumAmount(float amount) { this.MinimumSumAmount = amount; }
    }
}
