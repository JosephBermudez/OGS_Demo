using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderElement : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    public void textUpdate(int value)
    {
        text.text = Mathf.RoundToInt(value) + "units";
    }
}
