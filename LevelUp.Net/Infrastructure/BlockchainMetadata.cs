using LevelUp.Net.Models;
using System.Collections.Generic;

namespace LevelUp.Net.Infrastructure
{
    public static class BlockchainMetadata
    {
        public const string URL = "HTTP://127.0.0.1:7545";
        public const string CONTRACT_ADDRESS = "0x22C734a24E0d87BB426c1A5cc3398EDf232C56b1";

        public static TruffleAccount MainAccount;
        public static List<TruffleAccount> SecondaryAccounts = new List<TruffleAccount>();

        public static void Init()
        {
            MainAccount = new TruffleAccount
            {
                Address = "0xB73E65060436483143Ef85f672E057Ef158B44dC",
                PrivateKey = "c809266b80c97d3a4f0727cda3f8e799b090bdb2c744a265439fe257f129b511"
            };
            SecondaryAccounts.Add(new TruffleAccount
            {
                Address = "0x43d1407E8B895C15Ef3ED6B0b60dCDa68b399D76",
                PrivateKey = "092d0c3b4470921c11ae3003b1e24fe67b1cd406569cd726d66114dec52f82ff"
            });
        }
    }
}
