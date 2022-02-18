//Script Created by Jose Bermudez. 2/15/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckElement : MonoBehaviour
{
    public GameObject elementSet1, 
        elementSet2, 
        elementSet3,
        elementSet4
        ;

    private void Start()
    {
        elementSet1.SetActive(false);
        elementSet2.SetActive(false);
        elementSet3.SetActive(false);
        elementSet4.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Determina el texto que deberia ir en la parte inferior en el boton
        switch (other.tag)
        {
            case "Element1":
                elementSet1.SetActive(true);

                elementSet2.SetActive(false);
                elementSet3.SetActive(false);
                elementSet4.SetActive(false);
                Debug.Log("Now you should mix");
                break;
            case "Element2":
                elementSet2.SetActive(true);

                elementSet1.SetActive(false);
                elementSet3.SetActive(false);
                elementSet4.SetActive(false);
                Debug.Log("Now you should craft");
                break;
            case "Element3":
                elementSet3.SetActive(true);

                elementSet1.SetActive(false);
                elementSet2.SetActive(false);
                elementSet4.SetActive(false);
                Debug.Log("Now you should investigate");
                break;
            case "Element4":
                elementSet4.SetActive(true);

                elementSet1.SetActive(false);
                elementSet2.SetActive(false);
                elementSet3.SetActive(false);
                Debug.Log("Now you should sacrifice your inner gate");
                break;
            default:
                break;
        }

        //if (other.gameObject.tag == "Fusionar")
        //{

        //}
    }
}
