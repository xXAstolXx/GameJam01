using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelInteractable : Interactable
{
    [SerializeField]
    private float fuelAmount;
    private void Awake()
    {
        UI_Canvas = GameObject.Find("UI_Canvas");
        inventory = UI_Canvas.GetComponent<ResourceInventory>();
    }

    protected override void Interact(Collider other)
    {
        inventory.AddResource("Fuel", fuelAmount);
        Destroy(gameObject);
    }
}
