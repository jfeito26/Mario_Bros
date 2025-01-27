using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator _animator;
    private PLAYERMOVEMENT _movement;
    private SpriteRenderer _rend;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _movement = GetComponent<PLAYERMOVEMENT>();
        _rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //switch (_movement.GetCurrentState())
        //{
        //    case PlayerState.IDLE:
        //        _animator.SetBool("isWalking", false);
        //        break;
        //    case PlayerState.WALKING:
        //        _animator.SetBool("isWalking", true);
        //        break;
        //        //case PlayerState.JUMPING:
        //        //    break ;
        //}

        if (_movement.GetDirection().x < 0)
        {
            _rend.flipX = true;
        }
        else if (_movement.GetDirection().x > 0)
        {
            _rend.flipX = false;
        }


    }
}