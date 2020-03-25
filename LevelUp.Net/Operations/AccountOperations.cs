using LevelUp.Net.Infrastructure;
using Nethereum.Web3;
using System;
using System.Threading.Tasks;

namespace LevelUp.Net.Operations
{
    public class AccountOperations
    {
        public async Task GetAccountBalanceAsync(string accountAddress)
        {
            var web3 = new Web3(BlockchainMetadata.URL);

            var balance = await web3.Eth.GetBalance.SendRequestAsync(accountAddress);
            Console.WriteLine($"Balance in Wei: {balance.Value}");

            var etherAmount = Web3.Convert.FromWei(balance.Value);
            Console.WriteLine($"Balance in Ether: {etherAmount}");
        }
    }
}
