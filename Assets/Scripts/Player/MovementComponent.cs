using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : ParentComponent
{
    [SerializeField] float moveSpeed = 0;
    [SerializeField] float initSpeed = 5;
    [SerializeField] bool isMoving = false;

    protected override void Start()
    {
        base.Start();
        ResetInitSpeed();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 _moveAxis = playerRef.Inputs.Movement.ReadValue<Vector2>();

        // Have to change by Impulse
        transform.position += transform.up * moveSpeed * _moveAxis.y * Time.deltaTime;
        transform.position += transform.right * moveSpeed * _moveAxis.x * Time.deltaTime;
        if (_moveAxis.x != 0 || _moveAxis.y != 0 || (_moveAxis.x != 0 && _moveAxis.y != 0)) { 
            isMoving = true;
        } else isMoving = false;

        playerRef.CharacterAnimator.SetIsMovingAnim(isMoving);
        playerRef.CharacterAnimator.SetMovementAnimation(_moveAxis.x, _moveAxis.y);
        
        //playerRef.CharacterAnimator.UpdateUpAnim(_moveAxis.y);
        //playerRef.CharacterAnimator.UpdateRightAnim(_moveAxis.x);
    }

    void ResetInitSpeed()
    {
        moveSpeed = initSpeed;
    }
}
