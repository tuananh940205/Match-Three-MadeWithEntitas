public sealed class GameSystems : Feature
{
    public GameSystems(Contexts contexts)
    {
        // Input
        Add(new EmitInputSystem(contexts));

        // View
        Add(new AddViewSystem(contexts));
        Add(new CreateBoardSystem(contexts));
    }
}