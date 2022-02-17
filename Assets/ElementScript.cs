using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementScript : MonoBehaviour
{
    public int actualQuantity;
    public int maxQuantity;
    public int grabbedAmount;

    public Text actual;
    public Text total;

    public Text sliderValue;

    [SerializeField]
    private Slider slider;
    [SerializeField]
    private Text text;

    private void Start()
    {
        actualQuantity = maxQuantity;
        slider.onValueChanged.AddListener((v) =>
        {
            text.text = v.ToString();
        });
    }

    private void Update()
    {
        GetInentory();
    }

    public void ReduceQuantity()
    {
        if (actualQuantity > 0)
        {
            actualQuantity -= 1;
            grabbedAmount += 1;
        }
        else
        {
            actualQuantity = 0;
            grabbedAmount = 100;
        }
        
    }

    public void IncreaseQuantity()
    {
        if (actualQuantity < maxQuantity)
        {
            actualQuantity += 1;
            grabbedAmount -= 1;
        }
        else
        {
            actualQuantity = maxQuantity;
            grabbedAmount = 0;
        }
    }

    public void GetInentory()
    {
        actual.text = actualQuantity.ToString();
        total.text = maxQuantity.ToString();
        sliderValue.text = grabbedAmount.ToString();
    }
}
