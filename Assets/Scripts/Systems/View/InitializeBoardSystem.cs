using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class InitializeBoardSystem : ReactiveSystem<GameEntity>
{
    readonly GameContext _gameContext;
    Transform _viewContainer = new GameObject("Game Views").transform;

    public InitializeBoardSystem(Contexts contexts) : base(contexts.game)
    {
        _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf(GameMatcher.BoardRow, GameMatcher.BoardColumn));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasBoardRow && entity.hasBoardColumn;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity e in entities)
        {
            for(int y = 0; y < e.boardColumn.value; y++)
            {
                for(int x = 0; x < e.boardRow.value; x++)
                {
                    GameEntity en = _gameContext.CreateEntity();
                    GameObject go = Resources.Load<GameObject>("Prefabs/Apple");
                    GameObject goo = Object.Instantiate(go);
                    goo.transform.SetParent(_viewContainer, true);
                    en.isPositionSetter = true;
                    en.AddView(goo, x, y);
                }
            }
        }
    }
}