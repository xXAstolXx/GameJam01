using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spikes : Interactable
{
    [SerializeField]
    private int Damage = 100;

    // Update is called once per frame
    void Update()
    {
    }

    protected override void Interact(Collider other)
    {
        Debug.Log("1");
    }
}
