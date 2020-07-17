using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CreateBoardSystem : IInitializeSystem
{
    readonly GameContext _gameContext;
    public CreateBoardSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Initialize() 
    {
        GameEntity e = _gameContext.CreateEntity();
        e.AddBoardColumn(10);
        e.AddBoardRow(8);
    }
}