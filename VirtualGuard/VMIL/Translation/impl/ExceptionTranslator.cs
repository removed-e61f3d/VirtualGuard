﻿using System.Diagnostics;
using AsmResolver.PE.DotNet.Cil;
using VirtualGuard.VMIL.VM;

namespace VirtualGuard.VMIL.Translation.impl;

public class ExceptionTranslator : ITranslator
{
    public void Translate(CilInstruction instr, VmBlock block, VmMethod meth, VirtualGuardContext ctx)
    {
        switch (instr.OpCode.Code)
        {
            case CilCode.Leave:
            case CilCode.Leave_S:
                block.WithContent(new VmInstruction(VmCode.Ldc_I4, instr.Operand),
                    new VmInstruction(VmCode.Leave)
                    );
                break;
        }
    }

    public bool Supports(CilInstruction instr)
    {
        return new[]
        {
            CilCode.Leave,
            CilCode.Leave_S
        }.Contains(instr.OpCode.Code);
    }
}