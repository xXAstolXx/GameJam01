using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Camera playerCamera;

    [SerializeField]
    private LayerMask groundMask;

    [SerializeField]
    private int range = 200;
    PlayerAgent agent;

    private PlayerInputBindings playerBindings;
    private InputAction mouseClickInputAction;
    private InputAction mousePositionInputAction;
    private void Awake()
    {
        playerCamera = Camera.main;
        agent = GetComponent<PlayerAgent>();
        playerBindings = new PlayerInputBindings();
        mouseClickInputAction = playerBindings.PlayerMouseControlls.MouseClick;
        mousePositionInputAction = playerBindings.PlayerMouseControlls.MousePos;
    }

    private void OnEnable()
    {
        mouseClickInputAction.Enable();
        mousePositionInputAction.Enable();
    }
    private void OnDisable()
    {
        mouseClickInputAction.Disable();
        mousePositionInputAction.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if(mouseClickInputAction.WasPerformedThisFrame() == true)
        {
            Vector2 mousePosition = mousePositionInputAction.ReadValue<Vector2>();

            Ray ray = playerCamera.ScreenPointToRay(mousePosition);
            RaycastHit hit; 
            if(Physics.Raycast(ray, out hit, range, groundMask))
            {
                agent.MoveToPosition(hit.point);

            }
        }
    }
}
