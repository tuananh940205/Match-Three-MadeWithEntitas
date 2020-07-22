using Entitas;
using UnityEngine;
using System.Collections.Generic;
using Entitas.Unity;

public class CreateBoardSystem : ReactiveSystem<GameEntity>
{
    readonly GameContext _gameContext;
    Transform viewContainer = new GameObject("Game Views").transform;
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
            Vector2 offset = Resources.Load<GameObject>("Prefabs/Apple").GetComponent<SpriteRenderer>().bounds.size;
            Debug.LogFormat("value - {0}", offset);
            Vector2 startPosition = new Vector2(-2.35f, 1.6f);
            for(int y = 0; y < e.boardColumn.value; y++)
            {
                for(int x = 0; x < e.boardRow.value; x++)
                {
                    // GameEntity _gameEntity = _gameContext.CreateEntity();
                    Debug.LogFormat("x = {0}, y = {1}", x, y);
                    GameObject go = Resources.Load<GameObject>("Prefabs/" + names[Random.Range(0, names.Length)]);;
                    GameObject tile = Object.Instantiate(go);
                    tile.transform.position =  new Vector2(startPosition.x + x * offset.x, startPosition.y - y * offset.y);
                    tile.transform.SetParent(viewContainer, true);
                    // tile.Link(e);
                    
                }
            }
        }
    }

}