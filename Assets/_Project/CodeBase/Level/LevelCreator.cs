using System.Collections.Generic;
using CodeBase.Card;
using CodeBase.Grid;
using UnityEngine;

namespace CodeBase.Level
{
    public class LevelCreator
    {
        private readonly CustomGridLayout _gridLayout;
        private readonly CardPackFactory _cardPackFactory;
        
        private List<CardData> _cardData = new List<CardData>(); 
        private List<Card.Card> _cards = new List<Card.Card>();

        private const float BounceDuration = 1f;
        private const int Bounciness = 1;

        public LevelCreator(CustomGridLayout gridLayout,
            CardPackFactory cardPackFactory)
        {
            _gridLayout = gridLayout;
            _cardPackFactory  = cardPackFactory;
        }


        public List<Card.Card> CreateCards(LevelStageConfig stageData)
        {
            _cardData.Clear();
            
            foreach (var card in stageData.CardPack.Cards)
            {
                _cardData.Add(card);
            }
            
            var cardToCreate = stageData.Rows * stageData.Columns - _cards.Count;
            
            var cards  = _cardPackFactory.CreateCardPack(stageData.CardPack, cardToCreate);

            for (int i = 0; i < cards.Count; i++)
            {
                _cards.Add(cards[i]);
            }
            
            foreach (var card in _cards)
            {
                card.transform.SetParent(_gridLayout.transform);
                var randomCard = RandomCard();
                card.Init(randomCard.ItemImage, randomCard.Name);
            }

            _gridLayout.SetNewGridSize(stageData.Rows, stageData.Columns);

            return _cards;
        }
        
        private CardData RandomCard()
        {
            var card = _cardData[Random.Range(0, _cardData.Count)];
            _cardData.Remove(card);
            
            return card;
        }

        public void Reset()
        {
            for (int i = 0; i < _cards.Count; i++)
            {
                GameObject.DestroyImmediate(_cards[i].gameObject);
            }

            _cards.Clear();
        }
    }
}