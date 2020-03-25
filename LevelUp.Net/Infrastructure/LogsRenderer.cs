using Nethereum.RPC.Eth.DTOs;
using System;

namespace LevelUp.Net.Infrastructure
{
    public static class LogsRenderer
    {
        public static void Log(TransactionReceipt transactionResponse)
        {
            Console.WriteLine($"Block number: {transactionResponse.BlockNumber}");
            Console.WriteLine($"Transaction hash: {transactionResponse.TransactionHash}");
            Console.WriteLine($"Transaction gas used: {transactionResponse.GasUsed}");
        }
    }
}
