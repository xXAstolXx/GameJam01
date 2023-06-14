using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObstacleWall : MonoBehaviour
{

    [SerializeField]
    bool isActiveOnStart = true;

    private void Awake()
    {
        GetComponent<BoxCollider>().enabled = isActiveOnStart;
        GetComponent<NavMeshObstacle>().enabled = isActiveOnStart;
        GetComponent<MeshRenderer>().enabled = isActiveOnStart;
    }

    public void ActiveToggle()
    {
        GetComponent<BoxCollider>().enabled = !GetComponent<BoxCollider>().enabled;
        GetComponent<NavMeshObstacle>().enabled = !GetComponent<NavMeshObstacle>().enabled;
        GetComponent<MeshRenderer>().enabled = !GetComponent<MeshRenderer>().enabled;
        Debug.Log("Wall Active!");

    }
}
