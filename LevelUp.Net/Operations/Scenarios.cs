using System.Linq;
using static LevelUp.Net.Infrastructure.BlockchainMetadata;

namespace LevelUp.Net.Operations
{
    public class Scenarios
    {
        public AccountOperations accountsOps = new AccountOperations();
        public ContractOperations contractsOps = new ContractOperations();
        public TransactionOperations transactionsOps = new TransactionOperations();

        public void GetAccountBalance()
        {
            var address = MainAccount.Address;
            accountsOps.GetAccountBalanceAsync(address).Wait();
        }

        public void GetContractTotalInfluence()
        {
            var address = MainAccount.Address;
            contractsOps.CallGetTotalInfluenceAsync().Wait();
        }

        public void JoinTheCause()
        {
            var account = SecondaryAccounts.First();
            contractsOps.SendJoinTheCauseAsync(account).Wait();
        }

        public void TransferEth()
        {
            var sender = MainAccount;
            var receiverAddress = SecondaryAccounts.First().Address;
            var transferedValue = 1.5m;
            transactionsOps.TransferEtherAsync(sender, receiverAddress, transferedValue).Wait();
        }
    }
}
