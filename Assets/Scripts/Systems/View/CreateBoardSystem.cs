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
        
    }
}