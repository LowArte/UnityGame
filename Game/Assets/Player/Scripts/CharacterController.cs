using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    CharacterTakeDmg takedmg;
    CharacterMovement movement;
    CharacteAnimations animation;
    
    CharacterBARS bar;
    // Start is called before the first frame update
    void Start()
    {
      
        takedmg = GetComponent<CharacterTakeDmg>();
        bar = GetComponent<CharacterBARS>();
        movement = GetComponent<CharacterMovement>();
        animation = GetComponent<CharacteAnimations>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bar.BarDraw();
        movement.PlayerMove();
        animation.Animate();
       
        

    }
   
}
