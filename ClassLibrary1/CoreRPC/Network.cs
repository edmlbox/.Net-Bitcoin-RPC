using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.Mining;
using BitcoinRpc.RequestModels.Network;
using BitcoinRpc.StaticStrings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace BitcoinRpc.CoreRPC
{
    /// <summary>
    /// The main <seealso cref="Network"/> class.
    /// Contains all methods for performing <seealso cref="Network"/> operations.
    /// </summary>
    public class Network
    {
        BitcoinClient bitcoinClient;
        HttpRequest httpRequest;

        public Network(BitcoinClient bitcoinClient)
        {
            this.bitcoinClient = bitcoinClient;
            httpRequest = new HttpRequest(bitcoinClient);
        }
        /// <summary>
        /// Attempts to add or remove a node from the addnode list.
        ///Or try a connection to a node once.
        ///Nodes added using addnode (or -connect) are protected from DoS disconnection and are not required to be
        ///full nodes/support SegWit as other outbound peers are(though such peers will not be synced from).
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="command">'add' to add a node to the list, 'remove' to remove a node from the list, 'onetry' to try a connection to the node once.</param>
        /// <returns></returns>
        public async Task<string> AddNode(string node, NodeCommand command)
        {

            AddNode addNode = new AddNode() { Node = node, NodeCommand = command };
            string response = await httpRequest.SendReq(MethodName.addnode, addNode);
            return response;

        }
        /// <summary>
        /// Clear all banned IPs.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ClearBanned()
        {

            string response = await httpRequest.SendReq(MethodName.clearbanned);
            return response;

        }
        /// <summary>
        /// Immediately disconnects from the specified peer node.
        /// </summary>
        /// <param name="nodeId">The node ID (see getpeerinfo for node IDs).</param>
        /// <returns></returns>
        public async Task<string> DisconnectNode(int nodeId)
        {
            DisconnectNode disconnectNode = new DisconnectNode() { NodeId = nodeId };
            string response = await httpRequest.SendReq(MethodName.disconnectnode, disconnectNode);
            return response;

        }
        /// <summary>
        /// Immediately disconnects from the specified peer node.
        /// </summary>
        /// <param name="nodeAddress">The IP address/port of the node</param>
        /// <returns></returns>
        public async Task<string> DisconnectNode(string nodeAddress)
        {
            DisconnectNode disconnectNode = new DisconnectNode() { NodeAddress = nodeAddress };
            string response = await httpRequest.SendReq(MethodName.disconnectnode, disconnectNode);
            return response;

        }
        /// <summary>
        /// Returns information about all nodes.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetAddedNodeInfo()
        {
            string response = await httpRequest.SendReq(MethodName.getaddednodeinfo);
            return response;

        }
        /// <summary>
        /// Returns information about the given added node.
        ///(note that onetry addnodes are not listed here)
        /// </summary>
        /// <param name="nodeAddress">Returns information about this specific node.</param>
        /// <returns></returns>
        public async Task<string> GetAddedNodeInfo(string nodeAddress)
        {

            string response = await httpRequest.SendReq(MethodName.getaddednodeinfo, nodeAddress);
            return response;

        }
        /// <summary>
        /// Returns the number of connections to other nodes.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetConnectionCount()
        {
            string response = await httpRequest.SendReq(MethodName.getconnectioncount);
            return response;

        }
        /// <summary>
        /// Returns information about network traffic, including bytes in, bytes out,
        /// and current time.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetNetTotals()
        {
            string response = await httpRequest.SendReq(MethodName.getnettotals);
            return response;

        }
        /// <summary>
        /// Returns an object containing various state info regarding P2P networking.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetNetworkInfo()
        {
            string response = await httpRequest.SendReq(MethodName.getnetworkinfo);
            return response;
        }


        /// <summary>
        /// Return known addresses which can potentially be used to find new nodes in the network.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetNodeAddresses()
        {
            string response = await httpRequest.SendReq(MethodName.getnodeaddresses);
            return response;
        }

        /// <summary>
        /// Return known addresses which can potentially be used to find new nodes in the network.
        /// </summary>
        /// <param name="count">How many addresses to return. Limited to the smaller of 2500 or 23% of all known addresses.</param>
        /// <returns></returns>
        public async Task<string> GetNodeAddresses(int count)
        {
            string response = await httpRequest.SendReq(MethodName.getnodeaddresses, count);
            return response;
        }
        /// <summary>
        /// Returns data about each connected network node as a json array of objects.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetPeerInfo()
        {
            string response = await httpRequest.SendReq(MethodName.getpeerinfo);
            return response;
        }
        /// <summary>
        /// List all banned IPs/Subnets.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListBanned()
        {
            string response = await httpRequest.SendReq(MethodName.listbanned);
            return response;
        }
        /// <summary>
        /// Requests that a ping be sent to all other nodes, to measure ping time.
        /// </summary>
        /// <returns></returns>
        public async Task<string> Ping()
        {
            string response = await httpRequest.SendReq(MethodName.ping);
            return response;
        }

        /// <summary>
        /// Attempts to add or remove an IP/Subnet from the banned list.
        /// </summary>
        /// <param name="setBan">See SetBan properties.</param>
        /// <returns></returns>
        public async Task<string> SetBan(SetBan setBan)
        {

            string response = await httpRequest.SendReq(MethodName.setban, setBan);
            return response;
        }
        /// <summary>
        /// Attempts to add or remove an IP/Subnet from the banned list.
        /// </summary>
        /// <param name="subnet">The IP/Subnet (see getpeerinfo for nodes IP) with an optional netmask (default is /32 = single IP).</param>
        /// <param name="banCommand">'add' to add an IP/Subnet to the list, 'remove' to remove an IP/Subnet from the list.</param>
        /// <param name="bantime">time in seconds how long (or until when if [absolute] is set) the IP is banned (0 or empty means using the default time of 24h which can also be overwritten by the -bantime startup argument).</param>
        /// <param name="absolute">If set, the bantime must be an absolute timestamp expressed in UNIX epoch time.</param>
        /// <returns></returns>
        public async Task<string> SetBan(string subnet, BanCommand banCommand, int bantime = 0, bool absolute = false)
        {
            SetBan setBan = new SetBan { Subnet = subnet, BanCommand = banCommand, BanTime = bantime, Absolute = absolute };
            string response = await httpRequest.SendReq(MethodName.setban, setBan);
            return response;
        }
        /// <summary>
        /// Disable/enable all p2p network activity.
        /// </summary>
        /// <param name="IsNetworkActive">true to enable networking, false to disable.</param>
        /// <returns></returns>
        public async Task<string> SetNetworkActive(bool IsNetworkActive)
        {

            string response = await httpRequest.SendReq(MethodName.setnetworkactive, IsNetworkActive);
            return response;
        }






    }

}
