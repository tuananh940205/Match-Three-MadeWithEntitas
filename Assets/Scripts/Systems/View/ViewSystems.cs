public class ViewSystems : Feature
{
    public ViewSystems(Contexts contexts) : base("View Systems")
    {
        Add(new InitializeBoardSystem(contexts));
        Add(new CreateBoardSystem(contexts));
    }
}