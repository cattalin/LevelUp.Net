using LevelUp.Net.Infrastructure;
using System.Linq;

namespace LevelUp.Net.Operations
{
    public class Scenarios
    {
        public AccountOperations accountsOps = new AccountOperations();
        public ContractOperations contractsOps = new ContractOperations();
        public TransactionOperations transactionsOps = new TransactionOperations();

        public void GetAccountBalance()
        {
            var address = BlockchainMetadata.mainAccount.Address;
            accountsOps.GetAccountBalanceAsync(address).Wait();
        }

        public void TransferEth()
        {
            var sender = BlockchainMetadata.mainAccount;
            var receiverAddress = BlockchainMetadata.secondaryAccounts.First().Address;
            var transferedValue = 1.5m;
            transactionsOps.TransferEtherAsync(sender, receiverAddress, transferedValue).Wait();
        }
    }
}
