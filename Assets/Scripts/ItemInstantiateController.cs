using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Numerics;
using Newtonsoft.Json;
using System;

public class ItemInstantiateController : MonoBehaviour
{
    [Header("Shop system")]
    public List<MonsterCards> monsterCards = new List<MonsterCards>();
    //! call a method to find all the monstercards in account 1

    public GameObject menuUI;
    public GameObject battleUI;
    //public GameObject winPanel;
    //public GameObject[] monsterList;
 
    public GameObject Item_monsterCardShop;
    public GameObject monsterCardShopItemHolder;
    public MonsterCards lastClickedMonsterCardShop;

    [Header("Inventory System")]
    public List<MonsterCards> monsterCardsInventory = new List<MonsterCards>();
    public GameObject monsterCardInventoryItemHolder;
    public GameObject Item_monsterCardInventory;


    public static ItemInstantiateController Instance;

    [SerializeField]
    private string contract = "0x2a3E40cf30B839ca4E6819A5c210c931C4D4eCd3";
    [SerializeField]
    private string toAccount = "0xfE8cb6256108a5ce16cEDCe0bD9B4dC3c7695Db6";
    [SerializeField]
    private string amount = "10000000000000000000";

    private readonly string abi = "[ { \"inputs\": [ { \"internalType\": \"string\", \"name\": \"name_\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"symbol_\", \"type\": \"string\" } ], \"stateMutability\": \"nonpayable\", \"type\": \"constructor\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"spender\", \"type\": \"address\" }, { \"indexed\": false, \"internalType\": \"uint256\", \"name\": \"value\", \"type\": \"uint256\" } ], \"name\": \"Approval\", \"type\": \"event\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"indexed\": false, \"internalType\": \"uint256\", \"name\": \"value\", \"type\": \"uint256\" } ], \"name\": \"Transfer\", \"type\": \"event\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"spender\", \"type\": \"address\" } ], \"name\": \"allowance\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"spender\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"amount\", \"type\": \"uint256\" } ], \"name\": \"approve\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"account\", \"type\": \"address\" } ], \"name\": \"balanceOf\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"decimals\", \"outputs\": [ { \"internalType\": \"uint8\", \"name\": \"\", \"type\": \"uint8\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"spender\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"subtractedValue\", \"type\": \"uint256\" } ], \"name\": \"decreaseAllowance\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"spender\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"addedValue\", \"type\": \"uint256\" } ], \"name\": \"increaseAllowance\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"name\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"symbol\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"totalSupply\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"amount\", \"type\": \"uint256\" } ], \"name\": \"transfer\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"amount\", \"type\": \"uint256\" } ], \"name\": \"transferFrom\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"nonpayable\", \"type\": \"function\" } ]";

    string responseee = "";

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

    async public void instantiateMonsterCardsShop()
    {

        ClearChildren(monsterCardShopItemHolder);

        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0xc7a0016A793f4EcBfb7d82db22fc3448911b478F";
        string account = "0xc543A948A17dc0919b7b7e672aC85C720f10139F";

        foreach (MonsterCards monster in monsterCards)
        {
            string tokenId = monster.tokenId;

            System.Numerics.BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
            print(balanceOf);

            if (balanceOf > 0)
            {

                //make monster card in shop
                GameObject x = Instantiate(Item_monsterCardShop, monsterCardShopItemHolder.transform);
                x.GetComponent<MonsterCardHolder>().monsterCard = monster;
                x.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = monster.monsterCardLV1Sprite;
                x.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = monster.price.ToString();
            }


        }


    }

    /*
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
    */


    public void monsterCardDetailsShopBUYBUTTON()
    {
        foreach (MonsterCards card in monsterCards)
        {
            if (card.monsterCardName == lastClickedMonsterCardShop.monsterCardName)
            {
                //CHECK IF THE COINS ARE ENOUGH
                //CHECK IF THE TOKENS ARE ENOUGH IN THE ACCOUNT
                monsterCardsInventory.Add(card);
                monsterCards.Remove(card);
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
    /*
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
    */


    async public void instantiateMonsterCardsInventory()
    {


        ClearChildren(monsterCardInventoryItemHolder);

        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0xc7a0016A793f4EcBfb7d82db22fc3448911b478F";
        string account = PlayerPrefs.GetString("Account");

        foreach (MonsterCards monster in monsterCards)
        {
            string tokenId = monster.tokenId;

            System.Numerics.BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
            print(balanceOf);

            if (balanceOf > 0)
            {

                //make monster card in shop
                GameObject x = Instantiate(Item_monsterCardInventory, monsterCardInventoryItemHolder.transform);
                x.GetComponent<MonsterCardHolder>().monsterCard = monster;
                //check for the level then set the sprite
                x.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = monster.monsterCardLV1Sprite;
                x.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TMP_Text>().text = monster.monsterCardLevel.ToString();
            }


        }


    }

    private void Update()
    {
        if (responseee.Contains("0"))
        {
            battleUI.SetActive(true);
            menuUI.SetActive(false);
        }
    }

    async public void checkNFT()
    {


        // smart contract method to call
        string method = "transfer";
        // array of arguments for contract
        string[] obj = { toAccount, amount };
        string args = JsonConvert.SerializeObject(obj);
        // value in wei
        string value = "0";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to send a transaction
        try
        {
            string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);
            Debug.Log(response);
            responseee = response;

        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }







        /*

        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0xc7a0016A793f4EcBfb7d82db22fc3448911b478F";
        string account = PlayerPrefs.GetString("Account");
        string salamanderID = "0000000000000000000000000000000000000000000000000000000000000003";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, salamanderID);
        print(balanceOf);


        if (balanceOf > 0)
        {
            foreach (GameObject monster in monsterList)
            {
                switch (monster.name)
                {
                    case "Salamander":
                        menuUI.SetActive(false);
                        battleUI.SetActive(true);
                        monster.SetActive(true);
                        break;
                    default:
                        break;
                }
            }
        }
        */

        /*
        foreach (GameObject monster in monsterList)
        {
            switch (monster.name)
            {
                case "Salamander":
                    menuUI.SetActive(false);
                    battleUI.SetActive(true);
                    monster.SetActive(true);
                    break;
                default:
                    break;
            }
        }
        */
    }



    public void menuBtn()
    {
        menuUI.SetActive(true);
        battleUI.SetActive(false);
    }

    #endregion
}
