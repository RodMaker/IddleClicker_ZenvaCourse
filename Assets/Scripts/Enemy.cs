using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int curHp;
    public int maxHp;
    public int goldToGive;
    public Image healthBarFill;
    public Animation anim;

    public void Damage()
    {
        // deals damage to the target. subtracts hp
        curHp--;

        // sets the fill of the bar. the (float) converts the variable from int to float (decimal)
        healthBarFill.fillAmount = (float)curHp / (float)maxHp;

        // stops the animation
        anim.Stop();
        // plays the animation once
        anim.Play();

        if(curHp <= 0)
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        // adds gold after defeating an enemy
        GameManager.instance.AddGold(goldToGive);
        EnemyManager.instance.DefeatEnemy(gameObject);
    }
}
