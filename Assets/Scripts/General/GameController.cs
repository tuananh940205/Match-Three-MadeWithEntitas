using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Systems _systems;

    void Start()
    {
        Contexts _contexts = Contexts.sharedInstance;
        _systems = new Feature("Features")
            // .Add(new GameSystems(_contexts));
            .Add(new InputSystems(_contexts))
            .Add(new ViewSystems(_contexts));
        _systems.Initialize();
    }

    void Update()
    {   
        _systems.Execute();
        _systems.Cleanup();
    }
}