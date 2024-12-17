using CodeBase.Card;
using UnityEngine;

namespace CodeBase.Level
{
    [CreateAssetMenu(menuName = "Data/LevelData", fileName = "LevelData", order = 0)]
    public class LevelData : ScriptableObject
    {
        [field: SerializeField] public Vector2Int Grid { get; private set; }
        [field: SerializeField] public CardPack CardPack { get; private set; }
    }
}