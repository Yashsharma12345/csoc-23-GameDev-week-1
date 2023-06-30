using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI coinsPicked;
    public int coins = 0;
    void Start()
    {
        coinsPicked.text = "Coins Collected " + coins;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag=="Coin")
        {
            coins = coins + 1;
            Destroy(other.gameObject);
            coinsPicked.text = "Coins Collected " + coins;
        }
    }

}
