using Entitas;

public class InitializeBoardSystem : IInitializeSystem
{
    readonly GameContext _gameContext;
    public InitializeBoardSystem(Contexts contexts)
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