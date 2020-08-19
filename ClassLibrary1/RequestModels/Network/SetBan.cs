
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Network
{
   public class SetBan
    {
        public string Subnet { get; set; }
        public BanCommand BanCommand { get; set; }
        public int BanTime { get; set; }
        public bool Absolute { get; set; }
    }
}
