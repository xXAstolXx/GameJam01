using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPInteractable : Interactable
{
    [SerializeField]
    private float HPAmount;

    private GameObject UI_Canvas;
    private ResourceInventory inventory;

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
