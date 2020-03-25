using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace LevelUp.Net.Operations.Calls
{
    [Function("JoinTheCause", "bool")]
    public class SendEnvySomeone : FunctionMessage
    {
        [Parameter("address","target")]
        public string Target { get; set; }
    }
}
