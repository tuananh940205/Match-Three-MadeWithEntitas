using Entitas;
using UnityEngine;
using System.Collections.Generic;
using Entitas.Unity;

public class CreateBoardSystem : ReactiveSystem<GameEntity>
{
    // Transform viewContainer = new GameObject("Game Views").transform;
    readonly GameContext _gameContext;
    
    
    string[] names = new string[] {"Apple", "Bread", "Coconut", "Flower", "Milk", "Orange", "Vegetable"};
    public CreateBoardSystem(Contexts contexts) : base (contexts.game)
    {
        _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger (IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf(GameMatcher.BoardColumn, GameMatcher.BoardRow));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasBoardRow;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity e in entities)
        {
            // Debug.LogFormat("value - {0}", offset);
            for(int y = 0; y < e.boardColumn.value; y++)
            {
                for(int x = 0; x < e.boardRow.value; x++)
                {
                    GameEntity gameEntity = _gameContext.CreateEntity();
                    // GameObject go = Resources.Load<GameObject>("Prefabs/" + names[Random.Range(0, names.Length - 1)]);
                    GameObject go = Resources.Load<GameObject>("Prefabs/NullPrefab");
                    // Vector2 tilePos = new Vector2(startPosition.x + x * offset.x, startPosition.y - y * offset.y);

                    gameEntity.AddView(go, x, -y);
                    // gameEntity.AddPosition(tilePos);
                    // Debug.LogFormat("x = {0}, y = {1}", x, y);
                    // GameObject tile = Object.Instantiate(go);
                    // tile.Link(_gameEntity);
                    // _gameEntity.AddView(go);
                    // tile.transform.position =  new Vector2(startPosition.x + x * offset.x, startPosition.y - y * offset.y);
                    // tile.transform.SetParent(viewContainer, true);
                }
            }
        }
    }
}