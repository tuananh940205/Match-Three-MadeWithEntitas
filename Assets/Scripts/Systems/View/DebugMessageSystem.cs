using Entitas;
using UnityEngine;
using System.Collections.Generic;

public class DebugMessageSystem : ReactiveSystem<GameEntity>
{
    readonly GameContext _gameContext;

    public DebugMessageSystem(Contexts contexts) : base(contexts.game)
    {
        _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.DebugMessage);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasDebugMessage;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity e in entities)
        {
            // Debug.Log(e.debugMessage.message);
        }
    }
}