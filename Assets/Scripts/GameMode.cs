using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    public Text options;
    public GameObject inventory;
    public GameObject select;
    public GameObject fuse;

    private string gameMode;

    public GameObject elementSet1,
        elementSet2,
        elementSet3,
        elementSet4
        ;



    void Start()
    {
        select.SetActive(true);

        inventory.SetActive(false);
        fuse.SetActive(false);
        elementSet1.SetActive(false);
        elementSet2.SetActive(false);
        elementSet3.SetActive(false);
        elementSet4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GetName();
    }

    private void GetName()
    {
        gameMode = options.text;
    }

    public void ActivateMenu()
    {
        //Determina que tipo de menu es el que se encuentra activo de momento
        switch (gameMode)
        {
            case "Fusionar":
                select.SetActive(false);
                elementSet1.SetActive(true);
                inventory.SetActive(true);
                fuse.SetActive(true);
                break;
            case "Forjar":
                inventory.SetActive(false);
                elementSet1.SetActive(false);
                elementSet2.SetActive(false);
                elementSet3.SetActive(false);
                elementSet4.SetActive(false);
                break;
            case "Descubrir":
                inventory.SetActive(false);
                elementSet1.SetActive(false);
                elementSet2.SetActive(false);
                elementSet3.SetActive(false);
                elementSet4.SetActive(false);
                break;
            case "Donar":
                inventory.SetActive(false);
                elementSet1.SetActive(false);
                elementSet2.SetActive(false);
                elementSet3.SetActive(false);
                elementSet4.SetActive(false);
                break;
            case "Alquimia":
                inventory.SetActive(false);
                elementSet1.SetActive(false);
                elementSet2.SetActive(false);
                elementSet3.SetActive(false);
                elementSet4.SetActive(false);
                break;

            default:
                break;
        }
    }
}
