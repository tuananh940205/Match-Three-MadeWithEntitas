using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game]
public class ViewComponent : IComponent
{
    public GameObject gameObject;
}

[Game]
public class PositionComponent : IComponent
{
    public Vector2 position;
}

[Game]
public class DirectionComponent : IComponent
{
    public float angle;
}