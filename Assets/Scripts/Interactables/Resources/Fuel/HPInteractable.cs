using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPInteractable : Interactable
{
    [SerializeField]
    private float HPAmount;

    private void Awake()
    {
        UI_Canvas = GameObject.Find("UI_Canvas");
        inventory = UI_Canvas.GetComponent<ResourceInventory>();
    }

    protected override void Interact(Collider other)
    {
        inventory.AddResource("HP", HPAmount);
        Destroy(this);
    }
}
