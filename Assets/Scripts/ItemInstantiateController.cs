using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemInstantiateController : MonoBehaviour
{
    [Header("Shop system")]
    public List<MonsterCards> monsterCardsShop = new List<MonsterCards>();
    public GameObject Item_monsterCardShop;
    public GameObject monsterCardShopItemHolder;
    public MonsterCards lastClickedMonsterCardShop;

    [Header("Inventory System")]
    public List<MonsterCards> monsterCardsInventory = new List<MonsterCards>();
    public GameObject monsterCardInventoryItemHolder;
    public GameObject Item_monsterCardInventory;


    public static ItemInstantiateController Instance;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    #region SHOP
    public void instantiateMonsterCardsShop()
    {
        ClearChildren(monsterCardShopItemHolder);

        foreach (MonsterCards monster in monsterCardsShop)
        {
            GameObject x = Instantiate(Item_monsterCardShop, monsterCardShopItemHolder.transform);
            x.GetComponent<MonsterCardHolder>().monsterCard = monster;
            x.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = monster.monsterCardLV1Sprite;
            x.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = monster.price.ToString();
        }
    }


    public void monsterCardDetailsShopBUYBUTTON()
    {
        foreach (MonsterCards card in monsterCardsShop)
        {
            if (card.monsterCardName == lastClickedMonsterCardShop.monsterCardName)
            {
                //CHECK IF THE COINS ARE ENOUGH
                monsterCardsInventory.Add(card);
                monsterCardsShop.Remove(card);
                MainMenu.Instance.closeMonsterCardDetailsShop();
                break;
            }
        }
    }

    #endregion




    public void ClearChildren(GameObject toClear)
    {
        int i = 0;

        //Array to hold all child obj
        GameObject[] allChildren = new GameObject[toClear.transform.childCount];

        //Find all child obj and store to that array
        foreach (Transform child in toClear.transform)
        {
            allChildren[i] = child.gameObject;
            i += 1;
        }

        //Now destroy them
        foreach (GameObject child in allChildren)
        {
            DestroyImmediate(child.gameObject);
        }

    }


    #region INVENTORY
    public void instantiateMonsterCardsInventory()
    {
        ClearChildren(monsterCardInventoryItemHolder);

        foreach (MonsterCards monster in monsterCardsInventory)
        {
            GameObject x = Instantiate(Item_monsterCardInventory, monsterCardInventoryItemHolder.transform);
            x.GetComponent<MonsterCardHolder>().monsterCard = monster;
            //check for the level then set the sprite
            x.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = monster.monsterCardLV1Sprite;
            x.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = monster.monsterCardLevel.ToString();
        }
    }
    #endregion
}
