using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemInstantiateController : MonoBehaviour
{
    public List<MonsterCards> monsterCardsShop = new List<MonsterCards>();
    public GameObject Item_monsterCardShop;
    public GameObject monsterCardShopItemHolder;

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

    public void removeFromMonsterCardsShop()
    {

    }

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

}
