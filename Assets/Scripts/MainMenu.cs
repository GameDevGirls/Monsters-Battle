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
    public GameObject credits;
    public GameObject shopPanel;
    public GameObject inventoryPanel;
    public GameObject equipPanel;
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
    public void CreditsButtonMainMenu()
    {
        titlePanel.SetActive(false);
        menuPanel.SetActive(false);
        credits.SetActive(true);
    }
    public void CloseOrBackButton()
    {
        titlePanel.SetActive(true);
        menuPanel.SetActive(true);
        howToPlayPanel.SetActive(false);
        startButtonPanel.SetActive(false);
        credits.SetActive(false);
    }

    public void OpenBattleScene()
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
        inventoryPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void CloseShopPanel()
    {
        startButtonPanel.SetActive(true);
        shopPanel.SetActive(false);
    }public void CloseInventoryPanel()
    {
        startButtonPanel.SetActive(true);
        inventoryPanel.SetActive(false);
    }

    public void CloseEquipPanel()
    {
        equipPanel.SetActive(false);

    }

    public void OpenEquipPanel()
    {
        equipPanel.SetActive(true);
    }






}
