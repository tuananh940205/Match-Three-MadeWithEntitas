using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.Unity;

public class TileView : MonoBehaviour
{
    void OnMouseDown() 
    {
        Debug.LogFormat("down");
    }

    // public void RegisterListener(Contexts contexts, GameEntity entity)
    // {
    //     entity.AddGamePositionListener(this);
    // }

    // public void OnPosition(GameEntity entity1, float x, float y)
    // {
    //     transform.position = new Vector2(x, y);
    // }
}