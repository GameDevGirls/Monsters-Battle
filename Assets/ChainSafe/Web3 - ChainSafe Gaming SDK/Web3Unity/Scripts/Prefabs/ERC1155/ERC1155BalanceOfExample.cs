using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    public GameObject shadow;
    async public void checkNFT()
    {
        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0x21998b669003AA2d6C0ad2233E5998A79f1B635B";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0000000000000000000000000000000000000000000000000000000000000001";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);


        if(balanceOf > 0)
        {
            shadow.SetActive(true);
        }

    }



}
