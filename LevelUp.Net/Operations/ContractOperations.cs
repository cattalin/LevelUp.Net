using LevelUp.Net.Infrastructure;
using LevelUp.Net.Models;
using LevelUp.Net.Operations.Calls;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System;
using System.Numerics;
using System.Threading.Tasks;
using static LevelUp.Net.Infrastructure.BlockchainMetadata;

namespace LevelUp.Net.Operations
{
    public class ContractOperations
    {
        public async Task CallGetTotalInfluenceAsync()
        {
            var web3 = new Web3(URL);
            var call = new CallGetTotalInfluence();

            var callHandler = web3.Eth.GetContractQueryHandler<CallGetTotalInfluence>();
            var callResponse = await callHandler.QueryAsync<BigInteger>(CONTRACT_ADDRESS, call);

            Console.WriteLine($"Total Influence: {callResponse}");
        }

        public async Task SendJoinTheCauseAsync(TruffleAccount senderAccount)
        {
            var account = new Account(senderAccount.PrivateKey);
            var web3 = new Web3(account, URL);
            var transaction = new SendJoinTheCause();

            var transactionHandler = web3.Eth.GetContractTransactionHandler<SendJoinTheCause>();
            var transactionReceipt = await transactionHandler.SendRequestAndWaitForReceiptAsync(CONTRACT_ADDRESS, transaction);

            LogsRenderer.Log(transactionReceipt);
        }
    }
}
