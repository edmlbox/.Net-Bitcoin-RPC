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
### getblockchaininfo
-----
### getblockcount
-----
### getblockhash
-----
### getblockheader
-----
### getblockstats
-----
### getchaintips
-----
### getchaintxstats
-----
### getdifficulty
-----
### getmempoolancestors
-----
### getmempooldescendants
-----
### getmempoolentry
-----
### getmempoolinfo
-----
### getrawmempool
-----
### gettxout
-----
### gettxoutproof
-----
### gettxoutsetinfo
-----
### preciousblock
-----
### pruneblockchain
-----
### savemempool
-----
### scantxoutset
-----
### verifychain
-----
### verifytxoutproof
-----

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


