
using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.Blockchain;
using BitcoinRpc.StaticStrings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinRpc.CoreRPC
{
    /// <summary>
    /// The main <seealso cref="Blockchain"/> class.
    /// Contains all methods for performing <seealso cref="Blockchain"/> operations.
    /// </summary>
    public class Blockchain
    {
        BitcoinClient bitcoinClient;
        HttpRequest httpRequest;



        public Blockchain(BitcoinClient bitcoinClient)
        {
            this.bitcoinClient = bitcoinClient;
            httpRequest = new HttpRequest(bitcoinClient);
        }



        /**<summary>Returns the hash of the best (tip) block in the most-work fully-validated chain.</summary>**/
        public async Task<string> GetBestBlockHash()
        {
            string response = await httpRequest.SendReq(MethodName.getbestblockhash);
            return response;
        }

        /**<summary>Returns an object containing various state info regarding blockchain processing.</summary>**/
        public async Task<string> GetbBlockchainInfo()
        {
            string response = await httpRequest.SendReq(MethodName.getblockchaininfo);
            return response;
        }

        /**<summary>Returns the height of the most-work fully-validated chain.
The genesis block has height 0.</summary>**/
        public async Task<string> GetBlockCount()
        {
            string response = await httpRequest.SendReq(MethodName.getblockcount);
            return response;
        }
        /**<summary>Retrieve a BIP 157 content filter for a particular block.</summary>**/
        /// See <see cref="GetBlock(string, Verbosity)"/>
        /// <param name="blockhash">The hash of the block.</param>
        /// <param name="filterType">The type name of the filter.</param>

        public async Task<string> GetBlockFilter(string blockhash, string filterType=null)
        {
            GetBlockFilter getBlockFilter = new GetBlockFilter() { Blockhash = blockhash, FilterType = filterType };
            string response = await httpRequest.SendReq(MethodName.getblockfilter, getBlockFilter);
            return response;
        }

        /**<summary>Return information about all known tips in the block tree, including the main chain as well as orphaned branches.</summary>**/
        public async Task<string> GetChainTips()
        {
            string response = await httpRequest.SendReq(MethodName.getchaintips);
            return response;
        }

        /**<summary>Returns the proof-of-work difficulty as a multiple of the minimum difficulty.</summary>**/
        
        public async Task<string> GetDifficulty()
        {
            string response = await httpRequest.SendReq(MethodName.getdifficulty);
            return response;
        }
        /**<summary>
          Returns statistics about the unspent transaction output set.
              </summary>
        <remarks>This call may take some time.</remarks>
         **/
        public async Task<string> GetTxOutSetInfo()
        {
            string response = await httpRequest.SendReq(MethodName.gettxoutsetinfo);
            return response;
        }
        /**<summary>Dumps the mempool to disk. It will fail until the previous dump is fully loaded.</summary>**/
        public async Task<string> SaveMemPool()
        {
            string response = await httpRequest.SendReq(MethodName.savemempool);
            return response;
        }
        /**<summary>
          Return information about block.
          </summary>**/
        /// See <see cref="GetBlock(string, Verbosity)"/>
        /// <param name="blockhash">The block hash.</param>
        /// <param name="verbosity">"VerbosityZero" for hex-encoded data, "VerbosityOne" for a json object, and "VerbosityTwo" for json object with transaction data.</param>
        public async Task<string> GetBlock(string blockhash, Verbosity verbosity = Verbosity.VerbosityOne)
        {

            GetBlock getBlock = new GetBlock { Blockhash = blockhash, Verbosity = verbosity };

            string response = await httpRequest.SendReq(MethodName.getblock, getBlock);
            return response;

        }
        /**<summary>Returns hash of block in best-block-chain at height provided.</summary>**/
        /// <param name="height">The height index.</param>


        public async Task<string> GetBlockHash(int height)
        {
            string response = await httpRequest.SendReq(MethodName.getblockhash, height);
            return response;
        }
        /**<summary>Returns an Object with information about blockheader or hex-encoded data for blockheader hash</summary>**/
        ///<param name="blockhash">The block hash</param>
        ///<param name="blockHeaderVerbosity">Return format <c>Json</c> or <c>Hex</c></param>
        public async Task<string> GetBlockHeader(string blockhash, BlockHeaderVerbosity blockHeaderVerbosity = BlockHeaderVerbosity.Json)
        {
            GetBlockHeader getBlockHeader = new GetBlockHeader() { Blockhash = blockhash, BlockHeaderVerbosity = blockHeaderVerbosity };
            string response = await httpRequest.SendReq(MethodName.getblockheader, getBlockHeader);
            return response;
        }


        /**<summary>Compute per block statistics for a given window. All amounts are in satoshis.
            It won't work for some heights with pruning.</summary>**/
        ///<param name="blockhash">The block hash of the target block.</param>
        ///<param name="filterBlockStats">Values to plot.</param>
        public async Task<string> GetBlockStats(string blockhash, List<BlockStatsFilter> filterBlockStats = null)
        {
            GetBlockStats getBlockStats = new GetBlockStats
            {
                BlockHash = blockhash,
                BlockStatsFilter = filterBlockStats
            };

            string response = await httpRequest.SendReq(MethodName.getblockstats, getBlockStats);
            return response;
        }

        /**<summary>Compute per block statistics for a given window. All amounts are in satoshis.
            It won't work for some heights with pruning.</summary>**/
        ///<param name="height">The Height of the target block.</param>
        ///<param name="filterBlockStats">Values to plot.</param>
        public async Task<string> GetBlockStats(int height, List<BlockStatsFilter> filterBlockStats = null)
        {
            GetBlockStats getBlockStats = new GetBlockStats
            {
                Height = height,
                BlockStatsFilter = filterBlockStats
            };

            string response = await httpRequest.SendReq(MethodName.getblockstats, getBlockStats);
            return response;
        }
        /*End GetBlockStats*/


        /**<summary>Compute statistics about the total number and rate of transactions in the chain.</summary>**/
        public async Task<string> GetChainTxStats()
        {
            string response = await httpRequest.SendReq(MethodName.getchaintxstats);
            return response;
        }

        /**<summary>Compute statistics about the total number and rate of transactions in the chain.</summary>**/
        ///<param name="nblocks">Size of the window in number of blocks.</param>
        ///<param name="finalBlockhash">The hash of the block that ends the window.</param>
        public async Task<string> GetChainTxStats(int nblocks, string finalBlockhash = "optional, default=chain tip")
        {
            GetChainTxStats getChainTxStats = new GetChainTxStats() { NBlocks = nblocks, FinalBlockhash = finalBlockhash };
            string response = await httpRequest.SendReq(MethodName.getchaintxstats, getChainTxStats);
            return response;
        }

        /**<summary>If txid is in the mempool, returns all in-mempool ancestors.</summary>**/
        ///<param name="txid">The transaction id (must be in mempool).</param>
        ///<param name="returnFormat">"Json" or "Array of transaction ids".</param>
        public async Task<string> GetMemPoolAncestors(string txid, ReturnFormat returnFormat = ReturnFormat.JSON)
        {
            GetMemPool memPoolAncestors = new GetMemPool { ReturnFormat = returnFormat, Txid = txid };

            string response = await httpRequest.SendReq(MethodName.getmempoolancestors, memPoolAncestors);
            return response;
        }
        /**<summary>If txid is in the mempool, returns all in-mempool descendants.</summary>**/
        ///<param name="txid">The transaction id (must be in mempool).</param>
        ///<param name="returnFormat">"Json" or "Array of transaction ids".</param>
        public async Task<string> GetMemPoolDescendants(string txid, ReturnFormat returnFormat = ReturnFormat.JSON)
        {
            GetMemPool memPoolAncestors = new GetMemPool { ReturnFormat = returnFormat, Txid = txid };

            string response = await httpRequest.SendReq(MethodName.getmempooldescendants, memPoolAncestors);
            return response;
        }
        /**<summary>Returns mempool data for given transaction</summary>**/
        ///<param name="txid">The transaction id (must be in mempool).</param>
        public async Task<string> GetMemPoolEntry(string txid)
        {
            GetMemPool memPoolAncestors = new GetMemPool { Txid = txid };

            string response = await httpRequest.SendReq(MethodName.getmempoolentry, memPoolAncestors);
            return response;
        }
        /**<summary>Returns details on the active state of the TX memory pool.</summary>**/
        public async Task<string> GetMemPoolInfo()
        {
            string response = await httpRequest.SendReq(MethodName.getmempoolinfo);
            return response;
        }
        /**<summary>Returns all transaction ids in memory pool as a json array of string transaction ids.</summary>**/
        ///<param name="returnFormat">"Json" or "Array of transaction ids".</param>
        public async Task<string> GetRawMempool(ReturnFormat returnFormat = ReturnFormat.JSON)
        {
            GetMemPool getMemPool = new GetMemPool { ReturnFormat = returnFormat };
            string response = await httpRequest.SendReq(MethodName.getrawmempool, getMemPool);
            return response;
        }
        /**<summary>Returns details about an unspent transaction output.</summary>**/
        ///<param name="txid">The transaction id.</param>
        ///<param name="voutNumber">Vout number.</param>
        ///<param name="includeTheMemPool">Whether to include the mempool. Note that an unspent output that is spent in the mempool won't appear.</param>
        public async Task<string> GetTxOut(string txid, int voutNumber, bool includeTheMemPool = true)
        {
            GetTxOut getTxOut = new GetTxOut { Txid = txid, VoutNumber = voutNumber, IncludeTheMemPool = includeTheMemPool };
            string response = await httpRequest.SendReq(MethodName.gettxout, getTxOut);
            return response;
        }

        /**<summary>Returns details about an unspent transaction output.
          </summary>
         <remarks>NOTE: By default this function only works sometimes.This is when there is an
            unspent output in the utxo for this transaction.To make it always work,
            you need to maintain a transaction index, using the -txindex command line option or
            specify the block in which the transaction is included manually(by blockhash).</remarks>**/
        ///<param name="txids">The txids to filter. Transaction hash list.</param>
        public async Task<string> GetTxOutProof(List<string> txids)
        {
            GetTxOutProof txOutProof = new GetTxOutProof { ArrayOfTxids = txids };
            string response = await httpRequest.SendReq(MethodName.gettxoutproof, txOutProof);
            return response;
        }
        /**<summary>Returns a hex-encoded proof that "txid" was included in a block.
            </summary>
         <remarks>NOTE: By default this function only works sometimes.This is when there is an
            unspent output in the utxo for this transaction.To make it always work,
            you need to maintain a transaction index, using the -txindex command line option or
            specify the block in which the transaction is included manually(by blockhash).</remarks>**/
        
        ///<param name="txids">The txids to filter. Transaction hash list.</param>
        ///<param name="blockhash">If specified, looks for txid in the block with this hash.</param>
        public async Task<string> GetTxOutProof(List<string> txids, string blockhash)
        {
            GetTxOutProof txOutProof = new GetTxOutProof { ArrayOfTxids = txids, Blockhash = blockhash };
            string response = await httpRequest.SendReq(MethodName.gettxoutproof, txOutProof);
            return response;
        }
        /**<summary>Treats a block as if it were received before others with the same work.
         </summary>
            <remarks> A later preciousblock call can override the effect of an earlier one.
            The effects of preciousblock are not retained across restarts.</remarks>**/
        ///<param name="blockhash">The hash of the block to mark as precious.</param>
        public async Task<string> PreciousBlock(string blockhash)
        {

            string response = await httpRequest.SendReq(MethodName.preciousblock, blockhash);
            return response;
        }
        /**<summary>Prune blockchain to a specific height</summary>**/
        ///<param name="height">The block height to prune up to. May be set to a discrete height.</param>
        public async Task<string> PruneBlockchain(int height)
        {
            PruneBlockChain pruneBlockChain = new PruneBlockChain { Height = height };
            string response = await httpRequest.SendReq(MethodName.pruneblockchain, pruneBlockChain);
            return response;
        }
        /**<summary>Prune blockchain to a UNIX epoch time,
             to prune blocks whose block time is at least 2 hours older than the provided timestamp.</summary>**/
        ///<param name="unixTimestamp">A UNIX epoch time</param>
       
        public async Task<string> PruneBlockchain(long unixTimestamp)
        {
            PruneBlockChain pruneBlockChain = new PruneBlockChain { UnixTimestamp = unixTimestamp };
            string response = await httpRequest.SendReq(MethodName.pruneblockchain, pruneBlockChain);
            return response;
        }

        //EXPERIMENTAL warning: this call may be removed or changed in future releases.
        /**<summary>Scans the unspent transaction output set for entries that match certain output descriptors.</summary>**/
        ///<param name="scan">The action to execute "start" for starting a scan "abort" for aborting the current scan (returns true when abort was successful), "status" for progress report (in %) of the current scan.</param>
        ///<param name="scanTxOutSet">Array of scan objects. Required for "start" action.</param>
        public async Task<string> ScanTxOutSet(Scan scan, ScanTxOutSet scanTxOutSet)
        {

            string response = await httpRequest.SendReq(MethodName.scantxoutset, scanTxOutSet);
            return response;
        }

        /**<summary>Verifies blockchain database.</summary>
          See <see cref="Verifychain(int, int)"/> to add integers.
         <param name="checklevel">How thorough the block verification is. Range = 0-4.</param>
         <param name="nblocks">The number of blocks to check. Set to "0" to check all.</param>**/
        public async Task<string> Verifychain(int checklevel = 3, int nblocks = 6)
        {

            Verifychain verifychain = new Verifychain { CheckLevel = checklevel, NBlocks = nblocks };
            string response = await httpRequest.SendReq(MethodName.verifychain, verifychain);
            return response;
        }



        /**<summary>
          Verifies that a proof points to a transaction in a block, returning the transaction it commits to
         and throwing an RPC error if the block is not in our best chain.   
        </summary>
        <param name = "hexProof" > The hex-encoded proof generated by "GetTxOutProof" method.</param>**/
        public async Task<string> VerifyTxOutProof(string hexProof)
        {


            string response = await httpRequest.SendReq(MethodName.verifytxoutproof, hexProof);
            return response;
        }





    }

}
