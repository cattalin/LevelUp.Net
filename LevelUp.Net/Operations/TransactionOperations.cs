using LevelUp.Net.Infrastructure;
using LevelUp.Net.Models;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System.Threading.Tasks;

namespace LevelUp.Net.Operations
{
    public class TransactionOperations
    {
        public async Task TransferEtherAsync(TruffleAccount sender, string receiverAddress, decimal etherValue)
        {
            var sourceAccount = new Account(sender.PrivateKey);
            var web3 = new Web3(sourceAccount, BlockchainMetadata.URL);

            var transactionReceipt = await web3.Eth.GetEtherTransferService().TransferEtherAndWaitForReceiptAsync(receiverAddress, etherValue);
            
            LogsRenderer.Log(transactionReceipt);
        }
    }
}
