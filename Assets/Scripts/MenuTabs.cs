using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTabs : MonoBehaviour
{
    public GameObject monsterCards, boosters;
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
