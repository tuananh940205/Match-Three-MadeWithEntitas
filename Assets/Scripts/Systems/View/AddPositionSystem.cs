using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class AddPositionSystem : ReactiveSystem<GameEntity>
{
    readonly GameContext gameContext;
    public AddPositionSystem(Contexts contexts) : base(contexts.game)
    {
        gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Position);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasPosition;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity e in entities)
        {
            
        }
    }
}