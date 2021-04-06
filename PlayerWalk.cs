using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public Transform PlayerTransform;
    public SpriteRenderer PlayerSpriteRenderer;
    public Animator PlayerAnimator;
    public int speed;
    // Update is called once per frame
    void Update()
    {
        var lado = Input.GetAxisRaw("Horizontal");
        PlayerTransform.position += new Vector3(lado,0,0) * Time.deltaTime * speed;
        if(lado == 1)
        {
            PlayerSpriteRenderer.flipX = false;
            PlayerAnimator.SetBool("IsWalking",true);
        }
        else if(lado == -1)
        {
            PlayerSpriteRenderer.flipX = true;
            PlayerAnimator.SetBool("IsWalking", true);
        }
        else if(lado == 0)
        {
            PlayerAnimator.SetBool("IsWalking", false);
        }
    }
}
