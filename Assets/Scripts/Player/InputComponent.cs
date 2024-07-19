using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputComponent : ParentComponent
{
    [SerializeField] Inputs controls = null;
    [SerializeField] InputAction movement = null;
    [SerializeField] InputAction interact = null;

    public InputAction Movement => movement;
    public InputAction Interact => interact;
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

    }

    void Update()
    {
        
    }

    void Init()
    {
        controls = new Inputs();
        movement = controls.Ground.Movement;
        interact = controls.Ground.Interact;

        movement.Enable();
        interact.Enable();
    }
}
