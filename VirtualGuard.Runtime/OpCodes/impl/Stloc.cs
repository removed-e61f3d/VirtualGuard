using VirtualGuard.Runtime.Dynamic;
using VirtualGuard.Runtime.Execution;

namespace VirtualGuard.Runtime.OpCodes.impl;

public class Stloc : IOpCode
{
    public void Execute(VMContext ctx, out ExecutionState state)
    {
        throw new NotImplementedException();
    }

    public byte GetCode() => 0;
}