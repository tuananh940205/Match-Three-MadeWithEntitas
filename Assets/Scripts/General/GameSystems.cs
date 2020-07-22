public sealed class GameSystems : Feature
{
    public GameSystems(Contexts contexts) : base("Game Systems")
    {
        Add(new InputSystems(contexts));
        Add(new ViewSystems(contexts));
    }
}