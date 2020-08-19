using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.Mining;
using BitcoinRpc.RequestModels.Network;
using BitcoinRpc.RequestModels.RawTransactions;
using BitcoinRpc.StaticStrings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinRpc.CoreRPC
{
    /// <summary>
    /// The main <seealso cref="RawTransaction"/> class.
    /// Contains all methods for performing <seealso cref="RawTransaction"/> operations.
    /// </summary>
    public class RawTransaction
    {

        BitcoinClient bitcoinClient;
        HttpRequest httpRequest;
        public RawTransaction(BitcoinClient bitcoinClient)
        {
            this.bitcoinClient = bitcoinClient;
            httpRequest = new HttpRequest(bitcoinClient);
        }
        /// <summary>
        /// Analyzes and provides information about the current status of a PSBT and its inputs.
        /// </summary>
        /// <param name="PSBT">A base64 string of a PSBT.</param>
        /// <returns></returns>
        public async Task<string> AnalyzePSBT(string PSBT)
        {
            string response = await httpRequest.SendReq(MethodName.analyzepsbt, PSBT);
            return response;
        }/// <summary>
         /// Combine multiple partially signed Bitcoin transactions into one transaction.
         ///Implements the Combiner role.
         /// </summary>
         /// <param name="PSBT">The base64 strings of partially signed transactions.</param>
         /// <returns></returns>
        public async Task<string> CombinePSBT(string[] PSBT)
        {
            string response = await httpRequest.SendReq(MethodName.combinepsbt, PSBT);
            return response;
        }
        /// <summary>
        /// Combine multiple partially signed Bitcoin transactions into one transaction.
        ///Implements the Combiner role.
        /// </summary>
        /// <param name="PSBT">The base64 strings of partially signed transactions.</param>
        /// <returns></returns>
        public async Task<string> CombinePSBT(List<string> PSBT)
        {
            string response = await httpRequest.SendReq(MethodName.combinepsbt, PSBT);
            return response;
        }
        /// <summary>
        /// Combine multiple partially signed transactions into one transaction.
        ///The combined transaction may be another partially signed transaction or a
        ///fully signed transaction.
        /// </summary>
        /// <param name="PSBT">The hex strings of partially signed transactions.</param>
        /// <returns></returns>
        public async Task<string> CombineRawTransaction(List<string> PSBT)
        {
            string response = await httpRequest.SendReq(MethodName.combinerawtransaction, PSBT);
            return response;
        }
        /// <summary>
        /// Combine multiple partially signed transactions into one transaction.
        ///The combined transaction may be another partially signed transaction or a
        ///fully signed transaction.
        /// </summary>
        /// <param name="PSBT">The hex strings of partially signed transactions.</param>
        /// <returns></returns>
        public async Task<string> CombineRawTransaction(string[] PSBT)
        {
            string response = await httpRequest.SendReq(MethodName.combinerawtransaction, PSBT);
            return response;
        }
        /// <summary>
        /// Converts a network serialized transaction to a PSBT. This should be used only with createrawtransaction and fundrawtransaction
        /// createpsbt and walletcreatefundedpsbt should be used for new applications.
        /// </summary>
        /// <param name="hexString">The hex string of a raw transaction.</param>
        /// <returns></returns>
        public async Task<string> ConvertToPSBT(string hexString)
        {
            ConvertToPSBT convertToPSBT = new ConvertToPSBT { HexString = hexString };
            string response = await httpRequest.SendReq(MethodName.converttopsbt, convertToPSBT);
            return response;
        }
        /// <summary>
        /// Converts a network serialized transaction to a PSBT. This should be used only with createrawtransaction and fundrawtransaction
        ///createpsbt and walletcreatefundedpsbt should be used for new applications.
        /// </summary>
        /// <param name="hexString">The hex string of a raw transaction.</param>
        /// <param name="permitSigData">If true, any signatures in the input will be discarded and conversion
        /// will continue. If false, RPC will fail if any signatures are present.</param>
        /// <param name="iSWitness">Whether the transaction hex is a serialized witness transaction.</param>
        /// <returns></returns>
        public async Task<string> ConvertToPSBT(string hexString, bool permitSigData = false, bool iSWitness = false)
        {
            ConvertToPSBT convertToPSBT = new ConvertToPSBT { HexString = hexString, PermitSigData = permitSigData, IsWitness = iSWitness };
            string response = await httpRequest.SendReq(MethodName.converttopsbt, convertToPSBT);
            return response;
        }
        /// <summary>
        /// Creates a transaction in the Partially Signed Transaction format.
        /// Implements the Creator role.
        /// </summary>
        /// <param name="pSBTInputs">The json objects.</param>
        /// <param name="pSBTOutputs">The outputs (key-value pairs), where none of the keys are duplicated.
        ///That is, each address can only appear once</param>
        /// <param name="hexData">Hex-encoded data.</param>
        /// <returns></returns>
        public async Task<string> CreatePSBT(List<PSBTInput> pSBTInputs, List<PSBTOutput> pSBTOutputs, string hexData)
        {
            CreatePSBT createPSBT = new CreatePSBT() { PSBT_Inputs = pSBTInputs, PSBT_Outputs = pSBTOutputs, Data = hexData };

            string response = await httpRequest.SendReq(MethodName.createpsbt, createPSBT);
            return response;
        }



        /// <summary>
        /// Creates a transaction in the Partially Signed Transaction format.
        /// Implements the Creator role.
        /// </summary>
        /// <param name="pSBTInputs">The json objects.</param>
        /// <param name="pSBTOutputs">The outputs (key-value pairs), where none of the keys are duplicated.
        ///That is, each address can only appear once</param>
        /// <param name="hexData">Hex-encoded data.</param>
        /// <param name="locktime">Raw locktime. Non-0 value also locktime-activates inputs.</param>
        /// <param name="replaceable">Marks this transaction as BIP125 replaceable.
        ///Allows this transaction to be replaced by a transaction with higher fees. If provided, it is an error if explicit sequence numbers are incompatible.</param>
        /// <returns></returns>
      
        public async Task<string> CreatePSBT(List<PSBTInput> pSBTInputs, List<PSBTOutput> pSBTOutputs, string hexData, int locktime, bool replaceable)
        {
            CreatePSBT createPSBT = new CreatePSBT() { PSBT_Inputs = pSBTInputs, PSBT_Outputs = pSBTOutputs, Locktime = locktime, Replaceable = replaceable, Data = hexData };
            string response = await httpRequest.SendReq(MethodName.createpsbt, createPSBT);
            return response;
        }


        /// <summary>
        /// Create a transaction spending the given inputs and creating new outputs.
        /// </summary>
        /// <param name="rawInputs">The inputs.</param>
        /// <param name="rawOutputs">The outputs.</param>
        /// <param name="locktime">Raw locktime. Non-0 value also locktime-activates inputs.</param>
        /// <param name="replaceable">Marks this transaction as BIP125-replaceable.
        /// Allows this transaction to be replaced by a transaction with higher fees. If provided, it is an error if explicit sequence numbers are incompatible.</param>
        /// <returns></returns>
        public async Task<string> CreateRawTransaction(RawInputs rawInputs, RawOutputs rawOutputs, int locktime = 0, bool replaceable = false)
        {
            CreateRawTransaction createRawTransaction = new CreateRawTransaction()
            {
                RawInputs = rawInputs,
                RawOutputs = rawOutputs,
                Locktime = locktime,
                Replaceable = replaceable
            };

            string response = await httpRequest.SendReq(MethodName.createrawtransaction, createRawTransaction);
            return response;

        }
        /// <summary>
        /// Create a transaction with new outputs.
        /// </summary>
        /// <param name="rawOutputs">The outputs.</param>
        /// <param name="locktime">Raw locktime. Non-0 value also locktime-activates inputs.</param>
        /// <param name="replaceable">Marks this transaction as BIP125-replaceable.
        /// Allows this transaction to be replaced by a transaction with higher fees. If provided, it is an error if explicit sequence numbers are incompatible.</param>
        /// <returns></returns>

        public async Task<string> CreateRawTransaction(RawOutputs rawOutputs, int locktime = 0, bool replaceable = false)
        {
            CreateRawTransaction createRawTransaction = new CreateRawTransaction()
            {

                RawOutputs = rawOutputs,
                Locktime = locktime,
                Replaceable = replaceable
            };

            string response = await httpRequest.SendReq(MethodName.createrawtransaction, createRawTransaction);
            return response;

        }
        /// <summary>
        /// Create a transaction spending the given inputs.
        /// Returns hex-encoded raw transaction.
        /// Note that the transaction's inputs are not signed, and
        /// it is not stored in the wallet or transmitted to the network.
        /// </summary>
        /// <param name="rawInputs">The inputs.</param>
        /// <param name="locktime">Raw locktime. Non-0 value also locktime-activates inputs.</param>
        /// <param name="replaceable">Marks this transaction as BIP125-replaceable.
       /// Allows this transaction to be replaced by a transaction with higher fees. If provided, it is an error if explicit sequence numbers are incompatible.</param>
        /// <returns></returns>
        public async Task<string> CreateRawTransaction(RawInputs rawInputs, int locktime = 0, bool replaceable = false)
        {
            CreateRawTransaction createRawTransaction = new CreateRawTransaction()
            {

                RawInputs = rawInputs,
                Locktime = locktime,
                Replaceable = replaceable
            };

            string response = await httpRequest.SendReq(MethodName.createrawtransaction, createRawTransaction);
            return response;

        }
        /// <summary>
        /// Return a JSON object representing the serialized, base64-encoded partially signed Bitcoin transaction.
        /// </summary>
        /// <param name="psbt">The PSBT base64 string.</param>
        /// <returns></returns>
        public async Task<string> DecodePSBT(string psbt)
        {
            string response = await httpRequest.SendReq(MethodName.decodepsbt, psbt);
            return response;
        }
        /// <summary>
        /// Return a JSON object representing the serialized, hex-encoded transaction.
        /// </summary>
        /// <param name="hexString">The transaction hex string.</param>
        /// <returns></returns>
        public async Task<string> DecodeRawTransaction(string hexString)
        {
            DecodeRawTransaction decodeRawTransaction = new DecodeRawTransaction { HexString = hexString };

            string response = await httpRequest.SendReq(MethodName.decoderawtransaction, decodeRawTransaction);
            return response;


        }
        /// <summary>
        /// Return a JSON object representing the serialized, hex-encoded transaction.
        /// </summary>
        /// <param name="hexString">The transaction hex string.</param>
        /// <param name="isWitness">Whether the transaction hex is a serialized witness transaction.</param>
        /// <returns></returns>
        public async Task<string> DecodeRawTransaction(string hexString, bool isWitness)
        {
            DecodeRawTransaction decodeRawTransaction = new DecodeRawTransaction { HexString = hexString, IsWitness = isWitness };
            string response = await httpRequest.SendReq(MethodName.decoderawtransaction, decodeRawTransaction);
            return response;
        }
        /// <summary>
        /// Decode a hex-encoded script.
        /// </summary>
        /// <param name="hexString">The hex-encoded script.</param>
        /// <returns></returns>
        public async Task<string> DecodeScript(string hexString)
        {
            string response = await httpRequest.SendReq(MethodName.decodescript, hexString);
            return response;

        }
        /// <summary>
        /// Finalize the inputs of a PSBT.
        /// </summary>
        /// <param name="psbt">A base64 string of a PSBT.</param>
        /// <returns></returns>
        public async Task<string> FinalizePSBT(string psbt)
        {
            FinalizePSBT finalizePSBT = new FinalizePSBT { PSBT = psbt };
            string response = await httpRequest.SendReq(MethodName.finalizepsbt, finalizePSBT);
            return response;

        }
        /// <summary>
        /// Finalize the inputs of a PSBT.
        /// </summary>
        /// <param name="psbt">A base64 string of a PSBT.</param>
        /// <param name="extract">If true and the transaction is complete,
        ///extract and return the complete transaction in normal network serialization instead of the PSBT.</param>
        /// <returns></returns>
        public async Task<string> FinalizePSBT(string psbt, bool extract)
        {
            FinalizePSBT finalizePSBT = new FinalizePSBT { PSBT = psbt, Extract = extract };
            string response = await httpRequest.SendReq(MethodName.finalizepsbt, finalizePSBT);
            return response;

        }
        /// <summary>
        /// Add inputs to a transaction until it has enough in value to meet its out value.
        /// </summary>
        /// <param name="hexString">he hex string of the raw transaction.</param>
        /// <returns></returns>
        public async Task<string> FundRawTransaction(string hexString)
        {
            FundRawTransaction fundRawTransaction = new FundRawTransaction { HexString = hexString };
            string response = await httpRequest.SendReq(MethodName.fundrawtransaction, fundRawTransaction);
            return response;
        }
        /// <summary>
        /// Add inputs to a transaction until it has enough in value to meet its out value.
        /// </summary>
        /// <param name="hexString">he hex string of the raw transaction.</param>
        /// <param name="options">Founding options</param>
        /// <returns></returns>
        public async Task<string> FundRawTransaction(string hexString, FundOptions options)
        {
            FundRawTransaction fundRawTransaction = new FundRawTransaction { HexString = hexString, FundOptions = options };
            string response = await httpRequest.SendReq(MethodName.fundrawtransaction, fundRawTransaction);
            return response;
        }
        /// <summary>
        /// Add inputs to a transaction until it has enough in value to meet its out value.
        /// </summary>
        /// <param name="hexString">he hex string of the raw transaction.</param>
        /// <param name="options">Founding options</param>
        /// <param name="isWitness">Whether the transaction hex is a serialized witness transaction.</param>
        /// <returns></returns>
        public async Task<string> FundRawTransaction(string hexString, FundOptions options, bool isWitness)
        {
            FundRawTransaction fundRawTransaction = new FundRawTransaction { HexString = hexString, FundOptions = options, IsWitness = isWitness };
            string response = await httpRequest.SendReq(MethodName.fundrawtransaction, fundRawTransaction);
            return response;
        }
        /// <summary>
        /// Return the raw transaction data.
        /// </summary>
        /// <param name="txid">The transaction id.</param>
        /// <returns></returns>
        public async Task<string> GetRawTransaction(string txid)
        {
            GetRawTransaction getRawTransaction = new GetRawTransaction { Txid = txid };
            string response = await httpRequest.SendReq(MethodName.getrawtransaction, getRawTransaction);
            return response;
        }
        /// <summary>
        /// Return the raw transaction data.
        /// </summary>
        /// <param name="txid">The transaction id.</param>
        /// <param name="returnType">Return format <c>Json</c> or <c>String</c></param>
        /// <returns></returns>
        public async Task<string> GetRawTransaction(string txid, TXReturnType returnType)
        {
            GetRawTransaction getRawTransaction = new GetRawTransaction { Txid = txid, ReturnType = returnType };
            string response = await httpRequest.SendReq(MethodName.getrawtransaction, getRawTransaction);
            return response;
        }
        /// <summary>
        /// Return the raw transaction data.
        /// </summary>
        /// <param name="txid">The transaction id.</param>
        /// <param name="returnType">Return format <c>Json</c> or <c>String</c></param>
        /// <param name="blockhash">The block in which to look for the transaction.</param>
        /// <returns></returns>
        public async Task<string> GetRawTransaction(string txid, TXReturnType returnType, string blockhash)
        {
            GetRawTransaction getRawTransaction = new GetRawTransaction { Txid = txid, ReturnType = returnType, Blockhash = blockhash };
            string response = await httpRequest.SendReq(MethodName.getrawtransaction, getRawTransaction);
            return response;
        }
        /// <summary>
        /// Joins multiple distinct PSBTs with different inputs and outputs into one PSBT with inputs and outputs from all of the PSBTs
        ///No input in any of the PSBTs can be in more than one of the PSBTs.
        /// </summary>
        /// <param name="txs">The base64 strings of partially signed transactions.</param>
        /// <returns></returns>
        public async Task<string> JoinPSBTS(string[] txs)
        {

            string response = await httpRequest.SendReq(MethodName.joinpsbts, txs);
            return response;
        }
        /// <summary>
        /// Joins multiple distinct PSBTs with different inputs and outputs into one PSBT with inputs and outputs from all of the PSBTs
        /// No input in any of the PSBTs can be in more than one of the PSBTs.
        /// </summary>
        /// <param name="txs">The base64 strings of partially signed transactions.</param>
        /// <returns></returns>
        public async Task<string> JoinPSBTS(List<string> txs)
        {
            string response = await httpRequest.SendReq(MethodName.joinpsbts, txs);
            return response;
        }

        #region SendRawTransaction
        /// <summary>
        /// Submit a raw transaction (serialized, hex-encoded) to local node and network.
        /// </summary>
        /// <param name="hexString">The hex string of the raw transaction.</param>
        /// <returns></returns>
        public async Task<string> SendRawTransaction(string hexString)
        {
            SendRawTransaction sendRawTransaction = new SendRawTransaction()
            {
                HexString = hexString,
            };

            string response = await httpRequest.SendReq(MethodName.sendrawtransaction, sendRawTransaction);
            return response;
        }


        /**<summary>"allowHighFees" is deprecated from Bitcoin Core version 0.19.0.1</summary>**/

        /// <summary>
        /// Submit a raw transaction (serialized, hex-encoded) to local node and network.
        /// </summary>
        /// <param name="hexString">The hex string of the raw transaction.</param>
        
        [Obsolete("allowHighFees is deprecated from Bitcoin Core version 0.19.0.1")]
        public async Task<string> SendRawTransaction(string hexString, bool allowHighFees)
        {
            SendRawTransaction sendRawTransaction = new SendRawTransaction()
            {
                HexString = hexString,
                AllowHighFees = allowHighFees
            };

            string response = await httpRequest.SendReq(MethodName.sendrawtransaction, sendRawTransaction);
            return response;
        }
        /// <summary>
        ///  Submit a raw transaction (serialized, hex-encoded) to local node and network.
        /// </summary>
        /// <param name="hexString">The hex string of the raw transaction.</param>
        /// <param name="maxFeeRate">Reject transactions whose fee rate is higher than the specified value, expressed in BTC/kB.
        ///Set to 0 to accept any fee rate.</param>
        /// <returns></returns>
        public async Task<string> SendRawTransaction(string hexString, float maxFeeRate)
        {
            SendRawTransaction sendRawTransaction = new SendRawTransaction()
            {
                HexString = hexString,
                MaxFeeRate = maxFeeRate
            };

            string response = await httpRequest.SendReq(MethodName.sendrawtransaction, sendRawTransaction);
            return response;
        }
        #endregion
        #region SignRawTransactionWithKey overloads
        /// <summary>
        /// Sign inputs for raw transaction (serialized, hex-encoded).
        /// </summary>
        /// <param name="hexstring">The transaction hex string.</param>
        /// <param name="privkeys">The base58-encoded private keys for signing.</param>
        /// <returns></returns>
        public async Task<string> SignRawTransactionWithKey(string hexstring, List<string> privkeys)
        {
            SignRawTransactionWithKey signRawTransactionWithKey = new SignRawTransactionWithKey()
            {
                Hexstring = hexstring,
                PrivKeys = privkeys
            };

            string response = await httpRequest.SendReq(MethodName.signrawtransactionwithkey, signRawTransactionWithKey);
            return response;
        }
        /// <summary>
        /// Sign inputs for raw transaction (serialized, hex-encoded).
        /// </summary>
        /// <param name="hexstring">The transaction hex string.</param>
        /// <param name="privkeys">The base58-encoded private keys for signing.</param>
        /// <param name="prevTxs">The previous dependent transaction outputs.</param>
        /// <returns></returns>
        public async Task<string> SignRawTransactionWithKey(string hexstring, List<string> privkeys, List<PrevTxs> prevTxs)
        {
            SignRawTransactionWithKey signRawTransactionWithKey = new SignRawTransactionWithKey()
            {
                Hexstring = hexstring,
                PrivKeys = privkeys,
                PrevTxs = prevTxs
            };

            string response = await httpRequest.SendReq(MethodName.signrawtransactionwithkey, signRawTransactionWithKey);
            return response;
        }
        /// <summary>
        /// Sign inputs for raw transaction (serialized, hex-encoded).
        /// </summary>
        /// <param name="hexstring">The transaction hex string.</param>
        /// <param name="privkeys">The base58-encoded private keys for signing.</param>
        /// <param name="prevTxs">The previous dependent transaction outputs.</param>
        /// <param name="sigHashType">The signature hash type.</param>
        /// <returns></returns>
        public async Task<string> SignRawTransactionWithKey(string hexstring, List<string> privkeys, List<PrevTxs> prevTxs, SigHashType sigHashType)
        {
            SignRawTransactionWithKey signRawTransactionWithKey = new SignRawTransactionWithKey()
            {
                Hexstring = hexstring,
                PrivKeys = privkeys,
                PrevTxs = prevTxs,
                HashType = sigHashType
            };

            string response = await httpRequest.SendReq(MethodName.signrawtransactionwithkey, signRawTransactionWithKey);
            return response;
        }
        #endregion



        #region TestMemPoolAccept
        /// <summary>
        /// Returns result of mempool acceptance tests indicating if raw transaction (serialized, hex-encoded) would be accepted by mempool.
        /// </summary>
        /// <param name="rawTx">A hex string of raw transaction.</param>
        /// <returns></returns>
        public async Task<string> TestMemPoolAccept(string rawTx)
        {
            TestMemPoolAccept testMemPoolAccept = new TestMemPoolAccept() { RawTx = rawTx };
            string response = await httpRequest.SendReq(MethodName.testmempoolaccept, testMemPoolAccept);
            return response;
        }
        /// <summary>
        /// Returns result of mempool acceptance tests indicating if raw transaction (serialized, hex-encoded) would be accepted by mempool.
        /// </summary>
        /// <param name="rawTx">A hex string of raw transaction.</param>
        /// <param name="maxFeeRate">Reject transactions whose fee rate is higher than the specified value, expressed in BTC/kB.</param>
        /// <returns></returns>
        public async Task<string> TestMemPoolAccept(string rawTx, float maxFeeRate)
        {
            TestMemPoolAccept testMemPoolAccept = new TestMemPoolAccept() { RawTx = rawTx, MaxFeeRate = maxFeeRate };
            string response = await httpRequest.SendReq(MethodName.testmempoolaccept, testMemPoolAccept);
            return response;
        }
        /// <summary>
        /// Returns result of mempool acceptance tests indicating if raw transaction (serialized, hex-encoded) would be accepted by mempool.
        /// </summary>
        /// <param name="rawTx">A hex string of raw transaction.</param>
        /// <param name="maxFeeRate">Reject transactions whose fee rate is higher than the specified value, expressed in BTC/kB.</param>
        /// <returns></returns>
        public async Task<string> TestMemPoolAccept(string rawTx, string maxFeeRate)
        {
            TestMemPoolAccept testMemPoolAccept = new TestMemPoolAccept() { RawTx = rawTx, MaxFeeRate = maxFeeRate };
            string response = await httpRequest.SendReq(MethodName.testmempoolaccept, testMemPoolAccept);
            return response;
        }
        /// <summary>
        /// Returns result of mempool acceptance tests indicating if raw transaction (serialized, hex-encoded) would be accepted by mempool.
        /// </summary>
        /// <param name="rawTxs">An array of hex strings of raw transactions.</param>
        /// <returns></returns>
        public async Task<string> TestMemPoolAccept(List<string> rawTxs)
        {
            TestMemPoolAccept testMemPoolAccept = new TestMemPoolAccept() { RawTxs = rawTxs };
            string response = await httpRequest.SendReq(MethodName.testmempoolaccept, testMemPoolAccept);
            return response;
        }
        /// <summary>
        /// Returns result of mempool acceptance tests indicating if raw transaction (serialized, hex-encoded) would be accepted by mempool.
        /// </summary>
        /// <param name="rawTxs">An array of hex strings of raw transactions.</param>
        /// <param name="maxFeeRate">Reject transactions whose fee rate is higher than the specified value, expressed in BTC/kB.</param>
        /// <returns></returns>
        public async Task<string> TestMemPoolAccept(List<string> rawTxs, float maxFeeRate)
        {
            TestMemPoolAccept testMemPoolAccept = new TestMemPoolAccept() { RawTxs = rawTxs, MaxFeeRate = maxFeeRate };
            string response = await httpRequest.SendReq(MethodName.testmempoolaccept, testMemPoolAccept);
            return response;
        }
        /// <summary>
        /// Returns result of mempool acceptance tests indicating if raw transaction (serialized, hex-encoded) would be accepted by mempool.
        /// </summary>
        /// <param name="rawTxs">An array of hex strings of raw transactions.</param>
        /// <param name="maxFeeRate">Reject transactions whose fee rate is higher than the specified value, expressed in BTC/kB</param>
        /// <returns></returns>
        public async Task<string> TestMemPoolAccept(List<string> rawTxs, string maxFeeRate)
        {
            TestMemPoolAccept testMemPoolAccept = new TestMemPoolAccept() { RawTxs = rawTxs, MaxFeeRate = maxFeeRate };
            string response = await httpRequest.SendReq(MethodName.testmempoolaccept, testMemPoolAccept);
            return response;
        }
        #endregion
        /// <summary>
        /// Updates all segwit inputs and outputs in a PSBT with data from output descriptors, the UTXO set or the mempool.
        /// </summary>
        /// <param name="psbt">A base64 string of a PSBT.</param>
        /// <returns></returns>
        public async Task<string> UtxoUpdatePSBT(string psbt)
        {
            UtxoUpdatePSBT utxoUpdatePSBT = new UtxoUpdatePSBT { PSBT = psbt };
            string response = await httpRequest.SendReq(MethodName.utxoupdatepsbt, utxoUpdatePSBT);
            return response;
        }
        /// <summary>
        /// Updates all segwit inputs and outputs in a PSBT with data from output descriptors, the UTXO set or the mempool.
        /// </summary>
        /// <param name="psbt">A base64 string of a PSBT.</param>
        /// <param name="outputDescriptors">A list of an output descriptor</param>
        /// <returns></returns>
        public async Task<string> UtxoUpdatePSBT(string psbt, List<string> outputDescriptors)
        {
            UtxoUpdatePSBT utxoUpdatePSBT = new UtxoUpdatePSBT { PSBT = psbt, OutputDescriptors = outputDescriptors };
            string response = await httpRequest.SendReq(MethodName.utxoupdatepsbt, utxoUpdatePSBT);
            return response;
        }
        /// <summary>
        /// Updates all segwit inputs and outputs in a PSBT with data from output descriptors, the UTXO set or the mempool.
        /// </summary>
        /// <param name="psbt">A base64 string of a PSBT.</param>
        /// <param name="outputDescriptors">An array of <c>OutputDescriptor</c> objects.</param>
        /// <returns></returns>
        public async Task<string> UtxoUpdatePSBT(string psbt, List<OutputDescriptor> outputDescriptors)
        {
            UtxoUpdatePSBT utxoUpdatePSBT = new UtxoUpdatePSBT { PSBT = psbt, OutputDescriptorsWithExtra = outputDescriptors };
            string response = await httpRequest.SendReq(MethodName.utxoupdatepsbt, utxoUpdatePSBT);
            return response;
        }



    }

}
