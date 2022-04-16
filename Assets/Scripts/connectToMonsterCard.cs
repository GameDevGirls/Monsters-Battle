using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class connectToMonsterCard : MonoBehaviour
{
    MonsterCards monsterCard;
    public GameObject monsterCardDetailsShop;

    public TextMeshProUGUI titleNameText;
    public TextMeshProUGUI healthCountText;
    public TextMeshProUGUI attackCountText;
    public TextMeshProUGUI defenceCountText;
    public Image image;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI coinCountText;




    private void Start()
    {
        monsterCard = this.gameObject.transform.parent.GetComponent<MonsterCardHolder>().monsterCard;

        
    }

    public void connect()
    {
        monsterCardDetailsShop.SetActive(true);
        //monsterCardDetailsShop.transform.Find("TitleNameText").GetComponent<TextMeshProUGUI>();
        //GET COMPONENTS AND FILL THEM
    }

}
