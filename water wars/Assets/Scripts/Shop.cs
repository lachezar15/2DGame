using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Transform shopPanel;
    public Button genUpgradeButton;
    public float starsCount;

    public TMP_Text starsText;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        { 
            shopPanel.gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        if (starsCount <= 0)
        {
            genUpgradeButton.interactable = false;
        }
        else {
            genUpgradeButton.interactable = true;
        }

        starsText.text = "Stars: " + starsCount;
    }
}
