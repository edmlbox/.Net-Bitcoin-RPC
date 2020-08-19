using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Mining
{
    class PrioritiseTransaction
    {
        public string Txid { get; set; }

        /**<summary>
         * API-Compatibility for previous API. Must be zero or null.
            DEPRECATED. For forward compatibility use named arguments and omit this parameter
         * </summary>**/
        public int Dummy { get; set; }

        /**<summary>The fee value (in satoshis) to add (or subtract, if negative).
            Note, that this value is not a fee rate. It is a value to modify absolute fee of the TX. The fee is not actually paid, only the algorithm for selecting transactions into a block considers the transaction as it would have paid a higher (or lower) fee.</summary>**/
        public int FeeDelta { get; set; }

        public PrioritiseTransaction(string txid, int feeDelta, int dummy = 0)
        {
            this.Txid = txid;
            this.Dummy = dummy;
            this.FeeDelta = feeDelta;
        }
    }
}
