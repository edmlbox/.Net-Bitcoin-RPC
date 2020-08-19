
using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.Util;
using BitcoinRpc.StaticStrings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinRpc.CoreRPC
{


    /// <summary>
    /// The main <seealso cref="Util"/> class.
    /// Contains all methods for performing <seealso cref="Util"/> operations.
    /// </summary>
    public class Util
    {
        BitcoinClient bitcoinClient;
        HttpRequest httpRequest;
        public Util(BitcoinClient bitcoinClient)
        {
            this.bitcoinClient = bitcoinClient;
            httpRequest = new HttpRequest(bitcoinClient);
        }


        /// <summary>
        /// Creates a multi-signature address with n signature of m keys required.
        /// </summary>
        /// <param name="nRequired">The number of required signatures out of the n keys.</param>
        /// <param name="publicKeys">The hex-encoded public keys.</param>
        /// <returns></returns>
        public async Task<string> CreateMultisig(int nRequired, List<string> publicKeys)
        {
            CreateMultisig createMultisig = new CreateMultisig() { NRequired = nRequired, PublicKeys = publicKeys };
            string response = await httpRequest.SendReq(MethodName.createmultisig, createMultisig);
            return response;
        }


        /// <summary>
        ///  Creates a multi-signature address with n signature of m keys required.
        /// </summary>
        /// <param name="nRequired">The number of required signatures out of the n keys.</param>
        /// <param name="publicKeys">The hex-encoded public keys.</param>
        /// <param name="addressType">The address type to use. Options are "legacy", "p2sh-segwit", and "bech32".</param>
        /// <returns></returns>
        public async Task<string> CreateMultisig(int nRequired, List<string> publicKeys, AddressType addressType)
        {
            CreateMultisig createMultisig = new CreateMultisig() { NRequired = nRequired, PublicKeys = publicKeys, AddressType = addressType };
            string response = await httpRequest.SendReq(MethodName.createmultisig, createMultisig);
            return response;
        }


        /// <summary>
        /// Derives one or more addresses corresponding to an output descriptor.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <returns></returns>
        public async Task<string> DeriveAddresses(string descriptor)
        {
            DeriveAddresses deriveAddresses = new DeriveAddresses { Descriptor = descriptor };
            string response = await httpRequest.SendReq(MethodName.deriveaddresses, deriveAddresses);
            return response;
        }


        /// <summary>
        /// Derives one or more addresses corresponding to an output descriptor.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <param name="endRange">This specifies the end range.</param>
        /// <returns></returns>
        public async Task<string> DeriveAddresses(string descriptor, int endRange)
        {
            DeriveAddresses deriveAddresses = new DeriveAddresses { Descriptor = descriptor, EndRange = endRange };
            string response = await httpRequest.SendReq(MethodName.deriveaddresses, deriveAddresses);
            return response;
        }


        /// <summary>
        /// Derives one or more addresses corresponding to an output descriptor.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <param name="beginRange">This specifies "begin" range to derive.</param>
        /// <param name="endRange">This specifies "end" range to derive.</param>
        /// <returns></returns>
        public async Task<string> DeriveAddresses(string descriptor, int beginRange, int endRange)
        {
            DeriveAddresses deriveAddresses = new DeriveAddresses { Descriptor = descriptor, BeginRange = beginRange, EndRange = endRange };
            string response = await httpRequest.SendReq(MethodName.deriveaddresses, deriveAddresses);
            return response;
        }


        /// <summary>
        /// Estimates the approximate fee per kilobyte needed for a transaction to begin
        /// confirmation within conf_target blocks if possible and return the number of blocks
        /// for which the estimate is valid.
        /// </summary>
        /// <param name="confTarget">Confirmation target in blocks (1 - 1008).</param>
        /// <returns></returns>
        public async Task<string> EstimateSmartFee(int confTarget)
        {
            EstimateSmartFee estimateSmartFee = new EstimateSmartFee { ConfTarget = confTarget };
            string response = await httpRequest.SendReq(MethodName.estimatesmartfee, estimateSmartFee);
            return response;
        }


        /// <summary>
        /// Estimates the approximate fee per kilobyte needed for a transaction to begin
        /// confirmation within conf_target blocks if possible and return the number of blocks
        /// for which the estimate is valid.
        /// </summary>
        /// <param name="confTarget">Confirmation target in blocks (1 - 1008).</param>
        /// <param name="estimateMode">The fee estimate mode.</param>
        /// <returns></returns>
        public async Task<string> EstimateSmartFee(int confTarget, EstimateMode estimateMode)
        {
            EstimateSmartFee estimateSmartFee = new EstimateSmartFee { ConfTarget = confTarget, EstimateMode = estimateMode };
            string response = await httpRequest.SendReq(MethodName.estimatesmartfee, estimateSmartFee);
            return response;
        }


        /// <summary>
        /// Analyses a descriptor.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <returns></returns>
        public async Task<string> GetDescriptorInfo(string descriptor)
        {
            string response = await httpRequest.SendReq(MethodName.getdescriptorinfo, descriptor);
            return response;
        }


        /// <summary>
        /// Sign a message with the private key of an address.
        /// </summary>
        /// <param name="privKey">The private key to sign the message with.</param>
        /// <param name="message">The message to create a signature of.</param>
        /// <returns></returns>
        public async Task<string> SignMessageWithPrivKey(string privKey, string message)
        {
            SignMessageWithPrivKey signMessageWithPriv = new SignMessageWithPrivKey() { Privkey = privKey, Message = message };
            string response = await httpRequest.SendReq(MethodName.signmessagewithprivkey, signMessageWithPriv);
            return response;
        }


        /// <summary>
        /// Return information about the given bitcoin address.
        /// </summary>
        /// <param name="address">The bitcoin address to validate.</param>
        /// <returns></returns>
        public async Task<string> ValidateAddress(string address)
        {
            string response = await httpRequest.SendReq(MethodName.validateaddress, address);
            return response;
        }


        /// <summary>
        /// Verify a signed message.
        /// </summary>
        /// <param name="address">The bitcoin address to use for the signature.</param>
        /// <param name="signature">The signature provided by the signer in base 64 encoding (see signmessage).</param>
        /// <param name="message">The message that was signed.</param>
        /// <returns></returns>
        public async Task<string> VerifyMessage(string address, string signature, string message)
        {
            VerifyMessage verifyMessage = new VerifyMessage { Address = address, Signature = signature, Message = message };
            string response = await httpRequest.SendReq(MethodName.verifymessage, verifyMessage);
            return response;
        }


    }




}
