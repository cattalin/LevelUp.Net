using LevelUp.Net.Infrastructure;
using LevelUp.Net.Models;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System;
using System.Threading.Tasks;

namespace LevelUp.Net.Operations
{
    public class TransactionOperations
    {
        public async Task TransferEtherAsync(TruffleAccount sender, string receiverAddress, decimal etherValue)
        {
            var sourceAccount = new Account(sender.PrivateKey);
            var web3 = new Web3(sourceAccount, BlockchainMetadata.Url);

            var transaction = await web3.Eth.GetEtherTransferService().TransferEtherAndWaitForReceiptAsync(receiverAddress, etherValue);
            Console.WriteLine($"Block number: {transaction.BlockNumber}");
            Console.WriteLine($"Transaction hash: {transaction.TransactionHash}");
            Console.WriteLine($"Transaction gas used: {transaction.GasUsed}");
        }
    }
}
