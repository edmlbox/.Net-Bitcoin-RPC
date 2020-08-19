using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
   public class OutputDescriptor
    {
        public string Desc { get; set; }
        public object Range;


        public OutputDescriptor(string desc)
        {
            this.Desc = desc;

        }
        public OutputDescriptor(string desc, int upTo)
        {
            this.Desc = desc;
            this.Range = upTo;
        }
        public OutputDescriptor(string desc, int begin, int end)
        {

            int[] rangeIndex = new int[] { begin, end };
            this.Desc = desc;
            this.Range = rangeIndex;
        }
    }
}
