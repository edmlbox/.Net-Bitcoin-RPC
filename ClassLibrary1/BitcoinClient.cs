using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BitcoinRpc
{
   public class BitcoinClient
    {
        public string NodeAddress { get; set; }
        public string UserPassword { get; set; }

        public BitcoinClient(string nodeAddress, string userPassword)
        {
            NodeAddress = nodeAddress;
            UserPassword = userPassword;
        }


       




    }

}
