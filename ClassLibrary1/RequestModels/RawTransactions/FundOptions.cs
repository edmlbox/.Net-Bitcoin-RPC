
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    public class FundOptions
    { /**<summary>
         * The bitcoin address to receive the change.
         * </summary>**/
        public string ChangeAddress { get; set; }
        /**<summary>
         * The index of the change output.
         * </summary>**/
        public int? ChangePosition { get; set; }
        /**<summary>
        * The output type to use. Only valid if changeAddress is not specified. Options are "legacy", "p2sh-segwit", and "bech32".
        * </summary>**/
        public ChangeType? ChangeType { get; set; }
        /**<summary>
        * Also select inputs which are watch only.
        * </summary>**/
        public bool? IncludeWatching { get; set; }
        /**<summary>
        * Lock selected unspent outputs.
        * </summary>**/
        public bool? LockUnspents { get; set; }
        /**<summary>
        * Set a specific fee rate in BTC/kB.
        * </summary>**/
        private object FeeRate { get; set; }
        /**<summary>
        * Set a specific fee rate in BTC/kB.
        * </summary>**/

        /**<summary>
        * A json array of integers. The fee will be equally deducted from the amount of each specified output. The outputs are specified by their zero-based index, before any change output is added. Those recipients will receive less bitcoins than you enter in their corresponding amount field. If no outputs are specified here, the sender pays the fee.
        * </summary>**/
        public byte[]? SubtractFeeFromOutputs { get; set; }
        /**<summary>
        * Marks this transaction as BIP125 replaceable. Allows this transaction to be replaced by a transaction with higher fees.
        * </summary>**/
        public bool? Replaceable { get; set; }
        /**<summary>
        * Confirmation target (in blocks).
        * </summary>**/
        public int? ConfTarget { get; set; }
        /**<summary>
        * The fee estimate mode, must be one of: “UNSET”, “ECONOMICAL”, “CONSERVATIVE”
        * </summary>**/
        public FeeMode? EstimateMode { get; set; }

        public void SetFeeRate(string feeRate)
        {

            FeeRate = feeRate;
        }
        public void SetFeeRate(float feeRate)
        {

            FeeRate = feeRate;
        }

        public object GetFreeRate()
        {
            return FeeRate;
        }
    }
}
