using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class BoardSystem : ReactiveSystem<GameEntity>
{
    public BoardSystem(Contexts contexts) : base(contexts.game)
    {

    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf(GameMatcher.BoardColumn, GameMatcher.BoardRow));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasBoardColumn && entity.hasBoardRow;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity e in entities)
        {
            for(int y = 0; y < e.boardColumn.value; y++)
            {
                for(int x = 0; x < e.boardRow.value; x++)
                {
                    Debug.LogFormat("x = {0}, y = {1}", x, y);
                }
            }
        }
    }
}