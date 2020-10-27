using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenager : MonoBehaviour
{

    [SerializeField]
    private Text _CoinText;
    [SerializeField]
    private Text _LiveText;


    public void UpdateCoinDisplay(int coins)
    {
        _CoinText.text = "Coins: " + coins.ToString();
    }
    public void UpdateLivesDisplay(int lives){
        _LiveText.text = "Lives: " + lives.ToString();
    }
}
