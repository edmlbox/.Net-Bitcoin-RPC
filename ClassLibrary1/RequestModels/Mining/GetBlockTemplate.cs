
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Mining
{
   public class GetBlockTemplate
    {
        public string Target { get; set; }

        /**<summary>MUST be hex-encoded block data.</summary>**/
        public string Data { get; set; }
        /**<summary>If the server provided a workid, it MUST be included with proposals.</summary>**/
        public string WorkId { get; set; }
        /**<summary>Size of nonce range the miner needs; if not provided, the server SHOULD assume the client requires 2 power of 32.</summary>**/
        public int? Nonces { get; set; }

        public TemplateRequest Mode { get; set; }
        public Rules Rules { get; set; }

        public List<Capabilities> Capabilities = new List<Capabilities>();
        public string LongPollId { get; set; }
        public TemplateTweaking TemplateTweaking { get; set; }
        public List<Server> ServerList { get; set; }
        public List<Mutable> Mutations { get; set; }


       
    }
}
