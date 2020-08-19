using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Mining
{
    class GetNetworkHashPS
    { /**<summary>The number of blocks, or -1 for blocks since last difficulty change.</summary>**/
        public int NBlocks { get; set; } = 120;

        /**<summary>To estimate at the time of the given height.</summary>**/
        public int Height { get; set; } = -1;

        public GetNetworkHashPS(int nblocks = 120, int height = -1)
        {
            this.NBlocks = nblocks;
            this.Height = height;
        }
    }
}
