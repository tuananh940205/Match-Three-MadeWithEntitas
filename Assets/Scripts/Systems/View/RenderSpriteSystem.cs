using Entitas;
using UnityEngine;
using System.Collections.Generic;
using Entitas.Unity;

public class RenderSpriteSystem :ReactiveSystem<GameEntity>
{
    readonly GameContext gameContext;

    public RenderSpriteSystem(Contexts contexts) : base(contexts.game)
    {
        gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Sprite);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView && entity.hasSprite;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity e in entities)
        {
            string name = e.sprite.name;
            Sprite sprite = Resources.Load<Sprite>("Characters/" + name);
            e.view.gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }
}