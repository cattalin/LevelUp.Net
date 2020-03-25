using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace LevelUp.Net.Operations.Calls
{
    [Function("GetTotalInfluence", "uint")]
    public class CallGetTotalInfluence : FunctionMessage
    {
    }
}
