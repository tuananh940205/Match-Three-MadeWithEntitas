using Entitas;
using UnityEngine;
using System.Collections.Generic;
using Entitas.Unity;

public class BoardSizeSystem : IInitializeSystem
{
    readonly GameContext _gameContext;

    public BoardSizeSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Initialize()
    {
        GameEntity e = _gameContext.CreateEntity();

        e.AddBoardRow(8);
        e.AddBoardColumn(10);
    }
}