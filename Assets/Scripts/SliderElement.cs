using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderElement : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    public Text sliderValue;

    private void Start()
    {
        sliderValue = GetComponent<Text>();
        
    }

    private void Update()
    {
        TextUpdate();
    }

    public void TextUpdate()
    {
        string sliderMessage = slider.value.ToString();
        sliderValue.text = sliderMessage;
    }
}
