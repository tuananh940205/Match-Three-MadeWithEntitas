//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BoardRowComponent boardRow { get { return (BoardRowComponent)GetComponent(GameComponentsLookup.BoardRow); } }
    public bool hasBoardRow { get { return HasComponent(GameComponentsLookup.BoardRow); } }

    public void AddBoardRow(int newValue) {
        var index = GameComponentsLookup.BoardRow;
        var component = (BoardRowComponent)CreateComponent(index, typeof(BoardRowComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBoardRow(int newValue) {
        var index = GameComponentsLookup.BoardRow;
        var component = (BoardRowComponent)CreateComponent(index, typeof(BoardRowComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBoardRow() {
        RemoveComponent(GameComponentsLookup.BoardRow);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBoardRow;

    public static Entitas.IMatcher<GameEntity> BoardRow {
        get {
            if (_matcherBoardRow == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BoardRow);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBoardRow = matcher;
            }

            return _matcherBoardRow;
        }
    }
}
