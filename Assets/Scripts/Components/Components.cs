using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

// [Input, Unique]
// public class LeftMouseComponent : IComponent
// {

// }

// [Input]
// public class MouseDownComponent : IComponent
// {
//     public Vector2 position;
// }

// [Input]
// public class MouseUpPosition : IComponent
// {
//     public Vector2 position;
// }

// [Game]
// public class ViewComponent : IComponent
// {
//     public GameObject gameObject;
// }

// [Game]
// public class SpriteComponent : IComponent
// {
//     public string name;
// }

[Game]
public class BoardRowComponent : IComponent
{
    public int value;
}

[Game]
public class BoardColumnComponent : IComponent
{
    public int value;
}

[Game]
public class PositionComponent : IComponent
{
    public Vector2 position;
}

[Game]
public class SpriteComponent : IComponent
{
    public string name;
}

// [Game]
// public class 