using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    private AudioSource AudioS;
    public int coins;
    public Text TextCoins;
    private void Start()
    {
        AudioS = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
            TextCoins.text =coins.ToString();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Money")
        {
            coins++;
            other.gameObject.SetActive(false);   
            TextCoins.text = coins.ToString();
            PlayerPrefs.SetInt("Coins", coins);
            AudioS.Play();
        }
    }
}
