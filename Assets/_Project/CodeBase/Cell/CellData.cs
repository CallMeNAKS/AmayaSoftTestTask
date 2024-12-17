using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

namespace CodeBase.Cell
{
    [CreateAssetMenu(menuName = "Data/CellData", fileName = "CellData", order = 0)]
    public class CellData : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public Sprite Image { get; private set; }
    }
}