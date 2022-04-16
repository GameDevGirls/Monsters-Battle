using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Monster", menuName = "Monster")]
public class ShopMonstersCard : ScriptableObject
{
    public new string titleName;
    public int healthCount;
    public int attackCount;
    public int defenceCount;
    public Sprite image;
    public string description;
    public int coinCount;



}
