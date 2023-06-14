using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spikes : Interactable
{
    //TODO 
    // HP Script 
    [SerializeField]
    private int Damage = 100;

    // Update is called once per frame
    void Update()
    {
    }

    protected override void Interact(Collider other)
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
