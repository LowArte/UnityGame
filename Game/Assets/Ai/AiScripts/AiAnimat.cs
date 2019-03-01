using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiAnimat : MonoBehaviour
{
    private Animator anim;
    public PropertyAi pa;
    public AiControl control;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void animate()
    {
        anim.SetBool("stop",pa.stop);
        anim.SetBool("isrun", pa.isrun);
        anim.SetBool("isattak", pa.isattak);
    }
    
        
    
}
