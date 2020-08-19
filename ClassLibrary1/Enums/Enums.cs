using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.Enums
{

    public enum Verbosity : int { VerbosityZero, VerbosityOne, VerbosityTwo }

    public enum ReturnFormat { JSON, ArrayOfTransactionIds }


    public enum BlockHeaderVerbosity { Hex, Json }


    public enum BlockStatsFilter
    {
        avgfee, avgfeerate, avgtxsize, blockhash, feerate_percentiles, height, ins, maxfee, maxfeerate,
        maxtxsize, medianfee, mediantime, mediantxsize, minfee, minfeerate, mintxsize, outs, subsidy,
        swtotal_size, swtotal_weight, swtxs, time, total_out, total_size, total_weight, totalfee, txs,
        utxo_increase, utxo_size_inc

    }

    public enum Scan { Start, Abort, Status }
    public enum Descriptor { raw, addr, multi, combo, wpkh, pkh, pk, wsh, sh }



    public enum Mode { Stats, Mallocinfo }

    public enum CommandHelp
    {
        getbestblockhash, getblock, getblockchaininfo, getblockcount, getblockhash,
        getblockheader, getblockstats, getchaintips, getchaintxstats, getdifficulty, getmempoolancestors,
        getmempooldescendants, getmempoolentry, getmempoolinfo, getrawmempool, gettxout, gettxoutproof, gettxoutsetinfo,
        preciousblock, pruneblockchain, savemempool, scantxoutset, verifychain, verifytxoutproof,
        getmemoryinfo, getrpcinfo, help, logging, stop, uptime, generate, generatetoaddress, getblocktemplate,
        getmininginfo, getnetworkhashps, prioritisetransaction, submitblock, submitheader, addnode, clearbanned, disconnectnode,
        getaddednodeinfo, getconnectioncount, getnettotals, getnetworkinfo, getnodeaddresses, getpeerinfo, listbanned, ping,
        setban, setnetworkactive, analyzepsbt, combinepsbt, combinerawtransaction, converttopsbt, createpsbt, createrawtransaction,
        decodepsbt, decoderawtransaction, decodescript, finalizepsbt, fundrawtransaction, getrawtransaction, joinpsbts,
        sendrawtransaction, signrawtransactionwithkey, testmempoolaccept, utxoupdatepsbt, createmultisig, deriveaddresses,
        estimatesmartfee, getdescriptorinfo, signmessagewithprivkey, validateaddress, verifymessage, abandontransaction,
        abortrescan, addmultisigaddress, backupwallet, bumpfee, createwallet, dumpprivkey, dumpwallet, encryptwallet, getaddressesbylabel,
        getaddressinfo, getbalance, getnewaddress, getrawchangeaddress, getreceivedbyaddress, getreceivedbylabel, gettransaction,
        getunconfirmedbalance, getwalletinfo, importaddress, importmulti, importprivkey, importprunedfunds, importpubkey,
        importwallet, keypoolrefill, listaddressgroupings, listlabels, listlockunspent, listreceivedbyaddress, listreceivedbylabel,
        listsinceblock, listtransactions, listunspent, listwalletdir, listwallets, loadwallet, lockunspent, removeprunedfunds,
        rescanblockchain, sendmany, sendtoaddress, sethdseed, setlabel, settxfee, signmessage, signrawtransactionwithwallet,
        unloadwallet, walletcreatefundedpsbt, walletlock, walletpassphrase, walletpassphrasechange, walletprocesspsbt

    }

    public enum LoggingCategories
    {
        all, none, net, tor, mempool, http, bench, zmq, walletdb, rpc, estimatefee, addrman, selectcoins, reindex,
        cmpctblock, rand, prune, proxy, mempoolrej, libevent, coindb, qt, leveldb, validation
    }

    public enum Capabilities { longpoll, coinbasetxn, coinbasevalue, proposal, serverlist, workid }
    public enum TemplateRequest { none, template, proposal }
    public enum Rules { none, segwit, csv }
    public enum Mutable
    {

        coinbaseAppend, // coinbase/append 
        coinbase,
        generation,
        timeIncrement, // time/increment
        timeDecrement, // time/decrement
        time,
        transactions,
        prevblock,
        versionForce, // version/force
        versionReduce, // version/reduce

    }


    public enum NodeCommand { add, remove, onetry }

    public enum BanCommand { add, remove }


    public enum FeeMode { UNSET, ECONOMICAL, CONSERVATIVE }
    public enum ChangeType { legacy, p2sh_segwit, bech32 }

    public enum TXReturnType { String, JSON }


    public enum SigHashType
    {
        ALL, NONE, SINGLE, ALL_ANYONECANPAY, NONE_ANYONECANPAY, SINGLE_ANYONECANPAY
    }

    public enum AddressType { legacy, p2sh_segwit, bech32 }


    public enum EstimateMode { UNSET, ECONOMICAL, CONSERVATIVE }

    public enum ScriptPubKeyType { Address, Script }
    public enum CreationTime { Now }
    public enum Purpose { Send, Receive }
    public enum Flag { Avoid_reuse }

}
