using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopMonstersCardDisplay : MonoBehaviour
{
    public ShopMonstersCard shopMonstersCard;

    public TextMeshProUGUI titleNameText;
    public TextMeshProUGUI healthCountText;
    public TextMeshProUGUI attackCountText;
    public TextMeshProUGUI defenceCountText;
    public Image image;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI coinCountText;
    void Start()
    {
        titleNameText.text = shopMonstersCard.titleName;
        healthCountText.text = shopMonstersCard.healthCount.ToString();
        attackCountText.text = shopMonstersCard.attackCount.ToString();
        defenceCountText.text = shopMonstersCard.defenceCount.ToString();
        image.sprite = shopMonstersCard.image;
        descriptionText.text = shopMonstersCard.description;
        coinCountText.text = shopMonstersCard.coinCount.ToString();
        


    }
    
}
