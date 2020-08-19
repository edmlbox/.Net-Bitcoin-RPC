using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.StaticStrings
{
    //Method names for bitcoin rpc.
    //Naming Convention. The field name must be exactly as the value.
    static class MethodName
    {
        //BlockChain RPC method names


        public static readonly string getbestblockhash = "getbestblockhash";
        public static readonly string getblockchaininfo = "getblockchaininfo";
        public static readonly string getblockcount = "getblockcount";
        public static readonly string getchaintips = "getchaintips";
        public static readonly string getdifficulty = "getdifficulty";
        public static readonly string gettxoutsetinfo = "gettxoutsetinfo";
        public static readonly string getblockfilter = "getblockfilter";
        public static readonly string savemempool = "savemempool";

        public static readonly string getblock = "getblock";
        public static readonly string getblockhash = "getblockhash";
        public static readonly string getblockheader = "getblockheader";
        public static readonly string getblockstats = "getblockstats";
        public static readonly string getchaintxstats = "getchaintxstats";
        public static readonly string getmempoolancestors = "getmempoolancestors";
        public static readonly string getmempooldescendants = "getmempooldescendants";
        public static readonly string getmempoolentry = "getmempoolentry";
        public static readonly string getmempoolinfo = "getmempoolinfo";
        public static readonly string getrawmempool = "getrawmempool";
        public static readonly string gettxout = "gettxout";
        public static readonly string gettxoutproof = "gettxoutproof";
        public static readonly string preciousblock = "preciousblock";
        public static readonly string pruneblockchain = "pruneblockchain";
        //EXPERIMENTAL warning: this call may be removed or changed in future releases.
        public static readonly string scantxoutset = "scantxoutset";
        //End
        public static readonly string verifychain = "verifychain";
        public static readonly string verifytxoutproof = "verifytxoutproof";


        //Control RPCs
        public static readonly string getmemoryinfo = "getmemoryinfo";
        public static readonly string getrpcinfo = "getrpcinfo";
        public static readonly string help = "help";
        public static readonly string logging = "logging";
        public static readonly string stop = "stop";
        public static readonly string uptime = "uptime";


        //Generating RPCs works in regtest only.
        public static readonly string generate = "generate";
        public static readonly string generatetoaddress = "generatetoaddress";
        public static readonly string generatetodescriptor = "generatetodescriptor";

        //Mining RPCs
        public static readonly string getblocktemplate = "getblocktemplate";
        public static readonly string getmininginfo = "getmininginfo";
        public static readonly string getnetworkhashps = "getnetworkhashps";
        public static readonly string prioritisetransaction = "prioritisetransaction";
        public static readonly string submitblock = "submitblock";
        public static readonly string submitheader = "submitheader";


        //Network RPCs
        public static readonly string addnode = "addnode";
        public static readonly string clearbanned = "clearbanned";
        public static readonly string disconnectnode = "disconnectnode";
        public static readonly string getaddednodeinfo = "getaddednodeinfo";
        public static readonly string getconnectioncount = "getconnectioncount";
        public static readonly string getnettotals = "getnettotals";
        public static readonly string getnetworkinfo = "getnetworkinfo";
        public static readonly string getnodeaddresses = "getnodeaddresses";
        public static readonly string getpeerinfo = "getpeerinfo";
        public static readonly string listbanned = "listbanned";
        public static readonly string ping = "ping";
        public static readonly string setban = "setban";
        public static readonly string setnetworkactive = "setnetworkactive";

        //Rawtransactions RPCs
        public static readonly string analyzepsbt = "analyzepsbt";
        public static readonly string combinepsbt = "combinepsbt";
        public static readonly string combinerawtransaction = "combinerawtransaction";
        public static readonly string converttopsbt = "converttopsbt";
        public static readonly string createpsbt = "createpsbt";
        public static readonly string createrawtransaction = "createrawtransaction";
        public static readonly string decodepsbt = "decodepsbt";
        public static readonly string decoderawtransaction = "decoderawtransaction";
        public static readonly string decodescript = "decodescript";
        public static readonly string finalizepsbt = "finalizepsbt";
        public static readonly string fundrawtransaction = "fundrawtransaction";
        public static readonly string getrawtransaction = "getrawtransaction";
        public static readonly string joinpsbts = "joinpsbts";
        public static readonly string sendrawtransaction = "sendrawtransaction";
        public static readonly string signrawtransactionwithkey = "signrawtransactionwithkey";
        public static readonly string testmempoolaccept = "testmempoolaccept";
        public static readonly string utxoupdatepsbt = "utxoupdatepsbt";

        //Util RPCs
        public static readonly string createmultisig = "createmultisig";
        public static readonly string deriveaddresses = "deriveaddresses";
        public static readonly string estimatesmartfee = "estimatesmartfee";
        public static readonly string getdescriptorinfo = "getdescriptorinfo";
        public static readonly string signmessagewithprivkey = "signmessagewithprivkey";
        public static readonly string validateaddress = "validateaddress";
        public static readonly string verifymessage = "verifymessage";


        //Wallet RPC method names
        public static readonly string abandontransaction = "abandontransaction";
        public static readonly string abortrescan = "abortrescan";
        public static readonly string addmultisigaddress = "addmultisigaddress";
        public static readonly string backupwallet = "backupwallet";
        public static readonly string bumpfee = "bumpfee";
        public static readonly string createwallet = "createwallet";
        public static readonly string dumpprivkey = "dumpprivkey";
        public static readonly string dumpwallet = "dumpwallet";
        public static readonly string encryptwallet = "encryptwallet";
        public static readonly string getaddressesbylabel = "getaddressesbylabel";
        public static readonly string getaddressinfo = "getaddressinfo";
        public static readonly string getbalance = "getbalance";
        public static readonly string getbalances = "getbalances";
        public static readonly string getnewaddress = "getnewaddress";
        public static readonly string getrawchangeaddress = "getrawchangeaddress";
        public static readonly string getreceivedbyaddress = "getreceivedbyaddress";
        public static readonly string getreceivedbylabel = "getreceivedbylabel";
        public static readonly string gettransaction = "gettransaction";
        public static readonly string getunconfirmedbalance = "getunconfirmedbalance";
        public static readonly string getwalletinfo = "getwalletinfo";
        public static readonly string importaddress = "importaddress";
        public static readonly string importmulti = "importmulti";
        public static readonly string importprivkey = "importprivkey";
        public static readonly string importprunedfunds = "importprunedfunds";
        public static readonly string importpubkey = "importpubkey";
        public static readonly string importwallet = "importwallet";
        public static readonly string keypoolrefill = "keypoolrefill";
        public static readonly string listaddressgroupings = "listaddressgroupings";
        public static readonly string listlabels = "listlabels";
        public static readonly string listlockunspent = "listlockunspent";
        public static readonly string listreceivedbyaddress = "listreceivedbyaddress";
        public static readonly string listreceivedbylabel = "listreceivedbylabel";
        public static readonly string listsinceblock = "listsinceblock";
        public static readonly string listtransactions = "listtransactions";
        public static readonly string listunspent = "listunspent";
        public static readonly string listwalletdir = "listwalletdir";
        public static readonly string listwallets = "listwallets";
        public static readonly string loadwallet = "loadwallet";
        public static readonly string lockunspent = "lockunspent";
        public static readonly string removeprunedfunds = "removeprunedfunds";
        public static readonly string rescanblockchain = "rescanblockchain";
        public static readonly string sendmany = "sendmany";
        public static readonly string sendtoaddress = "sendtoaddress";
        public static readonly string sethdseed = "sethdseed";
        public static readonly string setlabel = "setlabel";
        public static readonly string settxfee = "settxfee";
        public static readonly string setwalletflag = "setwalletflag";
        public static readonly string signmessage = "signmessage";
        public static readonly string signrawtransactionwithwallet = "signrawtransactionwithwallet";
        public static readonly string unloadwallet = "unloadwallet";
        public static readonly string walletcreatefundedpsbt = "walletcreatefundedpsbt";
        public static readonly string walletlock = "walletlock";
        public static readonly string walletpassphrase = "walletpassphrase";
        public static readonly string walletpassphrasechange = "walletpassphrasechange";
        public static readonly string walletprocesspsbt = "walletprocesspsbt";

        //ZMQ
        public static readonly string getzmqnotifications = "getzmqnotifications";

    }

}
