using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    //public GameObject playerAPrefab;
    //public GameObject playerBPrefab;
    //public GameObject playerCPrefab;
    public GameObject displayAbilities;

    private bool is_Visible = false;


    public void Btn1Clicked()
    {
        //Debug.Log("1");
    }

    public void Btn2Clicked()
    {
        //Debug.Log("2");
    }

    public void Btn3Clicked()
    {
        //Debug.Log("3");
    }

    public void DisplayAbilities()
    {
        if (!is_Visible)
        {
            displayAbilities.SetActive(true);
            is_Visible = true;
        }

        else
        {
            displayAbilities.SetActive(false);
            is_Visible = false;
        }
    }
}
