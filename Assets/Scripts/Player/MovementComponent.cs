using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : ParentComponent
{
    [Header("Components")]
    [SerializeField] Rigidbody2D rb = null;


    [Header("Values")]
    [SerializeField] float moveSpeed = 0;
    [SerializeField] float initSpeed = 5;
    [SerializeField] bool isMoving = false;

    protected override void Start()
    {
        base.Start();
        ResetInitSpeed();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
        //CheckSpeed();
    }

    void Move()
    {
        Vector2 _moveAxis = playerRef.Inputs.Movement.ReadValue<Vector2>();

        // Have to change by Impulse
        Vector3 _dir = _moveAxis.y * transform.up + transform.right * _moveAxis.x;
        //rb.AddForce(_dir * moveSpeed, ForceMode2D.Force);
        transform.position += _dir * moveSpeed * Time.deltaTime;
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

    void CheckSpeed()
    {
        Vector2 _vel = new Vector2(rb.velocity.x, rb.velocity.y);
        if (_vel.magnitude > moveSpeed)
        {
            Vector2 _limitedVel = _vel.normalized * moveSpeed;
            rb.velocity = new Vector2(_limitedVel.x, _limitedVel.y);
        }
        }
}
