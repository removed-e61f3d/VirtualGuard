using VirtualGuard.Runtime.Execution;

namespace VirtualGuard.Runtime.OpCodes.impl
{
    public class Xor : IOpCode
    {
        public void Execute(VMContext ctx, out ExecutionState state)
        {
            ctx.Stack.Push(ctx.Stack.Pop().ToNumeral().Xor(ctx.Stack.Pop().ToNumeral()));
            state = ExecutionState.Next;
        }

        public byte GetCode() => 0;
    }
}