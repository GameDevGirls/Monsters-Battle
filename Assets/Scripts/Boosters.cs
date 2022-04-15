using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Booster", menuName = "Booster")]
public class Boosters : ScriptableObject
{
    public string boosterName;
    public string boosterDescription;
    public boosterTypes boosterType;

    public int boosterValue;

    public enum boosterTypes { Health, Defense, Attack}

    public void boost(MonsterCards card)
    {
        if (boosterType == boosterTypes.Health)
        {
            //sum health of card by boosterValue and assign it to boostedHealth

        }
        else if (boosterType == boosterTypes.Defense)
        {
            //sum defense of card by boosterValue and assign it to boostedDefense

        }
        else if (boosterType == boosterTypes.Attack)
        {
            //sum attack of card by boosterValue and assign it to boostedAttack
        }
    }


}
