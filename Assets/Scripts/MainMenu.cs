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
    public GameObject monstersAndBooster;

    public GameObject salamander;
    public GameObject slime;
    public GameObject bat;
    public GameObject alquartz;
    public GameObject dragon;
    public GameObject crab;
    public GameObject flower;
    public GameObject ghost;
    public GameObject shadow;
    public GameObject shell;
    public GameObject skeleton;
    public GameObject troll;
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

    //Salamander
    public void OpenSalamanderCardDetail()
    {
        monstersAndBooster.SetActive(false);
        salamander.SetActive(true);
    }
    public void BackSalamanderCardDetail()
    {
        monstersAndBooster.SetActive(true);
        salamander.SetActive(false);
    }

    //Slime
    public void OpenSlimeCardDetail()
    {
        monstersAndBooster.SetActive(false);
        slime.SetActive(true);
    }
    public void BackSlimeCardDetail()
    {
        monstersAndBooster.SetActive(true);
        slime.SetActive(false);
    }


    //Bat
     public void OpenBatCardDetail()
    {
        monstersAndBooster.SetActive(false);
        bat.SetActive(true);
    }
    public void BackBatCardDetail()
    {
        monstersAndBooster.SetActive(true);
        bat.SetActive(false);
    }


    //Alquartz
    public void OpenAlquartzCardDetail()
    {
        monstersAndBooster.SetActive(false);
        alquartz.SetActive(true);
    }
    public void BackAlquartzCardDetail()
    {
        monstersAndBooster.SetActive(true);
        alquartz.SetActive(false);
    }


    //Dragon
    public void OpenDragonCardDetail()
    {
        monstersAndBooster.SetActive(false);
        dragon.SetActive(true);
    }
    public void BackDragonCardDetail()
    {
        monstersAndBooster.SetActive(true);
        dragon.SetActive(false);
    }


    //Crab
    public void OpenCrabCardDetail()
    {
        monstersAndBooster.SetActive(false);
        crab.SetActive(true);
    }
    public void BackCrabCardDetail()
    {
        monstersAndBooster.SetActive(true);
        crab.SetActive(false);
    }


    //Flower
    public void OpenFlowerCardDetail()
    {
        monstersAndBooster.SetActive(false);
        flower.SetActive(true);
    }
    public void BackFlowerCardDetail()
    {
        monstersAndBooster.SetActive(true);
        flower.SetActive(false);
    }


    //Ghost
    public void OpenGhostCardDetail()
    {
        monstersAndBooster.SetActive(false);
        ghost.SetActive(true);
    }
    public void BackGhostCardDetail()
    {
        monstersAndBooster.SetActive(true);
        ghost.SetActive(false);
    }


    //Shadow
    public void OpenShadowCardDetail()
    {
        monstersAndBooster.SetActive(false);
        shadow.SetActive(true);
    }
    public void BackShadowCardDetail()
    {
        monstersAndBooster.SetActive(true);
        shadow.SetActive(false);
    }

    //Shell
    public void OpenShellCardDetail()
    {
        monstersAndBooster.SetActive(false);
        shell.SetActive(true);
    }
    public void BackShellCardDetail()
    {
        monstersAndBooster.SetActive(true);
        shell.SetActive(false);
    }


    //Skeleton
    public void OpenSkeletonCardDetail()
    {
        monstersAndBooster.SetActive(false);
        skeleton.SetActive(true);
    }
    public void BackSkeletonCardDetail()
    {
        monstersAndBooster.SetActive(true);
        skeleton.SetActive(false);
    }


    //Troll
    public void OpenTrollCardDetail()
    {
        monstersAndBooster.SetActive(false);
        troll.SetActive(true);
    }
    public void BackTrollCardDetail()
    {
        monstersAndBooster.SetActive(true);
        troll.SetActive(false);
    }



}
