using BitcoinRpc.CoreRPC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using BitcoinRpc.RequestModels.Wallet;

namespace BitcoinRpc
{
   public static class MultipleWallet
    {
       public static string WalletName { get; set; }


       async public static Task<List<string>> GetWallets(BitcoinClient bitcoinClient)
       {
            Wallet wallet = new Wallet(bitcoinClient);
            string walletDir = await wallet.ListWalletDir();
            
            WalletDir walletDir1 = JsonSerializer.Deserialize<WalletDir>(walletDir);
            List<Wllt> wllt = walletDir1.Result.Wallets;

            List<string> wallets = new List<string>();
            foreach(Wllt w in wllt)
            {
                wallets.Add(w.Name);
            }

            return wallets;

       }

    }
}
