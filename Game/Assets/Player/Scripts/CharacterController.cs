using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    CharacterTakeDmg takedmg;
    CharacterMovement movement;
    CharacteAnimations animation;
    public PlayerProperty player;

    CharacterBARS bar;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<CharacteAnimations>();
        takedmg = GetComponent<CharacterTakeDmg>();
        bar = GetComponent<CharacterBARS>();
        movement = GetComponent<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.PlayerMove();
        animation.Animate();
        bar.BarDraw();
    }
   
}
