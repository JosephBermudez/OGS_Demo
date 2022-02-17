using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusionButton : MonoBehaviour
{
    public GameObject particlesPrefab;

    public GameObject normalMenu;


    public void StartMixing()
    {
        StartCoroutine(CreateParticle());
    }

    public IEnumerator CreateParticle()
    {
        normalMenu.SetActive(false);
        yield return new WaitForSeconds(1);
        GameObject clone =  Instantiate(particlesPrefab, Vector3.zero, Quaternion.identity);
        Destroy(clone, 2f);
        yield return new WaitForSeconds(3);
        normalMenu.SetActive(true);
    }

}
