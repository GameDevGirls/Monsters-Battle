using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void CloseShopPanel()
    {
        SceneManager.LoadScene("MainMenuScene");
    }



}
