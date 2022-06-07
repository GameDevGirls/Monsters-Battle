using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Newtonsoft.Json;
using System;

public class TransferFromTest : MonoBehaviour
{
    public TMP_Text hash;

    [SerializeField]
    private string contract = "0x6D36E8B81be15868419A4Dc234B92D0e4bC39aED";
    [SerializeField]
    private string toAccount = "0xc543A948A17dc0919b7b7e672aC85C720f10139F";
    
    [SerializeField]
    private string fromAccount = "0xfE8cb6256108a5ce16cEDCe0bD9B4dC3c7695Db6";
    [SerializeField]
    private string amount = "10000000000000000000";

    private readonly string abi = "[ { \"inputs\": [ { \"internalType\": \"address payable\", \"name\": \"_to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"_amount\", \"type\": \"uint256\" } ], \"name\": \"withdrawMoney\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" } ]";
        
        
        


    async public void TransferFrom()
    {
        // smart contract method to call
        string method = "withdrawMoney";
        // array of arguments for contract
        string[] obj = {toAccount, amount };
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
            hash.text = response;

        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }
    public void Update()
    {
        if (hash.text.Contains("0"))
        {
            //SceneManager.LoadScene(2);
            Debug.Log("Hash is " + hash);
        }
    }
}
