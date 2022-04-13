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
    public void closeButtonHowToPlayMainMenu()
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
        SceneManager.LoadScene("ShopScene");
    }
    public void InventoryButton()
    {

    }

}
