using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenInteractable : Interactable
{
    [SerializeField]
    private float OxygenAmount;

    private void Awake()
    {
        UI_Canvas = GameObject.Find("UI_Canvas");
        inventory = UI_Canvas.GetComponent<ResourceInventory>();
    }

    protected override void Interact(Collider other)
    {
        inventory.AddResource("Oxygen", OxygenAmount);
        Destroy(gameObject);
    }
}
