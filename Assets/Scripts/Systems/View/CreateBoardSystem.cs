using Entitas;
using UnityEngine;

public class CreateBoardSystem : MonoBehaviour, IInitializeSystem
{
    readonly GameContext _gameContext;
    Vector2 offset = new Vector2(0.8f, 0.8f);
    int _boardRow = 8;
    int _boardColumn = 10;
    int level;

    public CreateBoardSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Initialize()
    {
        CreateBoard();
    }

    void CreateBoard()
    {
        for(int y = 0; y < _boardColumn; y++)
        {
            for(int x = 0; x < _boardRow; x++)
            {
                GameObject go = Resources.Load<GameObject>("Prefabs/" + "Vegetable");
                Instantiate(go);
            }
        }
    }
}