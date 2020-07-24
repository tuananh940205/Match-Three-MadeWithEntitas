using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.Unity;

public class AddViewSystem : ReactiveSystem<GameEntity>
{
    // Transform viewContainer = new GameObject("Game Views").transform;
    readonly GameContext _gameContext;
    // Vector2 startPosition = new Vector2(-2.35f, 1.6f);
    // Vector2 offset = Resources.Load<GameObject>("Prefabs/Apple").GetComponent<SpriteRenderer>().bounds.size;
    // string[] names = new string[] {"Apple", "Bread", "Coconut", "Flower", "Milk", "Orange", "Vegetable"};

    public AddViewSystem(Contexts contexts): base(contexts.game)
    {
        _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.View);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView && !entity.hasPosition;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity e in entities)
        {
            Debug.LogFormat("gameobject = {0}, x = {1}, y = {2}", e.view.gameObject.name, e.view.rowPosition, e.view.columnPosition);
            // Vector2 tilePos = new Vector2(e.view.rowPosition, e.view.columnPosition);
            // Vector2 tilePos = new Vector2(startPosition.x + offset.x * e.view.rowPosition, startPosition.y + offset.y * e.view.columnPosition);
            // GameObject go = Object.Instantiate(e.view.gameObject, tilePos, Quaternion.identity);
            // GameObject go = Object.Instantiate(e.view.gameObject);
            // go.transform.SetParent(viewContainer, true);
            // e.AddSprite(names[Random.Range(0, names.Length - 1)]);
            // e.AddPosition(tilePos);
            // Debug.LogFormat("x = {0}, y = {1}", e.view.rowPosition, e.view.columnPosition);
            // // Vector2 tilePos = new Vector2(12, 1);
            // // Debug.LogFormat("" + tilePos);
            // e.AddView(new GameObject());
            // go.Link(e);
        }
    }
}
