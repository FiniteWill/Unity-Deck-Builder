using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Debugging;

namespace Card
{
    public enum CardType { MONSTER, EQUIPMENT, SPELL, ZONE, EVENT, ACTION };

    /// <summary>
    /// Contains information for a card.
    /// </summary>
    public class CardData
    {
        const bool DEBUGGING = true;
        private string m_cardName = "Default Card Name";
        public string CardName { get => m_cardName; private set => m_cardName = value; }
        private Guid m_id = Guid.NewGuid();
        public Guid Id { get => m_id; private set => m_id = value; }
        private CardType m_cardType = CardType.MONSTER;
        public CardType CardType { get => m_cardType; set => m_cardType = value; }

        public CardData()
        {
            CardName = "Default Card Name";
            Id = Guid.NewGuid();
            CardType = CardType.MONSTER;
        }
        public CardData(string cardName)
        {
            CardName = cardName;
            Id = Guid.NewGuid();
            CardType = CardType.MONSTER;
        }
        public CardData(CardType cardType)
        {
            CardType = cardType;
        }
        public CardData(string cardName, CardType cardType)
        {
            CardName = cardName;
            CardType = cardType;
        }
    }

    public class MonsterCardData : CardData
    {
        private const int DEFAULT_ATTACK = 0;
        private const int DEFAULT_HEALTH = 1;

        private int m_attack = DEFAULT_ATTACK;
        public int Attack { get => m_attack; set => m_attack = value; }
        private int m_health = DEFAULT_HEALTH;
        public int Health { get => m_health; set => m_health = value; }

        public MonsterCardData(): base()
        {
            Attack = DEFAULT_ATTACK;
            Health = DEFAULT_HEALTH;
        }
        public MonsterCardData(string name):base(name, CardType.MONSTER)
        {
            Attack = DEFAULT_ATTACK;
            Health = DEFAULT_HEALTH;
        }
        public MonsterCardData(int attack, int health): base()
        {
            Attack = attack;
            Health = health;
        }
        public MonsterCardData(string cardName, int attack, int health): base(cardName, CardType.MONSTER)
        {
            Attack = attack;
            Health = health;
        }

        
    }

    public class EquipmentCardData : CardData
    {
        public EquipmentCardData(): base()
        {
            
        }
    }

    public class SpellCardData : CardData
    {
        public SpellCardData(): base()
        {

        }
    }

    public class ZoneCardData : CardData
    {
        public ZoneCardData(): base()
        {

        }
    }

    public class EventCardData: CardData
    {
        public EventCardData(): base()
        {

        }
    }

    public class ActionCardData: CardData
    {
        public ActionCardData(): base()
        {

        }
    }
}
