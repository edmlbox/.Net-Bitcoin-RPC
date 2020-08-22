# .Net-Bitcoin-RPC

### Bitcoin Core RPC library for .Net. Covers all commands. 

Table of contents
=================
   
<!--ts-->
   * [Installation](#installation)
   * [Core RPC](#usage)
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


BLOCKCHAIN
-----

**[getbestblockhash](#getbestblockhash),** **[getblock](#getblock)**, **[getblockchaininfo](#getblockchaininfo)**, **[getblockcount](#getblockcount)**, **[getblockhash](#getblockhash)**,  **[getblockheader](#getblockheader)**,  **[getblockstats](#getblockstats)**,  **[getchaintips](#getchaintips)**,  **[getchaintxstats](#getchaintxstats)**,  **[getdifficulty](#getdifficulty)**,  **[getmempoolancestors](#getmempoolancestors)**,  **[getmempooldescendants](#getmempooldescendants)**,  **[getmempoolentry](#getmempoolentry)**,  **[getmempoolinfo](#getmempoolinfo)**, **[getrawmempool](#getrawmempool)**, **[gettxout](#gettxout)**, **[gettxoutproof](#gettxoutproof)**, **[gettxoutsetinfo](#gettxoutsetinfo)**, **[preciousblock](#preciousblock)**, **[pruneblockchain](#pruneblockchain)**, **[savemempool](#savemempool)**, **[scantxoutset](#scantxoutset)**, **[verifychain](#verifychain)**, **[verifytxoutproof](#verifytxoutproof)**


### getbestblockhash
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
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### generatetodescriptor
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>



MINING
-----
**[getblocktemplate](#getblocktemplate)**, **[getmininginfo](#getmininginfo)**, **[getnetworkhashps](#getnetworkhashps)**, **[prioritisetransaction](#prioritisetransaction)**, **[submitblock](#submitblock)**, **[submitheader](#submitheader)**


### getblocktemplate
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getmininginfo
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getnetworkhashps
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### prioritisetransaction
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### submitblock
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### submitheader
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>


NETWORK
-----
**[addnode](#addnode)**, **[clearbanned](#clearbanned)**, **[disconnectnode](#disconnectnode)**, **[getaddednodeinfo](#getaddednodeinfo)**, **[getconnectioncount](#getconnectioncount)**, **[getnettotals](#getnettotals)**, **[getnetworkinfo](#getnetworkinfo)**, **[getnodeaddresses](#getnodeaddresses)**, **[getpeerinfo](#getpeerinfo)**, **[listbanned](#listbanned)**, **[ping](#ping)**, **[setban](#setban)**, **[setnetworkactive](#setnetworkactive)**


### addnode
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### clearbanned
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### disconnectnode
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getaddednodeinfo
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getconnectioncount
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getnettotals
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getnetworkinfo
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getnodeaddresses
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getpeerinfo
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listbanned
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### ping
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### setban
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### setnetworkactive
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>


RAWTRANSACTIONS
-----
**[analyzepsbt](#analyzepsbt)**, **[combinepsbt](#combinepsbt)**, **[combinerawtransaction](#combinerawtransaction)**, **[converttopsbt](#converttopsbt)**, **[createpsbt](#createpsbt)**, **[createrawtransaction](#createrawtransaction)**, **[decodepsbt](#decodepsbt)**, **[decoderawtransaction](#decoderawtransaction)**, **[decodescript](#decodescript)**, **[finalizepsbt](#finalizepsbt)**, **[fundrawtransaction](#fundrawtransaction)**, **[getrawtransaction](#getrawtransaction)**, **[joinpsbts](#joinpsbts)**, **[sendrawtransaction](#sendrawtransaction)**, **[signrawtransactionwithkey](#signrawtransactionwithkey)**, **[testmempoolaccept](#testmempoolaccept)**, **[utxoupdatepsbt](#utxoupdatepsbt)**


### analyzepsbt
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### combinepsbt
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### combinerawtransaction
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### converttopsbt
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### createpsbt
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### createrawtransaction
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### decodepsbt
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### decoderawtransaction
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### decodescript
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### finalizepsbt
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### fundrawtransaction
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getrawtransaction
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### joinpsbts
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### sendrawtransaction
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### signrawtransactionwithkey
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### testmempoolaccept
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### utxoupdatepsbt
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

UTIL
-----
**[createmultisig](#createmultisig)**, **[deriveaddresses](#deriveaddresses)**, **[estimatesmartfee](#estimatesmartfee)**, **[getdescriptorinfo](#getdescriptorinfo)**, **[signmessagewithprivkey](#signmessagewithprivkey)**, **[validateaddress](#validateaddress)**, **[verifymessage](#verifymessage)**


### createmultisig
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### deriveaddresses
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### estimatesmartfee
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getdescriptorinfo
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### signmessagewithprivkey
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### validateaddress
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### verifymessage
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

WALLET
-----
**[abandontransaction](#abandontransaction)**, **[abortrescan](#abortrescan)**, **[addmultisigaddress](#addmultisigaddress)**, **[backupwallet](#backupwallet)**,  **[bumpfee](#bumpfee)**,  **[createwallet](#createwallet)**,  **[dumpprivkey](#dumpprivkey)**,  **[dumpwallet](#dumpwallet)**,  **[encryptwallet](#encryptwallet)**,  **[getaddressesbylabel](#getaddressesbylabel)**,  **[getaddressinfo](#getaddressinfo)**,  **[getbalance](#getbalance)**,  **[getbalances](#getbalances)**,  **[getnewaddress](#getnewaddress)**,  **[getrawchangeaddress](#getrawchangeaddress)**,  **[getreceivedbyaddress](#getreceivedbyaddress)**,  **[getreceivedbylabel](#getreceivedbylabel)**,  **[gettransaction](#gettransaction)**,  **[getunconfirmedbalance](#getunconfirmedbalance)**,  **[getwalletinfo](#getwalletinfo)**,  **[importaddress](#importaddress)**,  **[importmulti](#importmulti)**,  **[importprivkey](#importprivkey)**,  **[importprunedfunds](#importprunedfunds)**,  **[importpubkey](#importpubkey)**,  **[importwallet](#importwallet)**,  **[keypoolrefill](#keypoolrefill)**,  **[listaddressgroupings](#listaddressgroupings)**,  **[listlabels](#listlabels)**,  **[listlockunspent](#listlockunspent)**,  **[listreceivedbyaddress](#listreceivedbyaddress)**,  **[listreceivedbylabel](#listreceivedbylabel)**,  **[listsinceblock](#listsinceblock)**,  **[listtransactions](#listtransactions)**,  **[listunspent](#listunspent)**,  **[listwalletdir](#listwalletdir)**,  **[listwallets](#listwallets)**,  **[loadwallet](#loadwallet)**,  **[lockunspent](#lockunspent)**,  **[removeprunedfunds](#removeprunedfunds)**,  **[rescanblockchain](#rescanblockchain)**,  **[sendmany](#sendmany)**,  **[sendtoaddress](#sendtoaddress)**,  **[sethdseed](#sethdseed)**,  **[setlabel](#setlabel)**,  **[settxfee](#settxfee)**,  **[setwalletflag](#setwalletflag)**,  **[signmessage](#signmessage)**,  **[signrawtransactionwithwallet](#signrawtransactionwithwallet)**,  **[unloadwallet](#unloadwallet)**,  **[walletcreatefundedpsbt](#walletcreatefundedpsbt)**,  **[walletlock](#walletlock)**,  **[walletpassphrase](#walletpassphrase)**,  **[walletpassphrasechange](#walletpassphrasechange)**,  **[walletprocesspsbt](#walletprocesspsbt)**


### abandontransaction
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### abortrescan
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### addmultisigaddress
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### backupwallet
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### bumpfee
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### createwallet
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### dumpprivkey
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### dumpwallet
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### encryptwallet
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getaddressesbylabel
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getaddressinfo
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getbalance
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getbalances
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getnewaddress
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getrawchangeaddress
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getreceivedbyaddress
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getreceivedbylabel
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### gettransaction
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getunconfirmedbalance
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getwalletinfo
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### importaddress
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### importmulti
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### importprivkey
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### importprunedfunds
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### importpubkey
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### importwallet
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### keypoolrefill
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listaddressgroupings
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listlabels
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listlockunspent
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listreceivedbyaddress
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listreceivedbylabel
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listsinceblock
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listtransactions
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listunspent
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listwalletdir
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### listwallets
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### loadwallet
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### lockunspent
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### removeprunedfunds
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### rescanblockchain
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### sendmany
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### sendtoaddress
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### sethdseed
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### setlabel
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### settxfee
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### setwalletflag
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### signmessage
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### signrawtransactionwithwallet
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### unloadwallet
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### walletcreatefundedpsbt
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### walletlock
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### walletpassphrase
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### walletpassphrasechange
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### walletprocesspsbt
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>







ZMQ
-----
**[getzmqnotifications](#getzmqnotifications)**


### getzmqnotifications
-----
```csharp    

  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>


