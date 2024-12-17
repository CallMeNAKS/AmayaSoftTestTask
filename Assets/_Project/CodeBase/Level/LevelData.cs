using CodeBase.Cell;
using UnityEngine;


namespace CodeBase.Level
{
    [CreateAssetMenu(menuName = "Data/LevelData", fileName = "LevelData", order = 0)]
    public class LevelData : ScriptableObject
    {
        [field: SerializeField] public int GridWidth { get; private set; }
        [field: SerializeField] public int GridHeight { get; private set; }
        [field: SerializeField] public CellData[] CellsData { get; private set; }
        [field: SerializeField] public string QuestDescription { get; private set; }
    }
}
