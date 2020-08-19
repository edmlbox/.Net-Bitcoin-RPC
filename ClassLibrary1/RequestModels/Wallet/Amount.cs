using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
  public  class AddressAmount
    {
        public string Address { get; set; }
        public object Amount { get; set; }

        public AddressAmount(string address, string amount)
        {
            this.Address = address;
            this.Amount = amount;
        }
        public AddressAmount(string address, float amount)
        {
            this.Address = address;
            this.Amount = amount;
        }
    }
}
