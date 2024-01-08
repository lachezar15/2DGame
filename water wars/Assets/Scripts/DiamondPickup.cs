using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondPickup : MonoBehaviour
{
    private DiamondsGen DG;

    private void Start()
    {
        DG = GameObject.Find("Generator").GetComponent<DiamondsGen>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DG.diamondCount++;
            DG.diamondsText.text = "Diamonds: " + DG.diamondCount;
            Destroy(this.gameObject);
        }
    }
}
