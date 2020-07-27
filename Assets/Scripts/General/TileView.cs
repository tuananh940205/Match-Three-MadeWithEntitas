using UnityEngine;
using DG.Tweening;
using Entitas;
using Entitas.Unity;

public class TileView : MonoBehaviour
{
    private Vector2 firstPosition;
    private Vector2 lastPosition;
    private Tween tween;

    void OnMouseDown()
    {
        //Debug.LogFormat("OnMouseDown");
        //Debug.LogFormat("OnMouseDown != null");
        // onMouseDown?.Invoke(this);

        Vector3[] wayPath = new Vector3[]
        {
            transform.position,
            new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z),
            transform.position
        };

        firstPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        tween = transform.DOPath( wayPath, .8f);
    }

    void OnMouseUp()
    {
        tween.Complete();
        lastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        EntityLink entity = gameObject.GetEntityLink();

        if(entity != null)
        {
            GameEntity e = entity.entity as GameEntity;
            e.ReplaceDebugMessage("Hello World!");
        }

        //Debug.LogFormat("onMouseUp != null");
        // onMouseUp?.Invoke(firstPosition, lastPosition);
    }
}