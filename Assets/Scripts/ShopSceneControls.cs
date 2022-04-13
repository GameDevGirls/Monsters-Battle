using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class ShopSceneControls : MonoBehaviour
{

    public GameObject boosters;
    public GameObject monsterCards;

    public void openBoosters()
    {
        boosters.SetActive(true);
        monsterCards.SetActive(false);
    }
    public void openMonsterCards()
    {
        boosters.SetActive(false);
        monsterCards.SetActive(true);
    }



}
