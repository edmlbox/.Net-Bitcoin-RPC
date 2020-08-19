using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace BitcoinRpc
{
    class MethodNameSwitch
    {
        readonly CaseWriter CaseWriter;
        public MethodNameSwitch()
        {
            CaseWriter = new CaseWriter();
        }

        public void MethodNameFilter(string methodName, object guesType, Utf8JsonWriter writer)
        {
            if (guesType == null) { writer.WriteEndArray(); return; }

            switch (methodName)
            {
                case "getblock":
                    {
                        CaseWriter.GetBlock(methodName, guesType, writer);
                        break;
                    }

                case "getblockhash":
                    {
                        CaseWriter.GetBlockHash(methodName, guesType, writer);
                        break;
                    }
                case "getblockfilter":
                    {
                        CaseWriter.GetBlockFilter(methodName, guesType, writer);
                        break;
                    }

                case "getblockheader":
                    {
                        CaseWriter.GetBlockHeader(methodName, guesType, writer);
                        break;
                    }
                case "getblockstats":
                    {
                        CaseWriter.GetBlockStats(methodName, guesType, writer);
                        break;
                    }
                case "getchaintxstats":
                    {
                        CaseWriter.GetChainTxStats(methodName, guesType, writer);
                        break;
                    }
                case "getmempoolancestors":
                    {
                        CaseWriter.GetMempoolAncestors(methodName, guesType, writer);
                        break;
                    }
                case "getmempooldescendants":
                    {
                        CaseWriter.GetMempoolDescendants(methodName, guesType, writer);
                        break;
                    }
                case "getmempoolentry":
                    {
                        CaseWriter.GetMempoolEntry(methodName, guesType, writer);
                        break;
                    }
                case "getrawmempool":
                    {
                        CaseWriter.GetRawMempool(methodName, guesType, writer);
                        break;
                    }
                case "gettxout":
                    {
                        CaseWriter.GetTxOut(methodName, guesType, writer);
                        break;
                    }
                case "gettxoutproof":
                    {
                        CaseWriter.GetTxOutProof(methodName, guesType, writer);
                        break;
                    }
                case "preciousblock":
                    {
                        CaseWriter.PreciousBlock(methodName, guesType, writer);
                        break;
                    }
                case "pruneblockchain":
                    {
                        CaseWriter.PruneBlockchain(methodName, guesType, writer);
                        break;
                    }
                case "scantxoutset":
                    {
                        CaseWriter.ScanTxOutSet(methodName, guesType, writer);
                        break;
                    }
                case "verifychain":
                    {
                        CaseWriter.VerifyChain(methodName, guesType, writer);
                        break;
                    }
                case "verifytxoutproof":
                    {
                        CaseWriter.VerifyTxOutProof(methodName, guesType, writer);
                        break;
                    }
                case "getmemoryinfo":
                    {
                        CaseWriter.GetMemoryInfo(methodName, guesType, writer);
                        break;
                    }
                case "help":
                    {
                        CaseWriter.Help(methodName, guesType, writer);
                        break;
                    }
                case "generate":
                    {
                        CaseWriter.Generate(methodName, guesType, writer);
                        break;
                    }
                case "generatetoaddress":
                    {
                        CaseWriter.GenerateToAddress(methodName, guesType, writer);
                        break;
                    }
                case "generatetodescriptor":
                    {
                        CaseWriter.GenerateToDescriptor(methodName, guesType, writer);
                        break;
                    }
                case "getblocktemplate":
                    {
                        CaseWriter.GetBlockTemplate(methodName, guesType, writer);
                        break;
                    }
                case "getnetworkhashps":
                    {
                        CaseWriter.GetNetworkHashPS(methodName, guesType, writer);
                        break;
                    }
                case "prioritisetransaction":
                    {
                        CaseWriter.PrioritiseTransaction(methodName, guesType, writer);
                        break;
                    }
                case "submitblock":
                    {
                        CaseWriter.SubmitBlock(methodName, guesType, writer);
                        break;
                    }
                case "submitheader":
                    {
                        CaseWriter.SubmitHeader(methodName, guesType, writer);
                        break;
                    }
                case "addnode":
                    {
                        CaseWriter.AddNode(methodName, guesType, writer);
                        break;
                    }
                case "disconnectnode":
                    {
                        CaseWriter.DisconnectNode(methodName, guesType, writer);
                        break;
                    }
                case "getaddednodeinfo":
                    {
                        CaseWriter.GetAddedNodeInfo(methodName, guesType, writer);
                        break;
                    }
                case "getnodeaddresses":
                    {
                        CaseWriter.GetNodeAddresses(methodName, guesType, writer);
                        break;
                    }
                case "setban":
                    {
                        CaseWriter.SetBan(methodName, guesType, writer);
                        break;
                    }
                case "setnetworkactive":
                    {
                        CaseWriter.State(methodName, guesType, writer);
                        break;
                    }
                case "analyzepsbt":
                    {
                        CaseWriter.AnalyzePSBT(methodName, guesType, writer);
                        break;
                    }
                case "combinepsbt":
                    {
                        CaseWriter.CombinePSBT(methodName, guesType, writer);
                        break;
                    }
                case "combinerawtransaction":
                    {
                        CaseWriter.CombineRawTransaction(methodName, guesType, writer);
                        break;
                    }
                case "converttopsbt":
                    {
                        CaseWriter.ConvertToPSBT(methodName, guesType, writer);
                        break;
                    }
                case "createpsbt":
                    {
                        CaseWriter.CreatePSBT(methodName, guesType, writer);
                        break;
                    }
                case "createrawtransaction":
                    {
                        CaseWriter.CreateRawTransaction(methodName, guesType, writer);
                        break;
                    }
                case "decodepsbt":
                    {
                        CaseWriter.DecodePSBT(methodName, guesType, writer);
                        break;
                    }
                case "decoderawtransaction":
                    {
                        CaseWriter.DecodeRawTransaction(methodName, guesType, writer);
                        break;
                    }
                case "decodescript":
                    {
                        CaseWriter.DecodeScript(methodName, guesType, writer);
                        break;
                    }
                case "finalizepsbt":
                    {
                        CaseWriter.FinalizePSBT(methodName, guesType, writer);
                        break;
                    }
                case "fundrawtransaction":
                    {
                        CaseWriter.FundRawTransaction(methodName, guesType, writer);
                        break;
                    }
                case "getrawtransaction":
                    {
                        CaseWriter.GetRawTransaction(methodName, guesType, writer);
                        break;
                    }
                case "joinpsbts":
                    {
                        CaseWriter.JoinPSBTS(methodName, guesType, writer);
                        break;
                    }
                case "sendrawtransaction":
                    {
                        CaseWriter.SendRawTransaction(methodName, guesType, writer);
                        break;
                    }
                case "signrawtransactionwithkey":
                    {
                        CaseWriter.SignRawTransactionWithKey(methodName, guesType, writer);
                        break;
                    }
                case "testmempoolaccept":
                    {
                        CaseWriter.TestMemPoolAccept(methodName, guesType, writer);
                        break;
                    }
                case "utxoupdatepsbt":
                    {
                        CaseWriter.UtxoUpdatePSBT(methodName, guesType, writer);
                        break;
                    }
                case "createmultisig":
                    {
                        CaseWriter.CreateMultisig(methodName, guesType, writer);
                        break;
                    }
                case "deriveaddresses":
                    {
                        CaseWriter.DeriveAddresses(methodName, guesType, writer);
                        break;
                    }
                case "estimatesmartfee":
                    {
                        CaseWriter.EstimateSmartFee(methodName, guesType, writer);
                        break;
                    }
                case "getdescriptorinfo":
                    {
                        CaseWriter.GetDescriptorInfo(methodName, guesType, writer);
                        break;
                    }
                case "signmessagewithprivkey":
                    {
                        CaseWriter.SignMessageWithPrivKey(methodName, guesType, writer);
                        break;
                    }
                case "validateaddress":
                    {
                        CaseWriter.ValidateAddress(methodName, guesType, writer);
                        break;
                    }
                case "verifymessage":
                    {
                        CaseWriter.VerifyMessage(methodName, guesType, writer);
                        break;
                    }
                case "abandontransaction":
                    {
                        CaseWriter.AbandonTransaction(methodName, guesType, writer);
                        break;
                    }
                case "addmultisigaddress":
                    {
                        CaseWriter.AddMultisigAddress(methodName, guesType, writer);
                        break;
                    }
                case "backupwallet":
                    {
                        CaseWriter.BackupWallet(methodName, guesType, writer);
                        break;
                    }
                case "bumpfee":
                    {
                        CaseWriter.BumpFee(methodName, guesType, writer);
                        break;
                    }
                case "createwallet":
                    {
                        CaseWriter.CreateWallet(methodName, guesType, writer);
                        break;
                    }
                case "dumpprivkey":
                    {
                        CaseWriter.DumpPrivKey(methodName, guesType, writer);
                        break;
                    }
                case "dumpwallet":
                    {
                        CaseWriter.DumpWallet(methodName, guesType, writer);
                        break;
                    }
                case "encryptwallet":
                    {
                        CaseWriter.EncryptWallet(methodName, guesType, writer);
                        break;
                    }
                case "getaddressesbylabel":
                    {
                        CaseWriter.GetAddressesByLabel(methodName, guesType, writer);
                        break;
                    }
                case "loadwallet":
                    {
                        CaseWriter.LoadWallet(methodName, guesType, writer);
                        break;
                    }
                case "getaddressinfo":
                    {
                        CaseWriter.GetAddressInfo(methodName, guesType, writer);
                        break;
                    }
                case "getbalance":
                    {
                        CaseWriter.GetBalance(methodName, guesType, writer);
                        break;
                    }
                case "getnewaddress":
                    {
                        CaseWriter.GetNewAddress(methodName, guesType, writer);
                        break;
                    }
                case "getrawchangeaddress":
                    {
                        CaseWriter.GetRawChangeAddress(methodName, guesType, writer);
                        break;
                    }
                case "getreceivedbyaddress":
                    {
                        CaseWriter.GetReceivedByAddress(methodName, guesType, writer);
                        break;
                    }
                case "getreceivedbylabel":
                    {
                        CaseWriter.GetReceivedByLabel(methodName, guesType, writer);
                        break;
                    }
                case "gettransaction":
                    {
                        CaseWriter.GetTransaction(methodName, guesType, writer);
                        break;
                    }
                case "importaddress":
                    {
                        CaseWriter.ImportAddress(methodName, guesType, writer);
                        break;
                    }
                case "importmulti":
                    {
                        CaseWriter.ImportMulti(methodName, guesType, writer);
                        break;
                    }
                case "importprivkey":
                    {
                        CaseWriter.ImportPrivKey(methodName, guesType, writer);
                        break;
                    }
                case "importprunedfunds":
                    {
                        CaseWriter.ImportPrunedFunds(methodName, guesType, writer);
                        break;
                    }
                case "importpubkey":
                    {
                        CaseWriter.ImportPubkey(methodName, guesType, writer);
                        break;
                    }
                case "importwallet":
                    {
                        CaseWriter.ImportWallet(methodName, guesType, writer);
                        break;
                    }
                case "keypoolrefill":
                    {
                        CaseWriter.KeypoolRefill(methodName, guesType, writer);
                        break;
                    }
                case "listlabels":
                    {
                        CaseWriter.ListLabels(methodName, guesType, writer);
                        break;
                    }
                case "listreceivedbyaddress":
                    {
                        CaseWriter.ListReceivedByAddress(methodName, guesType, writer);
                        break;
                    }
                case "listreceivedbylabel":
                    {
                        CaseWriter.ListReceivedByLabel(methodName, guesType, writer);
                        break;
                    }
                case "listsinceblock":
                    {
                        CaseWriter.ListSinceBlock(methodName, guesType, writer);
                        break;
                    }
                case "listtransactions":
                    {
                        CaseWriter.ListTransactions(methodName, guesType, writer);
                        break;
                    }
                case "listunspent":
                    {
                        CaseWriter.ListUnspent(methodName, guesType, writer);
                        break;
                    }
                case "lockunspent":
                    {
                        CaseWriter.LockUnspent(methodName, guesType, writer);
                        break;
                    }
                case "removeprunedfunds":
                    {
                        CaseWriter.RemovePrunedFunds(methodName, guesType, writer);
                        break;
                    }
                case "rescanblockchain":
                    {
                        CaseWriter.RescanBlockchain(methodName, guesType, writer);
                        break;
                    }
                case "sendmany":
                    {
                        CaseWriter.SendMany(methodName, guesType, writer);
                        break;
                    }
                case "sendtoaddress":
                    {
                        CaseWriter.SendToAddress(methodName, guesType, writer);
                        break;
                    }
                case "sethdseed":
                    {
                        CaseWriter.SetHDSeed(methodName, guesType, writer);
                        break;
                    }
                case "setlabel":
                    {
                        CaseWriter.SetLabel(methodName, guesType, writer);
                        break;
                    }
                case "settxfee":
                    {
                        CaseWriter.SetTxFee(methodName, guesType, writer);
                        break;
                    }
                case "setwalletflag":
                    {
                        CaseWriter.SetWalletFlag(methodName, guesType, writer);
                        break;
                    }
                case "signmessage":
                    {
                        CaseWriter.SignMessage(methodName, guesType, writer);
                        break;
                    }
                case "signrawtransactionwithwallet":
                    {
                        CaseWriter.SignRawTransactionWithWallet(methodName, guesType, writer);
                        break;
                    }
                case "unloadwallet":
                    {
                        CaseWriter.UnloadWallet(methodName, guesType, writer);
                        break;
                    }
                case "walletcreatefundedpsbt":
                    {
                        CaseWriter.WalletCreateFundedPSBT(methodName, guesType, writer);
                        break;
                    }
                case "walletpassphrase":
                    {
                        CaseWriter.WalletPassphrase(methodName, guesType, writer);
                        break;
                    }
                case "walletpassphrasechange":
                    {
                        CaseWriter.WalletPassphraseChange(methodName, guesType, writer);
                        break;
                    }
                case "walletprocesspsbt":
                    {
                        CaseWriter.WalletProcessPSBT(methodName, guesType, writer);
                        break;
                    }










            }
        }

    }

}
