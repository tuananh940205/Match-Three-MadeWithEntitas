using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game]
public class ViewComponent : IComponent
{
    public GameObject gameObject;
    public int rowPosition;
    public int columnPosition;
}

[Game]
public class PositionComponent : IComponent
{
    public Vector2 position;
}

[Game]
public class BoardColumnComponent : IComponent
{
    public int value;
}

[Game]
public class BoardRowComponent : IComponent
{
    public int value;
}

[Game]
public class TilePrefabComponent : IComponent
{
    public string[] name;
}