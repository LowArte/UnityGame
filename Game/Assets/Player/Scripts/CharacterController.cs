using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    CharacterMovement movement;
    CharacteAnimations animation;
    CharacterBARS bar;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<CharacterMovement>();
        animation = GetComponent<CharacteAnimations>();
        bar = GetComponent<CharacterBARS>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.PlayerMove();
        animation.Animate();
        bar.BarDraw();
    }
}
