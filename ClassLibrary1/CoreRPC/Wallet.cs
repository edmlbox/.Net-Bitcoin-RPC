
using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.RawTransactions;
using BitcoinRpc.RequestModels.Wallet;
using BitcoinRpc.StaticStrings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinRpc.CoreRPC
{
    /// <summary>
    /// The main <seealso cref="Wallet"/> class.
    /// Contains all methods for performing <seealso cref="Wallet"/> operations.
    /// </summary>
    public class Wallet
    {
        BitcoinClient bitcoinClient;
        HttpRequest httpRequest;
        public string ActiveWallet { get; set; }
        public Wallet(BitcoinClient bitcoinClient, string walletName=null)
        {
            this.bitcoinClient = bitcoinClient;
            this.ActiveWallet = walletName;
            httpRequest = new HttpRequest(bitcoinClient, this.ActiveWallet);
        }


        /// <summary>
        /// Mark in-wallet transaction "txid" as abandoned
        /// This will mark this transaction and all its in-wallet descendants as abandoned which will allow
        /// for their inputs to be respent.
        /// </summary>
        /// <param name="txid">The transaction id.</param>
        /// <returns></returns>
        public async Task<string> AbandonTransaction(string txid)
        {
            string response = await httpRequest.SendReq(MethodName.abandontransaction, txid);
            return response;
        }
        /// <summary>
        /// Stops current wallet rescan triggered by an RPC call, e.g. by an importprivkey call.
        /// </summary>
        /// <returns></returns>
        public async Task<string> AbortRescan()
        {

            string response = await httpRequest.SendReq(MethodName.abortrescan);
            return response;
        }
        /// <summary>
        /// Add an nrequired-to-sign multisignature address to the wallet.
        /// </summary>
        /// <param name="nRequired">The number of required signatures out of the n keys or addresses.</param>
        /// <param name="keys">The bitcoin addresses or hex-encoded public keys.</param>
        /// <returns></returns>
        public async Task<string> AddMultisigAddress(int nRequired, List<string> keys)
        {
            AddMultisigAddress addMultisigAddress = new AddMultisigAddress() { NRequired = nRequired, Keys = keys };
            string response = await httpRequest.SendReq(MethodName.addmultisigaddress, addMultisigAddress);
            return response;
        }
        /// <summary>
        /// Add an nrequired-to-sign multisignature address to the wallet.
        /// </summary>
        /// <param name="nRequired">The number of required signatures out of the n keys or addresses.</param>
        /// <param name="keys">The bitcoin addresses or hex-encoded public keys.</param>
        /// <param name="label">A label to assign the addresses to.</param>
        /// <returns></returns>
        public async Task<string> AddMultisigAddress(int nRequired, List<string> keys, string label)
        {
            AddMultisigAddress addMultisigAddress = new AddMultisigAddress() { NRequired = nRequired, Keys = keys, Label = label };
            string response = await httpRequest.SendReq(MethodName.addmultisigaddress, addMultisigAddress);
            return response;
        }
        /// <summary>
        /// Add an nrequired-to-sign multisignature address to the wallet.
        /// </summary>
        /// <param name="nRequired">The number of required signatures out of the n keys or addresses.</param>
        /// <param name="keys">The bitcoin addresses or hex-encoded public keys.</param>
        /// <param name="addressType">The address type to use. Options are "legacy", "p2sh-segwit", and "bech32".</param>
        /// <returns></returns>
        public async Task<string> AddMultisigAddress(int nRequired, List<string> keys, AddressType addressType)
        {
            AddMultisigAddress addMultisigAddress = new AddMultisigAddress() { NRequired = nRequired, Keys = keys, AddressType = addressType };
            string response = await httpRequest.SendReq(MethodName.addmultisigaddress, addMultisigAddress);
            return response;
        }
        /// <summary>
        /// Add an nrequired-to-sign multisignature address to the wallet.
        /// </summary>
        /// <param name="nRequired">The number of required signatures out of the n keys or addresses.</param>
        /// <param name="keys">The bitcoin addresses or hex-encoded public keys.</param>
        /// <param name="label">A label to assign the addresses to.</param>
        /// <param name="addressType">The address type to use. Options are "legacy", "p2sh-segwit", and "bech32".</param>
        /// <returns></returns>
        public async Task<string> AddMultisigAddress(int nRequired, List<string> keys, string label, AddressType addressType)
        {
            AddMultisigAddress addMultisigAddress = new AddMultisigAddress() { NRequired = nRequired, Keys = keys, Label = label, AddressType = addressType };
            string response = await httpRequest.SendReq(MethodName.addmultisigaddress, addMultisigAddress);
            return response;
        }


        /// <summary>
        /// Safely copies current wallet file to destination, which can be a directory or a path with filename.
        /// </summary>
        /// <param name="destination">The destination directory or file.</param>
        /// <returns></returns>
        public async Task<string> BackupWallet(string destination)
        {

            string response = await httpRequest.SendReq(MethodName.backupwallet, destination);
            return response;
        }
        /// <summary>
        /// Bumps the fee of an opt-in-RBF transaction T, replacing it with a new transaction B.
        /// </summary>
        /// <param name="txid">The txid to be bumped.</param>
        /// <returns></returns>
        public async Task<string> BumpFee(string txid)
        {
            BumpFee bumpFee = new BumpFee() { Txid = txid };
            string response = await httpRequest.SendReq(MethodName.bumpfee, bumpFee);
            return response;
        }
        /// <summary>
        /// Bumps the fee of an opt-in-RBF transaction T, replacing it with a new transaction B.
        /// </summary>
        /// <param name="txid">The txid to be bumped.</param>
        /// <param name="bumpFeeOptions">BumpFee options</param>
        /// <returns></returns>
        public async Task<string> BumpFee(string txid, BumpFeeOptions bumpFeeOptions)
        {
            BumpFee bumpFee = new BumpFee() { Txid = txid, BumpFeeOptions = bumpFeeOptions };
            string response = await httpRequest.SendReq(MethodName.bumpfee, bumpFee);
            return response;
        }
        /// <summary>
        /// Creates and loads a new wallet.
        /// </summary>
        /// <param name="walletName">The name for the new wallet. If this is a path, the wallet will be created at the path location.</param>
        /// <returns></returns>
        public async Task<string> CreateWallet(string walletName)
        {

            string response = await httpRequest.SendReq(MethodName.createwallet, walletName);
            return response;
        }
        /// <summary>
        /// Creates and loads a new wallet.
        /// </summary>
        /// <param name="walletName">The name for the new wallet. If this is a path, the wallet will be created at the path location.</param>
        /// <param name="disablePrivateKeys">Disable the possibility of private keys (only watchonlys are possible in this mode).</param>
        /// <param name="blank">Create a blank wallet. A blank wallet has no keys or HD seed. One can be set using sethdseed.</param>
        /// <param name="passphrase">Encrypt the wallet with this passphrase.</param>
        /// <param name="avoidReuse">Keep track of coin reuse, and treat dirty and clean coins differently with privacy considerations in mind.</param>
        /// <returns></returns>
        public async Task<string> CreateWallet(string walletName, bool disablePrivateKeys = false, bool blank = false, string passphrase = null, bool avoidReuse = false)
        {

            CreateWallet createWallet = new CreateWallet { WalletName = walletName, AvoidReuse = avoidReuse, Blank = blank, Passphrase = passphrase, DisablePrivateKeys = disablePrivateKeys };
            string response = await httpRequest.SendReq(MethodName.createwallet, createWallet);
            return response;

        }




        /// <summary>
        /// Reveals the private key corresponding to 'address'.
        /// Then the importprivkey can be used with this output
        /// </summary>
        /// <param name="address">The bitcoin address for the private key.</param>
        /// <returns></returns>
        public async Task<string> DumpPrivKey(string address)
        {

            string response = await httpRequest.SendReq(MethodName.dumpprivkey, address);
            return response;
        }
        /// <summary>
        /// Dumps all wallet keys in a human-readable format to a server-side file.
        /// </summary>
        /// <param name="fileName">The filename with path (either absolute or relative to bitcoind).</param>
        /// <returns></returns>
        public async Task<string> DumpWallet(string fileName)
        {

            string response = await httpRequest.SendReq(MethodName.dumpwallet, fileName);
            return response;
        }
        /// <summary>
        /// Encrypts the wallet with 'passphrase'. This is for first time encryption.
        /// </summary>
        /// <param name="passphrase">The pass phrase to encrypt the wallet with. It must be at least 1 character, but should be long.</param>
        /// <returns></returns>
        public async Task<string> EncryptWallet(string passphrase)
        {

            string response = await httpRequest.SendReq(MethodName.encryptwallet, passphrase);
            return response;
        }
        /// <summary>
        /// Returns the list of addresses assigned the specified label.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <returns></returns>
        public async Task<string> GetAddressesByLabel(string label)
        {

            string response = await httpRequest.SendReq(MethodName.getaddressesbylabel, label);
            return response;
        }
        /// <summary>
        /// Returns information about the given bitcoin address.
        /// Some of the information will only be present if the address is in the active wallet.
        /// </summary>
        /// <param name="address">The bitcoin address for which to get information.</param>
        /// <returns></returns>
        public async Task<string> GetAddressInfo(string address)
        {

            string response = await httpRequest.SendReq(MethodName.getaddressinfo, address);
            return response;
        }
        /// <summary>
        /// Returns the total available balance.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetBalance()
        {
            GetBalance getBalance = new GetBalance();
            string response = await httpRequest.SendReq(MethodName.getbalance);
            return response;
        }
        /// <summary>
        /// Returns the total available balance.
        /// </summary>
        /// <param name="minConf">Only include transactions confirmed at least this many times.</param>
        /// <param name="includeWatchonly">Also include balance in watch-only addresses.</param>
        /// <param name="avoidReuse">Do not include balance in dirty outputs.</param>
        /// <param name="dummy">Remains for backward compatibility. Must be excluded or set to "*".</param>
        /// <returns></returns>
        public async Task<string> GetBalance(int minConf, bool includeWatchonly, bool avoidReuse, string dummy = "*")
        {
            GetBalance getBalance = new GetBalance() { Dummy = dummy, MinConf = minConf, IncludeWatchOnly = includeWatchonly, AvoidReuse = avoidReuse };
            string response = await httpRequest.SendReq(MethodName.getbalance, getBalance);
            return response;
        }
        /// <summary>
        /// Returns an object with all balances in BTC.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetBalances()
        {

            string response = await httpRequest.SendReq(MethodName.getbalances);
            return response;
        }
        /// <summary>
        /// Returns a new Bitcoin address for receiving payments.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetNewAddress()
        {

            string response = await httpRequest.SendReq(MethodName.getnewaddress);
            return response;
        }
        /// <summary>
        /// Returns a new Bitcoin address for receiving payments.
        /// </summary>
        /// <param name="label">The label name for the address to be linked to.</param>
        /// <param name="addressType">The address type to use. Options are "legacy", "p2sh-segwit", and "bech32".</param>
        /// <returns></returns>
        public async Task<string> GetNewAddress(string label, AddressType addressType)
        {
            GetNewAddress getNewAddress = new GetNewAddress { Label = label, AddressType = addressType };
            string response = await httpRequest.SendReq(MethodName.getnewaddress, getNewAddress);
            return response;
        }
        /// <summary>
        /// Returns a new Bitcoin address for receiving payments.
        /// </summary>
        /// <param name="addressType">The address type to use. Options are "legacy", "p2sh-segwit", and "bech32".</param>
        /// <returns></returns>
        public async Task<string> GetNewAddress(AddressType addressType)
        {
            GetNewAddress getNewAddress = new GetNewAddress { AddressType = addressType };
            string response = await httpRequest.SendReq(MethodName.getnewaddress, getNewAddress);
            return response;
        }
        /// <summary>
        /// Returns a new Bitcoin address, for receiving change.
        /// This is for use with raw transactions, NOT normal use.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetRawChangeAddress()
        {

            string response = await httpRequest.SendReq(MethodName.getrawchangeaddress);
            return response;
        }
        /// <summary>
        /// Returns a new Bitcoin address, for receiving change.
        /// This is for use with raw transactions, NOT normal use.
        /// </summary>
        /// <param name="addressType">The address type to use. Options are "legacy", "p2sh-segwit", and "bech32".</param>
        /// <returns></returns>
        public async Task<string> GetRawChangeAddress(AddressType addressType)
        {

            string response = await httpRequest.SendReq(MethodName.getrawchangeaddress, addressType);
            return response;
        }
        /// <summary>
        /// Returns the total amount received by the given address.
        /// </summary>
        /// <param name="address">The bitcoin address for transactions.</param>
        /// <returns></returns>
        public async Task<string> GetReceivedByAddress(string address)
        {
            GetReceivedByAddress getReceivedByAddress = new GetReceivedByAddress { Address = address };
            string response = await httpRequest.SendReq(MethodName.getreceivedbyaddress, getReceivedByAddress);
            return response;
        }
        /// <summary>
        /// Returns the total amount received by the given address in transactions with at least minconf confirmations.
        /// </summary>
        /// <param name="address">The bitcoin address for transactions.</param>
        /// <param name="minConf">Only include transactions confirmed at least this many times.</param>
        /// <returns></returns>
        public async Task<string> GetReceivedByAddress(string address, int minConf)
        {
            GetReceivedByAddress getReceivedByAddress = new GetReceivedByAddress { Address = address, MinConf = minConf };
            string response = await httpRequest.SendReq(MethodName.getreceivedbyaddress, getReceivedByAddress);
            return response;
        }
        /// <summary>
        /// Returns the total amount received by addresses with specific "label".
        /// </summary>
        /// <param name="label">The selected label, may be the default label using "".</param>
        /// <returns></returns>
        public async Task<string> GetReceivedByLabel(string label)
        {
            GetReceivedByLabel getReceivedByLabel = new GetReceivedByLabel { Label = label };
            string response = await httpRequest.SendReq(MethodName.getreceivedbylabel, getReceivedByLabel);
            return response;
        }
        /// <summary>
        /// Returns the total amount received by addresses with "label" in transactions with at least "minconf" confirmations.
        /// </summary>
        /// <param name="label">The selected label, may be the default label using "".</param>
        /// <param name="minConf">Only include transactions confirmed at least this many times.</param>
        /// <returns></returns>
        public async Task<string> GetReceivedByLabel(string label, int minConf)
        {
            GetReceivedByLabel getReceivedByLabel = new GetReceivedByLabel { Label = label, MinConf = minConf };
            string response = await httpRequest.SendReq(MethodName.getreceivedbylabel, getReceivedByLabel);
            return response;
        }
        /// <summary>
        /// Get detailed information about in-wallet transaction.
        /// </summary>
        /// <param name="txid">The transaction id.</param>
        /// <returns></returns>
        public async Task<string> GetTransaction(string txid)
        {
            GetTransaction getTransaction = new GetTransaction { Txid = txid };
            string response = await httpRequest.SendReq(MethodName.gettransaction, getTransaction);
            return response;
        }
        /// <summary>
        /// Get detailed information about in-wallet transaction.
        /// </summary>
        /// <param name="txid">The transaction id.</param>
        /// <param name="includeWatchOnly">Whether to include watch-only addresses.</param>
        /// <param name="IncludeDecoded">Whether to include a `decoded` field containing the decoded transaction.</param>
        /// <returns></returns>
        public async Task<string> GetTransaction(string txid, bool includeWatchOnly, bool IncludeDecoded)
        {
            GetTransaction getTransaction = new GetTransaction { Txid = txid, IncludeWatchOnly = includeWatchOnly, IncludeDecoded = IncludeDecoded };
            string response = await httpRequest.SendReq(MethodName.gettransaction, getTransaction);
            return response;
        }

        /// <summary>
        /// DEPRECATED
        /// </summary>
        /// <returns></returns>
        [Obsolete]
        public async Task<string> GetUnconfirmedBalance()
        {
            string response = await httpRequest.SendReq(MethodName.getunconfirmedbalance);
            return response;
        }
        /// <summary>
        /// Returns an object containing various wallet state info.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetWalletInfo()
        {

            string response = await httpRequest.SendReq(MethodName.getwalletinfo);
            return response;
        }

        /// <summary>
        /// Adds an address or script (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
        /// </summary>
        /// <param name="address">The Bitcoin address (or hex-encoded script).</param>
        /// <returns></returns>
        public async Task<string> ImportAddress(string address)
        {
            ImportAddress importAddress = new ImportAddress { Address = address };
            string response = await httpRequest.SendReq(MethodName.importaddress, importAddress);
            return response;
        }
        /// <summary>
        /// Adds an address or script (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
        /// </summary>
        /// <param name="address">The Bitcoin address (or hex-encoded script).</param>
        /// <param name="label">An optional label.</param>
        /// <returns></returns>
        public async Task<string> ImportAddress(string address, string label)
        {
            ImportAddress importAddress = new ImportAddress { Address = address, Label = label };
            string response = await httpRequest.SendReq(MethodName.importaddress, importAddress);
            return response;
        }
        /// <summary>
        /// Adds an address or script (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
        /// </summary>
        /// <param name="address">The Bitcoin address (or hex-encoded script).</param>
        /// <param name="label">An optional label.</param>
        /// <param name="rescan">Rescan the wallet for transactions.</param>
        /// <returns></returns>
        public async Task<string> ImportAddress(string address, string label, bool rescan)
        {
            ImportAddress importAddress = new ImportAddress { Address = address, Label = label, Rescan = rescan };
            string response = await httpRequest.SendReq(MethodName.importaddress, importAddress);
            return response;
        }
        /// <summary>
        /// Adds an address or script (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
        /// </summary>
        /// <param name="address">The Bitcoin address (or hex-encoded script).</param>
        /// <param name="label">An optional label.</param>
        /// <param name="rescan">Rescan the wallet for transactions.</param>
        /// <param name="p2sh">Add the P2SH version of the script as well.</param>
        /// <returns></returns>
        public async Task<string> ImportAddress(string address, string label, bool rescan, bool p2sh)
        {
            ImportAddress importAddress = new ImportAddress { Address = address, P2SH = p2sh, Rescan = rescan, Label = label };
            string response = await httpRequest.SendReq(MethodName.importaddress, importAddress);
            return response;
        }
        /// <summary>
        /// Import addresses/scripts (with private or public keys, redeem script (P2SH)).
        /// </summary>
        /// <param name="data">Data to be imported.</param>
        /// <returns></returns>
        public async Task<string> ImportMulti(List<MultiData> data)
        {
            ImportMulti importMulti = new ImportMulti() { MultiData = data };
            string response = await httpRequest.SendReq(MethodName.importmulti, importMulti);
            return response;
        }
        /// <summary>
        /// Import addresses/scripts (with private or public keys, redeem script (P2SH)).
        /// </summary>
        /// <param name="data">Data to be imported.</param>
        /// <param name="rescan">Stating if should rescan the blockchain after all imports.</param>
        /// <returns></returns>
        public async Task<string> ImportMulti(List<MultiData> data, bool rescan)
        {

            ImportMulti importMulti = new ImportMulti() { MultiData = data, Rescan = rescan };
            string response = await httpRequest.SendReq(MethodName.importmulti, importMulti);
            return response;
        }
        /// <summary>
        /// Adds a private key (as returned by dumpprivkey) to your wallet. Requires a new wallet backup.
        /// </summary>
        /// <param name="privKey">The private key.</param>
        /// <returns></returns>
        public async Task<string> ImportPrivKey(string privKey)
        {
            ImportPrivKey importPrivKey = new ImportPrivKey { PrivKey = privKey };
            string response = await httpRequest.SendReq(MethodName.importprivkey, importPrivKey);
            return response;
        }
        /// <summary>
        /// Adds a private key (as returned by dumpprivkey) to your wallet. Requires a new wallet backup.
        /// </summary>
        /// <param name="privKey">The private key.</param>
        /// <param name="label">A label</param>
        /// <returns></returns>
        public async Task<string> ImportPrivKey(string privKey, string label)
        {
            ImportPrivKey importPrivKey = new ImportPrivKey { PrivKey = privKey, Label = label };
            string response = await httpRequest.SendReq(MethodName.importprivkey, importPrivKey);
            return response;
        }
        /// <summary>
        /// Adds a private key (as returned by dumpprivkey) to your wallet. Requires a new wallet backup.
        /// </summary>
        /// <param name="privKey">The private key.</param>
        /// <param name="rescan">Rescan the wallet for transactions.</param>
        /// <returns></returns>
        public async Task<string> ImportPrivKey(string privKey, bool rescan)
        {
            ImportPrivKey importPrivKey = new ImportPrivKey { PrivKey = privKey, Rescan = rescan };
            string response = await httpRequest.SendReq(MethodName.importprivkey, importPrivKey);
            return response;
        }
        /// <summary>
        /// Adds a private key (as returned by dumpprivkey) to your wallet. Requires a new wallet backup.
        /// </summary>
        /// <param name="privKey">The private key.</param>
        /// <param name="label">A label.</param>
        /// <param name="rescan">Rescan the wallet for transactions.</param>
        /// <returns></returns>
        public async Task<string> ImportPrivKey(string privKey, string label, bool rescan)
        {
            ImportPrivKey importPrivKey = new ImportPrivKey { PrivKey = privKey, Label = label, Rescan = rescan };
            string response = await httpRequest.SendReq(MethodName.importprivkey, importPrivKey);
            return response;
        }
        /// <summary>
        /// Imports funds without rescan. Corresponding address or script must previously be included in wallet.
        /// </summary>
        /// <param name="rawTransaction">A raw transaction in hex funding an already-existing address in wallet.</param>
        /// <param name="txOutProof">The hex output from gettxoutproof that contains the transaction.</param>
        /// <returns></returns>
        public async Task<string> ImportPrunedFunds(string rawTransaction, string txOutProof)
        {
            ImportPrunedFunds importPrunedFunds = new ImportPrunedFunds { RawTransaction = rawTransaction, TxOutProof = txOutProof };
            string response = await httpRequest.SendReq(MethodName.importprunedfunds, importPrunedFunds);
            return response;
        }
        /// <summary>
        /// Adds a public key (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
        /// </summary>
        /// <param name="pubkey">The hex-encoded public key.</param>
        /// <returns></returns>
        public async Task<string> ImportPubkey(string pubkey)
        {
            ImportPubkey importPubkey = new ImportPubkey { PubKey = pubkey };
            string response = await httpRequest.SendReq(MethodName.importpubkey, importPubkey);
            return response;
        }
        /// <summary>
        /// Adds a public key (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
        /// </summary>
        /// <param name="pubkey">The hex-encoded public key.</param>
        /// <param name="label">A label</param>
        /// <returns></returns>
        public async Task<string> ImportPubkey(string pubkey, string label)
        {
            ImportPubkey importPubkey = new ImportPubkey { PubKey = pubkey, Label = label };
            string response = await httpRequest.SendReq(MethodName.importpubkey, importPubkey);
            return response;
        }
        /// <summary>
        /// Adds a public key (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
        /// </summary>
        /// <param name="pubkey">The hex-encoded public key.</param>
        /// <param name="rescan">Rescan the wallet for transactions.</param>
        /// <returns></returns>
        public async Task<string> ImportPubkey(string pubkey, bool rescan)
        {
            ImportPubkey importPubkey = new ImportPubkey { PubKey = pubkey, Rescan = rescan };
            string response = await httpRequest.SendReq(MethodName.importpubkey, importPubkey);
            return response;
        }

        /// <summary>
        /// Adds a public key (in hex) that can be watched as if it were in your wallet but cannot be used to spend. Requires a new wallet backup.
        /// </summary>
        /// <param name="pubkey">The hex-encoded public key.</param>
        /// <param name="label">A label</param>
        /// <param name="rescan">Rescan the wallet for transactions.</param>
        /// <returns></returns>
        public async Task<string> ImportPubkey(string pubkey, string label, bool rescan)
        {
            ImportPubkey importPubkey = new ImportPubkey { PubKey = pubkey, Label = label, Rescan = rescan };
            string response = await httpRequest.SendReq(MethodName.importpubkey, importPubkey);
            return response;
        }

        /// <summary>
        /// Imports keys from a wallet dump file (see dumpwallet). Requires a new wallet backup to include imported keys.
        /// </summary>
        /// <param name="fileName">The wallet file.</param>
        /// <returns></returns>
        public async Task<string> ImportWallet(string fileName)
        {

            string response = await httpRequest.SendReq(MethodName.importwallet, fileName);
            return response;
        }
        /// <summary>
        /// Fills the keypool.
        /// </summary>
        /// <returns></returns>
        public async Task<string> KeyPoolRefill()
        {
            string response = await httpRequest.SendReq(MethodName.keypoolrefill);
            return response;
        }
        /// <summary>
        /// Fills the keypool.
        /// </summary>
        /// <param name="newSize">The new keypool size.</param>
        /// <returns></returns>
        public async Task<string> KeyPoolRefill(int newSize)
        {
            string response = await httpRequest.SendReq(MethodName.keypoolrefill, newSize);
            return response;
        }
        /// <summary>
        /// Lists groups of addresses which have had their common ownership
        /// made public by common use as inputs or as the resulting change
        /// in past transactions.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListAddressGroupings()
        {

            string response = await httpRequest.SendReq(MethodName.listaddressgroupings);
            return response;
        }
        /// <summary>
        /// Returns the list of all labels, or labels that are assigned to addresses with a specific purpose.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListLabels()
        {

            string response = await httpRequest.SendReq(MethodName.listlabels);
            return response;
        }
        /// <summary>
        /// Returns the list of all labels, or labels that are assigned to addresses with a specific purpose.
        /// </summary>
        /// <param name="purpose">Address purpose to list labels for ('send','receive').</param>
        /// <returns></returns>
        public async Task<string> ListLabels(Purpose purpose)
        {

            string response = await httpRequest.SendReq(MethodName.listlabels, purpose);
            return response;
        }
        /// <summary>
        /// Returns list of temporarily unspendable outputs.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListLockUnspent()
        {

            string response = await httpRequest.SendReq(MethodName.listlockunspent);
            return response;
        }

        /// <summary>
        /// List balances by receiving address.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListReceivedByAddress()
        {

            string response = await httpRequest.SendReq(MethodName.listreceivedbyaddress);
            return response;
        }
        /// <summary>
        /// List balances by receiving address.
        /// </summary>
        /// <param name="minConf">The minimum number of confirmations before payments are included.</param>
        /// <param name="includeEmpty">Whether to include addresses that haven't received any payments.</param>
        /// <param name="includeWatchOnly">Whether to include watch-only addresses.</param>
        /// <param name="addressFilter">If present, only return information on this address.</param>
        /// <returns></returns>
        public async Task<string> ListReceivedByAddress(int minConf, bool includeEmpty = false, bool includeWatchOnly = true, string addressFilter = null)
        {
            ListReceivedByAddress listReceivedByAddress = new ListReceivedByAddress { MinConf = minConf, IncludeEmpty = includeEmpty, IncludeWatchOnly = includeWatchOnly, AddressFilter = addressFilter };
            string response = await httpRequest.SendReq(MethodName.listreceivedbyaddress, listReceivedByAddress);
            return response;
        }
        /// <summary>
        /// List received transactions by label.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListReceivedByLabel()
        {

            string response = await httpRequest.SendReq(MethodName.listreceivedbylabel);
            return response;
        }
        /// <summary>
        /// List received transactions by label.
        /// </summary>
        /// <param name="minConf">The minimum number of confirmations before payments are included.</param>
        /// <param name="includeEmpty">Whether to include labels that haven't received any payments.</param>
        /// <param name="includeWatchOnly">Whether to include watch-only addresses.</param>
        /// <returns></returns>
        public async Task<string> ListReceivedByLabel(int minConf, bool includeEmpty = false, bool includeWatchOnly = true)
        {
            ListReceivedByLabel listReceivedByLabel = new ListReceivedByLabel { MinConf = minConf, IncludeEmpty = includeEmpty, IncludeWatchOnly = includeWatchOnly };
            string response = await httpRequest.SendReq(MethodName.listreceivedbylabel, listReceivedByLabel);
            return response;
        }
        /// <summary>
        /// Get all transactions in blocks since block "blockhash", or all transactions if omitted.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListSinceBlock()
        {

            string response = await httpRequest.SendReq(MethodName.listsinceblock);
            return response;
        }
        /// <summary>
        /// Get all transactions in blocks since block "blockhash", or all transactions if omitted.
        /// </summary>
        /// <param name="blockhash">The block hash to list transactions since.</param>
        /// <param name="targetConfirmations">Return the "nth" block hash from the main chain.</param>
        /// <param name="includeWatchonly">Include transactions to watch-only addresses.</param>
        /// <param name="includeRemoved">Show transactions that were removed due to a reorg in the "removed" array.</param>
        /// <returns></returns>
        public async Task<string> ListSinceBlock(string blockhash, int targetConfirmations = 1, bool includeWatchonly = true, bool includeRemoved = true)
        {
            ListSinceBlock listSinceBlock = new ListSinceBlock { Blockhash = blockhash, TargetConfirmations = targetConfirmations, IncludeWatchOnly = includeWatchonly, IncludeRemoved = includeRemoved };
            string response = await httpRequest.SendReq(MethodName.listsinceblock, listSinceBlock);
            return response;
        }
        /// <summary>
        /// List incoming transactions.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListTransactions()
        {

            string response = await httpRequest.SendReq(MethodName.listtransactions);
            return response;
        }
        /// <summary>
        /// List incoming transactions.
        /// </summary>
        /// <param name="label">Label name to return only incoming transactions
        ///  with the specified label, or "*" to disable filtering and return all transactions.</param>
        /// <param name="count">The number of transactions to return.</param>
        /// <param name="skip">The number of transactions to skip.</param>
        /// <param name="includeWatchOnly">Include transactions to watch-only addresses.</param>
        /// <returns></returns>
        public async Task<string> ListTransactions(string label, int count = 10, int skip = 0, bool includeWatchOnly = true)
        {
            ListTransactions listTransactions = new ListTransactions { Label = label, Count = count, IncludeWatchonly = includeWatchOnly, Skip = skip };
            string response = await httpRequest.SendReq(MethodName.listtransactions, listTransactions);
            return response;
        }
        /// <summary>
        /// Returns array of unspent transaction outputs.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListUnspent()
        {

            string response = await httpRequest.SendReq(MethodName.listunspent);
            return response;
        }
        /// <summary>
        /// Returns array of unspent transaction outputs.
        /// </summary>
        /// <param name="minConf">The minimum confirmations to filter.</param>
        /// <param name="maxConf">The maximum confirmations to filter.</param>
        /// <param name="addresses">The bitcoin addresses to filter.</param>
        /// <param name="includeUnsafe">Include outputs that are not safe to spend.</param>
        /// <param name="queryOptions">Query options.</param>
        /// <returns></returns>
        public async Task<string> ListUnspent(int minConf, int maxConf = 9999999, List<string> addresses = null, bool includeUnsafe = true, QueryOptions queryOptions = null)
        {
            ListUnspent listUnspent = new ListUnspent { MinConf = minConf, MaxConf = maxConf, Addresses = addresses, IncludeUnsafe = includeUnsafe, QueryOptions = queryOptions };
            string response = await httpRequest.SendReq(MethodName.listunspent, listUnspent);
            return response;
        }
        /// <summary>
        /// Returns a list of wallets in the wallet directory.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListWalletDir()
        {

            string response = await httpRequest.SendReq(MethodName.listwalletdir);
            return response;
        }
        /// <summary>
        /// Returns a list of currently loaded wallets.
        /// </summary>
        /// <returns></returns>
        public async Task<string> ListWallets()
        {

            string response = await httpRequest.SendReq(MethodName.listwallets);
            return response;
        }
        /// <summary>
        /// Loads a wallet from a wallet file or directory.
        /// </summary>
        /// <param name="fileName">The wallet directory or .dat file.</param>
        /// <returns></returns>
        public async Task<string> LoadWallet(string fileName)
        {

            string response = await httpRequest.SendReq(MethodName.loadwallet, fileName);
            return response;
        }
        /// <summary>
        /// Updates list of temporarily unspendable outputs.
        /// </summary>
        /// <param name="unlock">Whether to unlock (true) or lock (false) the specified transactions.</param>
        /// <returns></returns>
        public async Task<string> LockUnspent(bool unlock)
        {

            LockUnspent lockUnspent = new LockUnspent { Unlock = unlock };
            string response = await httpRequest.SendReq(MethodName.lockunspent, lockUnspent);
            return response;
        }
        /// <summary>
        /// Updates list of temporarily unspendable outputs.
        /// </summary>
        /// <param name="unlock">Whether to unlock (true) or lock (false) the specified transactions</param>
        /// <param name="transactionOutputs">The transaction outputs.</param>
        /// <returns></returns>
        public async Task<string> LockUnspent(bool unlock, List<TransactionOutputs> transactionOutputs)
        {

            LockUnspent lockUnspent = new LockUnspent { Unlock = unlock, TransactionOutputs = transactionOutputs };
            string response = await httpRequest.SendReq(MethodName.lockunspent, lockUnspent);
            return response;
        }
        /// <summary>
        /// Deletes the specified transaction from the wallet.
        /// </summary>
        /// <param name="txid">The hex-encoded id of the transaction you are deleting.</param>
        /// <returns></returns>
        public async Task<string> RemovePrunedFunds(string txid)
        {

            string response = await httpRequest.SendReq(MethodName.removeprunedfunds, txid);
            return response;
        }
        /// <summary>
        /// Rescan the local blockchain for wallet related transactions.
        /// </summary>
        /// <returns></returns>
        public async Task<string> RescanBlockchain()
        {

            string response = await httpRequest.SendReq(MethodName.rescanblockchain);
            return response;
        }
        /// <summary>
        /// Rescan the local blockchain for wallet related transactions.
        /// </summary>
        /// <param name="startHeight">Block height where the rescan should start.</param>
        /// <param name="stopHeight">The last block height that should be scanned.</param>
        /// <returns></returns>
        public async Task<string> RescanBlockchain(int startHeight, int stopHeight)
        {
            RescanBlockchain rescanBlockchain = new RescanBlockchain { StartHeight = startHeight, StopHeight = stopHeight };
            string response = await httpRequest.SendReq(MethodName.rescanblockchain, rescanBlockchain);
            return response;
        }
        /// <summary>
        /// Send multiple times. Amounts are double-precision floating point numbers.
        /// </summary>
        /// <param name="sendMany">SendMany object.</param>
        /// <returns></returns>
        #region SendMany
        public async Task<string> SendMany(SendMany sendMany)
        {
            string response = await httpRequest.SendReq(MethodName.sendmany, sendMany);
            return response;
        }
        /// <summary>
        /// Send multiple times. Amounts are double-precision floating point numbers.
        /// </summary>
        /// <param name="addressAmounts">The addresses and amounts.</param>
        /// <param name="comment">A comment.</param>
        /// <param name="subtractFeeFrom">The addresses.
        /// The fee will be equally deducted from the amount of each included address.</param>
        /// <param name="replaceable">Allow this transaction to be replaced by a transaction with higher fees via BIP 125.</param>
        /// <param name="confTarget">Confirmation target (in blocks).</param>
        /// <param name="estimateMode">The fee estimate mode.</param>
        /// <returns></returns>
        public async Task<string> SendMany(List<AddressAmount> addressAmounts, string comment = null, List<string> subtractFeeFrom = null, bool? replaceable = null, int? confTarget = null, EstimateMode? estimateMode = null)
        {
            SendMany sendMany = new SendMany
            {
                AddressesAmounts = addressAmounts,
                Comment = comment,
                ConfTarget = confTarget,
                EstimateMode = estimateMode,
                SubtractFeeFrom = subtractFeeFrom,
                Replaceable = replaceable
            };

            string response = await httpRequest.SendReq(MethodName.sendmany, sendMany);
            return response;
        }




        #endregion
        /// <summary>
        /// Send an amount to a given address.
        /// </summary>
        /// <param name="address">The bitcoin address to send to.</param>
        /// <param name="amount">The amount in BTC to send.</param>
        /// <returns></returns>
        public async Task<string> SendToAddress(string address, float amount)
        {
            SendToAddress sendToAddress = new SendToAddress(address, amount);
            string response = await httpRequest.SendReq(MethodName.sendtoaddress, sendToAddress);
            return response;
        }
        /// <summary>
        /// Send an amount to a given address.
        /// </summary>
        /// <param name="address">The bitcoin address to send to.</param>
        /// <param name="amount">The amount in BTC to send.</param>
        /// <returns></returns>
        public async Task<string> SendToAddress(string address, string amount)
        {
            SendToAddress sendToAddress = new SendToAddress(address, amount);
            string response = await httpRequest.SendReq(MethodName.sendtoaddress, sendToAddress);
            return response;
        }
        /// <summary>
        /// Send an amount to a given address.
        /// </summary>
        /// <param name="sendToAddress">SendToAddress object</param>
        /// <returns></returns>
        public async Task<string> SendToAddress(SendToAddress sendToAddress)
        {

            string response = await httpRequest.SendReq(MethodName.sendtoaddress, sendToAddress);
            return response;
        }


        /// <summary>
        /// Set or generate a new HD wallet seed.
        /// </summary>
        /// <returns></returns>
        public async Task<string> SetHDSeed()
        {

            string response = await httpRequest.SendReq(MethodName.sethdseed);
            return response;
        }
        /// <summary>
        /// Set or generate a new HD wallet seed.
        /// </summary>
        /// <param name="newKeypool">Whether to flush old unused addresses, including change addresses, from the keypool and regenerate it.</param>
        /// <param name="seed">The "WIF" private key to use as the new HD seed.</param>
        /// <returns></returns>
        public async Task<string> SetHDSeed(bool newKeypool, string seed = null)
        {
            SetHDSeed setHDSeed = new SetHDSeed { NewKeypool = newKeypool, Seed = seed };
            string response = await httpRequest.SendReq(MethodName.sethdseed, setHDSeed);
            return response;
        }
        /// <summary>
        /// Sets the label associated with the given address.
        /// </summary>
        /// <param name="address">The bitcoin address to be associated with a label.</param>
        /// <param name="label">The label to assign to the address.</param>
        /// <returns></returns>
        public async Task<string> SetLabel(string address, string label)
        {
            SetLabel setLabel = new SetLabel { Address = address, Label = label };
            string response = await httpRequest.SendReq(MethodName.setlabel, setLabel);
            return response;
        }
        /// <summary>
        /// Set the transaction fee per kB for this wallet. Overrides the global -paytxfee command line parameter.
        /// </summary>
        /// <param name="amount">The transaction fee in BTC/kB.</param>
        /// <returns></returns>
        public async Task<string> SetTxFee(float amount)
        {
            SetTxFee setTxFee = new SetTxFee { Amount = amount };
            string response = await httpRequest.SendReq(MethodName.settxfee, setTxFee);
            return response;
        }
        /// <summary>
        /// Set the transaction fee per kB for this wallet. Overrides the global -paytxfee command line parameter.
        /// </summary>
        /// <param name="amount">The transaction fee in BTC/kB.</param>
        /// <returns></returns>
        public async Task<string> SetTxFee(string amount)
        {
            SetTxFee setTxFee = new SetTxFee { Amount = amount };
            string response = await httpRequest.SendReq(MethodName.settxfee, setTxFee);
            return response;
        }
        /// <summary>
        /// Change the state of the given wallet flag for a wallet.
        /// </summary>
        /// <param name="flag">The name of the flag to change.</param>
        /// <param name="value">The new state.</param>
        /// <returns></returns>
        public async Task<string> SetWalletFlag(Flag flag, bool value)
        {
            SetWalletFlag setWalletFlag = new SetWalletFlag() { Flag = flag, Value = value };
            string response = await httpRequest.SendReq(MethodName.setwalletflag, setWalletFlag);
            return response;
        }
        /// <summary>
        /// Sign a message with the private key of an address.
        /// </summary>
        /// <param name="address">The bitcoin address to use for the private key.</param>
        /// <param name="message">The message to create a signature of.</param>
        /// <returns></returns>
        public async Task<string> SignMessage(string address, string message)
        {
            SignMessage signMessage = new SignMessage { Address = address, Message = message };
            string response = await httpRequest.SendReq(MethodName.signmessage, signMessage);
            return response;
        }
        /// <summary>
        /// Sign inputs for raw transaction (serialized, hex-encoded).
        /// </summary>
        /// <param name="hexString">The transaction hex string.</param>
        /// <returns></returns>
        public async Task<string> SignRawTransactionWithWallet(string hexString)
        {
            SignRawTransactionWithWallet signRawTransactionWithWallet = new SignRawTransactionWithWallet { HexString = hexString };
            string response = await httpRequest.SendReq(MethodName.signrawtransactionwithwallet, signRawTransactionWithWallet);
            return response;
        }
        /// <summary>
        /// Sign inputs for raw transaction (serialized, hex-encoded).
        /// </summary>
        /// <param name="hexString">The transaction hex string.</param>
        /// <param name="prevTxs">The previous dependent transaction outputs.</param>
        /// <returns></returns>
        public async Task<string> SignRawTransactionWithWallet(string hexString, List<PrevTxs> prevTxs)
        {
            SignRawTransactionWithWallet signRawTransactionWithWallet = new SignRawTransactionWithWallet { HexString = hexString, PrevTxs = prevTxs };
            string response = await httpRequest.SendReq(MethodName.signrawtransactionwithwallet, signRawTransactionWithWallet);
            return response;
        }
        /// <summary>
        /// Sign inputs for raw transaction (serialized, hex-encoded).
        /// </summary>
        /// <param name="hexString">The transaction hex string.</param>
        /// <param name="prevTxs">The previous dependent transaction outputs.</param>
        /// <param name="sigHashType">The signature hash type.</param>
        /// <returns></returns>
        public async Task<string> SignRawTransactionWithWallet(string hexString, List<PrevTxs> prevTxs, SigHashType sigHashType)
        {
            SignRawTransactionWithWallet signRawTransactionWithWallet = new SignRawTransactionWithWallet { HexString = hexString, PrevTxs = prevTxs, SigHashType = sigHashType };
            string response = await httpRequest.SendReq(MethodName.signrawtransactionwithwallet, signRawTransactionWithWallet);
            return response;
        }

        /// <summary>
        /// Unloads the wallet the active loaded wallet.
        /// </summary>
        /// <returns></returns>
        public async Task<string> UnloadWallet()
        {

            string response = await httpRequest.SendReq(MethodName.unloadwallet);
            return response;
        }
        /// <summary>
        /// Unloads the wallet specified in the argument.
        /// </summary>
        /// <param name="walletName">The name of the wallet to unload.</param>
        /// <returns></returns>
        public async Task<string> UnloadWallet(string walletName)
        {

            string response = await httpRequest.SendReq(MethodName.unloadwallet, walletName);
            return response;
        }
        /// <summary>
        /// Creates and funds a transaction in the Partially Signed Transaction format.
        /// </summary>
        /// <param name="Inputs">The inputs.</param>
        /// <param name="outputs">The outputs.</param>
        /// <returns></returns>
        public async Task<string> WalletCreateFundedPSBT(List<RawInput> Inputs, List<RawOutput> outputs)
        {
            WalletCreateFundedPSBT walletCreateFundedPSBT = new WalletCreateFundedPSBT { Inputs = Inputs, OutPuts = outputs };
            string response = await httpRequest.SendReq(MethodName.walletcreatefundedpsbt, walletCreateFundedPSBT);
            return response;
        }
        /// <summary>
        /// Creates and funds a transaction in the Partially Signed Transaction format.
        /// </summary>
        /// <param name="Inputs">The inputs.</param>
        /// <param name="outputs">The outputs.</param>
        /// <param name="locktime">Raw locktime. Non-0 value also locktime-activates inputs.</param>
        /// <param name="fundOptions">Found options.</param>
        /// <param name="bip32Derivs">Include BIP 32 derivation paths for public keys if we know them.</param>
        /// <param name="hexData">Hex-encoded data.</param>
        /// <returns></returns>
        public async Task<string> WalletCreateFundedPSBT(List<RawInput> Inputs, List<RawOutput> outputs, int locktime = 0, FundOptions fundOptions = null, bool? bip32Derivs = true, string hexData = null)
        {
            WalletCreateFundedPSBT walletCreateFundedPSBT = new WalletCreateFundedPSBT { Inputs = Inputs, OutPuts = outputs, Bip32Derivs = bip32Derivs, FundOptions = fundOptions, HexData = hexData, LockTime = locktime };
            string response = await httpRequest.SendReq(MethodName.walletcreatefundedpsbt, walletCreateFundedPSBT);
            return response;
        }
        /// <summary>
        /// Removes the wallet encryption key from memory, locking the wallet.
        /// </summary>
        /// <returns></returns>
        public async Task<string> WalletLock()
        {

            string response = await httpRequest.SendReq(MethodName.walletlock);
            return response;
        }
        /// <summary>
        /// Stores the wallet decryption key in memory for 'timeout' seconds.
        /// </summary>
        /// <param name="passphrase">The wallet passphrase.</param>
        /// <param name="timeout">The time to keep the decryption key in seconds, capped at 100000000 (~3 years).</param>
        /// <returns></returns>
        public async Task<string> WalletPassphrase(string passphrase, int timeout)
        {
            WalletPassphrase walletPassphrase = new WalletPassphrase { Passphrase = passphrase, Timeout = timeout };
            string response = await httpRequest.SendReq(MethodName.walletpassphrase, walletPassphrase);
            return response;
        }
        /// <summary>
        /// Changes the wallet passphrase from 'oldpassphrase' to 'newpassphrase'.
        /// </summary>
        /// <param name="oldpassphrase">The current passphrase.</param>
        /// <param name="newpassphrase">The new passphrase.</param>
        /// <returns></returns>
        public async Task<string> WalletPassphraseChange(string oldpassphrase, string newpassphrase)
        {
            WalletPassphraseChange walletPassphraseChange = new WalletPassphraseChange { NewPassphrase = newpassphrase, OldPassphrase = oldpassphrase };
            string response = await httpRequest.SendReq(MethodName.walletpassphrasechange, walletPassphraseChange);
            return response;
        }
        /// <summary>
        /// Update a PSBT with input information from our wallet and then sign inputs
        /// that we can sign for.
        /// </summary>
        /// <param name="psbt">The transaction base64 string.</param>
        /// <returns></returns>
        public async Task<string> WalletProcessPSBT(string psbt)
        {
            WalletProcessPSBT walletProcessPSBT = new WalletProcessPSBT { PSBT = psbt };
            string response = await httpRequest.SendReq(MethodName.walletprocesspsbt, walletProcessPSBT);
            return response;
        }
        /// <summary>
        /// Update a PSBT with input information from our wallet and then sign inputs
        /// that we can sign for.
        /// </summary>
        /// <param name="psbt">The transaction base64 string.</param>
        /// <param name="sign">Also sign the transaction when updating.</param>
        /// <param name="sigHashType">The signature hash type to sign with if not specified by the PSBT.</param>
        /// <param name="bip32Derivs">Include BIP 32 derivation paths for public keys if we know them.</param>
        /// <returns></returns>
        public async Task<string> WalletProcessPSBT(string psbt, bool sign = true, SigHashType sigHashType = SigHashType.ALL, bool bip32Derivs = true)
        {
            WalletProcessPSBT walletProcessPSBT = new WalletProcessPSBT { PSBT = psbt, Sign = sign, Bip32Derivs = bip32Derivs, SigHashType = sigHashType };
            string response = await httpRequest.SendReq(MethodName.walletprocesspsbt, walletProcessPSBT);
            return response;
        }


    }

}
