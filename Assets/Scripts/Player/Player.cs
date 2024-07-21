using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputComponent), typeof(MovementComponent), typeof(CharacterAnimator))]
[RequireComponent(typeof(CollisionComponent))]
public class Player : MonoBehaviour
{
    #region Components
    [Header("Components")]
    [SerializeField] InputComponent inputs = null;
    [SerializeField] MovementComponent movement = null;
    [SerializeField] CollisionComponent collision = null;
    [SerializeField] CharacterAnimator characterAnimator = null;
    #endregion Components

    public InputComponent Inputs => inputs;
    public MovementComponent Movement => movement;
    public CollisionComponent Collision => collision;
    public CharacterAnimator CharacterAnimator => characterAnimator;

    void Start()
    {
        Init();
    }

    void Update()
    {
        
    }

    void Init()
    {
        inputs = GetComponent<InputComponent>();
        movement = GetComponent<MovementComponent>();
        collision = GetComponent<CollisionComponent>();
        characterAnimator = GetComponent<CharacterAnimator>();
    }
}
