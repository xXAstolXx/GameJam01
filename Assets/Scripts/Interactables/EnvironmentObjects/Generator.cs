using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Generator : Interactable
{
    //[SerializeField]
    //private float requiredAmount = 1.0f;

    [SerializeField]
    private float checkAmount = 1.0f;

    private float currentFuel = 0.0f;

    private GameObject UI_Canvas;
    private ResourceInventory inventory;

    private void Awake()
    {
        UI_Canvas = GameObject.Find("UI_Canvas");
        inventory = UI_Canvas.GetComponent<ResourceInventory>();
    }

    protected override void Interact(Collider other)
    {
        if (inventory.CheckResource("Fuel") >= checkAmount)
        {
            currentFuel += inventory.CheckResource("Fuel");
            inventory.RemoveResource("Fuel", inventory.CheckResource("Fuel"));
        }
    }

    private void UpdateUI()
    {
        GetComponentInChildren<TextMeshProUGUI>().text = currentFuel.ToString() + "%";
    }

    public float CheckGeneratorFuel()
    {
        return currentFuel;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }
}
