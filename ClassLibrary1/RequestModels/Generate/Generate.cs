using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Generate
{
    class Generate
    {
        public int NBlocks { get; set; }
        public int Maxtries { get; set; }
        public string Address { get; set; }
    }
}
