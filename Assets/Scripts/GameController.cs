using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Systems _systems;
    private Contexts _contexts;
    void Start()
    {
        _contexts = Contexts.sharedInstance;
        _systems = new Feature("Features").Add(new GameSystems(_contexts));
        _systems.Initialize();
    }

    void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }
}