using BitcoinRpc.RequestModels.Mining;
using BitcoinRpc.StaticStrings;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinRpc.CoreRPC
{
    /// <summary>
    /// The main <seealso cref="Mining"/> class.
    /// Contains all methods for performing <seealso cref="Mining"/> operations.
    /// </summary>
    public class Mining
    {

        BitcoinClient bitcoinClient;
        HttpRequest httpRequest;

        public Mining(BitcoinClient bitcoinClient)
        {
            this.bitcoinClient = bitcoinClient;
            httpRequest = new HttpRequest(bitcoinClient);
        }
        /// <summary>
        /// If the request parameters include a 'mode' key, that is used to explicitly select between the default 'template' request or a 'proposal'.
        /// It returns data needed to construct a block to work on.
        ///For full specification, see BIPs 22, 23, 9, and 145
        /// </summary>
        /// <param name="getBlockTemplate">Format of the template</param>
        /// <returns></returns>
        public async Task<string> GetBlockTemplate(GetBlockTemplate getBlockTemplate)
        {

            string response = await httpRequest.SendReq(MethodName.getblocktemplate, getBlockTemplate);
            return response;
        }

        /**<summary>Returns a json object containing mining-related information.</summary>**/
        public async Task<string> GetMiningInfo()
        {

            string response = await httpRequest.SendReq(MethodName.getmininginfo);
            return response;
        }

        /// <summary>
        /// Returns the estimated network hashes per second based on the last n blocks.
        /// </summary>
        /// <param name="nblocks">The number of blocks, or -1 for blocks since last difficulty change.</param>
        /// <param name="height">To estimate at the time of the given height.</param>
        /// <returns></returns>
        public async Task<string> GetNetworkHashPS(int nblocks = 120, int height = -1)
        {
            GetNetworkHashPS getNetworkHashPS = new GetNetworkHashPS() { NBlocks = nblocks, Height = height };
            string response = await httpRequest.SendReq(MethodName.getnetworkhashps, getNetworkHashPS);
            return response;
        }
        /// <summary>
        /// Accepts the transaction into mined blocks at a higher (or lower) priority.
        /// </summary>
        /// 
        /// <param name="txid">The transaction id.</param>
        /// 
        /// <param name="feeDelta">The fee value (in satoshis) to add (or subtract, if negative).
        ///  Note, that this value is not a fee rate. It is a value to modify absolute fee of the TX.
        ///  The fee is not actually paid, only the algorithm for selecting transactions into a block
        ///  considers the transaction as it would have paid a higher (or lower) fee.</param>
        ///
        /// <param name="dummy">API-Compatibility for previous API. Must be zero or null.
        /// DEPRECATED.For forward compatibility use named arguments and omit this parameter.</param>
        /// <returns></returns>
        public async Task<string> PrioritiseTransaction(string txid, float feeDelta, int dummy = 0)
        {

            PrioritiseTransaction prioritiseTransaction = new PrioritiseTransaction(txid, feeDelta, dummy);
            string response = await httpRequest.SendReq(MethodName.prioritisetransaction, prioritiseTransaction);
            return response;
        }
        /// <summary>
        /// Attempts to submit new block to network.
        /// </summary>
        /// <param name="hexdata">The hex-encoded block data to submit.</param>
        /// <param name="dummy">Dummy value, for compatibility with BIP22. This value is ignored.</param>
        /// <returns></returns>
        public async Task<string> SubmitBlock(string hexdata, string dummy = null)
        {

            SubmitBlock submitBlock = new SubmitBlock() { HexData = hexdata, Dummy = dummy };
            string response = await httpRequest.SendReq(MethodName.submitblock, submitBlock);
            return response;
        }
        /// <summary>
        /// Decode the given hexdata as a header and submit it as a candidate chain tip if valid. Throws when the header is invalid.
        /// </summary>
        /// <param name="hexdata">The hex-encoded block header data.</param>
        /// <returns></returns>
        public async Task<string> SubmitHeader(string hexdata)
        {
            string response = await httpRequest.SendReq(MethodName.submitheader, hexdata);
            return response;
        }


    }

}
