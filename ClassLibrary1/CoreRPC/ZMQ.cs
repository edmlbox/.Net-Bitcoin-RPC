
using BitcoinRpc.StaticStrings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinRpc.CoreRPC
{
    /// <summary>
    /// The main <seealso cref="ZMQ"/> class.
    /// Contains all methods for performing <seealso cref="ZMQ"/> operations.
    /// </summary>
    public class ZMQ
    {
        BitcoinClient bitcoinClient;
        HttpRequest httpRequest;
        public ZMQ(BitcoinClient bitcoinClient)
        {
            this.bitcoinClient = bitcoinClient;
            httpRequest = new HttpRequest(bitcoinClient);
        }


        /// <summary>
        /// Returns information about the active ZeroMQ notifications.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetZMQNotifications()
        {
            string response = await httpRequest.SendReq(MethodName.getzmqnotifications);
            return response;
        }

    }

}
