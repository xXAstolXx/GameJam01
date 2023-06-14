using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour
{

    private GameObject UI_Canvas;
    private ResourceInventory inventory;

    [SerializeField]
    private float decreaseAmount = 0.01f;

    private Slider sliderValue;

    private void Awake()
    {
        UI_Canvas = GameObject.Find("UI_Canvas");
        inventory = UI_Canvas.GetComponent<ResourceInventory>();
        sliderValue = gameObject.GetComponent<Slider>();
    }

    public void decreaseOxygen()
    {
        Debug.Log(sliderValue);
        sliderValue.normalizedValue -= decreaseAmount;
        if (sliderValue.normalizedValue == 0.0f)
        {
            inventory.RemoveResource("HP", 100);
        }
    }
}
