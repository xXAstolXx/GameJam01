using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrapDoor : Interactable
{
    [SerializeField]
    private int cameraFaktor = 10;
    Camera playerCamera;

    private void Awake()
    {
        playerCamera = Camera.main;
    }

    protected override void Interact(Collider other)
    {
        other.GetComponent<NavMeshAgent>().enabled = false;
        other.transform.position = Vector3.up * 10;
        playerCamera.transform.position += Vector3.up * cameraFaktor;
        other.GetComponent<NavMeshAgent>().enabled = true;

    }
}
