using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputComponent), typeof(MovementComponent), typeof(CharacterAnimator))]
public class Player : MonoBehaviour
{
    #region Components
    [Header("Components")]
    [SerializeField] InputComponent inputs = null;
    [SerializeField] MovementComponent movement = null;
    [SerializeField] CharacterAnimator characterAnimator = null;
    #endregion Components

    public InputComponent Inputs => inputs;
    public MovementComponent Movement => movement;
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
        characterAnimator = GetComponent<CharacterAnimator>();
    }
}
