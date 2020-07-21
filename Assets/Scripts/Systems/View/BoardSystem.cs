// using System.Collections.Generic;
// using Entitas;
// using Entitas.Unity;
// using UnityEngine;

// public class BoardSystem : ReactiveSystem<GameEntity>
// {
//     readonly Transform _viewContainer = new GameObject("Game Views").transform;
//     readonly string[] prefabs = new string[] { "Apple", "Bread", "Coconut", "Flower", "Milk", "Orange", "Vegetable"};
//     public BoardSystem(Contexts contexts) : base(contexts.game)
//     {

//     }

//     protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
//     {
//         return context.CreateCollector(GameMatcher.AllOf(GameMatcher.BoardColumn, GameMatcher.BoardRow));
//     }

//     protected override bool Filter(GameEntity entity)
//     {
//         return entity.hasBoardColumn && entity.hasBoardRow;
//     }

//     protected override void Execute(List<GameEntity> entities)
//     {
//         foreach(GameEntity e in entities)
//         {
//             for(int y = 0; y < e.boardColumn.value; y++)
//             {
//                 for(int x = 0; x < e.boardRow.value; x++)
//                 {
//                     GameObject prefab = Resources.Load<GameObject>("Prefabs/" + prefabs[Random.Range(0, prefabs.Length)]);
//                     GameObject go = Object.Instantiate(prefab, new Vector2(x, y), Quaternion.identity);
//                     go.transform.SetParent(_viewContainer, true);
//                     go.Link(e);
//                 }
//             }
//         }
//     }
// }