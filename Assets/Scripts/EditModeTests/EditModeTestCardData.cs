using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Debugging;
using Card;

public class TestCardData
{
    [Test]
    public void TestCardDataInitialization()
    {
        const string DEFAULT_CARD_NAME = "Default Card Name";
        CardData noParamCardData = new CardData();
        Assert.AreEqual(DEFAULT_CARD_NAME, noParamCardData.CardName);
        Assert.AreEqual(CardType.MONSTER, noParamCardData.CardType);

        CardData nameParamCardData = new CardData("test");
        Assert.AreEqual("test", nameParamCardData.CardName);
        Assert.AreEqual(CardType.MONSTER, nameParamCardData.CardType);

        CardData namedAndTypedCardData = new CardData("test", CardType.EQUIPMENT);
        Assert.AreEqual("test", namedAndTypedCardData.CardName);
        Assert.AreEqual(CardType.EQUIPMENT, namedAndTypedCardData.CardType);
    }
    [Test]
    public void TestMonsterCardDataInitialization()
    {
        const int DEFAULT_ATTACK = 0;
        const int DEFAULT_HEALTH = 1;
        const string DEFAULT_CARD_NAME = "Default Card Name";

        MonsterCardData noParam = new MonsterCardData();
        Assert.AreEqual(DEFAULT_CARD_NAME, noParam.CardName);
        Assert.AreEqual(CardType.MONSTER, noParam.CardType);

        MonsterCardData nameParam = new MonsterCardData("test");
        Assert.AreEqual("test", nameParam.CardName);
        Assert.AreEqual(DEFAULT_ATTACK, nameParam.Attack);
        Assert.AreEqual(DEFAULT_HEALTH, nameParam.Health);

        MonsterCardData attackAndHealthParams = new MonsterCardData(3, 3);
        Assert.AreEqual(3, attackAndHealthParams.Attack);
        Assert.AreEqual(3, attackAndHealthParams.Health);

        MonsterCardData allParams = new MonsterCardData("test", 3, 3);
        Assert.AreEqual("test", allParams.CardName);
        Assert.AreEqual(3, allParams.Attack);
        Assert.AreEqual(3, allParams.Health);

    }
}
