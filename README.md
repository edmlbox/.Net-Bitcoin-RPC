# .Net-Bitcoin-RPC

### Bitcoin Core Rpc library for .Net. Covers all commands. 

Table of contents
=================
   
<!--ts-->
   * [Installation](#installation)
   * [Core Rpc](#usage)
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

 string getbestblockhash = await blockchain.GetBlock("00000000000000fd38c98aeef2f981a9591375748c2bb09b043be251d213edaf");
 
 Console.WriteLine(getbestblockhash);
  
```

<details>
  
  <summary>Server response</summary>
 
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

### getblockchaininfo
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getblockcount
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getblockhash
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getblockheader
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getblockstats
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getchaintips
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getchaintxstats
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getdifficulty
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getmempoolancestors
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getmempooldescendants
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getmempoolentry
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getmempoolinfo
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### getrawmempool
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### gettxout
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### gettxoutproof
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### gettxoutsetinfo
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### preciousblock
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### pruneblockchain
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### savemempool
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### scantxoutset
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### verifychain
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

### verifytxoutproof
-----
```csharp    
 
  
```

<details>
  
  <summary>Server response</summary>
 
 ```json

```
</details>

CONTROL
-----
**[getmemoryinfo](#getmemoryinfo)**, **[getrpcinfo](#getrpcinfo)**, **[help](#help)**, **[logging](#logging)**, **[stop](#stop)**, **[uptime](#uptime)**


### getmemoryinfo
-----
### getrpcinfo
-----
### help
-----
### logging
-----
### stop
-----
### uptime
-----


GENERATING
-----
**[generatetoaddress](#generatetoaddress)**, **[generatetodescriptor](#generatetodescriptor)**


### generatetoaddress
-----
### generatetodescriptor
-----



MINING
-----
**[getblocktemplate](#getblocktemplate)**, **[getmininginfo](#getmininginfo)**, **[getnetworkhashps](#getnetworkhashps)**, **[prioritisetransaction](#prioritisetransaction)**, **[submitblock](#submitblock)**, **[submitheader](#submitheader)**


### getblocktemplate
-----
### getmininginfo
-----
### getnetworkhashps
-----
### prioritisetransaction
-----
### submitblock
-----
### submitheader
-----


NETWORK
-----
**[addnode](#addnode)**, **[clearbanned](#clearbanned)**, **[disconnectnode](#disconnectnode)**, **[getaddednodeinfo](#getaddednodeinfo)**, **[getconnectioncount](#getconnectioncount)**, **[getnettotals](#getnettotals)**, **[getnetworkinfo](#getnetworkinfo)**, **[getnodeaddresses](#getnodeaddresses)**, **[getpeerinfo](#getpeerinfo)**, **[listbanned](#listbanned)**, **[ping](#ping)**, **[setban](#setban)**, **[setnetworkactive](#setnetworkactive)**


### addnode
-----
### clearbanned
-----
### disconnectnode
-----
### getaddednodeinfo
-----
### getconnectioncount
-----
### getnettotals
-----
### getnetworkinfo
-----
### getnodeaddresses
-----
### getpeerinfo
-----
### listbanned
-----
### ping
-----
### setban
-----
### setnetworkactive
-----


RAWTRANSACTIONS
-----
**[analyzepsbt](#analyzepsbt)**, **[combinepsbt](#combinepsbt)**, **[combinerawtransaction](#combinerawtransaction)**, **[converttopsbt](#converttopsbt)**, **[createpsbt](#createpsbt)**, **[createrawtransaction](#createrawtransaction)**, **[decodepsbt](#decodepsbt)**, **[decoderawtransaction](#decoderawtransaction)**, **[decodescript](#decodescript)**, **[finalizepsbt](#finalizepsbt)**, **[fundrawtransaction](#fundrawtransaction)**, **[getrawtransaction](#getrawtransaction)**, **[joinpsbts](#joinpsbts)**, **[sendrawtransaction](#sendrawtransaction)**, **[signrawtransactionwithkey](#signrawtransactionwithkey)**, **[testmempoolaccept](#testmempoolaccept)**, **[utxoupdatepsbt](#utxoupdatepsbt)**


### analyzepsbt
-----
### combinepsbt
-----
### combinerawtransaction
-----
### converttopsbt
-----
### createpsbt
-----
### createrawtransaction
-----
### decodepsbt
-----
### decoderawtransaction
-----
### decodescript
-----
### finalizepsbt
-----
### fundrawtransaction
-----
### getrawtransaction
-----
### joinpsbts
-----
### sendrawtransaction
-----
### signrawtransactionwithkey
-----
### testmempoolaccept
-----
### utxoupdatepsbt
-----


UTIL
-----
**[createmultisig](#createmultisig)**, **[deriveaddresses](#deriveaddresses)**, **[estimatesmartfee](#estimatesmartfee)**, **[getdescriptorinfo](#getdescriptorinfo)**, **[signmessagewithprivkey](#signmessagewithprivkey)**, **[validateaddress](#validateaddress)**, **[verifymessage](#verifymessage)**


### createmultisig
-----
### deriveaddresses
-----
### estimatesmartfee
-----
### getdescriptorinfo
-----
### signmessagewithprivkey
-----
### validateaddress
-----
### verifymessage
-----


WALLET
-----
**[abandontransaction](#abandontransaction)**, **[abortrescan](#abortrescan)**, **[addmultisigaddress](#addmultisigaddress)**, **[backupwallet](#backupwallet)**,  **[bumpfee](#bumpfee)**,  **[createwallet](#createwallet)**,  **[dumpprivkey](#dumpprivkey)**,  **[dumpwallet](#dumpwallet)**,  **[encryptwallet](#encryptwallet)**,  **[getaddressesbylabel](#getaddressesbylabel)**,  **[getaddressinfo](#getaddressinfo)**,  **[getbalance](#getbalance)**,  **[getbalances](#getbalances)**,  **[getnewaddress](#getnewaddress)**,  **[getrawchangeaddress](#getrawchangeaddress)**,  **[getreceivedbyaddress](#getreceivedbyaddress)**,  **[getreceivedbylabel](#getreceivedbylabel)**,  **[gettransaction](#gettransaction)**,  **[getunconfirmedbalance](#getunconfirmedbalance)**,  **[getwalletinfo](#getwalletinfo)**,  **[importaddress](#importaddress)**,  **[importmulti](#importmulti)**,  **[importprivkey](#importprivkey)**,  **[importprunedfunds](#importprunedfunds)**,  **[importpubkey](#importpubkey)**,  **[importwallet](#importwallet)**,  **[keypoolrefill](#keypoolrefill)**,  **[listaddressgroupings](#listaddressgroupings)**,  **[listlabels](#listlabels)**,  **[listlockunspent](#listlockunspent)**,  **[listreceivedbyaddress](#listreceivedbyaddress)**,  **[listreceivedbylabel](#listreceivedbylabel)**,  **[listsinceblock](#listsinceblock)**,  **[listtransactions](#listtransactions)**,  **[listunspent](#listunspent)**,  **[listwalletdir](#listwalletdir)**,  **[listwallets](#listwallets)**,  **[loadwallet](#loadwallet)**,  **[lockunspent](#lockunspent)**,  **[removeprunedfunds](#removeprunedfunds)**,  **[rescanblockchain](#rescanblockchain)**,  **[sendmany](#sendmany)**,  **[sendtoaddress](#sendtoaddress)**,  **[sethdseed](#sethdseed)**,  **[setlabel](#setlabel)**,  **[settxfee](#settxfee)**,  **[setwalletflag](#setwalletflag)**,  **[signmessage](#signmessage)**,  **[signrawtransactionwithwallet](#signrawtransactionwithwallet)**,  **[unloadwallet](#unloadwallet)**,  **[walletcreatefundedpsbt](#walletcreatefundedpsbt)**,  **[walletlock](#walletlock)**,  **[walletpassphrase](#walletpassphrase)**,  **[walletpassphrasechange](#walletpassphrasechange)**,  **[walletprocesspsbt](#walletprocesspsbt)**


### abandontransaction
-----
### abortrescan
-----
### addmultisigaddress
-----
### backupwallet
-----
### bumpfee
-----
### createwallet
-----
### dumpprivkey
-----
### dumpwallet
-----
### encryptwallet
-----
### getaddressesbylabel
-----
### getaddressinfo
-----
### getbalance
-----
### getbalances
-----
### getnewaddress
-----
### getrawchangeaddress
-----
### getreceivedbyaddress
-----
### getreceivedbylabel
-----
### gettransaction
-----
### getunconfirmedbalance
-----
### getwalletinfo
-----
### importaddress
-----
### importmulti
-----
### importprivkey
-----
### importprunedfunds
-----
### importpubkey
-----
### importwallet
-----
### keypoolrefill
-----
### listaddressgroupings
-----
### listlabels
-----
### listlockunspent
-----
### listreceivedbyaddress
-----
### listreceivedbylabel
-----
### listsinceblock
-----
### listtransactions
-----
### listunspent
-----
### listwalletdir
-----
### listwallets
-----
### loadwallet
-----
### lockunspent
-----
### removeprunedfunds
-----
### rescanblockchain
-----
### sendmany
-----
### sendtoaddress
-----
### sethdseed
-----
### setlabel
-----
### settxfee
-----
### setwalletflag
-----
### signmessage
-----
### signrawtransactionwithwallet
-----
### unloadwallet
-----
### walletcreatefundedpsbt
-----
### walletlock
-----
### walletpassphrase
-----
### walletpassphrasechange
-----
### walletprocesspsbt
-----







ZMQ
-----
**[getzmqnotifications](#getzmqnotifications)**


### getzmqnotifications
-----


