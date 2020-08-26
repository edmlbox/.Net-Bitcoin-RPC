# .Net-Bitcoin-RPC

### Bitcoin Core RPC library for .Net. All commands are covered with examples.

Table of contents
=================
   
<!--ts-->
   * [Installation](#installation)
   * [Usage](#usage)
   * Core RPC
      * [BLOCKCHAIN](#BLOCKCHAIN)
      * [CONTROL](#CONTROL)
      * [GENERATING](#GENERATING)
      * [MINING](#MINING)
      * [NETWORK](#NETWORK)
      * [RAWTRANSACTIONS](#RAWTRANSACTIONS)
      * [UTIL](#UTIL)
      * [WALLET](#WALLET)
      * [ZMQ](#ZMQ)
  
   * [Dependency](#dependency)
<!--te-->

INSTALLATION
-----

### NuGet Package Manager
In **Solution Explorer**, right-click on your project and choose **Manage NuGet Packages**.
Select the **Browse tab**, search for [BitcoinRPC](https://www.nuget.org/packages/BitcoinRPC/), select that package in the list, and select **Install**.

### Package Manager Console
1. Select the **Tools > NuGet Package Manager > Package Manager Console** menu command.
1. Once the console opens, check that the **Default project drop-down list** shows the project into which you want to install the package. If you have a single project in the solution, it is already selected.
1. Type the next command: **Install-Package BitcoinRPC**



USAGE
-----
### Add types to the namespace:
```csharp    
using BitcoinRpc;
using BitcoinRpc.CoreRPC;
```

### Connect to a node and send a command:
```csharp
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");

Blockchain blockchain = new Blockchain(bitcoinClient);

string getbBlockchainInfo = await blockchain.GetbBlockchainInfo();

Console.WriteLine(getbBlockchainInfo);
```
<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "chain": "main",
    "blocks": 645397,
    "headers": 645397,
    "bestblockhash": "000000000000000000066375ede5da171433cb80cf68661eaa71123a55799e3f",
    "difficulty": 17557993035167.3,
    "mediantime": 1598427110,
    "verificationprogress": 0.9999997177461921,
    "initialblockdownload": false,
    "chainwork": "000000000000000000000000000000000000000012cc279e8fda2b1e12bf7fc4",
    "size_on_disk": 581074555,
    "pruned": true,
    "pruneheight": 644983,
    "automatic_pruning": true,
    "prune_target_size": 629145600,
    "softforks": {
      "bip34": {
        "type": "buried",
        "active": true,
        "height": 227931
      },
      "bip66": {
        "type": "buried",
        "active": true,
        "height": 363725
      },
      "bip65": {
        "type": "buried",
        "active": true,
        "height": 388381
      },
      "csv": {
        "type": "buried",
        "active": true,
        "height": 419328
      },
      "segwit": {
        "type": "buried",
        "active": true,
        "height": 481824
      }
    },
    "warnings": ""
  },
  "error": null,
  "id": null
}
```
</details>


#### Below you can find all BitcoinRPC commands with examples.

BLOCKCHAIN
-----

**[getbestblockhash](#getbestblockhash),** **[getblock](#getblock)**, **[getblockchaininfo](#getblockchaininfo)**, **[getblockcount](#getblockcount)**, **[getblockhash](#getblockhash)**,  **[getblockheader](#getblockheader)**,  **[getblockstats](#getblockstats)**,  **[getchaintips](#getchaintips)**,  **[getchaintxstats](#getchaintxstats)**,  **[getdifficulty](#getdifficulty)**,  **[getmempoolancestors](#getmempoolancestors)**,  **[getmempooldescendants](#getmempooldescendants)**,  **[getmempoolentry](#getmempoolentry)**,  **[getmempoolinfo](#getmempoolinfo)**, **[getrawmempool](#getrawmempool)**, **[gettxout](#gettxout)**, **[gettxoutproof](#gettxoutproof)**, **[gettxoutsetinfo](#gettxoutsetinfo)**, **[preciousblock](#preciousblock)**, **[pruneblockchain](#pruneblockchain)**, **[savemempool](#savemempool)**, **[scantxoutset](#scantxoutset)**, **[verifychain](#verifychain)**, **[verifytxoutproof](#verifytxoutproof)**


### getbestblockhash  
##### Returns the hash of the best (tip) block in the most-work fully-validated chain.
-----
```csharp    
  BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
  
  Blockchain blockchain = new Blockchain(bitcoinClient);
  
  string getbestblockhash = await blockchain.GetBestBlockHash();
  
  Console.WriteLine(getbestblockhash);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "0000000000000000000560f1c95e7ab5857d37777f9c34015c99293fbe3c0d36",
  "error": null,
  "id": null
}
```
</details>

### getblock
##### Returns information about block.
-----
```csharp
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Blockchain blockchain = new Blockchain(bitcoinClient);

string blockhash="00000000000000fd38c98aeef2f981a9591375748c2bb09b043be251d213edaf";

string getbestblockhash_VerbosityZero = await blockchain.GetBlock(blockhash, Verbosity.VerbosityZero);
string getbestblockhash_VerbosityOne = await blockchain.GetBlock(blockhash, Verbosity.VerbosityOne);
string getbestblockhash_VerbosityTwo = await blockchain.GetBlock(blockhash, Verbosity.VerbosityTwo);
            
Console.WriteLine(getbestblockhash_VerbosityZero);
Console.WriteLine(getbestblockhash_VerbosityOne);
Console.WriteLine(getbestblockhash_VerbosityTwo);
```

<details>
  
  <summary>Server response (getbestblockhash_VerbosityZero)</summary>
 
 ```json
{
  "result": "0000c020e4ceed9df9c1849e51ee20b554ecf30b7f057fecdf4712126300000000000000a134f6eeff209f5328ebede96e03173b19f12b300345f5e6413ba5472368f8233b973f5fda51011a38b5d02efd6501020000000001010000000000000000000000000000000000000000000000000000000000000000ffffffff28035a961b043b973f5f7669702f7777772e6f6b706f6f6c2e746f702f020000002754000000000000ffffffff020cdd45010000000017a9147d0bc1f74eb7e9f77d68221c54a9ab76879f580f870000000000000000266a24aa21a9ed3ec75454dbd863f1ed72717b5124e2f6649c58ec65100857e91c6d3647208b630120000000000000000000000000...",
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (getbestblockhash_VerbosityOne)</summary>
 
 ```json
{
  "result": {
    "hash": "00000000000000fd38c98aeef2f981a9591375748c2bb09b043be251d213edaf",
    "confirmations": 4,
    "strippedsize": 63348,
    "size": 111897,
    "weight": 301941,
    "height": 1807962,
    "version": 549453824,
    "versionHex": "20c00000",
    "merkleroot": "23f8682347a53b41e6f54503302bf1193b17036ee9edeb28539f20ffeef634a1",
    "tx": [
      "45fc5d4375be80fe1a2a8bbe6dc04a2923a29e967466db5736763c1c57217e59",
      "6c74eda133d5356a648507ad92d2a76b815ec0bc4517dc1840f50585b5db2e05",
      "ab6d91aee09a9736710eb8fb3b56e7925aee614ec438262bf2e1433b9423d299",
      "5407f54b04d75c35be46023c28b00ee3194ffa23c12b33e6e0293de2b00e8a15",
      "cdcbf95127282fe27157bce4f5ae6fb3cf9e6ac92e5c33f20bf16855559995bd",
      "dc9c8ea2d452ac7709a3bc7aae7ddfd5482854cafa1aad66b3ced801950450aa",
      ...
    ],
    "time": 1598003003,
    "mediantime": 1597998014,
    "nonce": 785429816,
    "bits": "1a0151da",
    "difficulty": 12712392.76864377,
    "chainwork": "0000000000000000000000000000000000000000000001bfc249400761d235ce",
    "nTx": 357,
    "previousblockhash": "0000000000000063121247dfec7f057f0bf3ec54b520ee519e84c1f99dedcee4",
    "nextblockhash": "000000000000012da5c2fcb6c72523301a15319dd8d8469a6b298092230972a5"
  },
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (getbestblockhash_VerbosityTwo)</summary>
 
 ```json
{
  "result": {
    "hash": "00000000000000fd38c98aeef2f981a9591375748c2bb09b043be251d213edaf",
    "confirmations": 7,
    "strippedsize": 63348,
    "size": 111897,
    "weight": 301941,
    "height": 1807962,
    "version": 549453824,
    "versionHex": "20c00000",
    "merkleroot": "23f8682347a53b41e6f54503302bf1193b17036ee9edeb28539f20ffeef634a1",
    "tx": [
      {
        "txid": "45fc5d4375be80fe1a2a8bbe6dc04a2923a29e967466db5736763c1c57217e59",
        "hash": "143756e1fafc786d7f15d0327d1bb4f0839fa2f24502a5cfa5e22d2f87ad5041",
        "version": 2,
        "size": 206,
        "vsize": 179,
        "weight": 716,
        "locktime": 0,
        "vin": [
          {
            "coinbase": "035a961b043b973f5f7669702f7777772e6f6b706f6f6c2e746f702f020000002754000000000000",
            "sequence": 4294967295
          }
        ],
        "vout": [
          {
            "value": 0.21355788,
            "n": 0,
            "scriptPubKey": {
              "asm": "OP_HASH160 7d0bc1f74eb7e9f77d68221c54a9ab76879f580f OP_EQUAL",
              "hex": "a9147d0bc1f74eb7e9f77d68221c54a9ab76879f580f87",
              "reqSigs": 1,
              "type": "scripthash",
              "addresses": [
                "2N4eQYCbKUHCCTUjBJeHcJp9ok6J2GZsTDt"
              ]
            }
          },
          {
            "value": 0.00000000,
            "n": 1,
            "scriptPubKey": {
              "asm": "OP_RETURN aa21a9ed3ec75454dbd863f1ed72717b5124e2f6649c58ec65100857e91c6d3647208b63",
              "hex": "6a24aa21a9ed3ec75454dbd863f1ed72717b5124e2f6649c58ec65100857e91c6d3647208b63",
              "type": "nulldata"
            }
          }
        ],
        "hex": "020000000001010000000000000000000000000000000000000000000000000000000000000000ffffffff28035a961b043b973f5f7669702f7777772e6f6b706f6f6c2e746f702f020000002754000000000000ffffffff020cdd45010000000017a9147d0bc1f74eb7e9f77d68221c54a9ab76879f580f870000000000000000266a24aa21a9ed3ec75454dbd863f1ed72717b5124e2f6649c58ec65100857e91c6d3647208b630120000000000000000000000000000000000000000000000000000000000000000000000000"
      },
      ...
    ],
    "time": 1598003003,
    "mediantime": 1597998014,
    "nonce": 785429816,
    "bits": "1a0151da",
    "difficulty": 12712392.76864377,
    "chainwork": "0000000000000000000000000000000000000000000001bfc249400761d235ce",
    "nTx": 357,
    "previousblockhash": "0000000000000063121247dfec7f057f0bf3ec54b520ee519e84c1f99dedcee4",
    "nextblockhash": "000000000000012da5c2fcb6c72523301a15319dd8d8469a6b298092230972a5"
  },
  "error": null,
  "id": null
}
```
</details>

### getblockchaininfo
##### Returns an object containing various state info regarding blockchain processing.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Blockchain blockchain = new Blockchain(bitcoinClient);

string getblockchaininfo = await blockchain.GetbBlockchainInfo();

Console.WriteLine(getblockchaininfo);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "chain": "test",
    "blocks": 1807968,
    "headers": 1807968,
    "bestblockhash": "00000000e3498214681a478131ec9ca7773a019312d4dae762bdb31ac2134db8",
    "difficulty": 1,
    "mediantime": 1598003205,
    "verificationprogress": 0.9999986474152942,
    "initialblockdownload": false,
    "chainwork": "0000000000000000000000000000000000000000000001bfc48f2faa9fc6f79e",
    "size_on_disk": 28008947975,
    "pruned": false,
    "softforks": {
      "bip34": {
        "type": "buried",
        "active": true,
        "height": 21111
      },
      "bip66": {
        "type": "buried",
        "active": true,
        "height": 330776
      },
      "bip65": {
        "type": "buried",
        "active": true,
        "height": 581885
      },
      "csv": {
        "type": "buried",
        "active": true,
        "height": 770112
      },
      "segwit": {
        "type": "buried",
        "active": true,
        "height": 834624
      }
    },
    "warnings": "Warning: unknown new rules activated (versionbit 28)"
  },
  "error": null,
  "id": null
}
```
</details>

### getblockcount
##### 
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");

Blockchain blockchain = new Blockchain(bitcoinClient);

string getblockcount = await blockchain.GetBlockCount();

Console.WriteLine(getblockcount);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": 1807969,
  "error": null,
  "id": null
}
```
</details>

### getblockhash
##### Returns the height of the most-work fully-validated chain. The genesis block has height 0.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");

Blockchain blockchain = new Blockchain(bitcoinClient);

string getblockhash = await blockchain.GetBlockHash(1000);

Console.WriteLine(getblockhash);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "00000000373403049c5fff2cd653590e8cbe6f7ac639db270e7d1a7503d698df",
  "error": null,
  "id": null
}
```
</details>

### getblockheader
##### If "BlockHeaderVerbosity.Hex", returns a string that is serialized, hex-encoded data for blockheader 'hash'. If "BlockHeaderVerbosity.Json", returns an Object with information about blockheader "hash".
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");

Blockchain blockchain = new Blockchain(bitcoinClient);
string blockhash = "00000000000000b5eadb000848db1e0f79051679c462721dd29fe1fd365cb157";

string getblockheader_Hex = await blockchain.GetBlockHeader(blockhash, BlockHeaderVerbosity.Hex);
string getblockheader_Json = await blockchain.GetBlockHeader(blockhash, BlockHeaderVerbosity.Json);
            
Console.WriteLine(getblockheader_Hex);
Console.WriteLine(getblockheader_Json);
```

<details>
  
  <summary>Server response (getblockheader_Hex)</summary>
 
 ```json
{
  "result": "00000020b84d13c21ab3bd62e7dad41293013a77a79cec3181471a68148249e3000000002612428a5cb4cea23ab8929b6eb622d15becb96c8edba5266d9a30f4e7702937f3ad3f5fda51011a70fb1fca",
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (getblockheader_Json)</summary>
 
 ```json
{
  "result": {
    "hash": "00000000000000b5eadb000848db1e0f79051679c462721dd29fe1fd365cb157",
    "confirmations": 2,
    "height": 1807969,
    "version": 536870912,
    "versionHex": "20000000",
    "merkleroot": "372970e7f4309a6d26a5db8e6cb9ec5bd122b66e9b92b83aa2ceb45c8a421226",
    "time": 1598008819,
    "mediantime": 1598004409,
    "nonce": 3391093616,
    "bits": "1a0151da",
    "difficulty": 12712392.76864377,
    "chainwork": "0000000000000000000000000000000000000000000001bfc5512a355f178d8d",
    "nTx": 130,
    "previousblockhash": "00000000e3498214681a478131ec9ca7773a019312d4dae762bdb31ac2134db8",
    "nextblockhash": "0000000000000139ca625052631124ab9e5864aceb84a691da083ff61eb6adae"
  },
  "error": null,
  "id": null
}
```
</details>

### getblockstats
##### Compute per block statistics for a given window. All amounts are in satoshis. It won't work for some heights with pruning.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Blockchain blockchain = new Blockchain(bitcoinClient);

//Overload 1
int blockHeight = 100;
string getblockstats_byHeight = await blockchain.GetBlockStats(blockHeight); 

//Overload 2
string blockhash = "00000000000000b5eadb000848db1e0f79051679c462721dd29fe1fd365cb157";
string getblockstats_byBlockhash = await blockchain.GetBlockStats(blockhash);

//Include a filter. Note: If not included returns all.
List<BlockStatsFilter> blockStatsFilters = new List<BlockStatsFilter>();
            
blockStatsFilters.Add(BlockStatsFilter.maxfeerate);
blockStatsFilters.Add(BlockStatsFilter.mediantime);
blockStatsFilters.Add(BlockStatsFilter.totalfee);

string getblockstats_with_filter = await blockchain.GetBlockStats(100, blockStatsFilters);

Console.WriteLine(getblockstats_byHeight);
Console.WriteLine(getblockstats_byBlockhash);
Console.WriteLine(getblockstats_with_filter);
```

<details>
  
  <summary>Server response (getblockstats_byHeight)</summary>
 
 ```json
{
  "result": {
    "avgfee": 0,
    "avgfeerate": 0,
    "avgtxsize": 0,
    "blockhash": "000000002ce019cc4a8f2af62b3ecf7c30a19d29828b25268a0194dbac3cac50",
    "feerate_percentiles": [
      0,
      0,
      0,
      0,
      0
    ],
    "height": 100,
    "ins": 0,
    "maxfee": 0,
    "maxfeerate": 0,
    "maxtxsize": 0,
    "medianfee": 0,
    "mediantime": 1296698941,
    "mediantxsize": 0,
    "minfee": 0,
    "minfeerate": 0,
    "mintxsize": 0,
    "outs": 1,
    "subsidy": 5000000000,
    "swtotal_size": 0,
    "swtotal_weight": 0,
    "swtxs": 0,
    "time": 1296699105,
    "total_out": 0,
    "total_size": 0,
    "total_weight": 0,
    "totalfee": 0,
    "txs": 1,
    "utxo_increase": 1,
    "utxo_size_inc": 85
  },
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (getblockstats_byBlockhash)</summary>
 
 ```json
{
  "result": {
    "avgfee": 8657,
    "avgfeerate": 27,
    "avgtxsize": 548,
    "blockhash": "00000000000000b5eadb000848db1e0f79051679c462721dd29fe1fd365cb157",
    "feerate_percentiles": [
      1,
      1,
      1,
      19,
      124
    ],
    "height": 1807969,
    "ins": 274,
    "maxfee": 70000,
    "maxfeerate": 309,
    "maxtxsize": 33003,
    "medianfee": 256,
    "mediantime": 1598004409,
    "mediantxsize": 247,
    "minfee": 141,
    "minfeerate": 1,
    "mintxsize": 189,
    "outs": 256,
    "subsidy": 19531250,
    "swtotal_size": 65286,
    "swtotal_weight": 139755,
    "swtxs": 114,
    "time": 1598008819,
    "total_out": 256365694128,
    "total_size": 70754,
    "total_weight": 161627,
    "totalfee": 1116779,
    "txs": 130,
    "utxo_increase": -18,
    "utxo_size_inc": -1307
  },
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (getblockstats_with_filter)</summary>
 
 ```json
{
  "result": {
    "maxfeerate": 0,
    "mediantime": 1296698941,
    "totalfee": 0
  },
  "error": null,
  "id": null
}
```
</details>

### getchaintips
##### Return information about all known tips in the block tree, including the main chain as well as orphaned branches.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Blockchain blockchain = new Blockchain(bitcoinClient);

string getchaintips = await blockchain.GetChainTips();

Console.WriteLine(getchaintips);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    {
      "height": 1807971,
      "hash": "00000000eef8f81f91d8c3471be9545daab28bb09f7961faf5c1b16abbc9ade9",
      "branchlen": 0,
      "status": "active"
    },
    {
      "height": 1806605,
      "hash": "00000000000000a1cf038a2d4cf1d65bd07dc06feeca94b132a2ba389579156c",
      "branchlen": 1,
      "status": "valid-fork"
    },
    {
      "height": 1806595,
      "hash": "000000000000011bbcceab08b921c7a713c3aff25ef2bdfa5c14426b98b1b006",
      "branchlen": 1,
      "status": "valid-fork"
    },
    {
      "height": 1803960,
      "hash": "00000000000009016758be325bacf174b8bf6b088cc030e71a36f13efbe409ea",
      "branchlen": 1,
      "status": "valid-fork"
    },
    {
      "height": 1414433,
      "hash": "00000000210004840364b52bc5e455d888f164e4264a4fec06a514b67e9d5722",
      "branchlen": 23,
      "status": "headers-only"
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### getchaintxstats
##### Compute statistics about the total number and rate of transactions in the chain.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Blockchain blockchain = new Blockchain(bitcoinClient);

//Overload 1. One month window. Chain tip.
string getchaintxstats = await blockchain.GetChainTxStats();

//Overload 2. Size of the window in number of blocks.
string getchaintxstats_nblocks = await blockchain.GetChainTxStats(100);

//Overload 3. Size of the window in number of blocks. The hash of the block that ends the window.
string getchaintxstats_nblocks_finalBlockhash = await blockchain.GetChainTxStats(100, "00000000000000b5eadb000848db1e0f79051679c462721dd29fe1fd365cb157");

Console.WriteLine(getchaintxstats);
Console.WriteLine(getchaintxstats_nblocks);
Console.WriteLine(getchaintxstats_nblocks_finalBlockhash);
```

<details>
  
  <summary>Server response (getchaintxstats)</summary>
 
 ```json
{
  "result": {
    "time": 1598011942,
    "txcount": 57469714,
    "window_final_block_hash": "00000000759beb8094905a71acd9d3af0979dc1884026ef97817cbd1fedcc869",
    "window_final_block_height": 1807972,
    "window_block_count": 4320,
    "window_tx_count": 449972,
    "window_interval": 1481867,
    "txrate": 0.3036520821369259
  },
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (getchaintxstats_nblocks)</summary>
 
 ```json
{
  "result": {
    "time": 1598011942,
    "txcount": 57469714,
    "window_final_block_hash": "00000000759beb8094905a71acd9d3af0979dc1884026ef97817cbd1fedcc869",
    "window_final_block_height": 1807972,
    "window_block_count": 100,
    "window_tx_count": 21900,
    "window_interval": 96261,
    "txrate": 0.2275064667934054
  },
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (getchaintxstats_nblocks_finalBlockhash)</summary>
 
 ```json
{
  "result": {
    "time": 1598008819,
    "txcount": 57468886,
    "window_final_block_hash": "00000000000000b5eadb000848db1e0f79051679c462721dd29fe1fd365cb157",
    "window_final_block_height": 1807969,
    "window_block_count": 100,
    "window_tx_count": 21564,
    "window_interval": 96426,
    "txrate": 0.2236326302034721
  },
  "error": null,
  "id": null
}
```
</details>

### getdifficulty
##### Returns the proof-of-work difficulty as a multiple of the minimum difficulty.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Blockchain blockchain = new Blockchain(bitcoinClient);

string getdifficulty = await blockchain.GetDifficulty();

Console.WriteLine(getdifficulty);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": 16947802333946.61,
  "error": null,
  "id": null
}
```
</details>

### getmempoolancestors
##### If txid is in the mempool, returns all in-mempool ancestors.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");            
Blockchain blockchain = new Blockchain(bitcoinClient);

string txid = "e3da017450b456e194cb32f9959808b2ec2dacf8702018edf334eabafe829257";
string getmempoolancestors = await blockchain.GetMemPoolAncestors(txid);

Console.WriteLine(getmempoolancestors);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {},
  "error": null,
  "id": null
}
```
</details>

### getmempooldescendants
##### If txid is in the mempool, returns all in-mempool descendants.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");           
Blockchain blockchain = new Blockchain(bitcoinClient);

string txid = "ebf7b4cfe5a4aaf3c9faede04369527e14cc7c9766c448c765b6d64e85bee1a8";
string getmempooldescendants = await blockchain.GetMemPoolDescendants(txid);

Console.WriteLine(getmempooldescendants);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {},
  "error": null,
  "id": null
}
```
</details>

### getmempoolentry
##### Returns mempool data for given transaction.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");         
Blockchain blockchain = new Blockchain(bitcoinClient);

string txid = "e3da017450b456e194cb32f9959808b2ec2dacf8702018edf334eabafe829257";
string getmempoolentry = await blockchain.GetMemPoolEntry(txid);

Console.WriteLine(getmempoolentry);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "fees": {
      "base": 0.00016616,
      "modified": 0.00016616,
      "ancestor": 0.00016616,
      "descendant": 0.00016616
    },
    "vsize": 134,
    "weight": 534,
    "fee": 0.00016616,
    "modifiedfee": 0.00016616,
    "time": 1598013291,
    "height": 1807973,
    "descendantcount": 1,
    "descendantsize": 134,
    "descendantfees": 16616,
    "ancestorcount": 1,
    "ancestorsize": 134,
    "ancestorfees": 16616,
    "wtxid": "6659d9b42017c485f410cd75567d740745bfc0f03ef13f9ec263de8d32ab37f6",
    "depends": [],
    "spentby": [],
    "bip125-replaceable": false
  },
  "error": null,
  "id": null
}
```
</details>

### getmempoolinfo
##### Returns details on the active state of the TX memory pool.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Blockchain blockchain = new Blockchain(bitcoinClient);

string getmempoolinfo = await blockchain.GetMemPoolInfo();

Console.WriteLine(getmempoolinfo);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "loaded": true,
    "size": 232,
    "bytes": 128919,
    "usage": 464656,
    "maxmempool": 300000000,
    "mempoolminfee": 0.00001000,
    "minrelaytxfee": 0.00001000
  },
  "error": null,
  "id": null
}
```
</details>

### getrawmempool
##### Returns all transaction ids in memory pool as a json array of string transaction ids.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Blockchain blockchain = new Blockchain(bitcoinClient);

string getrawmempool_Json = await blockchain.GetRawMempool(ReturnFormat.JSON);
string getrawmempool_ArrayTxIds = await blockchain.GetRawMempool(ReturnFormat.ArrayOfTransactionIds);

Console.WriteLine(getrawmempool_Json);
Console.WriteLine(getrawmempool_ArrayTxIds);
```

<details>
  
  <summary>Server response (getrawmempool_Json)</summary>
 
 ```json
{
  "result": {
    "e7b18c209782a0fa9c2dd0c93c46720526b795c818f99d009c612f4405642f90": {
      "fees": {
        "base": 0.00016080,
        "modified": 0.00016080,
        "ancestor": 0.00016080,
        "descendant": 0.00016080
      },
      "vsize": 134,
      "weight": 533,
      "fee": 0.00016080,
      "modifiedfee": 0.00016080,
      "time": 1598013079,
      "height": 1807972,
      "descendantcount": 1,
      "descendantsize": 134,
      "descendantfees": 16080,
      "ancestorcount": 1,
      "ancestorsize": 134,
      "ancestorfees": 16080,
      "wtxid": "8f174f4d9650ab1f55a55199d01c96e72b2eeb24d5881258767c4a816b0af082",
      "depends": [],
      "spentby": [],
      "bip125-replaceable": false
    },
    "e1b98b7f5450b512a62dfd1f212ca1dbed5c46a394f3b01f230fbcea5ea7ab5f": {
      "fees": {
        "base": 0.00000168,
        "modified": 0.00000168,
        "ancestor": 0.00000168,
        "descendant": 0.00001109
      },
      "vsize": 168,
      "weight": 669,
      "fee": 0.00000168,
      "modifiedfee": 0.00000168,
      "time": 1598013084,
      "height": 1807972,
      "descendantcount": 2,
      "descendantsize": 1104,
      "descendantfees": 1109,
      "ancestorcount": 1,
      "ancestorsize": 168,
      "ancestorfees": 168,
      "wtxid": "14d70368f4123391c5c098cc10b8f1293e35f182f9ec868e3eecbbeb7fd5c200",
      "depends": [],
      "spentby": [
        "0d8a941cb0a29c8dddc16a8d1dfb2c8e7eabef5e0125fd20389865758586d352"
      ],
      "bip125-replaceable": false
    },
    "48b2fff54ad2a94434c6ab0d512505ca8b43d72d64fdee66b2471983b6f09c3d": {
      "fees": {
        "base": 0.00016616,
        "modified": 0.00016616,
        "ancestor": 0.00016616,
        "descendant": 0.00016616
      },
      "vsize": 134,
      "weight": 533,
      "fee": 0.00016616,
      "modifiedfee": 0.00016616,
      "time": 1598014003,
      "height": 1807973,
      "descendantcount": 1,
      "descendantsize": 134,
      "descendantfees": 16616,
      "ancestorcount": 1,
      "ancestorsize": 134,
      "ancestorfees": 16616,
      "wtxid": "dfca2c8e32039c1c89c3eab915f97ce94783e6d76d343be7eba48612938065c0",
      "depends": [],
      "spentby": [],
      "bip125-replaceable": false
    },
    "09656f5763c79d1fa7879e633a665a864b288b7c7dab606a9345cc01fe0e36eb": {
      "fees": {
        "base": 0.00016080,
        "modified": 0.00016080,
        "ancestor": 0.00016080,
        "descendant": 0.00016080
      },
      "vsize": 134,
      "weight": 533,
      "fee": 0.00016080,
      "modifiedfee": 0.00016080,
      "time": 1598013063,
      "height": 1807972,
      "descendantcount": 1,
      "descendantsize": 134,
      "descendantfees": 16080,
      "ancestorcount": 1,
      "ancestorsize": 134,
      "ancestorfees": 16080,
      "wtxid": "1e0a2465142fd7238dc75c3fe93c932edba6905a75a0e350ac1991ca337bddfb",
      "depends": [],
      "spentby": [],
      "bip125-replaceable": false
    },
    "12b4ee5000b4b6e41beb1a9a22ad2d02b43c726d9d43bdbac96749aa004bdecd": {
      "fees": {
        "base": 0.00008000,
        "modified": 0.00008000,
        "ancestor": 0.00008000,
        "descendant": 0.00008000
      },
      "vsize": 351,
      "weight": 1404,
      "fee": 0.00008000,
      "modifiedfee": 0.00008000,
      "time": 1598013326,
      "height": 1807973,
      "descendantcount": 1,
      "descendantsize": 351,
      "descendantfees": 8000,
      "ancestorcount": 1,
      "ancestorsize": 351,
      "ancestorfees": 8000,
      "wtxid": "12b4ee5000b4b6e41beb1a9a22ad2d02b43c726d9d43bdbac96749aa004bdecd",
      "depends": [],
      "spentby": [],
      "bip125-replaceable": false
    },
    ...
    
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (getrawmempool_ArrayTxIds)</summary>
 
 ```json
{
  "result": [
    "04ca9faf997418bf118daec86024667c697d86ac69dba478307faf21f85120c0",
    "45c6eb4bc755df282f581ac0d062d1f3994e7ca1c7c6657f1661f32710a518d0",
    "2e311d736b1ce1220d8d57e5c6dc67dfb59a0dc6fb43c2ea60207fd1f6b6efb0",
    "810ac5f503d986019ab82ffa20873c3dc43d5b13b35faf1a8d8d1587875e1489",
    "ca82e25573068e8f4e080938b4edd753d16de2d1b88bc63f223d7a6e50b05488",
    "09c61603db830d3a04d0473a9f673e9cfce41d5990f9421d86d464cc08d22c84",
    "464bc508bb01e775b551c47b71452f8fd37dff776e82940a001d2be0d277e780",
    "5f874b6cf2b156abff574506f142587f093fb9aae495314e8a99b93fa8ff327c",
    "db7c29c7f6f829e054ab6b1ffad05c1647de015ece8fd4fea8bc7907c17ce271",
    "62133de6a090aea37f9ced2a85641292e94150d7b966f9980ca6f22c29e7e94d",
    "ed69e0290eaef004d10de2ef55f8801159961289ef863fc59ebf05f3c0ba014c",
    "ba6fda128ca4fd05ceef9638d4225632b6946f7895dd1bb3436ae78407454a0f",
    "0b678077192c6f98ec48966058b3921a9804c5ddc32a75ca7ed2fc35f38be2b4",
    "94d780a34ecdecc3481993a275849a3db7a221a4dead9ea10172f2f00a5461f0",
    "62df2e795b99c34bbbdcbaf3e794abd2089b1b0971f00f7526f642c4e1135fbc",
    "2e6c94c54ff1400397786d3a0fbf7658bb725d0785383b7af5d189d58051b858",
    "de4c2706fde242d4155950ab2e6f034b6fd2b2e6f3e20a44248a1a5e77ce9a7b",
    "7db6b7e7b9e4a66de1b16d260ce987694ac097d2fd5f8559c086d9fe65ba7c44",
    "b45f9015da711c8bfe46c902fbcfbc3724cc5f394366272308712215073a2ee0",
    "3a0c8f7f14929fa0ebf32d5f67301d91ae9bc135a0fe013f1d2e92f01cde037c",
    "38e478d389e003640153fa70bc10a937618f832362ae3f5a071efbb981e6cd77",
    "50a7f5da7fe2b080bd725d85bf2bcb8217dd4c6d341265bcc9258b31d7fff65e",
    "da10bd222f849cb25ff0f5cdb764e83332435e3fbcb1f50f14695d5b804f0633",
    "dd884a32973545a9ab0e9b118dd982263e004a98f80d62312591cf6188f2d20f"
  ],
  "error": null,
  "id": null
}
```
</details>

### gettxout
##### Returns details about an unspent transaction output.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Blockchain blockchain = new Blockchain(bitcoinClient);

string txid = "cbfda9f0cb47ece3e2f0078d074c021548ba3ff53aff583a7777b9a682349d80";
string gettxout = await blockchain.GetTxOut(txid,0);

Console.WriteLine(gettxout);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "bestblock": "0000000053afbeda917e9a9d64af3bb5805214e21d9d982190695b7ed0dbfeff",
    "confirmations": 0,
    "value": 0.01189035,
    "scriptPubKey": {
      "asm": "0 7fd0e5fbb32a78ac2ced83fbc26be7d63e1f91fa",
      "hex": "00147fd0e5fbb32a78ac2ced83fbc26be7d63e1f91fa",
      "reqSigs": 1,
      "type": "witness_v0_keyhash",
      "addresses": [
        "tb1q0lgwt7an9fu2ct8ds0auy6l86clply06m2te54"
      ]
    },
    "coinbase": false
  },
  "error": null,
  "id": null
}
```
</details>

### gettxoutproof
##### Returns a hex-encoded proof that "txid" was included in a block.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Blockchain blockchain = new Blockchain(bitcoinClient);

List<string> txids = new List<string>();
           
txids.Add("aff347e3bf1803d33548b3b440506d7df6275ce4fae6c548f9076de0f46a63d1");
txids.Add("8903339fa21b5856e8ba9ed0828a9f03888ace9d551a2c24e3d19f9e3c3f9220");
            
//Overload 1.
string gettxoutproof = await blockchain.GetTxOutProof(txids);

//Overload 2. Looks for txid in the block with this hash.
string blockhash = "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319";
string gettxoutproof_InThisBlock= await blockchain.GetTxOutProof(txids, blockhash);

Console.WriteLine(gettxoutproof);
Console.WriteLine(gettxoutproof_InThisBlock);
```

<details>
  
  <summary>Server response (gettxoutproof)</summary>
 
 ```json
{
  "result": "000000207a5cd1d7d427da62a4a50fe4c91f92a5d4ad71335c7234880800000000000000d925e93b0e26f52e29ac074a44211382502ae2012600fd909f0c309fc316ac3b82ba365fffff001d8518aa6d150100000b35500c73b23dbe87c95a6df03fb02543733b6697ceaa277041f3f0f97a37366ed1636af4e06d07f948c5e6fae45c27f67d6d5040b4b34835d30318bfe347f3af20923f3c9e9fd1e3242c1a559dce8a88039f8a82d09ebae856581ba29f330389f16139def68f52b2d8013c24a0a3b8f5c008013ef495967ea6066fe7bb61a41193021c84199b08c30c9b3c27b168ef2b9812d154215851357018a52c019b66e71456e009e91983e6f839391e723465095d0d523a46ab5998919c6d28c3b21caff06803d7d15d98f966301d8a86c27bd4e6b35257e02049fb35ac234a53e7d84a353cfd6243b6f09b4b7f801e0f4a7c6661ba68d752b7e80833a6e2a87b7de046e0690a708b6361063223f9092a35840da01bd507eabc7e2eddf645fb142528a400c2c768b23b075186177baa987966aa527741fb37d04f78d9e0700b3b23375f8100ce01f8ee7e21034aab4658e99d814a725ecf5c35b7184149a6bd516a338a03ff1d00",
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (gettxoutproof_InThisBlock)</summary>
 
 ```json
{
  "result": "000000207a5cd1d7d427da62a4a50fe4c91f92a5d4ad71335c7234880800000000000000d925e93b0e26f52e29ac074a44211382502ae2012600fd909f0c309fc316ac3b82ba365fffff001d8518aa6d150100000b35500c73b23dbe87c95a6df03fb02543733b6697ceaa277041f3f0f97a37366ed1636af4e06d07f948c5e6fae45c27f67d6d5040b4b34835d30318bfe347f3af20923f3c9e9fd1e3242c1a559dce8a88039f8a82d09ebae856581ba29f330389f16139def68f52b2d8013c24a0a3b8f5c008013ef495967ea6066fe7bb61a41193021c84199b08c30c9b3c27b168ef2b9812d154215851357018a52c019b66e71456e009e91983e6f839391e723465095d0d523a46ab5998919c6d28c3b21caff06803d7d15d98f966301d8a86c27bd4e6b35257e02049fb35ac234a53e7d84a353cfd6243b6f09b4b7f801e0f4a7c6661ba68d752b7e80833a6e2a87b7de046e0690a708b6361063223f9092a35840da01bd507eabc7e2eddf645fb142528a400c2c768b23b075186177baa987966aa527741fb37d04f78d9e0700b3b23375f8100ce01f8ee7e21034aab4658e99d814a725ecf5c35b7184149a6bd516a338a03ff1d00",
  "error": null,
  "id": null
}
```
</details>

### gettxoutsetinfo
##### Returns statistics about the unspent transaction output set. Note this call may take some time.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Blockchain blockchain = new Blockchain(bitcoinClient);

string gettxoutsetinfo = await blockchain.GetTxOutSetInfo();

Console.WriteLine(gettxoutsetinfo);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "height": 1807979,
    "bestblock": "00000000d8cd50ceee79f11c7a19eaf39edbb99a54aedc778bbcae127ef1bdf3",
    "transactions": 9218161,
    "txouts": 24099837,
    "bogosize": 1807594455,
    "hash_serialized_2": "f0f4f455363d595f95c8df7e752dd8cc6f30b2429b3e068e4a1bc5362046f9a5",
    "disk_size": 1313163280,
    "total_amount": 20942088.95565249
  },
  "error": null,
  "id": null
}
```
</details>

### preciousblock
##### Treats a block as if it were received before others with the same work.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Blockchain blockchain = new Blockchain(bitcoinClient);

string blockhash = "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319";
string preciousblock = await blockchain.PreciousBlock(blockhash);

Console.WriteLine(preciousblock);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### pruneblockchain
##### Prune blockchain height. May be set to a discrete height, or to a UNIX epoch time to prune blocks whose block time is at least 2 hours older than the provided timestamp.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
Blockchain blockchain = new Blockchain(bitcoinClient);

//Overload 1. Prune upto height.
int height = 198000;
string pruneblockchain_UpToHeight = await blockchain.PruneBlockchain(height);

//Overload 2. Prune upto UnixEpochTime.
long UnixEpochTime = 1503326167;
string pruneblockchain_UpToUnixEpochTime = await blockchain.PruneBlockchain(UnixEpochTime);

Console.WriteLine(pruneblockchain_UpToHeight);
Console.WriteLine(pruneblockchain_UpToUnixEpochTime);
```

<details>
  
  <summary>Server response (pruneblockchain_UpToHeight)</summary>
 
 ```json
{
  "result": 644374,
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (pruneblockchain_UpToUnixEpochTime)</summary>
 
 ```json
{
  "result": 644374,
  "error": null,
  "id": null
}
```
</details>

### savemempool
##### Dumps the mempool to disk. It will fail until the previous dump is fully loaded.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Blockchain blockchain = new Blockchain(bitcoinClient);

string savemempool = await blockchain.SaveMemPool();

Console.WriteLine(savemempool);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### scantxoutset
##### Scans the unspent transaction output set for entries that match certain output descriptors.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Blockchain blockchain = new Blockchain(bitcoinClient);

ScanTxOutSet scanTxOutSet = new ScanTxOutSet();
scanTxOutSet.Descriptor = Descriptor.addr;
scanTxOutSet.ScanObjects = new List<string>()
   {
        "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
        "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj"
   };

string scantxoutset = await blockchain.ScanTxOutSet(Scan.Start, scanTxOutSet);

Console.WriteLine(scantxoutset);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "success": true,
    "txouts": 24100064,
    "height": 1807980,
    "bestblock": "0000000040daaabe09fd46b9c1c06352ee4f9da2b9ae5dad222d91b2d40a8b9f",
    "unspents": [
      {
        "txid": "c1e5d3718ff4ff0dfd5f50bd09d7c36c30a1ce203228041422411b8dbf28f501",
        "vout": 1,
        "scriptPubKey": "76a914ee747a81bc7af6afce0e597c672d9dcb4268aa4188ac",
        "desc": "addr(n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj)#lr0lv3s0",
        "amount": 0.00001000,
        "height": 1807225
      },
      {
        "txid": "1bdfb9b27a9ba9c8978933f3bbd95cd5845e2e6d770cabe92b170e3d570f8509",
        "vout": 1,
        "scriptPubKey": "76a914ee747a81bc7af6afce0e597c672d9dcb4268aa4188ac",
        "desc": "addr(n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj)#lr0lv3s0",
        "amount": 0.00001000,
        "height": 1807224
      },
      {
        "txid": "475b13c64baacc842336029d0c3ea3b1ad82f9f1c9e8fb156dd2c1c283ce5f0c",
        "vout": 1,
        "scriptPubKey": "76a914ee747a81bc7af6afce0e597c672d9dcb4268aa4188ac",
        "desc": "addr(n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj)#lr0lv3s0",
        "amount": 0.00003300,
        "height": 1807222
      },
      {
        "txid": "49314d54509c657184679c8801b9c13767e4b1aeee881ec2f378eb6518ff4f13",
        "vout": 1,
        "scriptPubKey": "76a914ee747a81bc7af6afce0e597c672d9dcb4268aa4188ac",
        "desc": "addr(n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj)#lr0lv3s0",
        "amount": 0.00003300,
        "height": 1807221
      },
    ...
    ],
    "total_amount": 0.32075157
  },
  "error": null,
  "id": null
}
```
</details>

### verifychain
##### Verifies blockchain database.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Blockchain blockchain = new Blockchain(bitcoinClient);
           
string verifychain = await blockchain.Verifychain();

Console.WriteLine(verifychain);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": true,
  "error": null,
  "id": null
}
```
</details>

### verifytxoutproof
##### Verifies that a proof points to a transaction in a block, returning the transaction it commits to and throwing an RPC error if the block is not in our best chain.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Blockchain blockchain = new Blockchain(bitcoinClient);

string hexProof = "000000207a5cd1d7d427da62a4a50fe4c91f92a5d4ad71335c7234880800000000000000d925e93b0e26f52e29ac074a44211382502ae2012600fd909f0c309fc316ac3b82ba365fffff001d8518aa6d150100000b35500c73b23dbe87c95a6df03fb02543733b6697ceaa277041f3f0f97a37366ed1636af4e06d07f948c5e6fae45c27f67d6d5040b4b34835d30318bfe347f3af20923f3c9e9fd1e3242c1a559dce8a88039f8a82d09ebae856581ba29f330389f16139def68f52b2d8013c24a0a3b8f5c008013ef495967ea6066fe7bb61a41193021c84199b08c30c9b3c27b168ef2b9812d154215851357018a52c019b66e71456e009e91983e6f839391e723465095d0d523a46ab5998919c6d28c3b21caff06803d7d15d98f966301d8a86c27bd4e6b35257e02049fb35ac234a53e7d84a353cfd6243b6f09b4b7f801e0f4a7c6661ba68d752b7e80833a6e2a87b7de046e0690a708b6361063223f9092a35840da01bd507eabc7e2eddf645fb142528a400c2c768b23b075186177baa987966aa527741fb37d04f78d9e0700b3b23375f8100ce01f8ee7e21034aab4658e99d814a725ecf5c35b7184149a6bd516a338a03ff1d00";

string verifytxoutproof = await blockchain.VerifyTxOutProof(hexProof);

Console.WriteLine(verifytxoutproof);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    "aff347e3bf1803d33548b3b440506d7df6275ce4fae6c548f9076de0f46a63d1",
    "8903339fa21b5856e8ba9ed0828a9f03888ace9d551a2c24e3d19f9e3c3f9220"
  ],
  "error": null,
  "id": null
}
```
</details>

CONTROL
-----
**[getmemoryinfo](#getmemoryinfo)**, **[getrpcinfo](#getrpcinfo)**, **[help](#help)**, **[logging](#logging)**, **[stop](#stop)**, **[uptime](#uptime)**


### getmemoryinfo
##### Returns an object containing information about memory usage.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
ServerControl serverControl = new ServerControl(bitcoinClient);

string getmemoryinfo = await serverControl.GetMemoryInfo();

Console.WriteLine(getmemoryinfo);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "locked": {
      "used": 176,
      "free": 261968,
      "total": 262144,
      "locked": 0,
      "chunks_used": 1,
      "chunks_free": 1
    }
  },
  "error": null,
  "id": null
}
```
</details>

### getrpcinfo
##### Returns details of the RPC server.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
ServerControl serverControl = new ServerControl(bitcoinClient);

string getrpcinfo = await serverControl.GetRpcInfo();

Console.WriteLine(getrpcinfo);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "active_commands": [
      {
        "method": "getrpcinfo",
        "duration": 0
      }
    ],
    "logpath": "E:\\btcData\\testnet3\\debug.log"
  },
  "error": null,
  "id": null
}
```
</details>

### help
##### List all commands, or get help for a specified command.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
ServerControl serverControl = new ServerControl(bitcoinClient);

string help = await serverControl.Help();
string help_with_Command = await serverControl.Help(CommandHelp.addnode);

Console.WriteLine(help);
Console.WriteLine(help_with_Command); 
```

<details>
  
  <summary>Server response (help)</summary>
 
 ```json
{
  "result": "== Blockchain ==\ngetbestblockhash\ngetblock \u0022blockhash\u0022 ( verbosity )\ngetblockchaininfo\ngetblockcount\ngetblockfilter \u0022blockhash\u0022 ( \u0022filtertype\u0022 )\ngetblockhash height\ngetblockheader \u0022blockhash\u0022 ( verbose )\ngetblockstats hash_or_height ( stats )\ngetchaintips\ngetchaintxstats ( nblocks \u0022blockhash\u0022 )\ngetdifficulty\ngetmempoolancestors \u0022txid\u0022 ( verbose )\ngetmempooldescendants \u0022txid\u0022 ( verbose )\ngetmempoolentry \u0022txid\u0022\ngetmempoolinfo\ngetrawmempool ( verbose )\ngettxout \u0022txid\u0022 n ( include_mempool )\ngettxoutproof [\u0022txid\u0022,...] ( \u0022blockhash\u0022 )\ngettxoutsetinfo\npreciousblock \u0022blockhash\u0022\npruneblockchain height\nsavemempool\nscantxoutset \u0022action\u0022 ( [scanobjects,...] )\nverifychain ( checklevel nblocks )\nverifytxoutproof \u0022proof\u0022\n\n== Control ==\ngetmemoryinfo ( \u0022mode\u0022 )\ngetrpcinfo\nhelp ( \u0022command\u0022 )\nlogging ( [\u0022include_category\u0022,...] [\u0022exclude_category\u0022,...] )\nstop\nuptime\n\n== Generating ==\ngeneratetoaddress nblocks \u0022address\u0022 ( maxtries )\ngeneratetodescriptor num_blocks \u0022descriptor\u0022 ( maxtries )\n\n== Mining ==\ngetblocktemplate ( \u0022template_request\u0022 )\ngetmininginfo\ngetnetworkhashps ( nblocks height )\nprioritisetransaction \u0022txid\u0022 ( dummy ) fee_delta\nsubmitblock \u0022hexdata\u0022 ( \u0022dummy\u0022 )\nsubmitheader \u0022hexdata\u0022\n\n== Network ==\naddnode \u0022node\u0022 \u0022command\u0022\nclearbanned\ndisconnectnode ( \u0022address\u0022 nodeid )\ngetaddednodeinfo ( \u0022node\u0022 )\ngetconnectioncount\ngetnettotals\ngetnetworkinfo\ngetnodeaddresses ( count )\ngetpeerinfo\nlistbanned\nping\nsetban \u0022subnet\u0022 \u0022command\u0022 ( bantime absolute )\nsetnetworkactive state\n\n== Rawtransactions ==\nanalyzepsbt \u0022psbt\u0022\ncombinepsbt [\u0022psbt\u0022,...]\ncombinerawtransaction [\u0022hexstring\u0022,...]\nconverttopsbt \u0022hexstring\u0022 ( permitsigdata iswitness )\ncreatepsbt [{\u0022txid\u0022:\u0022hex\u0022,\u0022vout\u0022:n,\u0022sequence\u0022:n},...] [{\u0022address\u0022:amount},{\u0022data\u0022:\u0022hex\u0022},...] ( locktime replaceable )\ncreaterawtransaction [{\u0022txid\u0022:\u0022hex\u0022,\u0022vout\u0022:n,\u0022sequence\u0022:n},...] [{\u0022address\u0022:amount},{\u0022data\u0022:\u0022hex\u0022},...] ( locktime replaceable )\ndecodepsbt \u0022psbt\u0022\ndecoderawtransaction \u0022hexstring\u0022 ( iswitness )\ndecodescript \u0022hexstring\u0022\nfinalizepsbt \u0022psbt\u0022 ( extract )\nfundrawtransaction \u0022hexstring\u0022 ( options iswitness )\ngetrawtransaction \u0022txid\u0022 ( verbose \u0022blockhash\u0022 )\njoinpsbts [\u0022psbt\u0022,...]\nsendrawtransaction \u0022hexstring\u0022 ( maxfeerate )\nsignrawtransactionwithkey \u0022hexstring\u0022 [\u0022privatekey\u0022,...] ( [{\u0022txid\u0022:\u0022hex\u0022,\u0022vout\u0022:n,\u0022scriptPubKey\u0022:\u0022hex\u0022,\u0022redeemScript\u0022:\u0022hex\u0022,\u0022witnessScript\u0022:\u0022hex\u0022,\u0022amount\u0022:amount},...] \u0022sighashtype\u0022 )\ntestmempoolaccept [\u0022rawtx\u0022,...] ( maxfeerate )\nutxoupdatepsbt \u0022psbt\u0022 ( [\u0022\u0022,{\u0022desc\u0022:\u0022str\u0022,\u0022range\u0022:n or [n,n]},...] )\n\n== Util ==\ncreatemultisig nrequired [\u0022key\u0022,...] ( \u0022address_type\u0022 )\nderiveaddresses \u0022descriptor\u0022 ( range )\nestimatesmartfee conf_target ( \u0022estimate_mode\u0022 )\ngetdescriptorinfo \u0022descriptor\u0022\nsignmessagewithprivkey \u0022privkey\u0022 \u0022message\u0022\nvalidateaddress \u0022address\u0022\nverifymessage \u0022address\u0022 \u0022signature\u0022 \u0022message\u0022\n\n== Wallet ==\nabandontransaction \u0022txid\u0022\nabortrescan\naddmultisigaddress nrequired [\u0022key\u0022,...] ( \u0022label\u0022 \u0022address_type\u0022 )\nbackupwallet \u0022destination\u0022\nbumpfee \u0022txid\u0022 ( options )\ncreatewallet \u0022wallet_name\u0022 ( disable_private_keys blank \u0022passphrase\u0022 avoid_reuse )\ndumpprivkey \u0022address\u0022\ndumpwallet \u0022filename\u0022\nencryptwallet \u0022passphrase\u0022\ngetaddressesbylabel \u0022label\u0022\ngetaddressinfo \u0022address\u0022\ngetbalance ( \u0022dummy\u0022 minconf include_watchonly avoid_reuse )\ngetbalances\ngetnewaddress ( \u0022label\u0022 \u0022address_type\u0022 )\ngetrawchangeaddress ( \u0022address_type\u0022 )\ngetreceivedbyaddress \u0022address\u0022 ( minconf )\ngetreceivedbylabel \u0022label\u0022 ( minconf )\ngettransaction \u0022txid\u0022 ( include_watchonly verbose )\ngetunconfirmedbalance\ngetwalletinfo\nimportaddress \u0022address\u0022 ( \u0022label\u0022 rescan p2sh )\nimportmulti \u0022requests\u0022 ( \u0022options\u0022 )\nimportprivkey \u0022privkey\u0022 ( \u0022label\u0022 rescan )\nimportprunedfunds \u0022rawtransaction\u0022 \u0022txoutproof\u0022\nimportpubkey \u0022pubkey\u0022 ( \u0022label\u0022 rescan )\nimportwallet \u0022filename\u0022\nkeypoolrefill ( newsize )\nlistaddressgroupings\nlistlabels ( \u0022purpose\u0022 )\nlistlockunspent\nlistreceivedbyaddress ( minconf include_empty include_watchonly \u0022address_filter\u0022 )\nlistreceivedbylabel ( minconf include_empty include_watchonly )\nlistsinceblock ( \u0022blockhash\u0022 target_confirmations include_watchonly include_removed )\nlisttransactions ( \u0022label\u0022 count skip include_watchonly )\nlistunspent ( minconf maxconf [\u0022address\u0022,...] include_unsafe query_options )\nlistwalletdir\nlistwallets\nloadwallet \u0022filename\u0022\nlockunspent unlock ( [{\u0022txid\u0022:\u0022hex\u0022,\u0022vout\u0022:n},...] )\nremoveprunedfunds \u0022txid\u0022\nrescanblockchain ( start_height stop_height )\nsendmany \u0022\u0022 {\u0022address\u0022:amount} ( minconf \u0022comment\u0022 [\u0022address\u0022,...] replaceable conf_target \u0022estimate_mode\u0022 )\nsendtoaddress \u0022address\u0022 amount ( \u0022comment\u0022 \u0022comment_to\u0022 subtractfeefromamount replaceable conf_target \u0022estimate_mode\u0022 avoid_reuse )\nsethdseed ( newkeypool \u0022seed\u0022 )\nsetlabel \u0022address\u0022 \u0022label\u0022\nsettxfee amount\nsetwalletflag \u0022flag\u0022 ( value )\nsignmessage \u0022address\u0022 \u0022message\u0022\nsignrawtransactionwithwallet \u0022hexstring\u0022 ( [{\u0022txid\u0022:\u0022hex\u0022,\u0022vout\u0022:n,\u0022scriptPubKey\u0022:\u0022hex\u0022,\u0022redeemScript\u0022:\u0022hex\u0022,\u0022witnessScript\u0022:\u0022hex\u0022,\u0022amount\u0022:amount},...] \u0022sighashtype\u0022 )\nunloadwallet ( \u0022wallet_name\u0022 )\nwalletcreatefundedpsbt [{\u0022txid\u0022:\u0022hex\u0022,\u0022vout\u0022:n,\u0022sequence\u0022:n},...] [{\u0022address\u0022:amount},{\u0022data\u0022:\u0022hex\u0022},...] ( locktime options bip32derivs )\nwalletlock\nwalletpassphrase \u0022passphrase\u0022 timeout\nwalletpassphrasechange \u0022oldpassphrase\u0022 \u0022newpassphrase\u0022\nwalletprocesspsbt \u0022psbt\u0022 ( sign \u0022sighashtype\u0022 bip32derivs )\n\n== Zmq ==\ngetzmqnotifications",
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response (help_with_Command)</summary>
 
 ```json
{
  "result": "addnode \u0022node\u0022 \u0022command\u0022\n\nAttempts to add or remove a node from the addnode list.\nOr try a connection to a node once.\nNodes added using addnode (or -connect) are protected from DoS disconnection and are not required to be\nfull nodes/support SegWit as other outbound peers are (though such peers will not be synced from).\n\nArguments:\n1. node       (string, required) The node (see getpeerinfo for nodes)\n2. command    (string, required) \u0027add\u0027 to add a node to the list, \u0027remove\u0027 to remove a node from the list, \u0027onetry\u0027 to try a connection to the node once\n\nResult:\nnull    (json null)\n\nExamples:\n\u003E bitcoin-cli addnode \u0022192.168.0.6:8333\u0022 \u0022onetry\u0022\n\u003E curl --user myusername --data-binary \u0027{\u0022jsonrpc\u0022: \u00221.0\u0022, \u0022id\u0022: \u0022curltest\u0022, \u0022method\u0022: \u0022addnode\u0022, \u0022params\u0022: [\u0022192.168.0.6:8333\u0022, \u0022onetry\u0022]}\u0027 -H \u0027content-type: text/plain;\u0027 http://127.0.0.1:8332/\n",
  "error": null,
  "id": null
}
```
</details>

### logging
##### Gets and sets the logging configuration. When called without an argument, returns the list of categories with status that are currently being debug logged or not. When called with arguments, adds or removes categories from debug logging and return the lists above.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
ServerControl serverControl = new ServerControl(bitcoinClient);

List<LoggingCategories> include = new List<LoggingCategories>();
include.Add(LoggingCategories.addrman);
include.Add(LoggingCategories.estimatefee);

List<LoggingCategories> exclude = new List<LoggingCategories>();
exclude.Add(LoggingCategories.libevent);
exclude.Add(LoggingCategories.proxy);

string logging = await serverControl.Logging();
string logging_filtered = await serverControl.Logging(include, exclude);
            
Console.WriteLine(logging);
Console.WriteLine(logging_filtered);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "net": false,
    "tor": false,
    "mempool": false,
    "http": false,
    "bench": false,
    "zmq": false,
    "walletdb": false,
    "rpc": false,
    "estimatefee": true,
    "addrman": true,
    "selectcoins": false,
    "reindex": false,
    "cmpctblock": false,
    "rand": false,
    "prune": false,
    "proxy": false,
    "mempoolrej": false,
    "libevent": false,
    "coindb": false,
    "qt": false,
    "leveldb": false,
    "validation": false
  },
  "error": null,
  "id": null
}
```
</details>
<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "net": false,
    "tor": false,
    "mempool": false,
    "http": false,
    "bench": false,
    "zmq": false,
    "walletdb": false,
    "rpc": false,
    "estimatefee": true,
    "addrman": true,
    "selectcoins": false,
    "reindex": false,
    "cmpctblock": false,
    "rand": false,
    "prune": false,
    "proxy": false,
    "mempoolrej": false,
    "libevent": false,
    "coindb": false,
    "qt": false,
    "leveldb": false,
    "validation": false
  },
  "error": null,
  "id": null
}
```
</details>

### stop
##### Request a graceful shutdown of Bitcoin Core.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
ServerControl serverControl = new ServerControl(bitcoinClient);

string stop = await serverControl.StopServer();
            
Console.WriteLine(stop);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "Bitcoin Core stopping",
  "error": null,
  "id": null
}
```
</details>

### uptime
##### Returns the total uptime of the server.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
ServerControl serverControl = new ServerControl(bitcoinClient);

string uptime = await serverControl.Uptime();
            
Console.WriteLine(uptime);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": 17,
  "error": null,
  "id": null
}
```
</details>

GENERATING
-----
**[generatetoaddress](#generatetoaddress)**, **[generatetodescriptor](#generatetodescriptor)**


### generatetoaddress
##### Mine blocks immediately to a specified address (before the RPC call returns).
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8334", "alice:pass");

RegTestGenerate regTestGenerate = new RegTestGenerate(bitcoinClient);

string generatetoaddress = await regTestGenerate.GenerateToAddress(100, "bcrt1qtljavjnh8584zc2vrl08gkpcuvlawgm8cd9rfx");

Console.WriteLine(generatetoaddress);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    "6a23d34d58d0f0ab8692198b501a337bb35d1f2043b22802f27151be96e8d103",
    "415fb29bb58482729853aa05b0d04913d186fa7be4e468837b49f68501fcaa33",
    "297cdc3edfdeb711bca1ae9b229d15cc23481207466d74e7b315251f54c60a28",
    "1a328fb0119321602b9d731f16a590c92af58b277a7ebdfdf1fe941a64b223ef",
    "7c4e94da2c96fcf473b2393ef14c54617630c8b6a2f700b5d0021c649d8804cd",
    "031c28d64a737a38d5a873785e0c2cfc55ad1478cca47f9d0bc56338312d457c",
    "2c8f1b461b86323912bcd0ff289e233997a9f6275f21e50bfd5c9aa3e7253772",
    "750e4082bb8c50a9a64ccff2d8868b88c8fb2a61d9b04752ac7a75de08979001",
    "3002a8feb836fc1659bc34475f7929d3e0477950e42551c41ae6da8782648b7f",
    "55831d7157176ee5e8ebf2e0da4b498818dd9c4e5a3ed59d2e3bc07b7b4a1c39",
    "52d1725427040a55c33451c74c013005b587d865b6c2acb303dee1ccfcd20fb1",
    "64d5353b6fc9be2a20ffc8e778438f4def2065adbdd14d66e83770ceefc4f843",
    "05ef835c5667868e1621e32dcb287d7a35d7c0bb29c23060cb737bcae94079e1",
    "5ddaf78f24a2d40c7bdfb4b17f0a49f9a341f85e7f9c1ae5f0318748a097c410",
    "7dce14b894a27a027548c6e556f4bab60646e85e2eddbe6ea2481ed6fbc8f5ae",
    "17772c760d2a1cfad8a8947f0c28248ae6950e4969dac5a9b3b02135a671a9e2",
    "15258b5a443eff2f343fc558af7d1b70a3c504beb1bd019833f02979649f9118",
    "4fdb0d6f18eae5e72f51936a48d3015ba0f7aa0082a1b3ab449e27bb0bbc4a8b",
    "38151bf973829f19145a2716da43c2c061c73c1ba7480d99bd694d083e3a090a",
    "2b345de086e06cc0094938a88da976f0bc8bdda7b314878114adf36d79a49e72",
    "436c4d3e0f6acc7442fb88e7cda9e61be2a1065b10561a5a4399f0434c440911",
    "5244a21d9a50a2e6f6318ebbccbc1aca6d7a81783b57f16439fdd1584ff0ff4d",
    "42a9a6f5747fc9a5bdd9d684e7de15fb67621fd143c7f9703c90725355e28551",
    "04d154b1ca121ad15042b9ebdfb02a5e56e24a833cfa3a1b4173f6c5a017158b",
    "2134b60c09e3cc3a08fea41158b67c453b8d65e6a380c68871fe2ea6f6f291ab",
    "57f95dcdd0891c94897a54a043e973eca9c293c589db73cb0d9c3a3d2b9a0924",
    "715930243d250968b368dcd1eac09cda7d000688a45454b4b2f773c029647e41",
    "2ef84f78bff2bc5e4560d34c1aaf6d08a3b2ebcdae4aac5884c5f0e40bb9a324",
    "64ba31aa4280e5115ebd3bbf3f4780244255dd884e4989f426467cea17dc1135",
    "11089115416eb69c5ef57cbdcc3b4c93dbea0d7d6f9aa6f86433fbfa0dffc711",
    "20ae6a031c12f824841f4de18cafa35eec2c78cf531575ce9229f3a59361d34c",
    "329fcbb82ffccf534a168fb2660f785972bdbd23d21cd2b69cbd71843dd883c9",
    "1895f1835e8dcdb77ed0bf5ac6720a99c82fb9cbc404faadc5b16c626cace4be",
    "6e084c466df1fb27c6086fdbd7f0eabd39b67bc00b9452f5ab4c3bdff34ccd5e",
    "35f27c8a1e7829fb020db1555ee4671d072c28eb1ce7ce4597a747e39a55ed3b",
    "3bea34a97e9b770c2d70ff8a501803a30caeccfff11a31d4b0033641cb596a47",
    "3c6b300442ff27b9daf66c56b61b6c16777998852dfca98311adcf060405ca1e",
    "5d529b66b0ff6caff0dc0e69b069c659b35f7b7690f389a2bab33d4b64246d5b",
    "12c10ea4759e0eedee7a541e924cb0773094a8a691c6a63a1be211d74386cac0",
    "266e57178dc861d78bae980766f5ceae7d5a505ead9aa04ad9e37e7637a9914c",
    "0bbc7a83ff82d1643cb2548aad8d7997a1086da868cc4614585f7253bb5970d1",
    "1b1d93de60825f6bf18114a5ef004b24e3c16187689a03636cebcd31d7e1e25c",
    "16fa1f58a4b4b37aa6975e5193f74e96419e4261cf65e9e2eef265484d7248a6",
    "537251f1a0b59845215d3cea39b84d0b513d33b83269a8c206aa812c247d24bd",
    "1540921d146c80d98200aa9da56b422c00a5f03277e34949591b213319f48343",
    "500622516949f1cea2f8544bf2fc167b17544d62d8eb5c14c0af3f79677cf5bc",
    "75730faba83c241a1c016f301822e263d1f4616e1758efbb2b169703effb30f9",
    "7f8c40a57731396f70fa5fe0089a9fc9ed445ed11b2ffd5eb28f87f8ef8b9951",
    "5c6da71ce54b52ce0c84ba925c8ff3d79477d6e2fb8fa033071f534c50836478",
    "247fd082a06dbc4e0124ea239185fbb4135b747f97b5b0ac6d2055cf0034b6c1",
    "3c8d3498f176cbbf1456007b8428880089147b4094aa3d353d950bd79ab43d10",
    "64dab2d03f338c34526973bdaa886f42e5871b59eb662d0997d58a47be2a47d2",
    "76bf7165d3a52836b84df21402c11f05794ec319da79fb619bbe2a680d1b0004",
    "05b37e03c55ec277f6076dd95ddddf1bfddf11d64b660b7d3a42c8d7c2584d6a",
    "6ea6fd2ae702ddb2ecd898befdcbaf8d885241082a14de699ad9c3b952c5b92f",
    "5217b2edf60f926872b4a56749f781f79bc6181e32d851c69c6fda1eb98562c2",
    "01fc7f5d72d0218fca68263947a260e759056e6efafa2b2e4e4dbec5c895e23b",
    "524783d732f5483908a0a06b45b0485bada52bbf400dd647150e8e691e82a578",
    "3d2c5cc7aca97085f84c4da40114f415aa5f010e1f6731ad9c27462a71e9b489",
    "52fa44288a74f5cc388086c740ad9b50aec64fdb8484fc02fd31912e8a2c92b2",
    "2c37c586ed655461059f4f5b804f81c67d63ce36e91faead701efa53fc3af8ce",
    "1eac275397cd1de95ad04d251b259745993e44498ac8a28454d5866b508696f4",
    "6325adb65c2ee204afa1ae8fd2ab37fe2b09382ddb08309f3294985be049ac82",
    "1961b534df984cc2b96b1bbe1a08f59333a2da5090e1443214d09a7ab77fd5d9",
    "3fc392ab799a9d9a9ce1d72915290766a8522bf2d3d277d49c87523b4ce5fb89",
    "333697913e1143a05e3759a84a87af4d3f03192bc76adbb0a0903611f1fdbb21",
    "022bccaa1eabb064b563d8859b1a4421293205b5e47adc73f15795b5db42c806",
    "36a3da198618b0fb2742f6dd41ba7788adc1abd3cb0427a6e7dea42f97900151",
    "5b21f85e7ae4cfc2ec416755a102ce1d78ca7b2cd26bc57b741063c8f5e47a9f",
    "7c1ac898998b42933861f6f91d35b01aedea7481f20346868ab9046ebf6868b2",
    "47cda225520d5c46b489f058883d3dd7a2c3030f40216ac8bb0d56d0265a9966",
    "1b3bd9ada14d1cd67ac932efc7a169e7665a1bf1150218e09c8f1ed93a63cc94",
    "0895acf355be4c49b76a5411637a02e6737e17d006c3c91aa38906a208f3d7bd",
    "2bf1e45e6184edf10d2c1835fd99a69f997fbd6ccb924ee22ae69e1ef6cce482",
    "252676340231e7409bb7278e2c75e486acc4ed3ffe2a865de58fb941dbba97ff",
    "115c98aa1223f8eeeb56cc06318cc7458d14b0b66571c77bf987b61660fb18c0",
    "0be6ce5bfe801c71d2700a774647202c59190fe67a229b0e24fb6718f52f79a6",
    "273c92678ae254d1fc2e82a960f4c4871884874653f8e0114c9ebe722fa8c7df",
    "794f6484b2833a076c248efa508e23378f79edcab348e4742cbbde31c648d5d8",
    "1e9db6557749fece8eac99690cb65c7f94f889cac331a4e1b1d4b44dc8f0a710",
    "4b7b0ce3b27dc86d601a47a2160700eadcba56c1b1ee53a6b328dd45092e2fe0",
    "431524268e343dfa14e28f5f094810a29af5866f84821c99a0e5ada37f767e22",
    "335c5e8af5aee062728a17148d34db7afcef9f56e252edd7b433f9c6c5dad26e",
    "7ae1057ac508adc1cc4598a21ae097e588709ff69b40e5a3c1b8da49caff441e",
    "67917940be493438bc042c59680be9e748b9c832fb388b91c9ddcdac1784ae7d",
    "07f1f4461cd61ef14a0ae257c3c87b923d596c0884f3958e1cdaaffc04c36491",
    "62e1011b88041b946dcf915d838e22ec02b3dd611c9168f62eb1185221d01478",
    "6f4624a6068dc5581e83b18e5c80009fb5be4d5aabf257248b7c47fd71649d3d",
    "6963ca816cd4e98ee4611f8312fc3023f73a025fe641179eed7ee52b8f9c1d5a",
    "46be8a2cb0887a05393ee2c335e5cb247380e414c94f613c28e7768115993fa1",
    "36f35ac2be4029a2910b0d6638656b388ba2e64557c44baa6363be03870b632f",
    "5e58237dbd0e717e598b6de4b224de8fea4c00f3a384c72f52185da3ac06a976",
    "287d38cbb36d2599cdf0dc92be54efc2295bc9b09f3ce1eab33ea13039e1cdbd",
    "3201575806ac061bbd06784476c406240278cea1ee32986c5c3f9c72e3aea599",
    "1ee5a31deb642ddd5f33a67b8bb58d17c9d2386bc53bd07443f1e9561ca30f62",
    "7535ac8fadb3e87527874226d42183e4014af0ed06836fd6b4fb23931e5983d5",
    "7683368d201eeba4481a47762326f46744802b35b36373a7856acff0fce04abd",
    "54132e583407d419077cf6a9e4f0533118b1519302f35726c291d867e0eb89bc",
    "47b6284b7f7b1c20a1e3d5170aa74ae0a06a30e5e2525aa67dbe372ada17cc63",
    "19cbe144f37bc1a88a07cd247574bac188f9ee642119a06bec43cce14089779b"
  ],
  "error": null,
  "id": null
}
```
</details>

### generatetodescriptor
##### Mine blocks immediately to a specified descriptor (before the RPC call returns).
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8334", "alice:pass");

RegTestGenerate regTestGenerate = new RegTestGenerate(bitcoinClient);

string generatetodescriptor = await regTestGenerate.GenerateToDescriptor(10, "addr(bcrt1qtljavjnh8584zc2vrl08gkpcuvlawgm8cd9rfx)");

Console.WriteLine(generatetodescriptor);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    "6cc635e2403ece05afe8551ae76cd7a646cc75b6dfddedaa3ccdfd9fd65e52c6",
    "4e94f7d4504a80422bac0928a4f9f851b118a5d5449edae3d8c5676a6beb71f1",
    "4c986754ca533967f59894f206a39c41645ffcab2cae46e5e6e61c8404e2b7f1",
    "649af186c05657e7e6f978ffd29286275ed99ba3ae63acc101cf896c65cbf9db",
    "201259e0c13332c9952badae998fda43dae3fb0f59b016cab4e2ceed7de7a0fc",
    "10b04289864e2fddf6bbba810875d017c4e523aebcb0aecd2e9b043040d4ee6d",
    "3b53e5401a98761f85c0d7e0f6844fcdb8a61ac7f7bbb99ceae6a6ff526df112",
    "5f5c75899c30ac7dbae089998ec3650da7667096507e8c2ac8abfaded5b73312",
    "3aaac69717338ca1d67a3a555de9a10647563bfe475e283d595783ea688786d1",
    "70ff725cec1637caa6146e079003d851d9b28f3027a9c75f3e1c74bea2da1907"
  ],
  "error": null,
  "id": null
}
```
</details>



MINING
-----
**[getblocktemplate](#getblocktemplate)**, **[getmininginfo](#getmininginfo)**, **[getnetworkhashps](#getnetworkhashps)**, **[prioritisetransaction](#prioritisetransaction)**, **[submitblock](#submitblock)**, **[submitheader](#submitheader)**


### getblocktemplate
##### It returns data needed to construct a block to work on.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Mining mining = new Mining(bitcoinClient);

GetBlockTemplate getBlockTemplate = new GetBlockTemplate();
getBlockTemplate.Capabilities.Add(Capabilities.coinbasetxn);
getBlockTemplate.Mode = TemplateRequest.template;
getBlockTemplate.Rules = Rules.segwit;

string getblocktemplate = await mining.GetBlockTemplate(getBlockTemplate);
Console.WriteLine(getblocktemplate);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "capabilities": [
      "proposal"
    ],
    "version": 536870912,
    "rules": [],
    "vbavailable": {},
    "vbrequired": 0,
    "previousblockhash": "000000007250814c62b9fae0da1c36c66244d2dbf492853f1ee8c0763d4e1e52",
    "transactions": [
      {
        "data": "02000000000101e67e5dab78ac1348ddb283607bdea036e6806116b9d8c57cc71bac0f3b90320e0100000000feffffff020d112d000000000016001439b6b10af9b464481ef2808609197e9493eccb4fa26ecba5010000001600145f2873f0f554f4b78b8f293df9902c34f079eecc0247304402205d8825ba1c486a4bc7c869389cafbc08fa9622253aedc403210057d1c009d6e502204999a75cf04e1375b89cc8931477c9a0fa17ea10417c25c847656b820bee05f30121030df0476a83320902a31f730907d97e2a8535a78d095cb47f638f612e5d25190db6961b00",
        "txid": "4cf49970f841c5e7325869febfca94baf9185310d93024dbad8103d66218901a",
        "hash": "7f5c99639d1fad846e6cdf99749033d549d363cd971731743db51159203586ef",
        "depends": [],
        "fee": 19679,
        "sigops": 1,
        "weight": 561
      },
      {
        "data": "02000000000101c54f32b710cdf8a9b3a561e8e63d4025e4ccee458a8ae36db654072374d4a9990000000000feffffff02e1cd92b40100000016001412a9cd4f69180bdb3b0493d401511d34f9b5c91096b11a0000000000160014e524798f6343428bd556834461d50844c7b061eb0247304402204e8dfafbc127030c334643ac7a7d1dd7d5d75aa159434773881b1dfba76aadfb022011b4cc9ab5a7cf0769f726cbb27d6544d4679db04fc1db13421d1bea85cf957001210254de3dd05396d951c76ca287b1507685970b27985372d9880c3704290d310335b6961b00",
        "txid": "994050a566c088fc86ff9c77e835ef4a51d5a6d4daca5ef01e5ec7e55fbef437",
        "hash": "eef653665da27ab62653fc2ac1fc74911855fa39fb9ac059e45ec30318446242",
        "depends": [],
        "fee": 19679,
        "sigops": 1,
        "weight": 561
      },
      {
        "data": "020000000001018875db8516132251b796962f4346af754fd4101c9b1289c74bf26e3e966da9470100000000feffffff026a47a77b01000000160014c82636fd7d699ce0aad43674370a0e69ce3717e7b6003a000000000016001400677c3b1b28a7448810740718aba52d958ca14e02473044022003c02da240988e8ed5470ab6935d61713ccb1e486abf0ee304180e316d5b31bc02200fc4168d2db3aa201f66a66ab5ae3d8cc4d99d4d6effe839180a459af1d3df3d012102e78ffe0011bf92e8b9157f10ef35527a3ccaf6bbb49e6c24b78cbcfbe563a939b6961b00",
        "txid": "d538b76bfc07a73c24f035b2a366b06757a72f50b0928ab941e756d1c95ff06c",
        "hash": "4e0760beffcebd7edd41216d08287352fcde5ee67aa48ddecdd901f74fdd38b0",
        "depends": [],
        "fee": 19679,
        "sigops": 1,
        "weight": 561
      },
      {
        "data": "0200000000010173fde03c774b4bbd0151654d14f362a035b1264d6d9d6a7e4e6b80b05048f71c0000000000feffffff024228e9bf0100000016001472f105a60c728f98413295bdc9e272967ef7ea2460ef150000000000160014c75e94fab288ab39372f036151745ef72dacd81202473044022070ebe3c677e497596aec7c9bd03174f11403aa340fe21e0d86fd046d908c86a202204408d6037825236a5d766ba5331705270fe686ab52c33a8c4be0d57783d4c7f301210370cef5aea7c0744a7bd1630ad0a5bfc2b3acb18a5ad62e038d75a9f48e3447fab6961b00",
        "txid": "d19f65f1853a75675511c495548db624f2a2b238e5d5c0205854f7daf46a0083",
        "hash": "fcc37969e55d67d4350ef0cf7b9566a106c67e04cf3921eed48d619e140cf822",
        "depends": [],
        "fee": 19679,
        "sigops": 1,
        "weight": 561
      },
      {
        "data": "02000000000101096df242a4a7b58639bf689e635fd6af89af6a54edd62de5bc139ea20e8449800100000000feffffff020dbdea8d010000001600147e92c8c6be34abfd17188fa334a2cfc2623dbf1e5835120000000000160014f303663181c5f18b38e5f41358940755db7950b70247304402202b9ca8234f7b52763ac6729f151cf05be36c91ca596661283418e8baef8cbc2002201275289c58693e319498f66325ac21f6bbea0f5639150195eb6dc5b3b6dbe65a01210232e31943540c317486c4b1d095271e321bce6556ae926bf91d9bae852f32ab92b6961b00",
        "txid": "df73d226e11e55196dde8f389ec9c99bc4d44c6ffb19bfed8111eb789a94c0e9",
        "hash": "2f1acf4f6319f37098a1e22e6bfe9bcabae8a55e45aec646f7ed9aa2c2505084",
        "depends": [],
        "fee": 19679,
        "sigops": 1,
        "weight": 561
      },
      {
        "data": "02000000000101d79cfccb9832c9d1a1ffcea93e7078a54234ee920cf62bd4abe6849437522e8b000000001716001469b60ba9807a3b550d325b8791ac4e15448c9fddfeffffff02bad2370000000000160014962a6a11c18b9b4b0ecd9316b5fe69261d494aa33294d9eb010000001600144bb800692c3372db68def4456441183e3f79843b0247304402203c8c6714c884756603760d0626daa1067568dc6396ed77ab2fe77ca646c62838022067b75ee1887db5ef46e984f106373ddeb523a21e82b51c8e39edf53add93877a01210258d54036352b5a96de2d53b9b2f4a901cfa941393348bc26a5289a3c1d90c036a9961b00",
        "txid": "603b89b0837ffde6505d03a857c1f302a307028e38661a4df4659ee32e36c81e",
        "hash": "a2b322e68e29fd187be51691afae89e8f07002dfa371081ffb7e2f602573974a",
        "depends": [],
        "fee": 22889,
        "sigops": 1,
        "weight": 653
      },
      {
        "data": "02000000000101197fa0c5a6c094a6087e12144c1711eae3ba2513cb283e1a1cef0d9930b8af9200000000171600141e59c794ddfaa52360124e1c884500ba84b179affeffffff02f7b712000000000016001445078f524953058b31e75483e8a0025da4b341b87cbc689a01000000160014ab147006312d3e2eab3461189f401f7c6cbca2dc0247304402206c663dc0f7e818cc420bfd8728b53058008248104e77803029e06a6c2a84e41d02203a6277c35a45a410deac0b69853de1f8a341ece5a45cc34d7c62635f09ab12ef01210247a991aa518c4955cef19c25e1265f7ae886615cd7222febb8991322e691b13db6961b00",
        "txid": "e42c909224a28c5195cf369406f50d3ca17f9b13ec1025cc4c1b14925786fc35",
        "hash": "8c053d58297d9a0ee213533c4099d03ec73c26755e7630079ebff834abe8e447",
        "depends": [],
        "fee": 22889,
        "sigops": 1,
        "weight": 653
      },
      ...
      {
        "data": "02000000000101c451dca61441589e690260a4a7d337ef60518956c8b0ab6b5c924bfd5e1b4d2a0000000000feffffff0295949b00000000001600146f011249160a29d6970ee5d7a1b16390b7ee2cbf088e01000000000017a91402c6c8874d4d39f9122b522975175a45c852079d870247304402200a6dd1d4a0db032a9e18da35a2225b2b137dc191a2e8496580c2a378e08cfcad02200e0849937223132621546f19a085292b083d9c96aa420bf4aeff3c8527fbf372012103c5fa46d8133dd2a7fbdd23d7a1c74be1ed55a08e3a231042f1864e4caa720fd8b6961b00",
        "txid": "f1d023587a32da77c72a9eff7d1729b068bd1d35c64b21cfce417d2545b830ad",
        "hash": "34ad93f2f531e991f1463a2e3ed2020f1f15815b806f642fd9da9f4b00c5a9d6",
        "depends": [],
        "fee": 142,
        "sigops": 1,
        "weight": 565
      },
      {
        "data": "020000000001011cde9b27cfcc12ef180fb1bca372f563e6f3fdbe4a798e88648585763d46fbc50000000000feffffff0241401500000000001600144fa628306a32bc86f57e13275274a04d4290d0bf5a8e01000000000017a914c66248d2b5778df652423d59a85a61be40c51d2287024730440220503134b982301279909abcbfe15b34505a2453785905e743d3ef9f366ee7e6de02204c76b5ddb001cdf351869078c324fafdce22caf5830bba94d2e4a60107b24eae012102b812e4b3fbeb0960cefd51f05bf5c6fdaac7b3eb0e35d8a992a4881de790ef0db6961b00",
        "txid": "d0459aa464cfbb544a884cbaeddf44567d9049bd97daccb546b3fde53a6e13b4",
        "hash": "387aa283eccaf1d929b1769ead9c13459386f2d8b35ecee110d35a1120acfa2f",
        "depends": [],
        "fee": 142,
        "sigops": 1,
        "weight": 565
      },
      {
        "data": "02000000000101668d090e63a8cad2d92cf102d29d90373dab82487a1fdd883ecf1b17cdc880ca01000000171600148dcf751d9def1441a66ab68956c8026c8462374afeffffff02f64a12000000000017a91450c1082e10cbb42973ebec1da626d55cddc4e80b8740420f000000000017a9147998d036bbb8e4f5ab025e295503be350d4e308f8702473044022077b92bf95575b47cf6f7ff22b66259700bc5ba1ff4fe8cc2782f5f5957f12f6802207c6484d465b94e8ed0b09bdf61822e0c90daf17807e176442dd5ed18127086a70121026b221376e8322e17ddcd337dcd2aafd561daf5ba08e6e533a6943fbcabb733b8b6961b00",
        "txid": "f0292efb27ecc6a4735c1c4ea786a716f9639f074d5c3f02452aa449cc8977bd",
        "hash": "cc3adee6a9332c2e3e4bb44f24785cbf328f0b674f7bf9b9a9900add87c23354",
        "depends": [],
        "fee": 166,
        "sigops": 1,
        "weight": 661
      },
      {
        "data": "0200000000010148357298fc7054415a744837f96a8207c6dd2c3ddb26b9c54dc2dfd923af99c90000000017160014b4f24a29b58228e97a6c8500a9472c52e597fe95feffffff0240420f000000000017a91401fba8a63f7c4a836c3584e7b33f898cabce413387f64a12000000000017a914fbebb81993727a479e4fe8231fa27fc4f2365da587024730440220051e3012170e5934784a6458200c9105b256e38e2804f32b82a58817b5c2023902201f73d363791f05d05ef3cd4ba2c8004c54cc51b279bab8f8dc4acf46262df0bf012102e9fd27d345644c228a12769b260968ce3735c814345191c75a91911c343ac757b6961b00",
        "txid": "6417e29a043e62283103fa527c5097257b32e4c947bd0fc4399c0f4cdf3346c0",
        "hash": "7d9d1a52952392f0783d9dfd07b63f0cc3d110e6b4d5d342d291aea198929e0c",
        "depends": [],
        "fee": 166,
        "sigops": 1,
        "weight": 661
      },
      {
        "data": "02000000000103e903f03e99b32264257548ee700e62b3349b5b8abd535907169ec6391d26ed760000000017160014b5d5a81ba37d47ad5fe276b23f3973f56b70a459fefffffff273542b9535f2a1bbe00f13bfeb0cbaac3df27aea8426b045e641a286ebc8000000000000feffffffb4efb01703acdfd931d14e36120ad20ebfa6052c6f2623ba32718f7063d907db00000000171600147af2e87a43f5370b17bb0bd0ea18849e123ba61afeffffff02801a060000000000160014f781ce508843c9ac5c09c380ee1f5317d6fbe08b04c21000000000001600146b947271f3ba4c1d6c91db741fc501880d3bf0f8024730440220014ba938565e6dd2ce1c65f3f56736d5575918fdf7a0219d6e3ab5bd6f86577c022057190ecb87c5efc8e296c4a8cae374dda55781e698e5414ce4e4edceb3fafb750121038a51c7db5ab7377e8d5f9a06be6b6b46c900df51af9495a79f3ef01a46c71f490247304402202fb16f69a903c0b6c3546a5ed95a1024169e921c587cf9671f5ba834f9af86b902204298bd2fe0fc297d84e6e1716e1cc0299e5f3ecb601c8476b2d0827055e884160121022ae757b9ee4af41242cf637046fb331b273f5fbf8539369af2a4e60841a4493f0247304402204fc29cb107043201c1bab1d10483d9413cef5c0f81ffa4bcdbdf688dfff624a20220053fda7683d43e67c41ef86a6f5a0ed1cc63243b08cc12f3e5f542fe0e74571e01210253d9126db8349ae5550fadd02ebe612fea2dd239ba32f1029342d407d4ab6fbab6961b00",
        "txid": "793f0ec86bb2dc5ea77fe727f726a8ee76e2f0ca80a2e37ad0e988ee714a43c1",
        "hash": "dd52781cc4138cfa002e41abc5a39f633aecb8946b0ff01a8fb5863e8d091329",
        "depends": [],
        "fee": 322,
        "sigops": 3,
        "weight": 1287
      },
      {
        "data": "020000000001028941b379e6e3ab44233716e3ab0a15783f662e9a8d70257794252e09b56cde9901000000171600142e1fee54ae9ce9aeb85a5cda338715a66698b9aafeffffff237e04fc62b4a567d0876820f3d6ce69b4872e814314e6d22927e3c141bc790d01000000171600140e12ff7bb5ecddb90fc2fd25609571ee618f3a63feffffff020acc13000000000017a9145e7f10b1b87940092dd10e0d941c7fd835a5544e8740420f000000000017a914eab6a78210d2a55226f19836eb77dd2ff220c4d887024730440220509b9e8899c9b52a6accae9c2627ace46c5f1d294650498c9dcc72bf43eaebac02202be1727b9d085b121f217ad0f46369860a7787a8523a4f41480b77f04d44c9f001210260319f2e2caab7b183d5a8e28cac42da3f19d9e1ca6bfecf6df1b589a4d0d66a024730440220797e31e44f68b5afcba6ed7d8fcd6dac9c11b91750d73fdcd58c2f06857026e102202572cefded1aaa516975d37eef3748a75afc70ad883525bbe0ce57b81ff0a365012102216e5a10ac16f97defbe9b2f706facedb42e05319adda2ea7a7211c601022688b6961b00",
        "txid": "e25cd81f0fdab13fad69b273225f545eb7eac34d9c6f1258275200c66cba64cc",
        "hash": "e2109ed15210ce6455125d295e93f6d4cb674acec69d957813517d1d0df7039c",
        "depends": [],
        "fee": 256,
        "sigops": 2,
        "weight": 1024
      },
     ...
      {
        "data": "0200000000010235a619a8187300da8ee225efddb09553488fec9f349e1a754c92e02fe0c28ff8010000001716001420b4e20f80e519e101acc9288134e6e8d280aa18feffffff4010fa1b5155051e0f138c7fce1a25e90a07a7e0ed917fc707fe7adfb0de97d101000000171600148444192ab9b3fc985aa41cdb4301f8bb66d59873feffffff02b0a916000000000017a914c5ae597a6dc819afd4058ac4ceb6c8a5e0af9b2a8740420f00000000001976a9145e95e0cfe31f65ae3bb43bf18b525e84a5dfc51288ac0247304402203e78a9c4df8b6f18c15eacec49e72023b1852933fbc6df12f25eed4bed0f8d2a02206d7c20842d3feae997355e9334de2b1dc74e27d358bc0710854a136ba67f25840121037aacbf0cd42edc6433089ff4068a3e17f56dd95255bacc4ca6cc6f8d8572e5080247304402206f98bafd9ddaf8b414a32ff5a9ef70f8ce0ebdacd005d37d1ec44b38db9a2118022007d0210e2b26c29846bd98e42233939065c3ae25e894421b33800c661c849b1801210333ef294d19af172d6ec1e7f63ffd7d9c598f809072b97a332a8ddb148327084bb6961b00",
        "txid": "a0edd298b1d0da59d45aa07fe114172bbf0e7c6fea31dfe420ccb0fb3f964bfe",
        "hash": "27ab5e3683b8a0c4824293fd2e8e4b40bb27ac0b008ca93ff61b48199be66911",
        "depends": [],
        "fee": 258,
        "sigops": 6,
        "weight": 1032
      }
    ],
    "coinbaseaux": {},
    "coinbasevalue": 19916039,
    "longpollid": "000000007250814c62b9fae0da1c36c66244d2dbf492853f1ee8c0763d4e1e52406",
    "target": "0000000000000151da0000000000000000000000000000000000000000000000",
    "mintime": 1598085307,
    "mutable": [
      "time",
      "transactions",
      "prevblock"
    ],
    "noncerange": "00000000ffffffff",
    "sigoplimit": 80000,
    "sizelimit": 4000000,
    "weightlimit": 4000000,
    "curtime": 1598090712,
    "bits": "1a0151da",
    "height": 1808055,
    "default_witness_commitment": "6a24aa21a9ed9ae37cdeaedad09163d8ee86ebb3bc644d068fcd321b147e391ea2faf7df46e4"
  },
  "error": null,
  "id": null
}
```
</details>

### getmininginfo
##### Returns a json object containing mining-related information.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");

Mining mining = new Mining(bitcoinClient);

string getmininginfo = await mining.GetMiningInfo();

Console.WriteLine(getmininginfo);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "blocks": 1808054,
    "currentblockweight": 144973,
    "currentblocktx": 81,
    "difficulty": 1,
    "networkhashps": 23772946303410.9,
    "pooledtx": 123,
    "chain": "test",
    "warnings": "Warning: unknown new rules activated (versionbit 28)"
  },
  "error": null,
  "id": null
}
```
</details>

### getnetworkhashps
##### Returns the estimated network hashes per second based on the last n blocks.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");

Mining mining = new Mining(bitcoinClient);

string getnetworkhashps = await mining.GetNetworkHashPS();

Console.WriteLine(getnetworkhashps);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": 23772946303410.9,
  "error": null,
  "id": null
}
```
</details>

### prioritisetransaction
##### Accepts the transaction into mined blocks at a higher (or lower) priority.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Mining mining = new Mining(bitcoinClient);

string txid = "4f642090847babf1e09e63e6be63a446c5327a30c5b6d41cd533b90a2df8ef01";
string prioritisetransaction = await mining.PrioritiseTransaction(txid, 2);
            
Console.WriteLine(BitcoinRpc.Debug.JsonRequest.GetRequestAsString(true));
Console.WriteLine(prioritisetransaction);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": true,
  "error": null,
  "id": null
}
```
</details>

### submitblock
##### Attempts to submit new block to network.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
Mining mining = new Mining(bitcoinClient);

string hexdata = "0100000000000000000000000000000000000000000000000000000000000000000000003BA3EDFD7A7B12B27AC72C3E67768F617FC81BC3888A51323A9FB8AA4B1E5E4A29AB5F49FFFF001D1DAC2B7C0101000000010000000000000000000000000000000000000000000000000000000000000000FFFFFFFF4D04FFFF001D0104455468652054696D65732030332F4A616E2F32303039204368616E63656C6C6F72206F6E206272696E6B206F66207365636F6E64206261696C6F757420666F722062616E6B73FFFFFFFF0100F2052A01000000434104678AFDB0FE5548271967F1A67130B7105CD6A828E03909A67962E0EA1F61DEB649F6BC3F4CEF38C4F35504E51EC112DE5C384DF7BA0B8D578A4C702B6BF11D5FAC00000000";

string submitblock = await mining.SubmitBlock(hexdata);
Console.WriteLine(submitblock);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "inconclusive",
  "error": null,
  "id": null
}
```
</details>

### submitheader
##### Decode the given hexdata as a header and submit it as a candidate chain tip if valid.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
Mining mining = new Mining(bitcoinClient);

string hexdata = "0100000000000000000000000000000000000000000000000000000000000000000000003BA3EDFD7A7B12B27AC72C3E67768F617FC81BC3888A51323A9FB8AA4B1E5E4A29AB5F49FFFF001D1DAC2B7C0101000000010000000000000000000000000000000000000000000000000000000000000000FFFFFFFF4D04FFFF001D0104455468652054696D65732030332F4A616E2F32303039204368616E63656C6C6F72206F6E206272696E6B206F66207365636F6E64206261696C6F757420666F722062616E6B73FFFFFFFF0100F2052A01000000434104678AFDB0FE5548271967F1A67130B7105CD6A828E03909A67962E0EA1F61DEB649F6BC3F4CEF38C4F35504E51EC112DE5C384DF7BA0B8D578A4C702B6BF11D5FAC00000000";

string submitheader = await mining.SubmitHeader(hexdata);
Console.WriteLine(submitheader);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": {
    "code": -25,
    "message": "Must submit previous header (0000000000000000000000000000000000000000000000000000000000000000) first"
  },
  "id": null
}
```
</details>


NETWORK
-----
**[addnode](#addnode)**, **[clearbanned](#clearbanned)**, **[disconnectnode](#disconnectnode)**, **[getaddednodeinfo](#getaddednodeinfo)**, **[getconnectioncount](#getconnectioncount)**, **[getnettotals](#getnettotals)**, **[getnetworkinfo](#getnetworkinfo)**, **[getnodeaddresses](#getnodeaddresses)**, **[getpeerinfo](#getpeerinfo)**, **[listbanned](#listbanned)**, **[ping](#ping)**, **[setban](#setban)**, **[setnetworkactive](#setnetworkactive)**


### addnode
##### Attempts to add or remove a node from the addnode list.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
Network network = new Network(bitcoinClient);

string addnode = await network.AddNode("43.225.62.107:8333", NodeCommand.add);
string removeNode = await network.AddNode("43.225.62.107:8333", NodeCommand.remove);
            
Console.WriteLine(addnode);
Console.WriteLine(removeNode);
```

<details>
  
  <summary>Server response (addnode)</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

<details>
  
  <summary>Server response (removeNode)</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### clearbanned
##### Clear all banned IPs.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Network network = new Network(bitcoinClient);

string clearbanned = await network.ClearBanned();

Console.WriteLine(clearbanned);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### disconnectnode
##### Immediately disconnects from the specified peer node.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
Network network = new Network(bitcoinClient);

string disconnectnode_byAddress = await network.DisconnectNode("134.209.27.213:8333");
string disconnectnode_byNodeId = await network.DisconnectNode(2);
            
Console.WriteLine(disconnectnode_byAddress);
Console.WriteLine(disconnectnode_byNodeId);
```

<details>
  
  <summary>Server response (disconnectnode_byAddress)</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

<details>
  
  <summary>Server response (disconnectnode_byNodeId)</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### getaddednodeinfo
##### Returns information about the given added node, or all added nodes.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
Network network = new Network(bitcoinClient);
            
string getaddednodeinfo_All = await network.GetAddedNodeInfo();
string getaddednodeinfo_Specific = await network.GetAddedNodeInfo("47.113.95.224:8333");

Console.WriteLine(getaddednodeinfo_All);
Console.WriteLine(getaddednodeinfo_Specific);
```

<details>
  
  <summary>Server response (getaddednodeinfo_All)</summary>
 
 ```json
{
  "result": [
    {
      "addednode": "195.206.105.22:8333",
      "connected": true,
      "addresses": [
        {
          "address": "195.206.105.22:8333",
          "connected": "outbound"
        }
      ]
    },
    {
      "addednode": "47.113.95.224:8333",
      "connected": true,
      "addresses": [
        {
          "address": "47.113.95.224:8333",
          "connected": "outbound"
        }
      ]
    }
  ],
  "error": null,
  "id": null
}
```
</details>

<details>
  
  <summary>Server response (getaddednodeinfo_Specific)</summary>
 
 ```json
{
  "result": [
    {
      "addednode": "47.113.95.224:8333",
      "connected": true,
      "addresses": [
        {
          "address": "47.113.95.224:8333",
          "connected": "outbound"
        }
      ]
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### getconnectioncount
##### Returns the number of connections to other nodes.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Network network = new Network(bitcoinClient);
            
string getconnectioncount = await network.GetConnectionCount();

Console.WriteLine(getconnectioncount);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": 13,
  "error": null,
  "id": null
}
```
</details>

### getnettotals
##### Returns information about network traffic, including bytes in, bytes out, and current time.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Network network = new Network(bitcoinClient);

string getnettotals = await network.GetNetTotals();

Console.WriteLine(getnettotals);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "totalbytesrecv": 18109462,
    "totalbytessent": 1276312,
    "timemillis": 1598093153465,
    "uploadtarget": {
      "timeframe": 86400,
      "target": 0,
      "target_reached": false,
      "serve_historical_blocks": true,
      "bytes_left_in_cycle": 0,
      "time_left_in_cycle": 0
    }
  },
  "error": null,
  "id": null
}
```
</details>

### getnetworkinfo
##### Returns an object containing various state info regarding P2P networking.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Network network = new Network(bitcoinClient);

string getnetworkinfo = await network.GetNetworkInfo();

Console.WriteLine(getnetworkinfo);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "version": 200000,
    "subversion": "/Satoshi:0.20.0/",
    "protocolversion": 70015,
    "localservices": "0000000000000408",
    "localservicesnames": [
      "WITNESS",
      "NETWORK_LIMITED"
    ],
    "localrelay": true,
    "timeoffset": 0,
    "networkactive": true,
    "connections": 13,
    "networks": [
      {
        "name": "ipv4",
        "limited": false,
        "reachable": true,
        "proxy": "",
        "proxy_randomize_credentials": false
      },
      {
        "name": "ipv6",
        "limited": false,
        "reachable": true,
        "proxy": "",
        "proxy_randomize_credentials": false
      },
      {
        "name": "onion",
        "limited": true,
        "reachable": false,
        "proxy": "",
        "proxy_randomize_credentials": false
      }
    ],
    "relayfee": 0.00001000,
    "incrementalfee": 0.00001000,
    "localaddresses": [],
    "warnings": ""
  },
  "error": null,
  "id": null
}
```
</details>

### getnodeaddresses
##### Return known addresses which can potentially be used to find new nodes in the network.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Network network = new Network(bitcoinClient);

string getnodeaddresses = await network.GetNodeAddresses();

Console.WriteLine(getnodeaddresses);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    {
      "time": 1596549781,
      "services": 1033,
      "address": "45.16.97.187",
      "port": 8333
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### getpeerinfo
##### Returns data about each connected network node as a json array of objects.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Network network = new Network(bitcoinClient);

string getpeerinfo = await network.GetPeerInfo();

Console.WriteLine(getpeerinfo);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    {
      "id": 0,
      "addr": "144.76.15.207:8333",
      "addrlocal": "37.229.74.123:50977",
      "addrbind": "192.168.1.5:50977",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093295,
      "lastrecv": 1598093295,
      "bytessent": 151214,
      "bytesrecv": 15275081,
      "conntime": 1598092011,
      "timeoffset": 2,
      "pingtime": 0.034179,
      "minping": 0.032542,
      "version": 70015,
      "subver": "/Satoshi:0.19.1/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644827,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 750,
        "feefilter": 32,
        "getaddr": 24,
        "getblocktxn": 3709,
        "getdata": 21943,
        "getheaders": 1053,
        "headers": 25,
        "inv": 119041,
        "notfound": 338,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 99,
        "sendheaders": 24,
        "tx": 3322,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 31282,
        "block": 12859953,
        "blocktxn": 2040192,
        "cmpctblock": 44859,
        "feefilter": 32,
        "getdata": 579,
        "getheaders": 1053,
        "headers": 916,
        "inv": 64652,
        "notfound": 898,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 229721,
        "verack": 24,
        "version": 126
      }
    },
    {
      "id": 1,
      "addr": "212.51.144.42:8333",
      "addrlocal": "37.229.74.123:50979",
      "addrbind": "192.168.1.5:50979",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093294,
      "lastrecv": 1598093294,
      "bytessent": 146260,
      "bytesrecv": 390925,
      "conntime": 1598092012,
      "timeoffset": 1,
      "pingtime": 0.042737,
      "minping": 0.040768,
      "version": 70015,
      "subver": "/Satoshi:0.20.0/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644827,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 980,
        "feefilter": 32,
        "getaddr": 24,
        "getdata": 28915,
        "getheaders": 1053,
        "headers": 25,
        "inv": 114287,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 30722,
        "feefilter": 32,
        "getheaders": 1053,
        "headers": 424,
        "inv": 70011,
        "notfound": 1003,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 286736,
        "verack": 24,
        "version": 126
      }
    },
    {
      "id": 3,
      "addr": "46.166.173.49:8333",
      "addrlocal": "37.229.74.123:50985",
      "addrbind": "192.168.1.5:50985",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093297,
      "lastrecv": 1598093296,
      "bytessent": 167931,
      "bytesrecv": 156606,
      "conntime": 1598092024,
      "timeoffset": 0,
      "pingtime": 0.081446,
      "minping": 0.044578,
      "version": 70015,
      "subver": "/Satoshi:0.20.0/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644827,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 835,
        "feefilter": 32,
        "getaddr": 24,
        "getdata": 6307,
        "getheaders": 1053,
        "headers": 106,
        "inv": 151145,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 7485,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 30832,
        "feefilter": 32,
        "getdata": 909,
        "getheaders": 1053,
        "headers": 424,
        "inv": 33095,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 89317,
        "verack": 24,
        "version": 126
      }
    },
    {
      "id": 6,
      "addr": "18.232.70.84:8333",
      "addrlocal": "37.229.74.123:50991",
      "addrbind": "192.168.1.5:50991",
      "services": "000000000000040d",
      "servicesnames": [
        "NETWORK",
        "BLOOM",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093296,
      "lastrecv": 1598093297,
      "bytessent": 156391,
      "bytesrecv": 707387,
      "conntime": 1598092032,
      "timeoffset": -1,
      "pingtime": 0.123588,
      "minping": 0.122352,
      "version": 70015,
      "subver": "/Satoshi:0.16.0/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644827,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 1150,
        "feefilter": 32,
        "getaddr": 24,
        "getdata": 52647,
        "getheaders": 1053,
        "inv": 96300,
        "notfound": 205,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 4036,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 30637,
        "feefilter": 32,
        "getdata": 571,
        "headers": 424,
        "inv": 85687,
        "notfound": 2810,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 586282,
        "verack": 24,
        "version": 126
      }
    },
    {
      "id": 7,
      "addr": "54.184.180.139:8333",
      "addrlocal": "37.229.74.123:50993",
      "addrbind": "192.168.1.5:50993",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093295,
      "lastrecv": 1598093275,
      "bytessent": 146325,
      "bytesrecv": 479359,
      "conntime": 1598092038,
      "timeoffset": 1,
      "pingtime": 0.205379,
      "minping": 0.193812,
      "version": 70015,
      "subver": "/Satoshi:0.19.0.1/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644828,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 1225,
        "feefilter": 32,
        "getaddr": 24,
        "getdata": 20333,
        "getheaders": 1053,
        "headers": 25,
        "inv": 121090,
        "notfound": 61,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 1538,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 30692,
        "feefilter": 32,
        "getdata": 266,
        "getheaders": 1053,
        "headers": 318,
        "inv": 60916,
        "notfound": 1360,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 383776,
        "verack": 24,
        "version": 128
      }
    },
    {
      "id": 12,
      "addr": "189.34.14.93:8333",
      "addrlocal": "37.229.74.123:51004",
      "addrbind": "192.168.1.5:51004",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": false,
      "lastsend": 1598093258,
      "lastrecv": 1598093281,
      "bytessent": 2103,
      "bytesrecv": 2822,
      "conntime": 1598092058,
      "timeoffset": -1,
      "pingtime": 0.285172,
      "minping": 0.284823,
      "version": 70015,
      "subver": "/Satoshi:0.19.1/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644828,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00000000,
      "bytessent_per_msg": {
        "getheaders": 1053,
        "headers": 106,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 475,
        "feefilter": 32,
        "getheaders": 1053,
        "headers": 318,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      }
    },
    {
      "id": 14,
      "addr": "116.202.245.89:8333",
      "addrlocal": "37.229.74.123:51006",
      "addrbind": "192.168.1.5:51006",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093294,
      "lastrecv": 1598093290,
      "bytessent": 139552,
      "bytesrecv": 389815,
      "conntime": 1598092059,
      "timeoffset": 0,
      "pingtime": 0.03402,
      "minping": 0.033238,
      "version": 70015,
      "subver": "/Satoshi:0.20.0(Gunbot Official Node, by Gunthy.org)/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644828,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 1015,
        "feefilter": 32,
        "getaddr": 24,
        "getdata": 23829,
        "getheaders": 1053,
        "headers": 106,
        "inv": 112549,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 30522,
        "feefilter": 32,
        "getheaders": 1053,
        "headers": 318,
        "inv": 63694,
        "notfound": 449,
        "ping": 352,
        "pong": 352,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 292766,
        "verack": 24,
        "version": 163
      }
    },
    {
      "id": 16,
      "addr": "98.146.119.124:8333",
      "addrbind": "192.168.1.5:51087",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093294,
      "lastrecv": 1598093294,
      "bytessent": 104412,
      "bytesrecv": 263484,
      "conntime": 1598092438,
      "timeoffset": 1,
      "pingtime": 0.206196,
      "minping": 0.204188,
      "version": 70015,
      "subver": "/Satoshi:0.19.0.1/",
      "inbound": false,
      "addnode": true,
      "startingheight": 644828,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 540,
        "feefilter": 32,
        "getaddr": 24,
        "getdata": 16462,
        "getheaders": 1053,
        "headers": 106,
        "inv": 84304,
        "ping": 256,
        "pong": 256,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 1139,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 30532,
        "feefilter": 32,
        "getdata": 244,
        "getheaders": 1053,
        "headers": 318,
        "inv": 43883,
        "notfound": 557,
        "ping": 256,
        "pong": 256,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 186111,
        "verack": 24,
        "version": 128
      }
    },
    {
      "id": 19,
      "addr": "18.217.164.147:8333",
      "addrlocal": "37.229.74.123:51113",
      "addrbind": "192.168.1.5:51113",
      "services": "000000000000040d",
      "servicesnames": [
        "NETWORK",
        "BLOOM",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": false,
      "lastsend": 1598093214,
      "lastrecv": 1598093214,
      "bytessent": 1719,
      "bytesrecv": 2293,
      "conntime": 1598092733,
      "timeoffset": 0,
      "pingtime": 0.142939,
      "minping": 0.141931,
      "version": 70015,
      "subver": "/Satoshi:0.18.1/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644828,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00000000,
      "bytessent_per_msg": {
        "getheaders": 1053,
        "headers": 106,
        "ping": 160,
        "pong": 160,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 330,
        "feefilter": 32,
        "getheaders": 1053,
        "headers": 318,
        "ping": 160,
        "pong": 160,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      }
    },
    {
      "id": 23,
      "addr": "75.3.206.157:8333",
      "addrlocal": "37.229.74.123:51127",
      "addrbind": "192.168.1.5:51127",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093293,
      "lastrecv": 1598093295,
      "bytessent": 65134,
      "bytesrecv": 147046,
      "conntime": 1598092767,
      "timeoffset": -1,
      "pingtime": 0.160426,
      "minping": 0.158789,
      "version": 70015,
      "subver": "/Satoshi:0.20.0/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644828,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 585,
        "feefilter": 32,
        "getaddr": 24,
        "getdata": 8309,
        "getheaders": 1053,
        "headers": 212,
        "inv": 54359,
        "ping": 160,
        "pong": 160,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 30277,
        "feefilter": 32,
        "getheaders": 1053,
        "headers": 212,
        "inv": 27289,
        "notfound": 219,
        "ping": 160,
        "pong": 160,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 87404,
        "verack": 24,
        "version": 126
      }
    },
    {
      "id": 26,
      "addr": "13.126.144.12:8333",
      "addrlocal": "37.229.74.123:51130",
      "addrbind": "192.168.1.5:51130",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093296,
      "lastrecv": 1598093297,
      "bytessent": 64434,
      "bytesrecv": 125106,
      "conntime": 1598092769,
      "timeoffset": 0,
      "pingtime": 0.146912,
      "minping": 0.146912,
      "version": 70015,
      "subver": "/Satoshi:0.19.1/",
      "inbound": false,
      "addnode": false,
      "startingheight": 644829,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 415,
        "feefilter": 32,
        "getaddr": 24,
        "getdata": 6439,
        "getheaders": 1053,
        "headers": 106,
        "inv": 55805,
        "ping": 160,
        "pong": 160,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 30252,
        "feefilter": 32,
        "getheaders": 1053,
        "headers": 212,
        "inv": 29435,
        "ping": 160,
        "pong": 160,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 63562,
        "verack": 24,
        "version": 126
      }
    },
    {
      "id": 29,
      "addr": "47.113.95.224:8333",
      "addrlocal": "37.229.74.123:51146",
      "addrbind": "192.168.1.5:51146",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093295,
      "lastrecv": 1598093297,
      "bytessent": 41451,
      "bytesrecv": 67214,
      "conntime": 1598092972,
      "timeoffset": 1,
      "pingtime": 0.464409,
      "minping": 0.246331,
      "version": 70015,
      "subver": "/Satoshi:0.19.0.1/",
      "inbound": false,
      "addnode": true,
      "startingheight": 644829,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "addr": 250,
        "feefilter": 32,
        "getaddr": 24,
        "getdata": 1261,
        "getheaders": 1053,
        "headers": 106,
        "inv": 38293,
        "ping": 96,
        "pong": 96,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "addr": 30192,
        "feefilter": 32,
        "getheaders": 1053,
        "headers": 212,
        "inv": 19168,
        "notfound": 61,
        "ping": 96,
        "pong": 96,
        "sendcmpct": 66,
        "sendheaders": 24,
        "tx": 16062,
        "verack": 24,
        "version": 128
      }
    },
    {
      "id": 32,
      "addr": "195.206.105.22:8333",
      "addrbind": "192.168.1.5:51166",
      "services": "0000000000000409",
      "servicesnames": [
        "NETWORK",
        "WITNESS",
        "NETWORK_LIMITED"
      ],
      "relaytxes": true,
      "lastsend": 1598093294,
      "lastrecv": 1598093294,
      "bytessent": 1519,
      "bytesrecv": 1497,
      "conntime": 1598093293,
      "timeoffset": 0,
      "pingtime": 0.278642,
      "minping": 0.278642,
      "version": 70015,
      "subver": "/Satoshi:0.19.0.1/",
      "inbound": false,
      "addnode": true,
      "startingheight": 644830,
      "banscore": 0,
      "synced_headers": 644830,
      "synced_blocks": 644830,
      "inflight": [],
      "whitelisted": false,
      "permissions": [],
      "minfeefilter": 0.00001000,
      "bytessent_per_msg": {
        "feefilter": 32,
        "getaddr": 24,
        "getheaders": 1053,
        "headers": 106,
        "ping": 32,
        "pong": 32,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 126
      },
      "bytesrecv_per_msg": {
        "feefilter": 32,
        "getheaders": 1053,
        "headers": 106,
        "ping": 32,
        "pong": 32,
        "sendcmpct": 66,
        "sendheaders": 24,
        "verack": 24,
        "version": 128
      }
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### listbanned
##### List all banned IPs/Subnets.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Network network = new Network(bitcoinClient);

string listbanned = await network.ListBanned();

Console.WriteLine(listbanned);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [],
  "error": null,
  "id": null
}
```
</details>

### ping
##### Requests that a ping be sent to all other nodes, to measure ping time.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Network network = new Network(bitcoinClient);

string ping = await network.Ping();

Console.WriteLine(ping);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### setban
##### Attempts to add or remove an IP/Subnet from the banned list.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Network network = new Network(bitcoinClient);

SetBan setBan = new SetBan();
setBan.Absolute = true;
setBan.BanCommand = BanCommand.add;
setBan.Subnet = "192.168.0.6";
setBan.BanTime = 86400;

string setban = await network.SetBan(setBan);

Console.WriteLine(setban);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### setnetworkactive
##### Disable/enable all p2p network activity.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");

Network network = new Network(bitcoinClient);

string setnetworkactive = await network.SetNetworkActive(true);

Console.WriteLine(setnetworkactive);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": true,
  "error": null,
  "id": null
}
```
</details>


RAWTRANSACTIONS
-----
**[analyzepsbt](#analyzepsbt)**, **[combinepsbt](#combinepsbt)**, **[combinerawtransaction](#combinerawtransaction)**, **[converttopsbt](#converttopsbt)**, **[createpsbt](#createpsbt)**, **[createrawtransaction](#createrawtransaction)**, **[decodepsbt](#decodepsbt)**, **[decoderawtransaction](#decoderawtransaction)**, **[decodescript](#decodescript)**, **[finalizepsbt](#finalizepsbt)**, **[fundrawtransaction](#fundrawtransaction)**, **[getrawtransaction](#getrawtransaction)**, **[joinpsbts](#joinpsbts)**, **[sendrawtransaction](#sendrawtransaction)**, **[signrawtransactionwithkey](#signrawtransactionwithkey)**, **[testmempoolaccept](#testmempoolaccept)**, **[utxoupdatepsbt](#utxoupdatepsbt)**


### analyzepsbt
##### Analyzes and provides information about the current status of a PSBT and its inputs.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");

RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string PSBT = "cHNidP8BAH0CAAAAAXz0qBDXO+uQOsNVaUcorfJafZYydCv5kGUTLaFs/r2HAAAAAAD+////AugDAAAAAAAAFgAUlBEbC0zwnx3lVjBHQ8j/OSY8D00DggEAAAAAACIAIIwfpAXvuuV+RHcUKJQhamBeY2kX8NQjEHnXq7nAxI0kAAAAAAABASughgEAAAAAACIAIF7irfIOj9QsEsbGg+4bmfHAIfxHGagcdw2PSeqZV1i9IgICykuckuH/D6RW3lBdbEqbEqHDxjQObhF8l5eQRDa64ftIMEUCIQD81o45GQb5Sl957dP64X4xj0QXzoMA8JTSBjbFRC3nrAIgCi1Ku1pSArpmyap0ZiZmAq8LRqis+cBdVeHJE9Da7WcBIgIC/NzEeTxfWJoNRzy7vS+dJSjAlu71hTAThp31g1LONFdHMEQCIBymHkm6ugBcdmllS0XhFHlGYglnrhtJOYk6ET865tYcAiAaBi9klfVfRnTP2KmHb7ZumIWEPzYRsXv2yUWn17Z3NAEBBUdSIQL83MR5PF9Ymg1HPLu9L50lKMCW7vWFMBOGnfWDUs40VyECykuckuH/D6RW3lBdbEqbEqHDxjQObhF8l5eQRDa64ftSriIGAspLnJLh/w+kVt5QXWxKmxKhw8Y0Dm4RfJeXkEQ2uuH7GGuz1AMsAACAAQAAgAAAAIAAAAAAAAAAACIGAvzcxHk8X1iaDUc8u70vnSUowJbu9YUwE4ad9YNSzjRXGHd0/yAsAACAAQAAgAAAAIAAAAAAAAAAAAAAAQFHUiEDLB2e+6+bTRK5ciRgj64xzggam4YgzswByu9oxg3wZ3UhA/jRhjYGYlDGSAoiCvs6tlL6CEU/gcH8yAq4NOqm8SEXUq4iAgMsHZ77r5tNErlyJGCPrjHOCBqbhiDOzAHK72jGDfBndRh3dP8gLAAAgAEAAIAAAACAAAAAAAIAAAAiAgP40YY2BmJQxkgKIgr7OrZS+ghFP4HB/MgKuDTqpvEhFxhrs9QDLAAAgAEAAIAAAACAAAAAAAIAAAAA";

string analyzepsbt = await rawTransaction.AnalyzePSBT(PSBT);

Console.WriteLine(analyzepsbt);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "inputs": [
      {
        "has_utxo": true,
        "is_final": false,
        "next": "updater"
      }
    ],
    "estimated_vsize": 181,
    "estimated_feerate": 0.00001000,
    "fee": 0.00000181,
    "next": "updater"
  },
  "error": null,
  "id": null
}
```
</details>

### combinepsbt
##### Combine multiple partially signed Bitcoin transactions into one transaction.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);
           
List<string> pSBTs = new List<string>
{
                "cHNidP8BAJoCAAAAAljoeiG1ba8MI76OcHBFbDNvfLqlyHV5JPVFiHuyq911AAAAAAD/////g40EJ9DsZQpoqka7CwmK6kQiwHGyyng1Kgd5WdB86h0BAAAAAP////8CcKrwCAAAAAAWABTYXCtx0AYLCcmIauuBXlCZHdoSTQDh9QUAAAAAFgAUAK6pouXw+HaliN9VRuh0LR2HAI8AAAAAAAEAuwIAAAABqtc5MQGL0l+ErkALaISL4J23BurCrBgpi6vucatlb4sAAAAASEcwRAIgWPb8fGoz4bMVSNSByCbAFb0wE1qtQs1neQ2rZtKtJDsCIEoc7SYExnNbY5PltBaR3XiwDwxZQvufdRhW+qk4FX26Af7///8CgPD6AgAAAAAXqRQPuUY0IWlrgsgzryQceMF9295JNIfQ8gonAQAAABepFCnKdPigj4GZlCgYXJe12FLkBj9hh2UAAAAiAgKVg785rgpgl0etGZrd1jT6YQhVnWxc05tMIYPxq5bgf0cwRAIgdAGK1BgAl7hzMjwAFXILNoTMgSOJEEjn282bVa1nnJkCIHPTabdA4+tT3O+jOCPIBwUUylWn3ZVE8VfBZ5EyYRGMAQEDBAEAAAABBEdSIQKVg785rgpgl0etGZrd1jT6YQhVnWxc05tMIYPxq5bgfyEC2rYf9JoU22p9ArDNH7t4/EsYMStbTlTa5Nui+/71NtdSriIGApWDvzmuCmCXR60Zmt3WNPphCFWdbFzTm0whg/GrluB/ENkMak8AAACAAAAAgAAAAIAiBgLath/0mhTban0CsM0fu3j8SxgxK1tOVNrk26L7/vU21xDZDGpPAAAAgAAAAIABAACAAAEBIADC6wsAAAAAF6kUt/X69A49QKWkWbHbNTXyty+pIeiHIgIDCJ3BDHrG21T5EymvYXMz2ziM6tDCMfcjN50bmQMLAtxHMEQCIGLrelVhB6fHP0WsSrWh3d9vcHX7EnWWmn84Pv/3hLyyAiAMBdu3Rw2/LwhVfdNWxzJcHtMJE+mWzThAlF2xIijaXwEBAwQBAAAAAQQiACCMI1MXN0O1ld+0oHtyuo5C43l9p06H/n2ddJfjsgKJAwEFR1IhAwidwQx6xttU+RMpr2FzM9s4jOrQwjH3IzedG5kDCwLcIQI63ZBPPW3PWd25BrDe4jUpt/+57VDl6GFRkmhgIh8Oc1KuIgYCOt2QTz1tz1nduQaw3uI1Kbf/ue1Q5ehhUZJoYCIfDnMQ2QxqTwAAAIAAAACAAwAAgCIGAwidwQx6xttU+RMpr2FzM9s4jOrQwjH3IzedG5kDCwLcENkMak8AAACAAAAAgAIAAIAAIgIDqaTDf1mW06ol26xrVwrwZQOUSSlCRgs1R1Ptnuylh3EQ2QxqTwAAAIAAAACABAAAgAAiAgJ/Y5l1fS7/VaE2rQLGhLGDi2VW5fG2s0KCqUtrUAUQlhDZDGpPAAAAgAAAAIAFAACAAA==",
                "cHNidP8BAJoCAAAAAljoeiG1ba8MI76OcHBFbDNvfLqlyHV5JPVFiHuyq911AAAAAAD/////g40EJ9DsZQpoqka7CwmK6kQiwHGyyng1Kgd5WdB86h0BAAAAAP////8CcKrwCAAAAAAWABTYXCtx0AYLCcmIauuBXlCZHdoSTQDh9QUAAAAAFgAUAK6pouXw+HaliN9VRuh0LR2HAI8AAAAAAAEAuwIAAAABqtc5MQGL0l+ErkALaISL4J23BurCrBgpi6vucatlb4sAAAAASEcwRAIgWPb8fGoz4bMVSNSByCbAFb0wE1qtQs1neQ2rZtKtJDsCIEoc7SYExnNbY5PltBaR3XiwDwxZQvufdRhW+qk4FX26Af7///8CgPD6AgAAAAAXqRQPuUY0IWlrgsgzryQceMF9295JNIfQ8gonAQAAABepFCnKdPigj4GZlCgYXJe12FLkBj9hh2UAAAAiAgLath/0mhTban0CsM0fu3j8SxgxK1tOVNrk26L7/vU210gwRQIhAPYQOLMI3B2oZaNIUnRvAVdyk0IIxtJEVDk82ZvfIhd3AiAFbmdaZ1ptCgK4WxTl4pB02KJam1dgvqKBb2YZEKAG6gEBAwQBAAAAAQRHUiEClYO/Oa4KYJdHrRma3dY0+mEIVZ1sXNObTCGD8auW4H8hAtq2H/SaFNtqfQKwzR+7ePxLGDErW05U2uTbovv+9TbXUq4iBgKVg785rgpgl0etGZrd1jT6YQhVnWxc05tMIYPxq5bgfxDZDGpPAAAAgAAAAIAAAACAIgYC2rYf9JoU22p9ArDNH7t4/EsYMStbTlTa5Nui+/71NtcQ2QxqTwAAAIAAAACAAQAAgAABASAAwusLAAAAABepFLf1+vQOPUClpFmx2zU18rcvqSHohyICAjrdkE89bc9Z3bkGsN7iNSm3/7ntUOXoYVGSaGAiHw5zRzBEAiBl9FulmYtZon/+GnvtAWrx8fkNVLOqj3RQql9WolEDvQIgf3JHA60e25ZoCyhLVtT/y4j3+3Weq74IqjDym4UTg9IBAQMEAQAAAAEEIgAgjCNTFzdDtZXftKB7crqOQuN5fadOh/59nXSX47ICiQMBBUdSIQMIncEMesbbVPkTKa9hczPbOIzq0MIx9yM3nRuZAwsC3CECOt2QTz1tz1nduQaw3uI1Kbf/ue1Q5ehhUZJoYCIfDnNSriIGAjrdkE89bc9Z3bkGsN7iNSm3/7ntUOXoYVGSaGAiHw5zENkMak8AAACAAAAAgAMAAIAiBgMIncEMesbbVPkTKa9hczPbOIzq0MIx9yM3nRuZAwsC3BDZDGpPAAAAgAAAAIACAACAACICA6mkw39ZltOqJdusa1cK8GUDlEkpQkYLNUdT7Z7spYdxENkMak8AAACAAAAAgAQAAIAAIgICf2OZdX0u/1WhNq0CxoSxg4tlVuXxtrNCgqlLa1AFEJYQ2QxqTwAAAIAAAACABQAAgAA="            
};
            
string combinepsbt = await rawTransaction.CombinePSBT(pSBTs);

Console.WriteLine(combinepsbt);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "cHNidP8BAJoCAAAAAljoeiG1ba8MI76OcHBFbDNvfLqlyHV5JPVFiHuyq911AAAAAAD/////g40EJ9DsZQpoqka7CwmK6kQiwHGyyng1Kgd5WdB86h0BAAAAAP////8CcKrwCAAAAAAWABTYXCtx0AYLCcmIauuBXlCZHdoSTQDh9QUAAAAAFgAUAK6pouXw\u002BHaliN9VRuh0LR2HAI8AAAAAAAEAuwIAAAABqtc5MQGL0l\u002BErkALaISL4J23BurCrBgpi6vucatlb4sAAAAASEcwRAIgWPb8fGoz4bMVSNSByCbAFb0wE1qtQs1neQ2rZtKtJDsCIEoc7SYExnNbY5PltBaR3XiwDwxZQvufdRhW\u002Bqk4FX26Af7///8CgPD6AgAAAAAXqRQPuUY0IWlrgsgzryQceMF9295JNIfQ8gonAQAAABepFCnKdPigj4GZlCgYXJe12FLkBj9hh2UAAAAiAgKVg785rgpgl0etGZrd1jT6YQhVnWxc05tMIYPxq5bgf0cwRAIgdAGK1BgAl7hzMjwAFXILNoTMgSOJEEjn282bVa1nnJkCIHPTabdA4\u002BtT3O\u002BjOCPIBwUUylWn3ZVE8VfBZ5EyYRGMASICAtq2H/SaFNtqfQKwzR\u002B7ePxLGDErW05U2uTbovv\u002B9TbXSDBFAiEA9hA4swjcHahlo0hSdG8BV3KTQgjG0kRUOTzZm98iF3cCIAVuZ1pnWm0KArhbFOXikHTYolqbV2C\u002BooFvZhkQoAbqAQEDBAEAAAABBEdSIQKVg785rgpgl0etGZrd1jT6YQhVnWxc05tMIYPxq5bgfyEC2rYf9JoU22p9ArDNH7t4/EsYMStbTlTa5Nui\u002B/71NtdSriIGApWDvzmuCmCXR60Zmt3WNPphCFWdbFzTm0whg/GrluB/ENkMak8AAACAAAAAgAAAAIAiBgLath/0mhTban0CsM0fu3j8SxgxK1tOVNrk26L7/vU21xDZDGpPAAAAgAAAAIABAACAAAEBIADC6wsAAAAAF6kUt/X69A49QKWkWbHbNTXyty\u002BpIeiHIgIDCJ3BDHrG21T5EymvYXMz2ziM6tDCMfcjN50bmQMLAtxHMEQCIGLrelVhB6fHP0WsSrWh3d9vcHX7EnWWmn84Pv/3hLyyAiAMBdu3Rw2/LwhVfdNWxzJcHtMJE\u002BmWzThAlF2xIijaXwEiAgI63ZBPPW3PWd25BrDe4jUpt/\u002B57VDl6GFRkmhgIh8Oc0cwRAIgZfRbpZmLWaJ//hp77QFq8fH5DVSzqo90UKpfVqJRA70CIH9yRwOtHtuWaAsoS1bU/8uI9/t1nqu\u002BCKow8puFE4PSAQEDBAEAAAABBCIAIIwjUxc3Q7WV37Sge3K6jkLjeX2nTof\u002BfZ10l\u002BOyAokDAQVHUiEDCJ3BDHrG21T5EymvYXMz2ziM6tDCMfcjN50bmQMLAtwhAjrdkE89bc9Z3bkGsN7iNSm3/7ntUOXoYVGSaGAiHw5zUq4iBgI63ZBPPW3PWd25BrDe4jUpt/\u002B57VDl6GFRkmhgIh8OcxDZDGpPAAAAgAAAAIADAACAIgYDCJ3BDHrG21T5EymvYXMz2ziM6tDCMfcjN50bmQMLAtwQ2QxqTwAAAIAAAACAAgAAgAAiAgOppMN/WZbTqiXbrGtXCvBlA5RJKUJGCzVHU\u002B2e7KWHcRDZDGpPAAAAgAAAAIAEAACAACICAn9jmXV9Lv9VoTatAsaEsYOLZVbl8bazQoKpS2tQBRCWENkMak8AAACAAAAAgAUAAIAA",
  "error": null,
  "id": null
}
```
</details>

### combinerawtransaction
##### Combine multiple partially signed transactions into one transaction. The combined transaction may be another partially signed transaction or a fully signed transaction.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

List<string> rawTxs = new List<string>
{
  "02000000000180969800000000001600149fb211bc475bd13a0be60f616a49ed7eabe1721500000000",
  "02000000000100350c0000000000160014d94869d7af11277d3e17220d741b9c2e95f09da500000000"
};

string combinerawtransaction = await rawTransaction.CombineRawTransaction(rawTxs);

Console.WriteLine(combinerawtransaction);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "02000000000180969800000000001600149fb211bc475bd13a0be60f616a49ed7eabe1721500000000",
  "error": null,
  "id": null
}
```
</details>

### converttopsbt
##### Converts a network serialized transaction to a PSBT. This should be used only with createrawtransaction and fundrawtransaction
createpsbt and walletcreatefundedpsbt should be used for new applications.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string rawTx = "02000000000180969800000000001600149fb211bc475bd13a0be60f616a49ed7eabe1721500000000";
string converttopsbt = await rawTransaction.ConvertToPSBT(rawTx);

Console.WriteLine(converttopsbt);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "cHNidP8BACkCAAAAAAGAlpgAAAAAABYAFJ\u002ByEbxHW9E6C\u002BYPYWpJ7X6r4XIVAAAAAAAA",
  "error": null,
  "id": null
}
```
</details>

### createpsbt
##### Creates a transaction in the Partially Signed Transaction format.
Implements the Creator role.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

List<PSBTInput> pSBTInputs = new List<PSBTInput>();

PSBTInput pSBTInput1 = new PSBTInput("cbfda9f0cb47ece3e2f0078d074c021548ba3ff53aff583a7777b9a682349d80", 0);
PSBTInput pSBTInput2 = new PSBTInput("3514897207fa4c12189a9b1336eac1909b94293a72b311f2b187fe53cef905bd", 0);

pSBTInputs.Add(pSBTInput1);
pSBTInputs.Add(pSBTInput2);

List<PSBTOutput> pSBTOutputs = new List<PSBTOutput>();
            
PSBTOutput pSBTOutput1 = new PSBTOutput("tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k", 0.0005f);
PSBTOutput pSBTOutput2 = new PSBTOutput("tb1qg3gt75avpyr72d2ndzame0ldrajpnyzk7syq0l", 0.0004f);
PSBTOutput pSBTOutput3 = new PSBTOutput("tb1qz00pk0pq49pxunagsdnxexv6cypet2lkavjuez", 0.0008f);
            
pSBTOutputs.Add(pSBTOutput1);
pSBTOutputs.Add(pSBTOutput2);
pSBTOutputs.Add(pSBTOutput3);

string hexData = "48656c6c6f20576f726c64";

string createpsbt = await rawTransaction.CreatePSBT(pSBTInputs, pSBTOutputs, hexData);

Console.WriteLine(createpsbt);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "cHNidP8BAM8CAAAAAoCdNIKmuXd3Olj/OvU/ukgVAkwHjQfw4uPsR8vwqf3LAAAAAAD/////vQX5zlP\u002Bh7HyEbNyOimUm5DB6jYTm5oYEkz6B3KJFDUAAAAAAP////8EUMMAAAAAAAAWABT5mJmHRssbs0N3B1p50NnElFadIUCcAAAAAAAAFgAURFC/U6wJB\u002BU1U2i7vL/tH2QZkFaAOAEAAAAAABYAFBPeGzwgqUJuT6iDZmyZmsEDlav2AAAAAAAAAAANagtIZWxsbyBXb3JsZAAAAAAAAAAAAAAA",
  "error": null,
  "id": null
}
```
</details>

### createrawtransaction
##### Create a transaction spending the given inputs and creating new outputs. Returns hex-encoded raw transaction.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

RawInputs rawInputs = new RawInputs();
            
RawInput rawInput1 = new RawInput("cbfda9f0cb47ece3e2f0078d074c021548ba3ff53aff583a7777b9a682349d80", 0);
RawInput rawInput2 = new RawInput("ebf7b4cfe5a4aaf3c9faede04369527e14cc7c9766c448c765b6d64e85bee1a8", 0);
RawInput rawInput3 = new RawInput("3289d44456da5dadfbd085814168eb0b75e2365bcead14639600b58d421c1501", 0);

rawInputs.Inputs.Add(rawInput1);
rawInputs.Inputs.Add(rawInput2);
rawInputs.Inputs.Add(rawInput3);

RawOutputs rawOutputs = new RawOutputs();
RawOutput rawOutput = new RawOutput("tb1qg3gt75avpyr72d2ndzame0ldrajpnyzk7syq0l",0.0001f);

rawOutputs.Outputs.Add(rawOutput);

string createrawtransaction = await rawTransaction.CreateRawTransaction(rawInputs, rawOutputs);

Console.WriteLine(createrawtransaction);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "0200000003809d3482a6b977773a58ff3af53fba4815024c078d07f0e2e3ec47cbf0a9fdcb0000000000ffffffffa8e1be854ed6b665c748c466977ccc147e526943e0edfac9f3aaa4e5cfb4f7eb0000000000ffffffff01151c428db500966314adce5b36e2750beb68418185d0fbad5dda5644d489320000000000ffffffff0110270000000000001600144450bf53ac0907e5355368bbbcbfed1f6419905600000000",
  "error": null,
  "id": null
}
```
</details>

### decodepsbt
##### Return a JSON object representing the serialized, base64-encoded partially signed Bitcoin transaction.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string pSBT = "cHNidP8BAJoCAAAAAljoeiG1ba8MI76OcHBFbDNvfLqlyHV5JPVFiHuyq911AAAAAAD/////g40EJ9DsZQpoqka7CwmK6kQiwHGyyng1Kgd5WdB86h0BAAAAAP////8CcKrwCAAAAAAWABTYXCtx0AYLCcmIauuBXlCZHdoSTQDh9QUAAAAAFgAUAK6pouXw+HaliN9VRuh0LR2HAI8AAAAAAAEAuwIAAAABqtc5MQGL0l+ErkALaISL4J23BurCrBgpi6vucatlb4sAAAAASEcwRAIgWPb8fGoz4bMVSNSByCbAFb0wE1qtQs1neQ2rZtKtJDsCIEoc7SYExnNbY5PltBaR3XiwDwxZQvufdRhW+qk4FX26Af7///8CgPD6AgAAAAAXqRQPuUY0IWlrgsgzryQceMF9295JNIfQ8gonAQAAABepFCnKdPigj4GZlCgYXJe12FLkBj9hh2UAAAAiAgLath/0mhTban0CsM0fu3j8SxgxK1tOVNrk26L7/vU210gwRQIhAPYQOLMI3B2oZaNIUnRvAVdyk0IIxtJEVDk82ZvfIhd3AiAFbmdaZ1ptCgK4WxTl4pB02KJam1dgvqKBb2YZEKAG6gEBAwQBAAAAAQRHUiEClYO/Oa4KYJdHrRma3dY0+mEIVZ1sXNObTCGD8auW4H8hAtq2H/SaFNtqfQKwzR+7ePxLGDErW05U2uTbovv+9TbXUq4iBgKVg785rgpgl0etGZrd1jT6YQhVnWxc05tMIYPxq5bgfxDZDGpPAAAAgAAAAIAAAACAIgYC2rYf9JoU22p9ArDNH7t4/EsYMStbTlTa5Nui+/71NtcQ2QxqTwAAAIAAAACAAQAAgAABASAAwusLAAAAABepFLf1+vQOPUClpFmx2zU18rcvqSHohyICAjrdkE89bc9Z3bkGsN7iNSm3/7ntUOXoYVGSaGAiHw5zRzBEAiBl9FulmYtZon/+GnvtAWrx8fkNVLOqj3RQql9WolEDvQIgf3JHA60e25ZoCyhLVtT/y4j3+3Weq74IqjDym4UTg9IBAQMEAQAAAAEEIgAgjCNTFzdDtZXftKB7crqOQuN5fadOh/59nXSX47ICiQABBUdSIQMIncEMesbbVPkTKa9hczPbOIzq0MIx9yM3nRuZAwsC3CECOt2QTz1tz1nduQaw3uI1Kbf/ue1Q5ehhUZJoYCIfDnNSriIGAjrdkE89bc9Z3bkGsN7iNSm3/7ntUOXoYVGSaGAiHw5zENkMak8AAACAAAAAgAMAAIAiBgMIncEMesbbVPkTKa9hczPbOIzq0MIx9yM3nRuZAwsC3BDZDGpPAAAAgAAAAIACAACAACICA6mkw39ZltOqJdusa1cK8GUDlEkpQkYLNUdT7Z7spYdxENkMak8AAACAAAAAgAQAAIAAIgICf2OZdX0u/1WhNq0CxoSxg4tlVuXxtrNCgqlLa1AFEJYQ2QxqTwAAAIAAAACABQAAgAA=";

string decodepsbt = await rawTransaction.DecodePSBT(pSBT);
Console.WriteLine(decodepsbt);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "tx": {
      "txid": "82efd652d7ab1197f01a5f4d9a30cb4c68bb79ab6fec58dfa1bf112291d1617b",
      "hash": "82efd652d7ab1197f01a5f4d9a30cb4c68bb79ab6fec58dfa1bf112291d1617b",
      "version": 2,
      "size": 154,
      "vsize": 154,
      "weight": 616,
      "locktime": 0,
      "vin": [
        {
          "txid": "75ddabb27b8845f5247975c8a5ba7c6f336c4570708ebe230caf6db5217ae858",
          "vout": 0,
          "scriptSig": {
            "asm": "",
            "hex": ""
          },
          "sequence": 4294967295
        },
        {
          "txid": "1dea7cd05979072a3578cab271c02244ea8a090bbb46aa680a65ecd027048d83",
          "vout": 1,
          "scriptSig": {
            "asm": "",
            "hex": ""
          },
          "sequence": 4294967295
        }
      ],
      "vout": [
        {
          "value": 1.49990000,
          "n": 0,
          "scriptPubKey": {
            "asm": "0 d85c2b71d0060b09c9886aeb815e50991dda124d",
            "hex": "0014d85c2b71d0060b09c9886aeb815e50991dda124d",
            "reqSigs": 1,
            "type": "witness_v0_keyhash",
            "addresses": [
              "bc1qmpwzkuwsqc9snjvgdt4czhjsnywa5yjdgwyw6k"
            ]
          }
        },
        {
          "value": 1.00000000,
          "n": 1,
          "scriptPubKey": {
            "asm": "0 00aea9a2e5f0f876a588df5546e8742d1d87008f",
            "hex": "001400aea9a2e5f0f876a588df5546e8742d1d87008f",
            "reqSigs": 1,
            "type": "witness_v0_keyhash",
            "addresses": [
              "bc1qqzh2ngh97ru8dfvgma25d6r595wcwqy0skmt5z"
            ]
          }
        }
      ]
    },
    "unknown": {},
    "inputs": [
      {
        "non_witness_utxo": {
          "txid": "75ddabb27b8845f5247975c8a5ba7c6f336c4570708ebe230caf6db5217ae858",
          "hash": "75ddabb27b8845f5247975c8a5ba7c6f336c4570708ebe230caf6db5217ae858",
          "version": 2,
          "size": 187,
          "vsize": 187,
          "weight": 748,
          "locktime": 101,
          "vin": [
            {
              "txid": "8b6f65ab71eeab8b2918acc2ea06b79de08b84680b40ae845fd28b013139d7aa",
              "vout": 0,
              "scriptSig": {
                "asm": "3044022058f6fc7c6a33e1b31548d481c826c015bd30135aad42cd67790dab66d2ad243b02204a1ced2604c6735b6393e5b41691dd78b00f0c5942fb9f751856faa938157dba[ALL]",
                "hex": "473044022058f6fc7c6a33e1b31548d481c826c015bd30135aad42cd67790dab66d2ad243b02204a1ced2604c6735b6393e5b41691dd78b00f0c5942fb9f751856faa938157dba01"
              },
              "sequence": 4294967294
            }
          ],
          "vout": [
            {
              "value": 0.50000000,
              "n": 0,
              "scriptPubKey": {
                "asm": "OP_HASH160 0fb9463421696b82c833af241c78c17ddbde4934 OP_EQUAL",
                "hex": "a9140fb9463421696b82c833af241c78c17ddbde493487",
                "reqSigs": 1,
                "type": "scripthash",
                "addresses": [
                  "338A1VzFsJXQAiJHeZDzwCvmSv4t1CoYkY"
                ]
              }
            },
            {
              "value": 49.49996240,
              "n": 1,
              "scriptPubKey": {
                "asm": "OP_HASH160 29ca74f8a08f81999428185c97b5d852e4063f61 OP_EQUAL",
                "hex": "a91429ca74f8a08f81999428185c97b5d852e4063f6187",
                "reqSigs": 1,
                "type": "scripthash",
                "addresses": [
                  "35VzAMxSnefPwn2bnCHs53cEWsMfyHUiZr"
                ]
              }
            }
          ]
        },
        "partial_signatures": {
          "02dab61ff49a14db6a7d02b0cd1fbb78fc4b18312b5b4e54dae4dba2fbfef536d7": "3045022100f61038b308dc1da865a34852746f015772934208c6d24454393cd99bdf2217770220056e675a675a6d0a02b85b14e5e29074d8a25a9b5760bea2816f661910a006ea01"
        },
        "sighash": "ALL",
        "redeem_script": {
          "asm": "2 029583bf39ae0a609747ad199addd634fa6108559d6c5cd39b4c2183f1ab96e07f 02dab61ff49a14db6a7d02b0cd1fbb78fc4b18312b5b4e54dae4dba2fbfef536d7 2 OP_CHECKMULTISIG",
          "hex": "5221029583bf39ae0a609747ad199addd634fa6108559d6c5cd39b4c2183f1ab96e07f2102dab61ff49a14db6a7d02b0cd1fbb78fc4b18312b5b4e54dae4dba2fbfef536d752ae",
          "type": "multisig"
        },
        "bip32_derivs": [
          {
            "pubkey": "029583bf39ae0a609747ad199addd634fa6108559d6c5cd39b4c2183f1ab96e07f",
            "master_fingerprint": "d90c6a4f",
            "path": "m/0\u0027/0\u0027/0\u0027"
          },
          {
            "pubkey": "02dab61ff49a14db6a7d02b0cd1fbb78fc4b18312b5b4e54dae4dba2fbfef536d7",
            "master_fingerprint": "d90c6a4f",
            "path": "m/0\u0027/0\u0027/1\u0027"
          }
        ]
      },
      {
        "witness_utxo": {
          "amount": 2.00000000,
          "scriptPubKey": {
            "asm": "OP_HASH160 b7f5faf40e3d40a5a459b1db3535f2b72fa921e8 OP_EQUAL",
            "hex": "a914b7f5faf40e3d40a5a459b1db3535f2b72fa921e887",
            "type": "scripthash",
            "address": "3JTiFf9xWFqryQ7CXK3hMX8oh4GxYxUyAr"
          }
        },
        "partial_signatures": {
          "023add904f3d6dcf59ddb906b0dee23529b7ffb9ed50e5e86151926860221f0e73": "3044022065f45ba5998b59a27ffe1a7bed016af1f1f90d54b3aa8f7450aa5f56a25103bd02207f724703ad1edb96680b284b56d4ffcb88f7fb759eabbe08aa30f29b851383d201"
        },
        "sighash": "ALL",
        "redeem_script": {
          "asm": "0 8c2353173743b595dfb4a07b72ba8e42e3797da74e87fe7d9d7497e3b2028900",
          "hex": "00208c2353173743b595dfb4a07b72ba8e42e3797da74e87fe7d9d7497e3b2028900",
          "type": "witness_v0_scripthash"
        },
        "witness_script": {
          "asm": "2 03089dc10c7ac6db54f91329af617333db388cead0c231f723379d1b99030b02dc 023add904f3d6dcf59ddb906b0dee23529b7ffb9ed50e5e86151926860221f0e73 2 OP_CHECKMULTISIG",
          "hex": "522103089dc10c7ac6db54f91329af617333db388cead0c231f723379d1b99030b02dc21023add904f3d6dcf59ddb906b0dee23529b7ffb9ed50e5e86151926860221f0e7352ae",
          "type": "multisig"
        },
        "bip32_derivs": [
          {
            "pubkey": "023add904f3d6dcf59ddb906b0dee23529b7ffb9ed50e5e86151926860221f0e73",
            "master_fingerprint": "d90c6a4f",
            "path": "m/0\u0027/0\u0027/3\u0027"
          },
          {
            "pubkey": "03089dc10c7ac6db54f91329af617333db388cead0c231f723379d1b99030b02dc",
            "master_fingerprint": "d90c6a4f",
            "path": "m/0\u0027/0\u0027/2\u0027"
          }
        ]
      }
    ],
    "outputs": [
      {
        "bip32_derivs": [
          {
            "pubkey": "03a9a4c37f5996d3aa25dbac6b570af0650394492942460b354753ed9eeca58771",
            "master_fingerprint": "d90c6a4f",
            "path": "m/0\u0027/0\u0027/4\u0027"
          }
        ]
      },
      {
        "bip32_derivs": [
          {
            "pubkey": "027f6399757d2eff55a136ad02c684b1838b6556e5f1b6b34282a94b6b50051096",
            "master_fingerprint": "d90c6a4f",
            "path": "m/0\u0027/0\u0027/5\u0027"
          }
        ]
      }
    ],
    "fee": 0.00010000
  },
  "error": null,
  "id": null
}
```
</details>

### decoderawtransaction
##### Return a JSON object representing the serialized, hex-encoded transaction.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string rawTx = "0200000003809d3482a6b977773a58ff3af53fba4815024c078d07f0e2e3ec47cbf0a9fdcb0000000000ffffffffa8e1be854ed6b665c748c466977ccc147e526943e0edfac9f3aaa4e5cfb4f7eb0000000000ffffffff01151c428db500966314adce5b36e2750beb68418185d0fbad5dda5644d489320000000000ffffffff0110270000000000001600144450bf53ac0907e5355368bbbcbfed1f6419905600000000";

string decoderawtransaction = await rawTransaction.DecodeRawTransaction(rawTx);
Console.WriteLine(decoderawtransaction);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "txid": "98b4eaf1ba98b360e7b3be000efa5d47a51b9c07525597800a518df59d8ecaa6",
    "hash": "98b4eaf1ba98b360e7b3be000efa5d47a51b9c07525597800a518df59d8ecaa6",
    "version": 2,
    "size": 164,
    "vsize": 164,
    "weight": 656,
    "locktime": 0,
    "vin": [
      {
        "txid": "cbfda9f0cb47ece3e2f0078d074c021548ba3ff53aff583a7777b9a682349d80",
        "vout": 0,
        "scriptSig": {
          "asm": "",
          "hex": ""
        },
        "sequence": 4294967295
      },
      {
        "txid": "ebf7b4cfe5a4aaf3c9faede04369527e14cc7c9766c448c765b6d64e85bee1a8",
        "vout": 0,
        "scriptSig": {
          "asm": "",
          "hex": ""
        },
        "sequence": 4294967295
      },
      {
        "txid": "3289d44456da5dadfbd085814168eb0b75e2365bcead14639600b58d421c1501",
        "vout": 0,
        "scriptSig": {
          "asm": "",
          "hex": ""
        },
        "sequence": 4294967295
      }
    ],
    "vout": [
      {
        "value": 0.00010000,
        "n": 0,
        "scriptPubKey": {
          "asm": "0 4450bf53ac0907e5355368bbbcbfed1f64199056",
          "hex": "00144450bf53ac0907e5355368bbbcbfed1f64199056",
          "reqSigs": 1,
          "type": "witness_v0_keyhash",
          "addresses": [
            "bc1qg3gt75avpyr72d2ndzame0ldrajpnyzk5kln5v"
          ]
        }
      }
    ]
  },
  "error": null,
  "id": null
}
```
</details>

### decodescript
##### Decode a hex-encoded script.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string script = "0200000003809d3482a6b977773a58ff3af53fba4815024c078d07f0e2e3ec47cbf0a9fdcb0000000000ffffffffa8e1be854ed6b665c748c466977ccc147e526943e0edfac9f3aaa4e5cfb4f7eb0000000000ffffffff01151c428db500966314adce5b36e2750beb68418185d0fbad5dda5644d489320000000000ffffffff0110270000000000001600144450bf53ac0907e5355368bbbcbfed1f6419905600000000";

string decodescript = await rawTransaction.DecodeScript(script);
Console.WriteLine(decodescript);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "asm": "0 0 3448192 OP_SIZE OP_RIPEMD160 OP_NOP10 OP_NIP OP_NIP 58ff3af53fba4815024c078d07f0e2e3ec47cbf0a9fdcb0000000000ffffffffa8e1be854ed6b665c748c466977ccc147e526943e0edfac9f3aa OP_MAX OP_UNKNOWN OP_UNKNOWN OP_NOP5 OP_UNKNOWN OP_UNKNOWN 0 0 0 0 0 OP_INVALIDOPCODE OP_INVALIDOPCODE OP_INVALIDOPCODE OP_INVALIDOPCODE 21 428db500966314adce5b36e2750beb68418185d0fbad5dda5644d489 [error]",
    "type": "nonstandard",
    "p2sh": "3EtVi2wJgGJtUjWxLLddEyeSvrmaSFv57n",
    "segwit": {
      "asm": "0 e4ca92b571f04183de76fea713cf54c90ece8617ba57b42facad65844783b76e",
      "hex": "0020e4ca92b571f04183de76fea713cf54c90ece8617ba57b42facad65844783b76e",
      "reqSigs": 1,
      "type": "witness_v0_scripthash",
      "addresses": [
        "bc1qun9f9dt37pqc8hnkl6n38n65ey8vapshhftmgtav44jcg3urkahq68tkds"
      ],
      "p2sh-segwit": "31ogGQQLx5acnSLjqJ3wCHTrowXp2S3tNs"
    }
  },
  "error": null,
  "id": null
}
```
</details>

### finalizepsbt
##### Finalize the inputs of a PSBT. If the transaction is fully signed, it will produce a network serialized transaction which can be broadcast with sendrawtransaction. Otherwise a PSBT will be created which has the final_scriptSig and final_scriptWitness fields filled for inputs that are complete.
Implements the Finalizer and Extractor roles.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string pSBT = "cHNidP8BAJoCAAAAAljoeiG1ba8MI76OcHBFbDNvfLqlyHV5JPVFiHuyq911AAAAAAD/////g40EJ9DsZQpoqka7CwmK6kQiwHGyyng1Kgd5WdB86h0BAAAAAP////8CcKrwCAAAAAAWABTYXCtx0AYLCcmIauuBXlCZHdoSTQDh9QUAAAAAFgAUAK6pouXw+HaliN9VRuh0LR2HAI8AAAAAAAEAuwIAAAABqtc5MQGL0l+ErkALaISL4J23BurCrBgpi6vucatlb4sAAAAASEcwRAIgWPb8fGoz4bMVSNSByCbAFb0wE1qtQs1neQ2rZtKtJDsCIEoc7SYExnNbY5PltBaR3XiwDwxZQvufdRhW+qk4FX26Af7///8CgPD6AgAAAAAXqRQPuUY0IWlrgsgzryQceMF9295JNIfQ8gonAQAAABepFCnKdPigj4GZlCgYXJe12FLkBj9hh2UAAAAiAgLath/0mhTban0CsM0fu3j8SxgxK1tOVNrk26L7/vU210gwRQIhAPYQOLMI3B2oZaNIUnRvAVdyk0IIxtJEVDk82ZvfIhd3AiAFbmdaZ1ptCgK4WxTl4pB02KJam1dgvqKBb2YZEKAG6gEBAwQBAAAAAQRHUiEClYO/Oa4KYJdHrRma3dY0+mEIVZ1sXNObTCGD8auW4H8hAtq2H/SaFNtqfQKwzR+7ePxLGDErW05U2uTbovv+9TbXUq4iBgKVg785rgpgl0etGZrd1jT6YQhVnWxc05tMIYPxq5bgfxDZDGpPAAAAgAAAAIAAAACAIgYC2rYf9JoU22p9ArDNH7t4/EsYMStbTlTa5Nui+/71NtcQ2QxqTwAAAIAAAACAAQAAgAABASAAwusLAAAAABepFLf1+vQOPUClpFmx2zU18rcvqSHohyICAjrdkE89bc9Z3bkGsN7iNSm3/7ntUOXoYVGSaGAiHw5zRzBEAiBl9FulmYtZon/+GnvtAWrx8fkNVLOqj3RQql9WolEDvQIgf3JHA60e25ZoCyhLVtT/y4j3+3Weq74IqjDym4UTg9IBAQMEAQAAAAEEIgAgjCNTFzdDtZXftKB7crqOQuN5fadOh/59nXSX47ICiQABBUdSIQMIncEMesbbVPkTKa9hczPbOIzq0MIx9yM3nRuZAwsC3CECOt2QTz1tz1nduQaw3uI1Kbf/ue1Q5ehhUZJoYCIfDnNSriIGAjrdkE89bc9Z3bkGsN7iNSm3/7ntUOXoYVGSaGAiHw5zENkMak8AAACAAAAAgAMAAIAiBgMIncEMesbbVPkTKa9hczPbOIzq0MIx9yM3nRuZAwsC3BDZDGpPAAAAgAAAAIACAACAACICA6mkw39ZltOqJdusa1cK8GUDlEkpQkYLNUdT7Z7spYdxENkMak8AAACAAAAAgAQAAIAAIgICf2OZdX0u/1WhNq0CxoSxg4tlVuXxtrNCgqlLa1AFEJYQ2QxqTwAAAIAAAACABQAAgAA=";

string finalizepsbt = await rawTransaction.FinalizePSBT(pSBT);
Console.WriteLine(finalizepsbt);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "psbt": "cHNidP8BAJoCAAAAAljoeiG1ba8MI76OcHBFbDNvfLqlyHV5JPVFiHuyq911AAAAAAD/////g40EJ9DsZQpoqka7CwmK6kQiwHGyyng1Kgd5WdB86h0BAAAAAP////8CcKrwCAAAAAAWABTYXCtx0AYLCcmIauuBXlCZHdoSTQDh9QUAAAAAFgAUAK6pouXw\u002BHaliN9VRuh0LR2HAI8AAAAAAAEAuwIAAAABqtc5MQGL0l\u002BErkALaISL4J23BurCrBgpi6vucatlb4sAAAAASEcwRAIgWPb8fGoz4bMVSNSByCbAFb0wE1qtQs1neQ2rZtKtJDsCIEoc7SYExnNbY5PltBaR3XiwDwxZQvufdRhW\u002Bqk4FX26Af7///8CgPD6AgAAAAAXqRQPuUY0IWlrgsgzryQceMF9295JNIfQ8gonAQAAABepFCnKdPigj4GZlCgYXJe12FLkBj9hh2UAAAAiAgLath/0mhTban0CsM0fu3j8SxgxK1tOVNrk26L7/vU210gwRQIhAPYQOLMI3B2oZaNIUnRvAVdyk0IIxtJEVDk82ZvfIhd3AiAFbmdaZ1ptCgK4WxTl4pB02KJam1dgvqKBb2YZEKAG6gEBAwQBAAAAAQRHUiEClYO/Oa4KYJdHrRma3dY0\u002BmEIVZ1sXNObTCGD8auW4H8hAtq2H/SaFNtqfQKwzR\u002B7ePxLGDErW05U2uTbovv\u002B9TbXUq4iBgKVg785rgpgl0etGZrd1jT6YQhVnWxc05tMIYPxq5bgfxDZDGpPAAAAgAAAAIAAAACAIgYC2rYf9JoU22p9ArDNH7t4/EsYMStbTlTa5Nui\u002B/71NtcQ2QxqTwAAAIAAAACAAQAAgAABASAAwusLAAAAABepFLf1\u002BvQOPUClpFmx2zU18rcvqSHohyICAjrdkE89bc9Z3bkGsN7iNSm3/7ntUOXoYVGSaGAiHw5zRzBEAiBl9FulmYtZon/\u002BGnvtAWrx8fkNVLOqj3RQql9WolEDvQIgf3JHA60e25ZoCyhLVtT/y4j3\u002B3Weq74IqjDym4UTg9IBAQMEAQAAAAEEIgAgjCNTFzdDtZXftKB7crqOQuN5fadOh/59nXSX47ICiQABBUdSIQMIncEMesbbVPkTKa9hczPbOIzq0MIx9yM3nRuZAwsC3CECOt2QTz1tz1nduQaw3uI1Kbf/ue1Q5ehhUZJoYCIfDnNSriIGAjrdkE89bc9Z3bkGsN7iNSm3/7ntUOXoYVGSaGAiHw5zENkMak8AAACAAAAAgAMAAIAiBgMIncEMesbbVPkTKa9hczPbOIzq0MIx9yM3nRuZAwsC3BDZDGpPAAAAgAAAAIACAACAACICA6mkw39ZltOqJdusa1cK8GUDlEkpQkYLNUdT7Z7spYdxENkMak8AAACAAAAAgAQAAIAAIgICf2OZdX0u/1WhNq0CxoSxg4tlVuXxtrNCgqlLa1AFEJYQ2QxqTwAAAIAAAACABQAAgAA=",
    "complete": false
  },
  "error": null,
  "id": null
}
```
</details>

### fundrawtransaction
##### Add inputs to a transaction until it has enough in value to meet its out value.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string rawTx = "0200000001809d3482a6b977773a58ff3af53fba4815024c078d07f0e2e3ec47cbf0a9fdcb0100000000ffffffff018813000000000000160014f998998746cb1bb34377075a79d0d9c494569d2100000000";

string fundrawtransaction = await rawTransaction.FundRawTransaction(rawTx);
Console.WriteLine(fundrawtransaction);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "hex": "0200000001809d3482a6b977773a58ff3af53fba4815024c078d07f0e2e3ec47cbf0a9fdcb0100000000ffffffff028813000000000000160014f998998746cb1bb34377075a79d0d9c494569d217b4b010000000000160014691dbebc30ecd822976d054be083fb6af3bd97ec00000000",
    "fee": 0.00000141,
    "changepos": 1
  },
  "error": null,
  "id": null
}
```
</details>

### getrawtransaction
##### Returns the raw transaction data.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string txid = "cbfda9f0cb47ece3e2f0078d074c021548ba3ff53aff583a7777b9a682349d80";
string getrawtransaction = await rawTransaction.GetRawTransaction(txid);

Console.WriteLine(getrawtransaction);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "02000000000101a8e1be854ed6b665c748c466977ccc147e526943e0edfac9f3aaa4e5cfb4f7eb0000000000fdffffff02ab241200000000001600147fd0e5fbb32a78ac2ced83fbc26be7d63e1f91fa905f0100000000001600147733bcaec8bf310756b795c691706057e11942050247304402204c7b2c1fb29ab7305c733e92463603357b932e6062c6c4e288e7d8a35564f52102205fd821196711e4708e7ce8c7ecb7dbed3e78b670964b6856b1684776e11df1690121033b5e7d8865da58d0f9e4e83e529f472de94a1817c709c18e3cd1e07d0530c3646a961b00",
  "error": null,
  "id": null
}
```
</details>

### joinpsbts
##### Joins multiple distinct PSBTs with different inputs and outputs into one PSBT with inputs and outputs from all of the PSBTs
No input in any of the PSBTs can be in more than one of the PSBTs.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

List<string> pSBTs = new List<string>
{
"cHNidP8BAHUCAAAAASaBcTce3/KF6Tet7qSze3gADAVmy7OtZGQXE8pCFxv2AAAAAAD+////AtPf9QUAAAAAGXapFNDFmQPFusKGh2DpD9UhpGZap2UgiKwA4fUFAAAAABepFDVF5uM7gyxHBQ8k0+65PJwDlIvHh7MuEwAAAQD9pQEBAAAAAAECiaPHHqtNIOA3G7ukzGmPopXJRjr6Ljl/hTPMti+VZ+UBAAAAFxYAFL4Y0VKpsBIDna89p95PUzSe7LmF/////4b4qkOnHf8USIk6UwpyN+9rRgi7st0tAXHmOuxqSJC0AQAAABcWABT+Pp7xp0XpdNkCxDVZQ6vLNL1TU/////8CAMLrCwAAAAAZdqkUhc/xCX/Z4Ai7NK9wnGIZeziXikiIrHL++E4sAAAAF6kUM5cluiHv1irHU6m80GfWx6ajnQWHAkcwRAIgJxK+IuAnDzlPVoMR3HyppolwuAJf3TskAinwf4pfOiQCIAGLONfc0xTnNMkna9b7QPZzMlvEuqFEyADS8vAtsnZcASED0uFWdJQbrUqZY3LLh+GFbTZSYG2YVi/jnF6efkE/IQUCSDBFAiEA0SuFLYXc2WHS9fSrZgZU327tzHlMDDPOXMMJ/7X85Y0CIGczio4OFyXBl/saiK9Z9R5E5CVbIBZ8hoQDHAXR8lkqASECI7cr7vCWXRC+B3jv7NYfysb3mk6haTkzgHNEZPhPKrMAAAAAAAAA",

"cHNidP8BAKACAAAAAqsJSaCMWvfEm4IS9Bfi8Vqz9cM9zxU4IagTn4d6W3vkAAAAAAD+////qwlJoIxa98SbghL0F+LxWrP1wz3PFTghqBOfh3pbe+QBAAAAAP7///8CYDvqCwAAAAAZdqkUdopAu9dAy+gdmI5x3ipNXHE5ax2IrI4kAAAAAAAAGXapFG9GILVT+glechue4O/p+gOcykWXiKwAAAAAAAEHakcwRAIgR1lmF5fAGwNrJZKJSGhiGDR9iYZLcZ4ff89X0eURZYcCIFMJ6r9Wqk2Ikf/REf3xM286KdqGbX+EhtdVRs7tr5MZASEDXNxh/HupccC1AaZGoqg7ECy0OIEhfKaC3Ibi1z+ogpIAAQEgAOH1BQAAAAAXqRQ1RebjO4MsRwUPJNPuuTycA5SLx4cBBBYAFIXRNTfy4mVAWjTbr6nj3aAfuCMIAAAA",

"cHNidP8BAFUCAAAAASeaIyOl37UfxF8iD6WLD8E+HjNCeSqF1+Ns1jM7XLw5AAAAAAD/////AaBa6gsAAAAAGXapFP/pwAYQl8w7Y28ssEYPpPxCfStFiKwAAAAAAAEBIJVe6gsAAAAAF6kUY0UgD2jRieGtwN8cTRbqjxTA2+uHIgIDsTQcy6doO2r08SOM1ul+cWfVafrEfx5I1HVBhENVvUZGMEMCIAQktY7/qqaU4VWepck7v9SokGQiQFXN8HC2dxRpRC0HAh9cjrD+plFtYLisszrWTt5g6Hhb+zqpS5m9+GFR25qaAQEEIgAgdx/RitRZZm3Unz1WTj28QvTIR3TjYK2haBao7UiNVoEBBUdSIQOxNBzLp2g7avTxI4zW6X5xZ9Vp+sR/HkjUdUGEQ1W9RiED3lXR4drIBeP4pYwfv5uUwC89uq/hJ/78pJlfJvggg71SriIGA7E0HMunaDtq9PEjjNbpfnFn1Wn6xH8eSNR1QYRDVb1GELSmumcAAACAAAAAgAQAAIAiBgPeVdHh2sgF4/iljB+/m5TALz26r+En/vykmV8m+CCDvRC0prpnAAAAgAAAAIAFAACAAAA="
};

string joinpsbts = await rawTransaction.JoinPSBTS(pSBTs);
Console.WriteLine(joinpsbts);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "cHNidP8BAP1WAQIAAAAEJoFxNx7f8oXpN63upLN7eAAMBWbLs61kZBcTykIXG/YAAAAAAP7///\u002BrCUmgjFr3xJuCEvQX4vFas/XDPc8VOCGoE5\u002BHelt75AAAAAAA/v///yeaIyOl37UfxF8iD6WLD8E\u002BHjNCeSqF1\u002BNs1jM7XLw5AAAAAAD/////qwlJoIxa98SbghL0F\u002BLxWrP1wz3PFTghqBOfh3pbe\u002BQBAAAAAP7///8FoFrqCwAAAAAZdqkU/\u002BnABhCXzDtjbyywRg\u002Bk/EJ9K0WIrADh9QUAAAAAF6kUNUXm4zuDLEcFDyTT7rk8nAOUi8eH09/1BQAAAAAZdqkU0MWZA8W6woaHYOkP1SGkZlqnZSCIrGA76gsAAAAAGXapFHaKQLvXQMvoHZiOcd4qTVxxOWsdiKyOJAAAAAAAABl2qRRvRiC1U/oJXnIbnuDv6foDnMpFl4isAAAAAAABAMwBAAAAAomjxx6rTSDgNxu7pMxpj6KVyUY6\u002Bi45f4UzzLYvlWflAQAAABcWABS\u002BGNFSqbASA52vPafeT1M0nuy5hf////\u002BG\u002BKpDpx3/FEiJOlMKcjfva0YIu7LdLQFx5jrsakiQtAEAAAAXFgAU/j6e8adF6XTZAsQ1WUOryzS9U1P/////AgDC6wsAAAAAGXapFIXP8Ql/2eAIuzSvcJxiGXs4l4pIiKxy/vhOLAAAABepFDOXJboh79Yqx1OpvNBn1semo50FhwAAAAAAAAEBIJVe6gsAAAAAF6kUY0UgD2jRieGtwN8cTRbqjxTA2\u002BuHAQQiACB3H9GK1FlmbdSfPVZOPbxC9MhHdONgraFoFqjtSI1WgQEFR1IhA7E0HMunaDtq9PEjjNbpfnFn1Wn6xH8eSNR1QYRDVb1GIQPeVdHh2sgF4/iljB\u002B/m5TALz26r\u002BEn/vykmV8m\u002BCCDvVKuIgYDsTQcy6doO2r08SOM1ul\u002BcWfVafrEfx5I1HVBhENVvUYQtKa6ZwAAAIAAAACABAAAgCIGA95V0eHayAXj\u002BKWMH7\u002BblMAvPbqv4Sf\u002B/KSZXyb4IIO9ELSmumcAAACAAAAAgAUAAIAAAQEgAOH1BQAAAAAXqRQ1RebjO4MsRwUPJNPuuTycA5SLx4cBBBYAFIXRNTfy4mVAWjTbr6nj3aAfuCMIAAAAAAAA",
  "error": null,
  "id": null
}
```
</details>

### sendrawtransaction
##### Submit a raw transaction (serialized, hex-encoded) to local node and network.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string hex = "020000000001012ec9d65ba255e44b85810beac4cad16418fa5c263a1d9f45ab03a4001edf24650000000000ffffffff01e803000000000000160014f998998746cb1bb34377075a79d0d9c494569d2102473044022039fc28874fc1fbf14c4297a4160acfb9793d341f32c61ccc27818fff5d47433102203c091fa28c69e3b2a337b560e20823f0a1b0aa7069d5f98dbe325a6807caa19e012102fc6958eee747f2471d4f34d5e4d7639de5c1abc32dbf05d876554cd7af66608900000000";

string sendrawtransaction = await rawTransaction.SendRawTransaction(hex);
         
Console.WriteLine(sendrawtransaction);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "2d7ecff0b455774f9740b8e11c12ec873479b46de92082bf2a12015baf63366e",
  "error": null,
  "id": null
}
```
</details>

### signrawtransactionwithkey
##### Sign inputs for raw transaction.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

//Step 1. Create the raw transaction.

RawInputs rawInputs = new RawInputs
{
   Inputs = new List<RawInput>() { new RawInput("6524df1e00a403ab459f1d3a265cfa1864d1cac4ea0b81854be455a25bd6c92e", 0) }
};

RawOutputs rawOutputs = new RawOutputs()
{
   Outputs = new List<RawOutput> { new RawOutput("tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k", 0.00001f) }
;

//The response object.
string response = await rawTransaction.CreateRawTransaction(rawInputs, rawOutputs);

//Deserialize the response.
dynamic deserialized = JsonConvert.DeserializeObject(response);

//Get the hex string.
string result = deserialized.result; // "02000000012ec9d65ba255e44b85810beac4cad16418fa5c263a1d9f45ab03a4001edf24650000000000ffffffff01e803000000000000160014f998998746cb1bb34377075a79d0d9c494569d2100000000"

//Step 2. Sign the raw transaction with private key.
string signrawtransactionwithkey = await rawTransaction.SignRawTransactionWithKey(result, new List<string> { "cSPSK16wrGeeNhhS97zgUDfvEkahRa7uGmG1UKnpzxKhe8Vdppg1" });

Console.WriteLine(signrawtransactionwithkey);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "hex": "020000000001012ec9d65ba255e44b85810beac4cad16418fa5c263a1d9f45ab03a4001edf24650000000000ffffffff01e803000000000000160014f998998746cb1bb34377075a79d0d9c494569d2102473044022039fc28874fc1fbf14c4297a4160acfb9793d341f32c61ccc27818fff5d47433102203c091fa28c69e3b2a337b560e20823f0a1b0aa7069d5f98dbe325a6807caa19e012102fc6958eee747f2471d4f34d5e4d7639de5c1abc32dbf05d876554cd7af66608900000000",
    "complete": true
  },
  "error": null,
  "id": null
}
```
</details>

### testmempoolaccept
##### Returns result of mempool acceptance tests indicating if raw transaction (serialized, hex-encoded) would be accepted by mempool.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string rawTx = "020000000001012ec9d65ba255e44b85810beac4cad16418fa5c263a1d9f45ab03a4001edf24650000000000ffffffff01e803000000000000160014f998998746cb1bb34377075a79d0d9c494569d2102473044022039fc28874fc1fbf14c4297a4160acfb9793d341f32c61ccc27818fff5d47433102203c091fa28c69e3b2a337b560e20823f0a1b0aa7069d5f98dbe325a6807caa19e012102fc6958eee747f2471d4f34d5e4d7639de5c1abc32dbf05d876554cd7af66608900000000";

string testmempoolaccept = await rawTransaction.TestMemPoolAccept(rawTx);
Console.WriteLine(testmempoolaccept); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    {
      "txid": "2d7ecff0b455774f9740b8e11c12ec873479b46de92082bf2a12015baf63366e",
      "allowed": true
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### utxoupdatepsbt
##### Updates all segwit inputs and outputs in a PSBT with data from output descriptors, the UTXO set or the mempool.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
RawTransaction rawTransaction = new RawTransaction(bitcoinClient);

string pSBT = "cHNidP8BAJoCAAAAAljoeiG1ba8MI76OcHBFbDNvfLqlyHV5JPVFiHuyq911AAAAAAD/////g40EJ9DsZQpoqka7CwmK6kQiwHGyyng1Kgd5WdB86h0BAAAAAP////8CcKrwCAAAAAAWABTYXCtx0AYLCcmIauuBXlCZHdoSTQDh9QUAAAAAFgAUAK6pouXw+HaliN9VRuh0LR2HAI8AAAAAAAAAAAA=";

string utxoupdatepsbt = await rawTransaction.UtxoUpdatePSBT(pSBT);
Console.WriteLine(utxoupdatepsbt);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "cHNidP8BAJoCAAAAAljoeiG1ba8MI76OcHBFbDNvfLqlyHV5JPVFiHuyq911AAAAAAD/////g40EJ9DsZQpoqka7CwmK6kQiwHGyyng1Kgd5WdB86h0BAAAAAP////8CcKrwCAAAAAAWABTYXCtx0AYLCcmIauuBXlCZHdoSTQDh9QUAAAAAFgAUAK6pouXw\u002BHaliN9VRuh0LR2HAI8AAAAAAAAAAAA=",
  "error": null,
  "id": null
}
```
</details>

UTIL
-----
**[createmultisig](#createmultisig)**, **[deriveaddresses](#deriveaddresses)**, **[estimatesmartfee](#estimatesmartfee)**, **[getdescriptorinfo](#getdescriptorinfo)**, **[signmessagewithprivkey](#signmessagewithprivkey)**, **[validateaddress](#validateaddress)**, **[verifymessage](#verifymessage)**


### createmultisig
##### Creates a multi-signature address with n signature of m keys required.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Util util = new Util(bitcoinClient);

int nRequired = 4;
List<string> publicKeys = new List<string>
{
    "034fab17259fc38d1ef5cfef0d41bc770d571052ff77aa543fc42926c9cfc7e5ca",
    "0259ddbb4b6b46cb166175ec41bdf4e6be91b0a7eaf9bfa08ce880dfa6dda40363",
    "039369ebfe09dc44bd0864a2063b72ee3ecf11f2754a28c4bfd9a9e88031b93a30",
    "039c54dcacf5b675560745054c39988136d1b4fd312e69c22fdb68816f36999fa9"
};

string createmultisig= await util.CreateMultisig(nRequired, publicKeys,AddressType.bech32);
Console.WriteLine(createmultisig);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "address": "tb1qu04n9l6ps64n4uy84e5khh7nld77hkxqam29wsupd3t5uklvmcdqx3m6c0",
    "redeemScript": "5421034fab17259fc38d1ef5cfef0d41bc770d571052ff77aa543fc42926c9cfc7e5ca210259ddbb4b6b46cb166175ec41bdf4e6be91b0a7eaf9bfa08ce880dfa6dda4036321039369ebfe09dc44bd0864a2063b72ee3ecf11f2754a28c4bfd9a9e88031b93a3021039c54dcacf5b675560745054c39988136d1b4fd312e69c22fdb68816f36999fa954ae",
    "descriptor": "wsh(multi(4,034fab17259fc38d1ef5cfef0d41bc770d571052ff77aa543fc42926c9cfc7e5ca,0259ddbb4b6b46cb166175ec41bdf4e6be91b0a7eaf9bfa08ce880dfa6dda40363,039369ebfe09dc44bd0864a2063b72ee3ecf11f2754a28c4bfd9a9e88031b93a30,039c54dcacf5b675560745054c39988136d1b4fd312e69c22fdb68816f36999fa9))#wtp4909w"
  },
  "error": null,
  "id": null
}
```
</details>

### deriveaddresses
##### Derives one or more addresses corresponding to an output descriptor.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Util util = new Util(bitcoinClient);

string deriveaddresses = await util.DeriveAddresses("wsh(multi(4,034fab17259fc38d1ef5cfef0d41bc770d571052ff77aa543fc42926c9cfc7e5ca,0259ddbb4b6b46cb166175ec41bdf4e6be91b0a7eaf9bfa08ce880dfa6dda40363,039369ebfe09dc44bd0864a2063b72ee3ecf11f2754a28c4bfd9a9e88031b93a30,039c54dcacf5b675560745054c39988136d1b4fd312e69c22fdb68816f36999fa9))#wtp4909w");

Console.WriteLine(deriveaddresses);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    "tb1qu04n9l6ps64n4uy84e5khh7nld77hkxqam29wsupd3t5uklvmcdqx3m6c0"
  ],
  "error": null,
  "id": null
}
```
</details>

### estimatesmartfee
##### Estimates the approximate fee per kilobyte needed for a transaction to begin confirmation within conf_target blocks if possible and return the number of blocks
for which the estimate is valid. Uses virtual transaction size as defined in BIP 141 (witness data is discounted).
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
            
Util util = new Util(bitcoinClient);

int confTarget = 6;
EstimateMode estimateMode = EstimateMode.CONSERVATIVE;

string estimatesmartfee = await util.EstimateSmartFee(confTarget, estimateMode);
Console.WriteLine(estimatesmartfee);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "feerate": 0.00061476,
    "blocks": 6
  },
  "error": null,
  "id": null
}
```
</details>

### getdescriptorinfo
##### Analyses a descriptor.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");           
Util util = new Util(bitcoinClient);

int confTarget = 6;
EstimateMode estimateMode = EstimateMode.CONSERVATIVE;

string descriptor = "wsh(multi(1,xpub661MyMwAqRbcFW31YEwpkMuc5THy2PSt5bDMsktWQcFF8syAmRUapSCGu8ED9W6oDMSgv6Zz8idoc4a6mr8BDzTJY47LJhkJ8UB7WEGuduB/1/0/*,xpub69H7F5d8KSRgmmdJg2KhpAK8SR3DjMwAdkxj3ZuxV27CprR9LgpeyGmXUbC6wb7ERfvrnKZjXoUmmDznezpbZb7ap6r1D3tgFxHmwMkQTPH/0/0/*))";

string getdescriptorinfo = await util.GetDescriptorInfo(descriptor);           
Console.WriteLine(getdescriptorinfo);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "descriptor": "wsh(multi(1,xpub661MyMwAqRbcFW31YEwpkMuc5THy2PSt5bDMsktWQcFF8syAmRUapSCGu8ED9W6oDMSgv6Zz8idoc4a6mr8BDzTJY47LJhkJ8UB7WEGuduB/1/0/*,xpub69H7F5d8KSRgmmdJg2KhpAK8SR3DjMwAdkxj3ZuxV27CprR9LgpeyGmXUbC6wb7ERfvrnKZjXoUmmDznezpbZb7ap6r1D3tgFxHmwMkQTPH/0/0/*))#t2zpj2eu",
    "checksum": "t2zpj2eu",
    "isrange": true,
    "issolvable": true,
    "hasprivatekeys": false
  },
  "error": null,
  "id": null
}
```
</details>

### signmessagewithprivkey
##### Sign a message with the private key of an address.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Util util = new Util(bitcoinClient);

//Only legacy supported.
string privKey = "cVD8v4Zprw2NRkNfqhNtgVrh4LuguYcZkwcjb3s6so3TLJqt2AAw";
string msg = "Hello World";
string signmessagewithprivkey = await util.SignMessageWithPrivKey(privKey, msg);

Console.WriteLine(signmessagewithprivkey);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "H79SeYYWoy/ZmcYUQQ\u002BAB\u002Bp34nYow5p7vZH9vtxKKpVKHvqUdtbscJOfOClVZokO3o1QmzLVCHB23ZONYE1UfG4=",
  "error": null,
  "id": null
}
```
</details>

### validateaddress
##### Return information about the given bitcoin address.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
Util util = new Util(bitcoinClient);

string address = "bc1qn7epr0z8t0gn5zlxpask5j0d0647zus4nj3fvj";
string validateaddress = await util.ValidateAddress(address);
            
Console.WriteLine(validateaddress);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "isvalid": true,
    "address": "bc1qn7epr0z8t0gn5zlxpask5j0d0647zus4nj3fvj",
    "scriptPubKey": "00149fb211bc475bd13a0be60f616a49ed7eabe17215",
    "isscript": false,
    "iswitness": true,
    "witness_version": 0,
    "witness_program": "9fb211bc475bd13a0be60f616a49ed7eabe17215"
  },
  "error": null,
  "id": null
}
```
</details>

### verifymessage
##### Verify a signed message.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Util util = new Util(bitcoinClient);

//Only legacy address supported.
string address = "muWkDUiLRXVFMmKTXkNtfoxgsJppUSXPKi";
string signature = "H79SeYYWoy/ZmcYUQQ\u002BAB\u002Bp34nYow5p7vZH9vtxKKpVKHvqUdtbscJOfOClVZokO3o1QmzLVCHB23ZONYE1UfG4=";
string msg = "Hello World";
string verifymessage = await util.VerifyMessage(address, signature, msg);

Console.WriteLine(verifymessage);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": true,
  "error": null,
  "id": null
}
```
</details>

WALLET
-----
**[abandontransaction](#abandontransaction)**, **[abortrescan](#abortrescan)**, **[addmultisigaddress](#addmultisigaddress)**, **[backupwallet](#backupwallet)**,  **[bumpfee](#bumpfee)**,  **[createwallet](#createwallet)**,  **[dumpprivkey](#dumpprivkey)**,  **[dumpwallet](#dumpwallet)**,  **[encryptwallet](#encryptwallet)**,  **[getaddressesbylabel](#getaddressesbylabel)**,  **[getaddressinfo](#getaddressinfo)**,  **[getbalance](#getbalance)**,  **[getbalances](#getbalances)**,  **[getnewaddress](#getnewaddress)**,  **[getrawchangeaddress](#getrawchangeaddress)**,  **[getreceivedbyaddress](#getreceivedbyaddress)**,  **[getreceivedbylabel](#getreceivedbylabel)**,  **[gettransaction](#gettransaction)**,  **[getunconfirmedbalance](#getunconfirmedbalance)**,  **[getwalletinfo](#getwalletinfo)**,  **[importaddress](#importaddress)**,  **[importmulti](#importmulti)**,  **[importprivkey](#importprivkey)**,  **[importprunedfunds](#importprunedfunds)**,  **[importpubkey](#importpubkey)**,  **[importwallet](#importwallet)**,  **[keypoolrefill](#keypoolrefill)**,  **[listaddressgroupings](#listaddressgroupings)**,  **[listlabels](#listlabels)**,  **[listlockunspent](#listlockunspent)**,  **[listreceivedbyaddress](#listreceivedbyaddress)**,  **[listreceivedbylabel](#listreceivedbylabel)**,  **[listsinceblock](#listsinceblock)**,  **[listtransactions](#listtransactions)**,  **[listunspent](#listunspent)**,  **[listwalletdir](#listwalletdir)**,  **[listwallets](#listwallets)**,  **[loadwallet](#loadwallet)**,  **[lockunspent](#lockunspent)**,  **[removeprunedfunds](#removeprunedfunds)**,  **[rescanblockchain](#rescanblockchain)**,  **[sendmany](#sendmany)**,  **[sendtoaddress](#sendtoaddress)**,  **[sethdseed](#sethdseed)**,  **[setlabel](#setlabel)**,  **[settxfee](#settxfee)**,  **[setwalletflag](#setwalletflag)**,  **[signmessage](#signmessage)**,  **[signrawtransactionwithwallet](#signrawtransactionwithwallet)**,  **[unloadwallet](#unloadwallet)**,  **[walletcreatefundedpsbt](#walletcreatefundedpsbt)**,  **[walletlock](#walletlock)**,  **[walletpassphrase](#walletpassphrase)**,  **[walletpassphrasechange](#walletpassphrasechange)**,  **[walletprocesspsbt](#walletprocesspsbt)**


### abandontransaction
##### Mark in-wallet transaction "txid" as abandoned.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

string txid = "6524df1e00a403ab459f1d3a265cfa1864d1cac4ea0b81854be455a25bd6c92e";
string abandontransaction = await wallet.AbandonTransaction(txid);

Console.WriteLine(abandontransaction);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": {
    "code": -5,
    "message": "Transaction not eligible for abandonment"
  },
  "id": null
}
```
</details>

### abortrescan
##### Stops current wallet rescan triggered by an RPC call, e.g. by an importprivkey call.
Note: Use "getwalletinfo" to query the scanning progress.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);
            
string abortrescan = await wallet.AbortRescan();

Console.WriteLine(abortrescan);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": true,
  "error": null,
  "id": null
}
```
</details>

### addmultisigaddress
##### Add an nrequired-to-sign multisignature address to the wallet.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

List<string> keys = new List<string>()
{
    "tb1qwuemetkghucsw44hjhrfzurq2ls3jss9lwfj62",
    "tb1qnh2qtqsu4un8xey5d3258tfd7efl3eu4acp076"
};

int nRequired = 2;
AddressType addressType = AddressType.bech32;

string addmultisigaddress = await wallet.AddMultisigAddress(nRequired, keys, addressType);
Console.WriteLine(addmultisigaddress);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "address": "tb1qs2axh0ldwzh9w4uqnpja5p8caqr676tzchh63vlheke2kuhf2d7s0nxmux",
    "redeemScript": "522102fc6958eee747f2471d4f34d5e4d7639de5c1abc32dbf05d876554cd7af66608921024f10e363d21c591612197a8b7cdc2debcb8250555cf8a44d9d6aeafcc14c0ae952ae",
    "descriptor": "wsh(multi(2,[6e528489/0\u0027/0\u0027/0\u0027]02fc6958eee747f2471d4f34d5e4d7639de5c1abc32dbf05d876554cd7af666089,[9b6a804e/0\u0027/0\u0027/3\u0027]024f10e363d21c591612197a8b7cdc2debcb8250555cf8a44d9d6aeafcc14c0ae9))#4afx49du"
  },
  "error": null,
  "id": null
}
```
</details>

### backupwallet
##### Safely copies current wallet file to destination, which can be a directory or a path with filename.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string backupwallet = await wallet.BackupWallet("backup.dat");
            
Console.WriteLine(backupwallet);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### bumpfee
##### Bumps the fee of an opt-in-RBF transaction T, replacing it with a new transaction B.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);
            
string txid = "6524df1e00a403ab459f1d3a265cfa1864d1cac4ea0b81854be455a25bd6c92e";
string bumpfee = await wallet.BumpFee(txid);

Console.WriteLine(bumpfee);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": {
    "code": -4,
    "message": "Transaction has been mined, or is conflicted with a mined transaction"
  },
  "id": null
}
```
</details>

### createwallet
##### Creates and loads a new wallet.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

//required
string walletName = "tomate";

//optional. wallet password.
string passphrase = "12345";

//optional
bool disablePrivateKeys = false;

//optional
bool blank = false;
            
//optional
bool avoidReuse = false;

string createwallet = await wallet.CreateWallet(walletName, disablePrivateKeys, blank, passphrase, avoidReuse);

Console.WriteLine(createwallet);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "name": "tomate",
    "warning": ""
  },
  "error": null,
  "id": null
}
```
</details>

### dumpprivkey
##### Reveals the private key corresponding to 'address'. Then the importprivkey can be used with this output
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");

Wallet wallet = new Wallet(bitcoinClient);
            
string dumpprivkey = await wallet.DumpPrivKey("tb1qnh2qtqsu4un8xey5d3258tfd7efl3eu4acp076");

Console.WriteLine(dumpprivkey);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "cQLanjPtqTSrPgLDV7oKgvv3HJXca9sakzzRZNjcUpaHt2a2A3h6",
  "error": null,
  "id": null
}
```
</details>

### dumpwallet
##### Dumps all wallet keys in a human-readable format to a server-side file. This does not allow overwriting existing files.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");

List<string> wallets = await MultipleWallet.GetWallets(bitcoinClient);

Wallet wallet = new Wallet(bitcoinClient);

string dumpprivkey = await wallet.DumpWallet("walletDump.txt");

Console.WriteLine(dumpprivkey);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
  {
  "result": {
    "filename": "E:\\Bitcoin\\walletDump.txt"
  },
  "error": null,
  "id": null
}

```
</details>

### encryptwallet
##### Encrypts the wallet with 'passphrase'. This is for first time encryption. After this, any calls that interact with private keys such as sending or signing  will require the passphrase to be set prior the making these calls. Use the walletpassphrase call for this, and then walletlock call. If the wallet is already encrypted, use the walletpassphrasechange call.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient, "orange");

string passphrase = "12345";
string encryptwallet = await wallet.EncryptWallet(passphrase);

Console.WriteLine(encryptwallet);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "wallet encrypted; The keypool has been flushed and a new HD seed was generated (if you are using HD). You need to make a new backup.",
  "error": null,
  "id": null
}
```
</details>

### getaddressesbylabel
##### Returns the list of addresses assigned the specified label.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");            
Wallet wallet = new Wallet(bitcoinClient);

string label = "one";
string getaddressesbylabel = await wallet.GetAddressesByLabel(label);

Console.WriteLine(getaddressesbylabel);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "tb1qnh3ahpknxnycpxva5vftt9mn0l6zyv74qxnfag": {
      "purpose": "receive"
    },
    "tb1qhhjmmg5pgjtlcux2mlky3lq5mv0zlzfzhdeq6j": {
      "purpose": "receive"
    }
  },
  "error": null,
  "id": null
}
```
</details>

### getaddressinfo
##### Return information about the given bitcoin address. Some of the information will only be present if the address is in the active wallet.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");           
Wallet wallet = new Wallet(bitcoinClient);

string address = "tb1qa6rs93lmdxsq2v3mnumna7wheenxr6tcax39j6";
string getaddressinfo = await wallet.GetAddressInfo(address);

Console.WriteLine(getaddressinfo); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "address": "tb1qa6rs93lmdxsq2v3mnumna7wheenxr6tcax39j6",
    "scriptPubKey": "0014ee8702c7fb69a005323b9f373ef9d7ce6661e978",
    "ismine": true,
    "solvable": true,
    "desc": "wpkh([df099759/0\u0027/0\u0027/14\u0027]027b6340ec261f9f9df90407d8033988c77476dedf36afd1ba7405f1d3b89ac600)#qcypltg8",
    "iswatchonly": false,
    "isscript": false,
    "iswitness": true,
    "witness_version": 0,
    "witness_program": "ee8702c7fb69a005323b9f373ef9d7ce6661e978",
    "pubkey": "027b6340ec261f9f9df90407d8033988c77476dedf36afd1ba7405f1d3b89ac600",
    "ischange": false,
    "timestamp": 1597225442,
    "hdkeypath": "m/0\u0027/0\u0027/14\u0027",
    "hdseedid": "e58c31d9d60daaa1f19fa3a2508c178e9d72f725",
    "hdmasterfingerprint": "df099759",
    "labels": [
      ""
    ]
  },
  "error": null,
  "id": null
}
```
</details>

### getbalance
##### Returns the total available balance. The available balance is what the wallet considers currently spendable.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string getbalance = await wallet.GetBalance();

Console.WriteLine(getbalance); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": 0.00020000,
  "error": null,
  "id": null
}
```
</details>

### getbalances
##### Returns an object with all balances in BTC.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string getbalances = await wallet.GetBalances();

Console.WriteLine(getbalances); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "mine": {
      "trusted": 0.03794156,
      "untrusted_pending": 0.00000000,
      "immature": 0.00000000
    }
  },
  "error": null,
  "id": null
}
```
</details>

### getnewaddress
##### Returns a new Bitcoin address for receiving payments. If 'label' is specified, it is added to the address book so payments received with the address will be associated with 'label'.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

//Optional.
AddressType addressType = AddressType.bech32;

//Optional.
string label = "best address";

string getnewaddress = await wallet.GetNewAddress(label, addressType);

Console.WriteLine(getnewaddress);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "bc1qrz74rd4v7lryfqu2cudckql4ta200ye6apjpnk",
  "error": null,
  "id": null
}
```
</details>

### getrawchangeaddress
##### Returns a new Bitcoin address, for receiving change. This is for use with raw transactions, NOT normal use.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

//Optional.
AddressType addressType = AddressType.bech32;

string getrawchangeaddress = await wallet.GetRawChangeAddress(addressType);

Console.WriteLine(getrawchangeaddress);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "bc1qv450gz0t5uw0hrt5xkvnegm2wvlrpg0y9pq452",
  "error": null,
  "id": null
}
```
</details>

### getreceivedbyaddress
##### Returns the total amount received by the given address in transactions with at least minconf confirmations.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");

Wallet wallet = new Wallet(bitcoinClient);

string address = "tb1qqvegzkql09s694kaa0czzav4ragmcnmwqg6ynk";
            
string getreceivedbyaddress = await wallet.GetReceivedByAddress(address);

Console.WriteLine(getreceivedbyaddress); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": 0.00019890,
  "error": null,
  "id": null
}
```
</details>

### getreceivedbylabel
##### Returns the total amount received by addresses with "label" in transactions with at least "minconf" confirmations.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);
            
string label = "one";
string getreceivedbylabel = await wallet.GetReceivedByLabel(label);

Console.WriteLine(getreceivedbylabel)
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": 0.01000000,
  "error": null,
  "id": null
}
```
</details>

### gettransaction
##### Get detailed information about in-wallet transaction "txid".
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);
            
string txid = "39c2b0dac1b7d986cd9042b72c4228ea78bb0439a6062062f0b5d98ac9cb013d";
string gettransaction = await wallet.GetTransaction(txid);

Console.WriteLine(gettransaction);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "amount": -0.00059859,
    "fee": -0.00000141,
    "confirmations": 1026,
    "blockhash": "00000000b99db7eba7428632c355e5554ebbb84d0d3b5d0e105f21c3f6dfb1f9",
    "blockheight": 1807234,
    "blockindex": 195,
    "blocktime": 1597417309,
    "txid": "39c2b0dac1b7d986cd9042b72c4228ea78bb0439a6062062f0b5d98ac9cb013d",
    "walletconflicts": [],
    "time": 1597416426,
    "timereceived": 1597416426,
    "bip125-replaceable": "no",
    "comment": "suck",
    "to": "comto",
    "details": [
      {
        "address": "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
        "category": "send",
        "amount": -0.00059859,
        "vout": 0,
        "fee": -0.00000141,
        "abandoned": false
      }
    ],
    "hex": "02000000000101e297d407f4d71d2bb96be4bac2d38921da8a74be436d601512802fd1d1ea4b6f0000000000fdffffff02d3e9000000000000160014f998998746cb1bb34377075a79d0d9c494569d21794a2a00000000001600146bdb400743f59e6c86b910003e018516334a8f7b02473044022008a4ecf385e4ecdad091f67d3617cc4225c21d8a9c0a94ece1535df578b26566022079538f621ab333eaeac95325a61d7eb5ce30976603e32a8bb0e6695fcd004fb40121021c5814c662bf0a4ca156eb31ffb8c664e167a965aa0c60acf36c757ba758a1f03d931b00"
  },
  "error": null,
  "id": null
}
```
</details>

### getunconfirmedbalance
##### DEPRECATED!!!
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);
            
string getunconfirmedbalance = await wallet.GetUnconfirmedBalance();

Console.WriteLine(getunconfirmedbalance);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": 0.01000000,
  "error": null,
  "id": null
}
```
</details>

### getwalletinfo
##### Returns an object containing various wallet state info.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient, "boss");

string getwalletinfo = await wallet.GetWalletInfo();

Console.WriteLine(getwalletinfo);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "walletname": "boss",
    "walletversion": 169900,
    "balance": 0.03794156,
    "unconfirmed_balance": 0.01000000,
    "immature_balance": 0.00000000,
    "txcount": 72,
    "keypoololdest": 1597417444,
    "keypoolsize": 999,
    "hdseedid": "468c02ca66ad6fc391406fafa19ff009ab78debd",
    "keypoolsize_hd_internal": 1000,
    "paytxfee": 0.00000000,
    "private_keys_enabled": true,
    "avoid_reuse": false,
    "scanning": false
  },
  "error": null,
  "id": null
}
```
</details>

### importaddress
##### Adds an address or script (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

//Required.
string address = "mtXWDB6k5yC5v7TcwKZHB89SUp85yCKshy";
            
//Optional.
string label = "label";

//Optional.
bool rescan = false;

string importaddress = await wallet.ImportAddress(address, label, rescan);

Console.WriteLine(importaddress); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### importmulti
##### Import addresses/scripts (with private or public keys, redeem script (P2SH)), optionally rescanning the blockchain from the earliest creation time of the imported scripts. Requires a new wallet backup.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

List<MultiData> multiDatas = new List<MultiData>();

MultiData MultiData = new MultiData()
{
      Desc = "addr(mtXWDB6k5yC5v7TcwKZHB89SUp85yCKshy)",
      Label = "imported",
      WatchOnly=true,
                
};
            
MultiData.SetTimestamp(CreationTime.Now);

string importmulti = await wallet.ImportMulti(multiDatas);

Console.WriteLine(importmulti); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [],
  "error": null,
  "id": null
}
```
</details>

### importprivkey
##### Adds a private key (as returned by dumpprivkey) to your wallet. Requires a new wallet backup.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

//Required.
string privKey = "cPF57iFYMW9wwegtpoZxN6ouJ2LWjxCHZokfaBTmaV3g9wcdpYzc";

//Optional.
bool rescan = false;

string importprivkey = await wallet.ImportPrivKey(privKey, rescan);

Console.WriteLine(importprivkey);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### importprunedfunds
##### Imports funds without rescan. Corresponding address or script must previously be included in wallet.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);
            
string rawTx = "0100000001f3f6a909f8521adb57d898d2985834e632374e770fd9e2b98656f1bf1fdfd427010000006b48304502203a776322ebf8eb8b58cc6ced4f2574f4c73aa664edce0b0022690f2f6f47c521022100b82353305988cb0ebd443089a173ceec93fe4dbfe98d74419ecc84a6a698e31d012103c5c1bc61f60ce3d6223a63cedbece03b12ef9f0068f2f3c4a7e7f06c523c3664ffffffff0260e31600000000001976a914977ae6e32349b99b72196cb62b5ef37329ed81b488ac063d1000000000001976a914f76bc4190f3d8e2315e5c11c59cfc8be9df747e388ac00000000";
            
string txOutProof = "00000020eaff1b2556050adcfd6994ecf108e925d07743aa529fe6f528010000000000001da0a71c89d160cae71e342a449342d2195768e39a9ed8d9e7e48409a44481e233c33f5fffff001d1e3525e1d00100000adae8f7bc7e19f44570ed252b4ee1dddf4d15fc3578ee92a3b4b8e7a32b797091effafc7601cab2f5a39c9422660c4c8d2d0b0bcd17be9824c98698e5542946061d78ace3258b0ff8dc09bcaa63fadfdfa71a136423570e5dfc63abccafd9ae9b234efd2c4dc22048acbd1163b3d524e0fb54e5e2c23719885f9730d08a76c1daaa70ac6019e0b5a1f3295232f6a1aeee541e68b2fd63403fd3ae2b6d945362ae527ca4689075ed2717cef6bf26ca0e68cc45aec7c9c5a665b8b02d7c27aabd8fa8e1be854ed6b665c748c466977ccc147e526943e0edfac9f3aaa4e5cfb4f7ebac2e3ec7aac342b5a9cb200be28d4e58fb7547b9a1f8252d9878ad42541e84e632ecbf55b2cbdfec9074ecbf9f6908024db8e80838d43959184107523031864f9a03005d7e09315b1bb076a227751cb31d2b077335c71af555013bce0424fe1003b5d500";
          
string importprunedfunds = await wallet.ImportPrunedFunds(rawTx, txOutProof);
Console.WriteLine(importprunedfunds);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": {
    "code": -5,
    "message": "Transaction given doesn\u0027t exist in proof"
  },
  "id": null
}
```
</details>

### importpubkey
##### Adds a public key (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

string pubKey = "024b840f7aa5881b9b9b0022e1808d1083738ce11239f890345adea7df4a0f9702";
bool rescan = false;

string importpubkey = await wallet.ImportPubkey(pubKey, rescan);

Console.WriteLine(importpubkey);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### importwallet
##### Imports keys from a wallet dump file (see dumpwallet). Requires a new wallet backup to include imported keys.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);
           
string fileName = "walletDump.txt";
string importwallet = await wallet.ImportWallet(fileName);

Console.WriteLine(importwallet);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### keypoolrefill
##### Fills the keypool.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);
                    
int newSize = 100;
string keypoolrefill = await wallet.KeyPoolRefill(newSize);

Console.WriteLine(keypoolrefill);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### listaddressgroupings
##### Lists groups of addresses which have had their common ownership made public by common use as inputs or as the resulting change in past transactions.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);
            
string listaddressgroupings = await wallet.ListAddressGroupings();

Console.WriteLine(listaddressgroupings);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    [
      [
        "tb1qrvstcs4r60kxpqhcf0phhz2uwe36khfd3jww4t",
        0.00000000
      ],
      [
        "tb1qg3gt75avpyr72d2ndzame0ldrajpnyzk7syq0l",
        0.00000000,
        ""
      ],
      [
        "tb1q208y4ftpp5r4ssuj73ve2hqey6sl97tj36wsqd",
        0.00000000
      ],
      [
        "tb1qwuemetkghucsw44hjhrfzurq2ls3jss9lwfj62",
        0.01090000,
        ""
      ],
      [
        "tb1q0vgtreynmdpwfnetu2qesxxkj4c3ys0uhkze6c",
        0.00000000
      ],
      [
        "tb1qnh2qtqsu4un8xey5d3258tfd7efl3eu4acp076",
        0.00080000,
        ""
      ],
      [
        "tb1qhwafkc0kdmktd4wksdrywukrrh7ugpasega5dz",
        0.00000000
      ],
      [
        "tb1qck5tv8cwwgtdf4xemgg4d0m3jl5pt9cnlyqkfg",
        0.00000000
      ],
      [
        "tb1qmnqprxwfm250fs0s0zt7matf84qmk98p0l72kt",
        0.00000000
      ],
      [
        "tb1qa98l6du0qjc02pyrq2at07zszqm33wuvjmnq9n",
        0.00000000
      ],
      [
        "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
        0.00000000,
        ""
      ]
    ]
  ],
  "error": null,
  "id": null
}
```
</details>

### listlabels
##### Returns the list of all labels, or labels that are assigned to addresses with a specific purpose.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient, "");

string listlabels = await wallet.ListLabels();

Console.WriteLine(listlabels); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    "",
    "John Doe",
    "apple",
    "best Address",
    "cherry",
    "one"
  ],
  "error": null,
  "id": null
}
```
</details>

### listlockunspent
##### Returns list of temporarily unspendable outputs. See the lockunspent call to lock and unlock transactions for spending.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string listlockunspent = await wallet.ListLockUnspent();

Console.WriteLine(listlockunspent);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    {
      "txid": "3289d44456da5dadfbd085814168eb0b75e2365bcead14639600b58d421c1501",
      "vout": 0
    },
    {
      "txid": "cbfda9f0cb47ece3e2f0078d074c021548ba3ff53aff583a7777b9a682349d80",
      "vout": 0
    },
    {
      "txid": "11a461bbe76f06a67e9695f43e0108c0f5b8a3a0243c01d8b2528ff6de3961f1",
      "vout": 0
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### listreceivedbyaddress
##### List balances by receiving address.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string listreceivedbyaddress = await wallet.ListReceivedByAddress();

Console.WriteLine(listreceivedbyaddress);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    {
      "address": "tb1qqvegzkql09s694kaa0czzav4ragmcnmwqg6ynk",
      "amount": 0.00019890,
      "confirmations": 963,
      "label": "ddddd",
      "txids": [
        "3289d44456da5dadfbd085814168eb0b75e2365bcead14639600b58d421c1501"
      ]
    },
    {
      "address": "tb1qgflg6yl8au445lt6xfddlvfumvp6d6z3g9wegt",
      "amount": 0.01100000,
      "confirmations": 5,
      "label": "",
      "txids": [
        "d51acb8f691f1a7de84ecc338e1fbcb0b19908b192d8ddd05a5f62abf1b32029",
        "8ddf6b7b33b1dba884f5f8c7869c2e2f8f89573c8fb28e5b27d9d904e007546b"
      ]
    },
    {
      "address": "tb1qwmxm8tshffmphupk7wr6j443uechlap7pver9e",
      "amount": 0.06130442,
      "confirmations": 1028,
      "label": "",
      "txids": [
        "ccaa4c9ac0d1a54e0ef137be53f5be00eda8c88e57ed261e9e621ad2e8de1858",
        "cda20c686f38983907b38d8404df79916f23b3ccd02561f33666ac290814448b",
        "3f2a689bdcb7efe12d94b77ea0f5970a68eb8226b6a0db62e1b0cc94a46a3698"
      ]
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### listreceivedbylabel
##### List received transactions by label.
-----
```csharp    

BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string listreceivedbylabel = await wallet.ListReceivedByLabel();

Console.WriteLine(listreceivedbylabel); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    {
      "amount": 0.07230442,
      "confirmations": 5,
      "label": ""
    },
    {
      "amount": 0.00019890,
      "confirmations": 963,
      "label": "ddddd"
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### listsinceblock
##### Get all transactions in blocks since block "blockhash", or all transactions if omitted.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string listsinceblock = await wallet.ListSinceBlock();

Console.WriteLine(listsinceblock);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "transactions": [
      {
        "address": "tb1qqvegzkql09s694kaa0czzav4ragmcnmwqg6ynk",
        "category": "receive",
        "amount": 0.00019890,
        "label": "ddddd",
        "vout": 0,
        "confirmations": 963,
        "blockhash": "00000000000000f7eda6b3c891cc0f5239711fd118bcd167d156ecff0a04d5d6",
        "blockheight": 1807302,
        "blockindex": 41,
        "blocktime": 1597484398,
        "txid": "3289d44456da5dadfbd085814168eb0b75e2365bcead14639600b58d421c1501",
        "walletconflicts": [],
        "time": 1597483770,
        "timereceived": 1597483770,
        "bip125-replaceable": "no"
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00001000,
        "vout": 1,
        "fee": -0.00000144,
        "confirmations": 1040,
        "blockhash": "00000000fb3efbec6ebe89436b2388825beca38aee09179925b7d1651b27e018",
        "blockheight": 1807225,
        "blockindex": 144,
        "blocktime": 1597409600,
        "txid": "c1e5d3718ff4ff0dfd5f50bd09d7c36c30a1ce203228041422411b8dbf28f501",
        "walletconflicts": [],
        "time": 1597409548,
        "timereceived": 1597409548,
        "bip125-replaceable": "no",
        "comment": "commmm",
        "abandoned": false
      },
 ...
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00000856,
        "vout": 1,
        "fee": -0.00000144,
        "confirmations": 1043,
        "blockhash": "0000000041b2713cdb39acf33f23a13958c9f17b417edb0298929b349a756c52",
        "blockheight": 1807222,
        "blockindex": 292,
        "blocktime": 1597406145,
        "txid": "f75488995e7798671522d72a2572e3c59dc99cd5697a3fa7712cfc3b7612a4c8",
        "walletconflicts": [],
        "time": 1597405740,
        "timereceived": 1597405740,
        "bip125-replaceable": "no",
        "comment": "Some Comment",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00000855,
        "vout": 0,
        "fee": -0.00000145,
        "confirmations": 1042,
        "blockhash": "00000000000001344fd8f0567312d5588219839d7665f566705e90f474075931",
        "blockheight": 1807223,
        "blockindex": 60,
        "blocktime": 1597407196,
        "txid": "ffc7550455b99809dc99943f330ac6e03361972680475afc4a9bbfcb0fb62bcb",
        "walletconflicts": [],
        "time": 1597406613,
        "timereceived": 1597406613,
        "bip125-replaceable": "no",
        "comment": "Some Comment",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00001000,
        "vout": 1,
        "fee": -0.00000144,
        "confirmations": 1040,
        "blockhash": "00000000fb3efbec6ebe89436b2388825beca38aee09179925b7d1651b27e018",
        "blockheight": 1807225,
        "blockindex": 381,
        "blocktime": 1597409600,
        "txid": "deb3ae9407331440b8151d66dbade001d851daf2892323f2e93ef4adbd6a06cd",
        "walletconflicts": [],
        "time": 1597409368,
        "timereceived": 1597409368,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00000856,
        "vout": 0,
        "fee": -0.00000144,
        "confirmations": 1042,
        "blockhash": "00000000000001344fd8f0567312d5588219839d7665f566705e90f474075931",
        "blockheight": 1807223,
        "blockindex": 102,
        "blocktime": 1597407196,
        "txid": "eb02550d87192fc775a7303dc25df7e8b2cf4abd8fc9b1341c0fccbbc25cdccf",
        "walletconflicts": [],
        "time": 1597406840,
        "timereceived": 1597406840,
        "bip125-replaceable": "no",
        "comment": "Some Comment",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00001000,
        "vout": 1,
        "fee": -0.00000144,
        "confirmations": 1041,
        "blockhash": "00000000f3033e79df7a23f0e7c148fcf987294c4efd6a1bd5645244f6475faa",
        "blockheight": 1807224,
        "blockindex": 346,
        "blocktime": 1597408398,
        "txid": "8b78cf3258640cfdd99904e7da0ea49b9cf9c5a56f1699f4b90bfc8ba34f6ad0",
        "walletconflicts": [],
        "time": 1597407792,
        "timereceived": 1597407792,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "2NF2TWBfHqgDpff2xWRB1DJR3C3kWUaQrsS",
        "category": "send",
        "amount": -0.00020000,
        "vout": 0,
        "fee": -0.00141858,
        "confirmations": 1026,
        "blockhash": "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319",
        "blockheight": 1807239,
        "blockindex": 1,
        "blocktime": 1597422210,
        "txid": "aff347e3bf1803d33548b3b440506d7df6275ce4fae6c548f9076de0f46a63d1",
        "walletconflicts": [],
        "time": 1597420923,
        "timereceived": 1597420923,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
        "category": "send",
        "amount": -0.00050000,
        "vout": 0,
        "fee": -0.00000141,
        "confirmations": 1032,
        "blockhash": "00000000f6fa4a3eaf6233a60c26d6b9e08e8f7c5dd33b97ef456086c273b484",
        "blockheight": 1807233,
        "blockindex": 126,
        "blocktime": 1597416108,
        "txid": "12e20f0b5de4fc6065055792bcdca79e9e454d7b7265d9a8e42941e9924b83d2",
        "walletconflicts": [],
        "time": 1597416062,
        "timereceived": 1597416062,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00001000,
        "vout": 1,
        "fee": -0.00000144,
        "confirmations": 1040,
        "blockhash": "00000000fb3efbec6ebe89436b2388825beca38aee09179925b7d1651b27e018",
        "blockheight": 1807225,
        "blockindex": 143,
        "blocktime": 1597409600,
        "txid": "098eab880fd384ceb67a3d10b0909ced7b2747f3f95dcf689a2f3d4b69bde9d5",
        "walletconflicts": [],
        "time": 1597409391,
        "timereceived": 1597409391,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00000856,
        "vout": 1,
        "fee": -0.00000144,
        "confirmations": 1042,
        "blockhash": "00000000000001344fd8f0567312d5588219839d7665f566705e90f474075931",
        "blockheight": 1807223,
        "blockindex": 105,
        "blocktime": 1597407196,
        "txid": "d36b75b7b339b276cbee0442777cb8d39a9663601c03cfe22b1da37b1e03edda",
        "walletconflicts": [],
        "time": 1597406974,
        "timereceived": 1597406974,
        "bip125-replaceable": "no",
        "comment": "Some Comment",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00001000,
        "vout": 1,
        "fee": -0.00000144,
        "confirmations": 1040,
        "blockhash": "00000000fb3efbec6ebe89436b2388825beca38aee09179925b7d1651b27e018",
        "blockheight": 1807225,
        "blockindex": 386,
        "blocktime": 1597409600,
        "txid": "753932efdf10d8c73e3a71a8ee14907e096d704458c9ebcff8354ef2d0afbfe1",
        "walletconflicts": [],
        "time": 1597409585,
        "timereceived": 1597409585,
        "bip125-replaceable": "no",
        "comment": "commmm",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00000855,
        "vout": 1,
        "fee": -0.00000145,
        "confirmations": 1042,
        "blockhash": "00000000000001344fd8f0567312d5588219839d7665f566705e90f474075931",
        "blockheight": 1807223,
        "blockindex": 61,
        "blocktime": 1597407196,
        "txid": "e255b24a54e998c9efb03e3cd997c974fd31a3dff3b5ff10c45da341494550e2",
        "walletconflicts": [],
        "time": 1597406288,
        "timereceived": 1597406288,
        "bip125-replaceable": "no",
        "comment": "Some Comment",
        "abandoned": false
      },
      {
        "address": "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
        "category": "send",
        "amount": -0.00059859,
        "vout": 1,
        "fee": -0.00000141,
        "confirmations": 1031,
        "blockhash": "00000000b99db7eba7428632c355e5554ebbb84d0d3b5d0e105f21c3f6dfb1f9",
        "blockheight": 1807234,
        "blockindex": 194,
        "blocktime": 1597417309,
        "txid": "6f4bead1d12f801215606d43be748ada2189d3c2bae46bb92b1dd7f407d497e2",
        "walletconflicts": [],
        "time": 1597416354,
        "timereceived": 1597416354,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00001000,
        "vout": 1,
        "fee": -0.00000144,
        "confirmations": 1041,
        "blockhash": "00000000f3033e79df7a23f0e7c148fcf987294c4efd6a1bd5645244f6475faa",
        "blockheight": 1807224,
        "blockindex": 345,
        "blocktime": 1597408398,
        "txid": "f47003d462ce015eced4168903c14e41d6398974272abed0d56126cf24e5cee4",
        "walletconflicts": [],
        "time": 1597407726,
        "timereceived": 1597407726,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00001000,
        "vout": 0,
        "fee": -0.00000144,
        "confirmations": 1041,
        "blockhash": "00000000f3033e79df7a23f0e7c148fcf987294c4efd6a1bd5645244f6475faa",
        "blockheight": 1807224,
        "blockindex": 356,
        "blocktime": 1597408398,
        "txid": "eb7ae3d68e2b983be1f1604f8fd468a3ac990dbe88fc97bc99e4eea5f43df1e8",
        "walletconflicts": [],
        "time": 1597407980,
        "timereceived": 1597407980,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00001000,
        "vout": 1,
        "fee": -0.00000144,
        "confirmations": 1041,
        "blockhash": "00000000f3033e79df7a23f0e7c148fcf987294c4efd6a1bd5645244f6475faa",
        "blockheight": 1807224,
        "blockindex": 248,
        "blocktime": 1597408398,
        "txid": "8e2180ff4225faa677bdced807cb5ff01c4f93bf7c03f32768a8a83ca4acf3ec",
        "walletconflicts": [],
        "time": 1597408095,
        "timereceived": 1597408095,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "tb1qnh2qtqsu4un8xey5d3258tfd7efl3eu4acp076",
        "category": "send",
        "amount": -0.00020000,
        "label": "",
        "vout": 1,
        "fee": -0.00140859,
        "confirmations": 1026,
        "blockhash": "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319",
        "blockheight": 1807239,
        "blockindex": 3,
        "blocktime": 1597422210,
        "txid": "11a461bbe76f06a67e9695f43e0108c0f5b8a3a0243c01d8b2528ff6de3961f1",
        "walletconflicts": [],
        "time": 1597420844,
        "timereceived": 1597420844,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
        "category": "send",
        "amount": -0.00020000,
        "vout": 0,
        "fee": -0.00000172,
        "confirmations": 1046,
        "blockhash": "00000000db93593441a3ad991d32ca1e0dda463bb19aa13de3cf89b54ebd2293",
        "blockheight": 1807219,
        "blockindex": 328,
        "blocktime": 1597402898,
        "txid": "f4542c60d0ca72a00e3b43b0cbf9dbf7066a4951fbcee600c1c2964cbfee3cfa",
        "walletconflicts": [],
        "time": 1597402794,
        "timereceived": 1597402794,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "tb1qwuemetkghucsw44hjhrfzurq2ls3jss9lwfj62",
        "category": "send",
        "amount": -0.00010000,
        "label": "",
        "vout": 1,
        "fee": -0.00000172,
        "confirmations": 1046,
        "blockhash": "00000000db93593441a3ad991d32ca1e0dda463bb19aa13de3cf89b54ebd2293",
        "blockheight": 1807219,
        "blockindex": 328,
        "blocktime": 1597402898,
        "txid": "f4542c60d0ca72a00e3b43b0cbf9dbf7066a4951fbcee600c1c2964cbfee3cfa",
        "walletconflicts": [],
        "time": 1597402794,
        "timereceived": 1597402794,
        "bip125-replaceable": "no",
        "abandoned": false
      },
      {
        "address": "n3FnenEMWzrw5XuVwaPG6qgBAsgwVZMtgj",
        "category": "send",
        "amount": -0.00001000,
        "vout": 0,
        "fee": -0.00000144,
        "confirmations": 1041,
        "blockhash": "00000000f3033e79df7a23f0e7c148fcf987294c4efd6a1bd5645244f6475faa",
        "blockheight": 1807224,
        "blockindex": 355,
        "blocktime": 1597408398,
        "txid": "465ce8083ac1aec6133b6e6bde23ea778363a93c63f2db5e92396981828be6fd",
        "walletconflicts": [],
        "time": 1597407974,
        "timereceived": 1597407974,
        "bip125-replaceable": "no",
        "abandoned": false
      }
    ],
    "removed": [],
    "lastblock": "0000000071a161910e348bdf3b6b2691cb93d3265b217165863659cfc5b40d5c"
  },
  "error": null,
  "id": null
}
```
</details>

### listtransactions
##### If a label name is provided, this will return only incoming transactions paying to addresses with the specified label.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string listtransactions = await wallet.ListTransactions();

Console.WriteLine(listtransactions); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    {
      "address": "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
      "category": "send",
      "amount": -0.00059859,
      "vout": 0,
      "fee": -0.00000141,
      "confirmations": 1031,
      "blockhash": "00000000b99db7eba7428632c355e5554ebbb84d0d3b5d0e105f21c3f6dfb1f9",
      "blockheight": 1807234,
      "blockindex": 195,
      "blocktime": 1597417309,
      "txid": "39c2b0dac1b7d986cd9042b72c4228ea78bb0439a6062062f0b5d98ac9cb013d",
      "walletconflicts": [],
      "time": 1597416426,
      "timereceived": 1597416426,
      "bip125-replaceable": "no",
      "comment": "suck",
      "to": "comto",
      "abandoned": false
    },
    {
      "address": "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
      "category": "send",
      "amount": -0.00059859,
      "vout": 1,
      "fee": -0.00000141,
      "confirmations": 1031,
      "blockhash": "00000000b99db7eba7428632c355e5554ebbb84d0d3b5d0e105f21c3f6dfb1f9",
      "blockheight": 1807234,
      "blockindex": 250,
      "blocktime": 1597417309,
      "txid": "9259992982e759964ea3b8a57c2e4962ac89ffdfc7ed78b9a8b745255be19fa4",
      "walletconflicts": [],
      "time": 1597416711,
      "timereceived": 1597416711,
      "bip125-replaceable": "no",
      "comment": "suck",
      "to": "comto",
      "abandoned": false
    },
    {
      "address": "tb1qwmxm8tshffmphupk7wr6j443uechlap7pver9e",
      "category": "receive",
      "amount": 0.01683033,
      "label": "",
      "vout": 0,
      "confirmations": 1028,
      "blockhash": "000000009e0491f8f205d4f71544cf4c74ab2821a1406b24fb816b3aaaa683ad",
      "blockheight": 1807237,
      "blockindex": 300,
      "blocktime": 1597420574,
      "txid": "3f2a689bdcb7efe12d94b77ea0f5970a68eb8226b6a0db62e1b0cc94a46a3698",
      "walletconflicts": [],
      "time": 1597420165,
      "timereceived": 1597420165,
      "bip125-replaceable": "no"
    },
    {
      "address": "tb1qnh2qtqsu4un8xey5d3258tfd7efl3eu4acp076",
      "category": "send",
      "amount": -0.00020000,
      "label": "",
      "vout": 1,
      "fee": -0.00140859,
      "confirmations": 1026,
      "blockhash": "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319",
      "blockheight": 1807239,
      "blockindex": 3,
      "blocktime": 1597422210,
      "txid": "11a461bbe76f06a67e9695f43e0108c0f5b8a3a0243c01d8b2528ff6de3961f1",
      "walletconflicts": [],
      "time": 1597420844,
      "timereceived": 1597420844,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "2NF2TWBfHqgDpff2xWRB1DJR3C3kWUaQrsS",
      "category": "send",
      "amount": -0.00020000,
      "vout": 0,
      "fee": -0.00141858,
      "confirmations": 1026,
      "blockhash": "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319",
      "blockheight": 1807239,
      "blockindex": 1,
      "blocktime": 1597422210,
      "txid": "aff347e3bf1803d33548b3b440506d7df6275ce4fae6c548f9076de0f46a63d1",
      "walletconflicts": [],
      "time": 1597420923,
      "timereceived": 1597420923,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "2NF2TWBfHqgDpff2xWRB1DJR3C3kWUaQrsS",
      "category": "send",
      "amount": -0.00020000,
      "vout": 0,
      "fee": -0.00141858,
      "confirmations": 1026,
      "blockhash": "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319",
      "blockheight": 1807239,
      "blockindex": 2,
      "blocktime": 1597422210,
      "txid": "8903339fa21b5856e8ba9ed0828a9f03888ace9d551a2c24e3d19f9e3c3f9220",
      "walletconflicts": [],
      "time": 1597421084,
      "timereceived": 1597421084,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "tb1qqvegzkql09s694kaa0czzav4ragmcnmwqg6ynk",
      "category": "receive",
      "amount": 0.00019890,
      "label": "ddddd",
      "vout": 0,
      "confirmations": 963,
      "blockhash": "00000000000000f7eda6b3c891cc0f5239711fd118bcd167d156ecff0a04d5d6",
      "blockheight": 1807302,
      "blockindex": 41,
      "blocktime": 1597484398,
      "txid": "3289d44456da5dadfbd085814168eb0b75e2365bcead14639600b58d421c1501",
      "walletconflicts": [],
      "time": 1597483770,
      "timereceived": 1597483770,
      "bip125-replaceable": "no"
    },
    {
      "address": "tb1qnh2qtqsu4un8xey5d3258tfd7efl3eu4acp076",
      "category": "send",
      "amount": -0.00080000,
      "label": "",
      "vout": 1,
      "fee": -0.00000141,
      "confirmations": 291,
      "blockhash": "00000000a6119fc55b2562e3898ff2a41a9e880020694f203955608e3b0b857d",
      "blockheight": 1807974,
      "blockindex": 430,
      "blocktime": 1598014259,
      "txid": "ebf7b4cfe5a4aaf3c9faede04369527e14cc7c9766c448c765b6d64e85bee1a8",
      "walletconflicts": [],
      "time": 1598013143,
      "timereceived": 1598013143,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "tb1qwuemetkghucsw44hjhrfzurq2ls3jss9lwfj62",
      "category": "send",
      "amount": -0.00090000,
      "label": "",
      "vout": 1,
      "fee": -0.00000141,
      "confirmations": 286,
      "blockhash": "00000000d8cd50ceee79f11c7a19eaf39edbb99a54aedc778bbcae127ef1bdf3",
      "blockheight": 1807979,
      "blockindex": 287,
      "blocktime": 1598019699,
      "txid": "cbfda9f0cb47ece3e2f0078d074c021548ba3ff53aff583a7777b9a682349d80",
      "walletconflicts": [],
      "time": 1598018608,
      "timereceived": 1598018608,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "tb1qgflg6yl8au445lt6xfddlvfumvp6d6z3g9wegt",
      "category": "receive",
      "amount": 0.01000000,
      "label": "",
      "vout": 1,
      "confirmations": 5,
      "blockhash": "00000000136a11a9752faa1b074bdbd77e84ae291659e8cf102b64ed41de62da",
      "blockheight": 1808260,
      "blockindex": 64,
      "blocktime": 1598286739,
      "txid": "d51acb8f691f1a7de84ecc338e1fbcb0b19908b192d8ddd05a5f62abf1b32029",
      "walletconflicts": [],
      "time": 1598286265,
      "timereceived": 1598286265,
      "bip125-replaceable": "no"
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### listunspent
##### Returns array of unspent transaction outputs with between minconf and maxconf (inclusive) confirmations.
Optionally filter to only include txouts paid to specified addresses.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string listunspent = await wallet.ListUnspent();

Console.WriteLine(listunspent);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    {
      "address": "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
      "category": "send",
      "amount": -0.00059859,
      "vout": 0,
      "fee": -0.00000141,
      "confirmations": 1031,
      "blockhash": "00000000b99db7eba7428632c355e5554ebbb84d0d3b5d0e105f21c3f6dfb1f9",
      "blockheight": 1807234,
      "blockindex": 195,
      "blocktime": 1597417309,
      "txid": "39c2b0dac1b7d986cd9042b72c4228ea78bb0439a6062062f0b5d98ac9cb013d",
      "walletconflicts": [],
      "time": 1597416426,
      "timereceived": 1597416426,
      "bip125-replaceable": "no",
      "comment": "suck",
      "to": "comto",
      "abandoned": false
    },
    {
      "address": "tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k",
      "category": "send",
      "amount": -0.00059859,
      "vout": 1,
      "fee": -0.00000141,
      "confirmations": 1031,
      "blockhash": "00000000b99db7eba7428632c355e5554ebbb84d0d3b5d0e105f21c3f6dfb1f9",
      "blockheight": 1807234,
      "blockindex": 250,
      "blocktime": 1597417309,
      "txid": "9259992982e759964ea3b8a57c2e4962ac89ffdfc7ed78b9a8b745255be19fa4",
      "walletconflicts": [],
      "time": 1597416711,
      "timereceived": 1597416711,
      "bip125-replaceable": "no",
      "comment": "suck",
      "to": "comto",
      "abandoned": false
    },
    {
      "address": "tb1qwmxm8tshffmphupk7wr6j443uechlap7pver9e",
      "category": "receive",
      "amount": 0.01683033,
      "label": "",
      "vout": 0,
      "confirmations": 1028,
      "blockhash": "000000009e0491f8f205d4f71544cf4c74ab2821a1406b24fb816b3aaaa683ad",
      "blockheight": 1807237,
      "blockindex": 300,
      "blocktime": 1597420574,
      "txid": "3f2a689bdcb7efe12d94b77ea0f5970a68eb8226b6a0db62e1b0cc94a46a3698",
      "walletconflicts": [],
      "time": 1597420165,
      "timereceived": 1597420165,
      "bip125-replaceable": "no"
    },
    {
      "address": "tb1qnh2qtqsu4un8xey5d3258tfd7efl3eu4acp076",
      "category": "send",
      "amount": -0.00020000,
      "label": "",
      "vout": 1,
      "fee": -0.00140859,
      "confirmations": 1026,
      "blockhash": "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319",
      "blockheight": 1807239,
      "blockindex": 3,
      "blocktime": 1597422210,
      "txid": "11a461bbe76f06a67e9695f43e0108c0f5b8a3a0243c01d8b2528ff6de3961f1",
      "walletconflicts": [],
      "time": 1597420844,
      "timereceived": 1597420844,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "2NF2TWBfHqgDpff2xWRB1DJR3C3kWUaQrsS",
      "category": "send",
      "amount": -0.00020000,
      "vout": 0,
      "fee": -0.00141858,
      "confirmations": 1026,
      "blockhash": "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319",
      "blockheight": 1807239,
      "blockindex": 1,
      "blocktime": 1597422210,
      "txid": "aff347e3bf1803d33548b3b440506d7df6275ce4fae6c548f9076de0f46a63d1",
      "walletconflicts": [],
      "time": 1597420923,
      "timereceived": 1597420923,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "2NF2TWBfHqgDpff2xWRB1DJR3C3kWUaQrsS",
      "category": "send",
      "amount": -0.00020000,
      "vout": 0,
      "fee": -0.00141858,
      "confirmations": 1026,
      "blockhash": "00000000247e018b2781be633c8605bd75b7aaee0419d4c1603782afbf8d1319",
      "blockheight": 1807239,
      "blockindex": 2,
      "blocktime": 1597422210,
      "txid": "8903339fa21b5856e8ba9ed0828a9f03888ace9d551a2c24e3d19f9e3c3f9220",
      "walletconflicts": [],
      "time": 1597421084,
      "timereceived": 1597421084,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "tb1qqvegzkql09s694kaa0czzav4ragmcnmwqg6ynk",
      "category": "receive",
      "amount": 0.00019890,
      "label": "ddddd",
      "vout": 0,
      "confirmations": 963,
      "blockhash": "00000000000000f7eda6b3c891cc0f5239711fd118bcd167d156ecff0a04d5d6",
      "blockheight": 1807302,
      "blockindex": 41,
      "blocktime": 1597484398,
      "txid": "3289d44456da5dadfbd085814168eb0b75e2365bcead14639600b58d421c1501",
      "walletconflicts": [],
      "time": 1597483770,
      "timereceived": 1597483770,
      "bip125-replaceable": "no"
    },
    {
      "address": "tb1qnh2qtqsu4un8xey5d3258tfd7efl3eu4acp076",
      "category": "send",
      "amount": -0.00080000,
      "label": "",
      "vout": 1,
      "fee": -0.00000141,
      "confirmations": 291,
      "blockhash": "00000000a6119fc55b2562e3898ff2a41a9e880020694f203955608e3b0b857d",
      "blockheight": 1807974,
      "blockindex": 430,
      "blocktime": 1598014259,
      "txid": "ebf7b4cfe5a4aaf3c9faede04369527e14cc7c9766c448c765b6d64e85bee1a8",
      "walletconflicts": [],
      "time": 1598013143,
      "timereceived": 1598013143,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "tb1qwuemetkghucsw44hjhrfzurq2ls3jss9lwfj62",
      "category": "send",
      "amount": -0.00090000,
      "label": "",
      "vout": 1,
      "fee": -0.00000141,
      "confirmations": 286,
      "blockhash": "00000000d8cd50ceee79f11c7a19eaf39edbb99a54aedc778bbcae127ef1bdf3",
      "blockheight": 1807979,
      "blockindex": 287,
      "blocktime": 1598019699,
      "txid": "cbfda9f0cb47ece3e2f0078d074c021548ba3ff53aff583a7777b9a682349d80",
      "walletconflicts": [],
      "time": 1598018608,
      "timereceived": 1598018608,
      "bip125-replaceable": "no",
      "abandoned": false
    },
    {
      "address": "tb1qgflg6yl8au445lt6xfddlvfumvp6d6z3g9wegt",
      "category": "receive",
      "amount": 0.01000000,
      "label": "",
      "vout": 1,
      "confirmations": 5,
      "blockhash": "00000000136a11a9752faa1b074bdbd77e84ae291659e8cf102b64ed41de62da",
      "blockheight": 1808260,
      "blockindex": 64,
      "blocktime": 1598286739,
      "txid": "d51acb8f691f1a7de84ecc338e1fbcb0b19908b192d8ddd05a5f62abf1b32029",
      "walletconflicts": [],
      "time": 1598286265,
      "timereceived": 1598286265,
      "bip125-replaceable": "no"
    }
  ],
  "error": null,
  "id": null
}
```
</details>

### listwalletdir
##### Returns a list of wallets in the wallet directory.
-----
```csharp    

BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string listwalletdir = await wallet.ListWalletDir();

Console.WriteLine(listwalletdir);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "wallets": [
      {
        "name": "apple"
      },
      {
        "name": "banana"
      },
      {
        "name": "boss"
      },
      {
        "name": "cherry"
      },
      {
        "name": "cherryw"
      },
      {
        "name": "orange"
      },
      {
        "name": "tomate"
      },
      {
        "name": ""
      }
    ]
  },
  "error": null,
  "id": null
}
```
</details>

### listwallets
##### Returns a list of currently loaded wallets.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string listwallets = await wallet.ListWallets();

Console.WriteLine(listwallets); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [
    "",
    "apple",
    "banana",
    "boss",
    "cherry",
    "cherryw",
    "orange",
    "tomate"
  ],
  "error": null,
  "id": null
}
```
</details>

### loadwallet
##### Loads a wallet from a wallet file or directory.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient, "boss");

string fileName = "apple";
string loadwallet = await wallet.LoadWallet(fileName);

Console.WriteLine(loadwallet);  
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "name": "apple",
    "warning": ""
  },
  "error": null,
  "id": null
}
```
</details>

### lockunspent
##### Updates list of temporarily unspendable outputs. Temporarily lock (unlock=false) or unlock (unlock=true) specified transaction outputs. If no transaction outputs are specified when unlocking then all current locked transaction outputs are unlocked. A locked transaction output will not be chosen by automatic coin selection, when spending bitcoins. Locks are stored in memory only. Nodes start with zero locked outputs, and the locked output list
is always cleared (by virtue of process exit) when a node stops or fails.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

bool unclock = false;
string lockunspent = await wallet.LockUnspent(unclock);
            
Console.WriteLine(lockunspent);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": true,
  "error": null,
  "id": null
}
```
</details>

### removeprunedfunds
##### Deletes the specified transaction from the wallet. Meant for use with pruned wallets and as a companion to importprunedfunds. This will affect wallet balances.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

string txid = "ab094f2e094824552cc6b69a857ce05ceda1d5eed792b33860470b63707def90";
string removeprunedfunds = await wallet.RemovePrunedFunds(txid);
            
Console.WriteLine(removeprunedfunds);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### rescanblockchain
##### Rescan the local blockchain for wallet related transactions.
Note: Use "getwalletinfo" to query the scanning progress.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient, "apple");

//Optional
int startHeight = 0;

//Optional
int stopHeight = 10000;

string rescanblockchain = await wallet.RescanBlockchain(startHeight, stopHeight);
            
Console.WriteLine(rescanblockchain);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "start_height": 0,
    "stop_height": 10000
  },
  "error": null,
  "id": null
}
```
</details>

### sendmany
##### Send multiple times. Amounts are double-precision floating point numbers. Requires wallet passphrase to be set with walletpassphrase call if wallet is encrypted.
-----
```csharp    

  BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient, "boss");

SendMany sendMany = new SendMany();
sendMany.AddressesAmounts = new List<AddressAmount>()
{
    new AddressAmount("tb1qwuemetkghucsw44hjhrfzurq2ls3jss9lwfj62", 0.0001f),
    new AddressAmount("tb1qqvegzkql09s694kaa0czzav4ragmcnmwqg6ynk", 0.00002f),
    new AddressAmount("tb1qnh2qtqsu4un8xey5d3258tfd7efl3eu4acp076", 0.00035f),
    new AddressAmount("tb1qwmxm8tshffmphupk7wr6j443uechlap7pver9e", 0.00089f),
    new AddressAmount("tb1qlxvfnp6xevdmxsmhqad8n5xecj29d8fpkaaf2k", 0.0004999f)
};

sendMany.ConfTarget = 6;
sendMany.EstimateMode = EstimateMode.CONSERVATIVE;
sendMany.Replaceable = true;
sendMany.SubtractFeeFrom = new List<string> { "tb1qqvegzkql09s694kaa0czzav4ragmcnmwqg6ynk" };
sendMany.Comment = "For coffe";

string rescanblockchain = await wallet.SendMany(sendMany);
            
Console.WriteLine(rescanblockchain);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "8272deeaf27668af2f945ba51aa83754ae6ffd2478e2e58984d47a022a73dd33",
  "error": null,
  "id": null
}
```
</details>

### sendtoaddress
##### Send an amount to a given address. Requires wallet passphrase to be set with walletpassphrase call if wallet is encrypted.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

SendToAddress sendToAddress = new SendToAddress("2NFvnihMBvphwrqBLvoQzSycmoYkMAmVX1a", 0.0000777f);

string sendtoaddress = await wallet.SendToAddress(sendToAddress);
            
Console.WriteLine(sendtoaddress); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "33e32952831e25ad4ebc5ee7a9f9c1402e26addf9c33aca8c3fc400bbad650ef",
  "error": null,
  "id": null
}
```
</details>

### sethdseed
##### Set or generate a new HD wallet seed. Non-HD wallets will not be upgraded to being a HD wallet. Wallets that are already HD will have a new HD seed set so that new keys added to the keypool will be derived from this new seed.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");            
Wallet wallet = new Wallet(bitcoinClient);

bool newKeyPool = true;
string hdSeed = "925p7GqzqXYY6kCFTvpvNF7U74Zj8MA4UVJSC3QKmczUaN8pPqV";
            
string sethdseed = await wallet.SetHDSeed(newKeyPool, hdSeed);
            
Console.WriteLine(sethdseed);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### setlabel
##### Sets the label associated with the given address.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");          
Wallet wallet = new Wallet(bitcoinClient);

string address = "n357LCRWaa2FFUazB1vAMYD79wQLEA1kdh";
string label = "car";

string setlabel = await wallet.SetLabel(address, label);
            
Console.WriteLine(setlabel);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### settxfee
##### Set the transaction fee per kB for this wallet. Overrides the global -paytxfee command line parameter.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

float amount = 0.0001f;

string settxfee = await wallet.SetTxFee(amount);
            
Console.WriteLine(settxfee);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": true,
  "error": null,
  "id": null
}
```
</details>

### setwalletflag
##### Change the state of the given wallet flag for a wallet.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

Flag flag = Flag.Avoid_reuse;
bool value = true;

string setwalletflag = await wallet.SetWalletFlag(flag, value);
            
Console.WriteLine(setwalletflag);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "flag_name": "avoid_reuse",
    "flag_state": true,
    "warnings": "You need to rescan the blockchain in order to correctly mark used destinations in the past. Until this is done, some destinations may be considered unused, even if the opposite is the case."
  },
  "error": null,
  "id": null
}
```
</details>

### signmessage
##### Sign a message with the private key of an address Requires wallet passphrase to be set with walletpassphrase call if wallet is encrypted.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8333", "alice:pass");            
Wallet wallet = new Wallet(bitcoinClient);

//Only legacy addresses supported.
string address = "1BnJ4bvMJBPbXsVRXJ2AEs3GFB8kQ63NwY";
string msg = "Hello World";

string signmessage = await wallet.SignMessage(address, msg);
            
Console.WriteLine(signmessage); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": "H43ZfDF1QV8k5E2b8Gxg2urqB7kWsEK7gqbEclRoMzc0RWhzUO/F7EP6ArUUJ7TD7f4lna8zzTJPd9CS3a29b7g=",
  "error": null,
  "id": null
}
```
</details>

### signrawtransactionwithwallet
##### Sign inputs for raw transaction (serialized, hex-encoded). The second optional argument (may be null) is an array of previous transaction outputs that this transaction depends on but may not yet be in the block chain. Requires wallet passphrase to be set with walletpassphrase call if wallet is encrypted.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient, "boss");
            
string txid = "0200000001c21355a9db10317974a8dccf65cfe6053968f7fdea1a19631943f21dffd26b480000000000ffffffff018c8101000000000016001476cdb3ae174a761bf036f387a956b1e6717ff43e00000000";

string signrawtransactionwithwallet = await wallet.SignRawTransactionWithWallet(txid);           
Console.WriteLine(signrawtransactionwithwallet);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "hex": "02000000000101c21355a9db10317974a8dccf65cfe6053968f7fdea1a19631943f21dffd26b480000000000ffffffff018c8101000000000016001476cdb3ae174a761bf036f387a956b1e6717ff43e0246304302202903f465ed980b7f8f8dc42a84639b1e45d0ae19e482841ad8965a2a02db8e20021f5814249c5e1b9c3458945422bf374495fe461680a9eefe0d1bb2982f23d5eb012102423a287e267ffb18bc72dc85848b5c9d971799ffbe576e6c9f8ef0275b5a11cd00000000",
    "complete": true
  },
  "error": null,
  "id": null
}
```
</details>

### unloadwallet
##### Unloads the active wallet otherwise unloads the wallet specified in the argument.
-----
```csharp    

BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string unloadwallet = await wallet.UnloadWallet();
            
Console.WriteLine(unloadwallet);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### walletcreatefundedpsbt
##### Creates and funds a transaction in the Partially Signed Transaction format. Inputs will be added if supplied inputs are not enough. Implements the Creator and Updater roles.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient, "boss");

//The inputs
List<RawInput> rawInputs = new List<RawInput>();
RawInput rawInput = new RawInput("486bd2ff1df2431963191aeafdf7683905e6cf65cfdca874793110dba95513c2", 0);

rawInputs.Add(rawInput);

//The outputs
List<RawOutput> rawOutputs = new List<RawOutput>();
RawOutput rawOutput = new RawOutput("mi88psRX4MawyLrxjrvwdrg9C6jHVPQifg", 0.0008f);

rawOutputs.Add(rawOutput);

//Data in hex format;
string hexData = "48656c6c6f20576f726c64";

string walletcreatefundedpsbt = await wallet.WalletCreateFundedPSBT(rawInputs, rawOutputs,hexData: hexData);
            
Console.WriteLine(walletcreatefundedpsbt); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "psbt": "cHNidP8BAIoCAAAAAcITVanbEDF5dKjcz2XP5gU5aPf96hoZYxlD8h3/0mtIAAAAAAD/////A4A4AQAAAAAAGXapFByXmfCaDDF7dYP94X7McpvZwfVaiKwaCQ4AAAAAABYAFO4RFDd9uMTRJkoogvoLMxdkd9i8AAAAAAAAAAANagtIZWxsbyBXb3JsZAAAAAAAAQEfQEIPAAAAAAAWABQDMoFYH3lhotbd6/AhdZUfUbxPbiIGAkI6KH4mf/sYvHLchYSLXJ2XF5n/vldubJ\u002BO8CdbWhHNEGPT0\u002BUAAACAAAAAgAMAAIAAACICA9SDITfNkb3deCAOi5GOkLJiegguBjehci73SzUsifVJEIGRNdwAAACAAQAAgAEAAIAAAA==",
    "fee": 0.00000166,
    "changepos": 1
  },
  "error": null,
  "id": null
}
```
</details>

### walletlock
##### Removes the wallet encryption key from memory, locking the wallet. After calling this method, you will need to call walletpassphrase again
before being able to call any methods which require the wallet to be unlocked.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
            
Wallet wallet = new Wallet(bitcoinClient);

string walletlock = await wallet.WalletLock();
            
Console.WriteLine(walletlock); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### walletpassphrase
##### Stores the wallet decryption key in memory for 'timeout' seconds. This is needed prior to performing transactions related to private keys such as sending bitcoins
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient, "");

string passphrase = "12345";
int timeout = 98765431;

string walletpassphrase = await wallet.WalletPassphrase(passphrase, timeout);
Console.WriteLine(walletpassphrase);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### walletpassphrasechange
##### Changes the wallet passphrase from 'oldpassphrase' to 'newpassphrase'.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient);

string oldPassphrase = "12345";
string newPassphrase = "apple";

string walletpassphrasechange = await wallet.WalletPassphraseChange(oldPassphrase, newPassphrase);
Console.WriteLine(walletpassphrasechange); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": null,
  "error": null,
  "id": null
}
```
</details>

### walletprocesspsbt
##### Update a PSBT with input information from our wallet and then sign inputs that we can sign for. Requires wallet passphrase to be set with walletpassphrase call if wallet is encrypted.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");
Wallet wallet = new Wallet(bitcoinClient, "");

string psbt = "cHNidP8BAIoCAAAAAcITVanbEDF5dKjcz2XP5gU5aPf96hoZYxlD8h3/0mtIAAAAAAD/////A4A4AQAAAAAAGXapFByXmfCaDDF7dYP94X7McpvZwfVaiKwaCQ4AAAAAABYAFO4RFDd9uMTRJkoogvoLMxdkd9i8AAAAAAAAAAANagtIZWxsbyBXb3JsZAAAAAAAAQEfQEIPAAAAAAAWABQDMoFYH3lhotbd6/AhdZUfUbxPbiIGAkI6KH4mf/sYvHLchYSLXJ2XF5n/vldubJ\u002BO8CdbWhHNEGPT0\u002BUAAACAAAAAgAMAAIAAACICA9SDITfNkb3deCAOi5GOkLJiegguBjehci73SzUsifVJEIGRNdwAAACAAQAAgAEAAIAAAA==";
            
string walletprocesspsbt = await wallet.WalletProcessPSBT(psbt);
Console.WriteLine(walletprocesspsbt); 
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": {
    "psbt": "cHNidP8BAIoCAAAAAcITVanbEDF5dKjcz2XP5gU5aPf96hoZYxlD8h3/0mtIAAAAAAD/////A4A4AQAAAAAAGXapFByXmfCaDDF7dYP94X7McpvZwfVaiKwaCQ4AAAAAABYAFO4RFDd9uMTRJkoogvoLMxdkd9i8AAAAAAAAAAANagtIZWxsbyBXb3JsZAAAAAAAAQEfQEIPAAAAAAAWABQDMoFYH3lhotbd6/AhdZUfUbxPbiIGAkI6KH4mf/sYvHLchYSLXJ2XF5n/vldubJ\u002BO8CdbWhHNEGPT0\u002BUAAACAAAAAgAMAAIAAACICA9SDITfNkb3deCAOi5GOkLJiegguBjehci73SzUsifVJEIGRNdwAAACAAQAAgAEAAIAAAA==",
    "complete": true
  },
  "error": null,
  "id": null
}
```
</details>







ZMQ
-----
**[getzmqnotifications](#getzmqnotifications)**


### getzmqnotifications
##### Returns information about the active ZeroMQ notifications.
-----
```csharp    
BitcoinClient bitcoinClient = new BitcoinClient("http://127.0.0.1:8332", "alice:pass");           

ZMQ zMQ = new ZMQ(bitcoinClient);

string getzmqnotifications = await zMQ.GetZMQNotifications();

Console.WriteLine(getzmqnotifications);
```

<details>
  
  <summary>Server response</summary>
 
 ```json
{
  "result": [],
  "error": null,
  "id": null
}
```
</details>


