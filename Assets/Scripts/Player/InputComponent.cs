using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputComponent : ParentComponent
{
    [SerializeField] Inputs controls = null;
    [SerializeField] InputAction movement = null;
    [SerializeField] InputAction interact = null;
    [SerializeField] InputAction openInventory = null;

    [SerializeField] InventoryController inventoryControllerRef = null;

    public InputAction Movement => movement;
    public InputAction Interact => interact;
    public InputAction OpenInventory => openInventory;

    private void OnEnable()
    {
        Init();
    }

    private void OnDisable()
    {
        movement.Disable();
        interact.Disable();
    }

    protected override void Start()
    {
        base.Start();
        Subscribe();

    }

    void Update()
    {
        
    }

    void Init()
    {
        controls = new Inputs();
        movement = controls.Ground.Movement;
        interact = controls.Ground.Interact;
        openInventory = controls.Ground.OpenInventory;

        movement.Enable();
        interact.Enable();
        openInventory.Enable();


    }

    void Subscribe()
    {
        inventoryControllerRef = FindObjectOfType<InventoryController>();
        openInventory.performed += inventoryControllerRef.OpenInventory;
    }
}
