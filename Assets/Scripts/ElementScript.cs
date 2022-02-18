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


    [SerializeField]
    private Slider slider;
    public Text sliderValue;

    [SerializeField]
    private InputField input;

    public int totalValue;

    private void Start()
    {
        actualQuantity = maxQuantity;
        slider.maxValue = maxQuantity;
    }

    private void Update()
    {
        GetInventory();
        TextUpdate();
        
    }

    public void ReduceQuantity()
    {
        if (actualQuantity > 0)
        {
            actualQuantity -= (int)slider.value;
            grabbedAmount += (int)slider.value;
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
            actualQuantity += (int)slider.value;
            grabbedAmount -= (int)slider.value;
        }
        else
        {
            actualQuantity = maxQuantity;
            grabbedAmount = 0;
        }
    }

    public void GetInventory()
    {
        actual.text = actualQuantity.ToString();
        total.text = maxQuantity.ToString();
        sliderValue.text = grabbedAmount.ToString();
    }

    public void TextUpdate()
    {
        string sliderMessage = slider.value.ToString();
        sliderValue.text = sliderMessage;
    }
}
