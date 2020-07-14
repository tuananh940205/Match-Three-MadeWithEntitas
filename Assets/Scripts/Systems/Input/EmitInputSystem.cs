using Entitas;
using UnityEngine;

public sealed class EmitInputSystem : IExecuteSystem
{
    readonly Contexts _contexts;

    public EmitInputSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {

    }
}
