using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class WebGLSendTransactionExample : MonoBehaviour
{
    public TMP_Text hash;

    async public void OnSendTransaction()
    {
        // account to send to
        string to = "0xc543A948A17dc0919b7b7e672aC85C720f10139F";
        // amount in wei to send
        string value = "50000000000000000";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to send a transaction
        try {
            string response = await Web3GL.SendTransaction(to, value, gasLimit, gasPrice);
            Debug.Log(response);
            hash.text = response;
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }

    public void Update()
    {
        if (hash.text.Contains("0")){
            SceneManager.LoadScene(2);
        }
    }

}
