using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterCardHolderToController : MonoBehaviour
{
    public void monsterCardToController()
    {
        MainMenu.Instance.monsterCardHolderx = this.gameObject.transform.GetComponent<MonsterCardHolder>();
        MainMenu.Instance.openMonsterCardDetailsShop();
    }
}
