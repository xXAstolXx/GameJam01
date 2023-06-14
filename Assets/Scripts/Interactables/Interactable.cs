using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected GameObject UI_Canvas; 
    protected ResourceInventory inventory;

    [SerializeField]
    Color gizmoColor;

    [SerializeField, Range(0, 5.0f)]
    private float debugInteractRadius;

    private SphereCollider interactableCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Interact(other);
        }
        else
        {
            return;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, debugInteractRadius * transform.localScale.x);
    }

    private void OnValidate()
    {
        GetComponent<SphereCollider>().radius = debugInteractRadius;
    }

    protected virtual void Interact(Collider other) { }
}
