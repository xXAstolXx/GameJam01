using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ladder : Interactable
{
    [SerializeField]
    private int UpDownFactor = 10;
    Camera playerCamera;

    GameObject player;

    Vector3 direction = Vector3.up;

    [SerializeField]
    bool isLadderDown = false; 

    private void Awake()
    {
        playerCamera = Camera.main;
        if(isLadderDown )
        {
            direction *= -1.0f;
        }
        direction *= UpDownFactor;
    }

    protected override void Interact(Collider other)
    {
        player = other.gameObject;
        LadderClimb();
    }

    private void LadderClimb()
    {
        player.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 playerTransformTemp = new Vector3(0,direction.y,0);
        player.transform.position += playerTransformTemp ;
        Debug.Log(direction);
        Vector3 cameraTransformTemp = new Vector3(0, direction.y,0);
        playerCamera.transform.position += cameraTransformTemp;
        player.GetComponent<NavMeshAgent>().enabled = true;
    }
}
