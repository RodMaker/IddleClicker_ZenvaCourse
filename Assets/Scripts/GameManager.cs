using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldText;

    public Sprite[] backgrounds;
    private int curBackground;
    private int enemiesUntilBackgroundChange;
    public Image backgroundImage;

    // creates a singleton
    public static GameManager instance;

    // sets the limite of enemies to defeat
    void Awake()
    {
        instance = this;
        enemiesUntilBackgroundChange = 5;
    }

    public void AddGold (int amount)
    {
        gold += amount;
        // saves the gold, and converts it from an int to a string
        goldText.text = "Gold: " + gold.ToString();
    }

    public void TakeGold (int amount)
    {
        gold -= amount;
        goldText.text = "Gold: " + gold.ToString();
    }

    public void BackgroundCheck()
    {
        enemiesUntilBackgroundChange--;

        if(enemiesUntilBackgroundChange == 0)
        {
            enemiesUntilBackgroundChange = 5;

            curBackground++;
            
            if(curBackground == backgrounds.Length)
            {
                curBackground = 0;
            }
            backgroundImage.sprite = backgrounds[curBackground];
        }
    }
}
