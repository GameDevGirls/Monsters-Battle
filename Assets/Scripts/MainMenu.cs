using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject titlePanel;
    public GameObject startButtonPanel;
    public GameObject menuPanel;
    public GameObject howToPlayPanel;
    public GameObject shopPanel;
    public void StartButtonMainMenu()
    {
        startButtonPanel.SetActive(true);
        titlePanel.SetActive(false);
        menuPanel.SetActive(false);
    }

    public void HowToPlayButtonMainMenu()
    {
        titlePanel.SetActive(false);
        menuPanel.SetActive(false);
        howToPlayPanel.SetActive(true);
    }
    public void CloseOrBackButton()
    {
        titlePanel.SetActive(true);
        menuPanel.SetActive(true);
        howToPlayPanel.SetActive(false);
        startButtonPanel.SetActive(false);
    }

    public void CreditsButtonMainMenu()
    {

    }

    public void BattleButtonScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void ShopButton()
    {
        menuPanel.SetActive(false);
        shopPanel.SetActive(true);
    }
    public void InventoryButton()
    {

    }

    //---------------------SHOP---------------------//

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
        startButtonPanel.SetActive(true);
        shopPanel.SetActive(false);
    }



}
