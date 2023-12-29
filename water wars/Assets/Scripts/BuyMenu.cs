using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyMenu : MonoBehaviour
{
    public Transform BuyMenuPanel;

    public void ActiveMenu()
    {
        if (BuyMenuPanel.gameObject.activeSelf == true)
        { 
            BuyMenuPanel.gameObject.SetActive(false);
        }
        else if (BuyMenuPanel.gameObject.activeSelf == false)
        {
            BuyMenuPanel.gameObject.SetActive(true);
        }
    }
}
