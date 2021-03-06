using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monsterBattleController : MonoBehaviour
{
    MonsterCards card;
    SkeletonAnimation anim;
    public float health = 0;
    public bool isEnemy = false;

    public GameObject enemy;
    public GameObject player;
    public Text healthTxt;
    public Text EnemyHealthTxt;

    public GameObject winPanel;

    bool alreadyAttackedEnemy = false;
    void Start()
    {

        anim = GetComponent<SkeletonAnimation>();


        
        card = GetComponent<MonsterCardHolder>().monsterCard;
        health = card.health;

        if (health > 0)
        {
            winPanel.SetActive(false);

        }
    }

    void Update()
    {
        if (!isEnemy)
        {
            if (Input.GetMouseButtonDown(0))
            {

                StartCoroutine(attack());
                attackEnemy();
            }
            healthTxt.text = health.ToString();
            EnemyHealthTxt.text = enemy.GetComponent<monsterBattleController>().health.ToString();
        }

        if(health <= 0)
        {
            StartCoroutine(die());

            if (isEnemy)
            {
                Debug.Log("You win");
                win();
                health = card.health;
                enemy.GetComponent<monsterBattleController>().health = enemy.GetComponent<monsterBattleController>().card.health;
            }
            else
            {
                Debug.Log("You lose");
            }
        }


        if (isEnemy)
        {
            attackENEMY();
        }

    }

    IEnumerator attack()
    {
        anim.AnimationName = "Attack";
        yield return new WaitForSeconds(0.9f);
        anim.AnimationName = "Idle";


    }

    public void takeDamage()
    {
        health -= 100;
    }

    public void attackEnemy()
    {
        enemy.GetComponent<monsterBattleController>().takeDamage();
    }

    void attackENEMY()
    {
        if (!alreadyAttackedEnemy)
        {


            alreadyAttackedEnemy = true;

            StartCoroutine(attack());
            player.GetComponent<monsterBattleController>().takeDamage();


            Invoke(nameof(resetAttack), 5);

        }

    }


    void resetAttack()
    {
        alreadyAttackedEnemy = false;
    }

    IEnumerator die()
    {
        anim.AnimationName = "Dead";
        yield return new WaitForSeconds(1.45f);
        Time.timeScale = 0;

    }

    void win()
    {
        winPanel.SetActive(true);
    }

}
