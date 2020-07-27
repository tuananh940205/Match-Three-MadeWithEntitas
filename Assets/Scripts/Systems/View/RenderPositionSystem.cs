using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class RenderPositionSystem : ReactiveSystem<GameEntity>
{
    readonly GameContext gameContext;
    public RenderPositionSystem(Contexts contexts) : base(contexts.game)
    {
        gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return
            context.CreateCollector(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.View));
            // context.CreateCollector(GameMatcher.AllOf(GameMatcher.View).NoneOf(GameMatcher.Position));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasPosition && entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity e in entities)
        {
            // Debug.LogFormat("x = {0}, y = {1}", e.view.rowPosition, e.view.columnPosition);
            // e.view.gameObject.transform.position = new Vector2(e.position.x, e.position.y);
            // e.isPositionSetter = false;
            // Debug.LogFormat("Set position; e.position.position = {0}", e.position.position);
            // e.view.gameObject.transform.position = new Vector2(e.position.x, e.position.y);
            // Debug.LogFormat("Gameobject = {0}, position = {1}", e.view.gameObject.name, e.view.gameObject.transform.position);
            // Vector2 position = e.position.position;
            // Debug.LogFormat("position = {0}, gameView = {1}", position, e.view.gameObject.transform.position);
        }
    }
}