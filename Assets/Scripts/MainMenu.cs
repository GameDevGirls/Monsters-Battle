using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject titlePanel;
    public GameObject menuPanel;
    public GameObject howToPlayPanel;
    public void StartButtonMainMenu()
    {
        SceneManager.LoadScene("MainScene");
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
    }

    public void CreditsButtonMainMenu()
    {

    }

}
