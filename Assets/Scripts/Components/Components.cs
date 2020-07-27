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

[Game, Event(EventTarget.Self)]
public class PositionComponent : IComponent
{
    public float x;
    public float y;
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
public class SpriteComponent : IComponent
{
    public string name;
}

[Game]
public class DebugMessageComponent : IComponent
{
    public string message;
}