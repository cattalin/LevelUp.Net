using LevelUp.Net.Infrastructure;
using LevelUp.Net.Operations;
using System;

namespace LevelUp.Net
{
    class Program
    {
        static Scenarios scenarios = new Scenarios();

        static void Main(string[] args)
        {
            BlockchainMetadata.Init();

            //scenarios.JoinTheCause();

            scenarios.GetContractTotalInfluence();
            scenarios.GetAccountBalance();
            scenarios.TransferEth();
            Console.ReadLine();
        }
    }
}
