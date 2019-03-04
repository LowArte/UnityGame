using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AiTakeDamage : MonoBehaviour
{
    public PropertyAi pa;
    public PlayerProperty player;
    public Image hpbar;
    // Start is called before the first frame update
    void Start()
    {
        pa.hp = 1f;
        hpbar.fillAmount = pa.hp;
    }

    // Update is called once per frame
    void Update()
    {
        if (pa.hp > 0)
        {
            pa.hp = pa.hp - player.damage;

        }
    }
}
