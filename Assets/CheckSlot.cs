//Script Created by Jose Bermudez. 2/15/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckSlot : MonoBehaviour
{
    public Text buttonText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Fusionar":
                buttonText.text = "Fusionar";
                Debug.Log("Now you should mix");
                break;
            case "Forjar":
                buttonText.text = "Forjar";
                Debug.Log("Now you should craft");
                break;
            case "Descubrir":
                buttonText.text = "Descubrir";
                Debug.Log("Now you should investigate");
                break;
            case "Alquimia":
                buttonText.text = "Alquimia";
                Debug.Log("Now you should sacrifice your inner gate");
                break;
            case "Donar":
                buttonText.text = "Donar";
                Debug.Log("Now you should give to the ones that need");
                break;
            default:
                break;
        }
        //if (other.gameObject.tag == "Fusionar")
        //{
           
        //}
    }
}
