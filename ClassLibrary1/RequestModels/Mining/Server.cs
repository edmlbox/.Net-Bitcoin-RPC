using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Mining
{
   public class Server
    { /**<summary>URI of the individual server; if authentication information is omitted, the same authentication used for this request MUST be assumed.</summary>**/
        public string Uri { get; set; }

        /**<summary>Number of seconds to avoid using this server.</summary>**/
        public int? Avoid { get; set; }

        /**<summary>An integer priority of this host (default: 0).</summary>**/
        public int Priority { get; set; }

        /**<summary>Number of seconds to stick to this server when used.</summary>**/
        public int? Sticky { get; set; }

        /**<summary>Whether this server may update the serverlist (default: true).</summary>**/
        public bool Update { get; set; } = true;

        /**<summary>A relative weight for hosts with the same priority (default: 1).</summary>**/
        public int Weight { get; set; } = 1;

        public Server(string uri, bool update = true, int priority = 0, int weight = 1, int? avoid = null, int? sticky = null)
        {
            this.Avoid = avoid;
            this.Priority = priority;
            this.Sticky = sticky;
            this.Update = update;
            this.Weight = weight;
            this.Uri = uri;
        }
    }
}
