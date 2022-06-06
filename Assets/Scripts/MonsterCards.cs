using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class MonsterCards : ScriptableObject
{
    public string tokenId;
    public string monsterCardName;
    public string monsterCardDescription;

    public Sprite monsterCardLV1Sprite;
    public Sprite monsterCardLV2Sprite;
    public Sprite monsterCardLV3Sprite;

    public int price;
    public int attack;
    public int health;
    public int defense;
    public Level monsterCardLevel;


    public int boostedAttack;
    public int boostedHealth;
    public int boostedDefense;

    public enum Level { firstLevel, secondLevel, thirdLevel}

}
