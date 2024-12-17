using UnityEngine;

namespace CodeBase.Card
{
    [CreateAssetMenu(menuName = "Data/Card/CardPack", fileName = "CardPack", order = 0)]
    public class CardPack : ScriptableObject
    {
        [field: SerializeField] public CardData[] Cards { get; private set; }
        [field: SerializeField] public string QuestDescription { get; private set; }
    }
}