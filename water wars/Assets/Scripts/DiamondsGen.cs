using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondsGen : MonoBehaviour
{
    public TMP_Text diamondsText;
    public float diamondsMult;

    float timeBtwGen;
    public float startTimeBtwGen;

    float diamondCount;

    public Shop shopScript;

    private void Start()
    {
        timeBtwGen = startTimeBtwGen;
    }

    private void Update()
    {
        if (timeBtwGen <= 0)
        {
            diamondCount += diamondsMult;
            diamondsText.text = "Diamonds: " + diamondCount;
            timeBtwGen = startTimeBtwGen;
        }
        else
        {
            timeBtwGen -= Time.deltaTime;
        }
    }

    public void DiaMultiply() {
        shopScript.starsCount--;
        diamondsMult++;
    }

}
