using UnityEngine;

namespace CodeBase.Card
{
    [CreateAssetMenu(menuName = "Data/Card/Card", fileName = "Card", order = 0)]
    public class CardData : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public Sprite BackgroundImage { get; private set; }
        [field: SerializeField] public Sprite ItemImage { get; private set; }
    }
}