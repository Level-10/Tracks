using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : ParentComponent
{
    [SerializeField] Animator animator = null;

    [SerializeField] string currentState = "";
    [SerializeField] bool isMovingAnim = false;

    protected override void Start()
    {
        base.Start();
        Init();
    }

    void Update()
    {
        
    }

    void Init()
    {
        animator = GetComponent<Animator>();
    }

    /*public void UpdateUpAnim(float _value)
    {
        if (!animator) return;
        animator.SetFloat(AnimatorParameters.upParam, _value);
    }

    public void UpdateRightAnim(float _value)
    {
        if (!animator) return;
        animator.SetFloat(AnimatorParameters.rightParam, _value);
    }*/

    public void ChangeAnimState(string _newState)
    {
        // Stop the same animation from interrupting itself
        if (currentState == _newState) return;

        // Play the animation
        animator.Play(_newState);

        // Reassign animation
        currentState = _newState;

    }

    public void SetMovementAnimation(float _xAxis, float _yAxis)
    {
        if (_yAxis < -0.1f)
        {
            playerRef.CharacterAnimator.ChangeAnimState(AnimatorParameters.LILITH_WALK_DOWN);
        }
        else if (_yAxis > 0.1f)
        {
            playerRef.CharacterAnimator.ChangeAnimState(AnimatorParameters.LILITH_WALK_UP);
        }
        else if (_xAxis < -0.1f)
        {
            playerRef.CharacterAnimator.ChangeAnimState(AnimatorParameters.LILITH_WALK_LEFT);
        }
        else if (_xAxis > 0.1f)
        {
            playerRef.CharacterAnimator.ChangeAnimState(AnimatorParameters.LILITH_WALK_RIGHT);
        }
        else if (!isMovingAnim)
        {
            playerRef.CharacterAnimator.ChangeAnimState(AnimatorParameters.LILITH_IDLE);
        }
    }

    public void SetIsMovingAnim(bool _isMoving) => isMovingAnim = _isMoving;
}
