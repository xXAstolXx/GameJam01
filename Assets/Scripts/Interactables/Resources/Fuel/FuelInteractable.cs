using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelInteractable : Interactable
{
    protected override void Interact(Collider other)
    {
        //TODO - add resourece
        Destroy(this);
    }
}
