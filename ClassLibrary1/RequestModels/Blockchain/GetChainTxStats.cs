using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class GetChainTxStats
    { //Size of the window in number of blocks
        public int NBlocks { get; set; }

        //The hash of the block that ends the window.
        public string FinalBlockhash { get; set; }
    }
}
