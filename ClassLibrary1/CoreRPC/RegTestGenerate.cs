
using BitcoinRpc.RequestModels.Generate;
using BitcoinRpc.StaticStrings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinRpc.CoreRPC
{
    /// <summary>
    /// The main <seealso cref="RegTestGenerate"/> class.
    /// Contains all methods for performing <seealso cref="RawTransaction"/> operations.
    /// </summary>
    public class RegTestGenerate
    {
        BitcoinClient bitcoinClient;
        HttpRequest httpRequest;
        public RegTestGenerate(BitcoinClient bitcoinClient)
        {
            this.bitcoinClient = bitcoinClient;
            httpRequest = new HttpRequest(bitcoinClient);
        }

        //Works only in regtest.
        [Obsolete("Please use GenerateToAddress instead.")]
        public async Task<string> GenerateUpTo(int nblocks, int maxtries = 1000000)
        {
            Generate generate = new Generate { NBlocks = nblocks, Maxtries = maxtries };
            string response = await httpRequest.SendReq(MethodName.generate, generate);
            return response;
        }

        //Works only in regtest.
        /// <summary>
        /// Mine blocks immediately to a specified address (before the RPC call returns).
        /// </summary>
        /// <param name="nblocks">How many blocks are generated immediately.</param>
        /// <param name="address">The address to send the newly generated bitcoin to.</param>
        /// <param name="maxtries">How many iterations to try.</param>
        /// <returns></returns>
        public async Task<string> GenerateToAddress(int nblocks, string address, int maxtries = 1000000)
        {
            Generate generate = new Generate { NBlocks = nblocks, Maxtries = maxtries, Address = address };
            string response = await httpRequest.SendReq(MethodName.generatetoaddress, generate);
            return response;
        }
        /// <summary>
        /// Mine blocks immediately to a specified descriptor (before the RPC call returns).
        /// </summary>
        /// <param name="numBlocks">How many blocks are generated immediately.</param>
        /// <param name="descriptor">The descriptor to send the newly generated bitcoin to.</param>
        /// <param name="maxtries">How many iterations to try.</param>
        /// <returns></returns>
        public async Task<string> GenerateToDescriptor(int numBlocks, string descriptor, int maxtries = 1000000)
        {
            GenerateToDescriptor generateToDescriptor = new GenerateToDescriptor { NumBlocks = numBlocks, Descriptor = descriptor, Maxtries = maxtries };
            string response = await httpRequest.SendReq(MethodName.generatetodescriptor, generateToDescriptor);
            return response;
        }

    }

}
