using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class InitializeBoardSystem : ReactiveSystem<GameEntity>
{
    readonly GameContext _gameContext;
    // Transform _viewContainer = new GameObject("Game Views").transform;
    
    GameEntity[,] _gameEntities;

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
            _gameEntities = new GameEntity[e.boardRow.value, e.boardColumn.value];
            List<string> names = new List<string>() {"Apple", "Bread", "Coconut", "Flower", "Milk", "Orange", "Vegetable"};
            // Debug.LogFormat("_gameEntity length = {0}, {1}", _gameEntities.GetLength(0), _gameEntities.GetLength(1));
            for(int y = 0; y < e.boardColumn.value; y++)
            {
                for(int x = 0; x < e.boardRow.value; x++)
                {
                    // Debug.LogFormat("AAA");
                    GameEntity tileEntity = _gameContext.CreateEntity();
                    _gameEntities[x, y] = tileEntity;
                    List<string> nameList = new List<string>();
                    nameList.AddRange(names);

                    if(x > 0) nameList.Remove(_gameEntities[x - 1, y].view.gameObject.name);
                    if(y > 0) nameList.Remove(_gameEntities[x, y - 1].view.gameObject.name);

                    // Debug.LogFormat("nameList count = {0}", nameList.Count);
                    string name = nameList[Random.Range(0, nameList.Count - 1)];
                    GameObject go = Resources.Load<GameObject>("Prefabs/" + name);
                    tileEntity.AddView(go, x, y);
                }
            }
        }
    }
}