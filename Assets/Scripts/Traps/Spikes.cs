using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spikes : Interactable
{
    [SerializeField]
    bool isActiveOnStart = true;

    [SerializeField]
    private int damage = 100;

    private void Awake()
    {
        UI_Canvas = GameObject.Find("UI_Canvas");
        inventory = UI_Canvas.GetComponent<ResourceInventory>();
        this.enabled = isActiveOnStart;
    }

    public void ActiveToggle()
    {
        isActiveOnStart = !isActiveOnStart;

    }
    protected override void Interact(Collider other)
    {
        inventory.RemoveResource("HP", damage);
    }
}
