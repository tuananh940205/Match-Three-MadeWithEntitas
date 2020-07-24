public class ViewSystems : Feature
{
    public ViewSystems(Contexts contexts) : base("View Systems")
    {
        Add(new BoardSizeSystem(contexts));
        Add(new InitializeBoardSystem(contexts));
        Add(new AddViewSystem(contexts));
        Add(new RenderPositionSystem(contexts));
    }
}