using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Generate
{
    class GenerateToDescriptor
    {
        public int NumBlocks { get; set; }
        public string Descriptor { get; set; }
        public int Maxtries { get; set; }
    }
}
